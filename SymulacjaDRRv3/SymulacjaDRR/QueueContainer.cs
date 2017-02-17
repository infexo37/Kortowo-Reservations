using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SymulacjaDRR
{
    public partial class QueueContainer : FlowLayoutPanel
    {
        private static Color initialColor = Color.White;
        private static Color activeColor = Color.WhiteSmoke;
        internal PacketQueue PacketQueue;

        internal QueueContainer(PacketQueue Queue)
        {
            InitializeComponent();
            PacketQueue = Queue;
            FlowDirection = FlowDirection.BottomUp;
            Dock = DockStyle.Fill;
            BackColor = Color.White;
            Margin = new Padding(0);
        }
        internal void ChangeColorInitial()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => BackColor = initialColor));
            }
            else
            {
                BackColor = initialColor;
            }
        }
        internal void ChangeColorActive()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => BackColor = activeColor));
            }
            else
            {
                BackColor = activeColor;
            }
        }

        private void QueueControl_SizeChanged(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                c.Width = this.Width - c.Margin.Left - c.Margin.Right;
            }
        }
        public override string ToString()
        {
            return "QueueControl: " + this.Name;
        }
    }
}
