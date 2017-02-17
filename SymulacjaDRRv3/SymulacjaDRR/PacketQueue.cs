using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SymulacjaDRR
{
    class PacketQueue : Queue<Packet>
    {
        public QueueContainer QueueContainer
        {
            get; protected set;
        }
        public QueueControl QueueControl
        {
            get; protected set;
        }
        public int MaxLength { get; protected set; }
        public int Quantum { get; protected set; }
        public string Name { get; set; }
        public int CurrentLength { get; protected set; }
        public int CurrentDeficit { get; protected set; }

        public PacketQueue(int maxLength, int quantum)
        {
            this.MaxLength = maxLength;
            this.Quantum = quantum;
            this.CurrentLength = this.CurrentDeficit = 0;
            UpdateBinding();
        }
        public void SetQueueControl(QueueControl qc)
        {
            QueueControl = qc;
            UpdateBinding();
        }
        public void SetQueueContainer(QueueContainer qc)
        {
            QueueContainer = qc;
        }
        public void ResetDeficit()
        {
            CurrentDeficit = 0;
            UpdateBinding();
        }
        public void IncreaseDeficit()
        {
            CurrentDeficit += Quantum;
            UpdateBinding();
        }
        public new bool Enqueue(Packet packet)
        {
            if (packet.Length + CurrentLength > MaxLength)
                return false;

            base.Enqueue(packet);
            CurrentLength += packet.Length;

            UpdateBinding();

            return true;
        }
        public new Packet Dequeue()
        {
            Packet p = base.Dequeue();

            CurrentLength -= p.Length;
            CurrentDeficit -= p.Length;

            UpdateBinding();

            return p;
        }
        public void UpdateBinding()
        {
            if(QueueControl != null)
            {
                if(QueueControl.InvokeRequired)
                {
                    QueueControl.Invoke(new MethodInvoker(() => QueueControl.SetText(this.ToString())));
                }
                else
                {
                    QueueControl.SetText(this.ToString());
                }
            }
        }
        public override string ToString()
        {
            string str = "";
            str += "Max. dł: " + MaxLength + Environment.NewLine;
            str += "Kwant:   " + Quantum + Environment.NewLine + Environment.NewLine;
            str += "Dł:      " + CurrentLength + Environment.NewLine;
            str += "Deficyt: " + CurrentDeficit;

            return str;
        }
    }
}
