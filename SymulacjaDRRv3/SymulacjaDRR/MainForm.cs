using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulacjaDRR
{
    public partial class MainForm : Form
    {
        private List<PacketQueue> queues = new List<PacketQueue>();
        CancellationTokenSource cts;

        public MainForm()
        {
            InitializeComponent();
            Simulation.AlgorithmStepButton = btnStep;
        }

        private void RemoveQueue(object sender, EventArgs e)
        {
            QueueControl qcontrol = sender as QueueControl;

            int qIndex = queues.FindIndex(_q => _q.QueueControl == qcontrol);

            if(qIndex > -1)
            {
                tlpVisualisation.Controls.Remove(queues[qIndex].QueueControl);
                tlpVisualisation.Controls.Remove(queues[qIndex].QueueContainer);

                for(int i = qIndex + 1; i < tlpVisualisation.ColumnCount; i++)
                {
                    QueueControl _qcontrol = tlpVisualisation.GetControlFromPosition(i, 0) as QueueControl;
                    QueueContainer _qc = tlpVisualisation.GetControlFromPosition(i, 1) as QueueContainer;
                    tlpVisualisation.Controls.Add(_qcontrol, i - 1, 0);
                    tlpVisualisation.Controls.Add(_qc, i - 1, 1);
                }

                if (tlpVisualisation.ColumnCount > 1)
                {
                    tlpVisualisation.ColumnCount = tlpVisualisation.ColumnCount - 1;
                }
                else
                {
                    btnGenerate.Enabled = false;
                    btnStart.Enabled = false;
                    btnStep.Enabled = false;
                }
            }

            queues.RemoveAt(qIndex);
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            if (nudQueueSize.Value <= 0)
                return;

            if (nudQuantum.Value >= nudQueueSize.Value)
                return;

            if (queues.Count == 0)
            {
                PacketQueue q = new PacketQueue((int)nudQueueSize.Value, (int)nudQuantum.Value);
                QueueContainer flp = new QueueContainer(q);
                flp.Dock = DockStyle.Fill;
                flp.Name = "flpQueue" + queues.Count;
                flp.BackColor = Color.White;
                tlpVisualisation.Controls.Add(flp, 0, 1);

                q.SetQueueContainer(flp);
                QueueControl qcontrol = new QueueControl();
                qcontrol.DeleteQueue += RemoveQueue;
                qcontrol.Name = "Kolejka " + queues.Count + 1;
                qcontrol.Dock = DockStyle.Fill;
                tlpVisualisation.Controls.Add(qcontrol, 0, 0);
                q.SetQueueControl(qcontrol);
                queues.Add(q);
                btnGenerate.Enabled = true;
                btnStart.Enabled = true;
                btnStep.Enabled = true;
            }
            else
            {
                tlpVisualisation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                PacketQueue q = new PacketQueue((int)nudQueueSize.Value, (int)nudQuantum.Value);
                QueueContainer flp = new QueueContainer(q);
                flp.Dock = DockStyle.Fill;
                flp.Name = "flpQueue" + queues.Count;
                flp.BackColor = Color.White;
                tlpVisualisation.Controls.Add(flp, tlpVisualisation.ColumnCount, 1);

                q.SetQueueContainer(flp);
                QueueControl qcontrol = new QueueControl();
                qcontrol.DeleteQueue += RemoveQueue;
                qcontrol.Name = "Kolejka " + queues.Count + 1;
                qcontrol.Dock = DockStyle.Fill;
                tlpVisualisation.Controls.Add(qcontrol, tlpVisualisation.ColumnCount, 0);

                tlpVisualisation.ColumnCount = tlpVisualisation.ColumnCount + 1;

                q.SetQueueControl(qcontrol);
                queues.Add(q);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (nudMinLength.Value < 0)
                return;

            if (nudMaxLength.Value <= 0 || nudMinLength.Value >= nudMaxLength.Value)
                return;

            int minLength = (int)nudMinLength.Value;
            int maxLength = (int)nudMaxLength.Value;
            int packetsAmount = (int)nudPacketAmount.Value;

            Random rand = new Random();

            tlpVisualisation.SuspendLayout();

            for(int i = 0; i < packetsAmount; i++)
            {
                int queueNo = rand.Next(0, queues.Count);
                if (queueNo == queues.Count)
                    queueNo--;

                int length = rand.Next(minLength + 1, maxLength - 1);
                Packet p = new Packet(length);
                BlockControl bc = new BlockControl();
                bc.SetText(length.ToString());
                p.Block = bc;

                int count = 0;
                QueueContainer qc = null;

                do
                {                   
                    if (queues[queueNo].Enqueue(p))
                    {
                        qc = queues[queueNo].QueueContainer;

                        if (qc != null)
                        {
                            bc.Width = qc.Width - bc.Margin.Left - bc.Margin.Right;
                            bc.Height = (int)((float)p.Length / queues[queueNo].MaxLength * qc.Height * 0.95f);

                            qc.Controls.Add(bc);
                        }

                        break;
                    }

                    count++;
                    queueNo = rand.Next(0, queues.Count);
                    if (queueNo == queues.Count)
                        queueNo--;

                } while (count < 10);
            }

            tlpVisualisation.ResumeLayout();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Zatrzymaj symulację";
            btnAddQueue.Enabled = false;
            btnStart.Click -= new EventHandler(this.btnStart_Click);
            btnStart.Click += new EventHandler(this.btnStop_Click);

            foreach(QueueControl qc in tlpVisualisation.Controls.OfType<QueueControl>())
            {
                qc.ButtonEnabled = false;
            }

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            token.Register(() =>
            {
                btnStart.Text = "Uruchom symulację";
                btnAddQueue.Enabled = true;
                btnStart.Click += new EventHandler(this.btnStart_Click);
                btnStart.Click -= new EventHandler(this.btnStop_Click);

                foreach (QueueControl qc in tlpVisualisation.Controls.OfType<QueueControl>())
                {
                    qc.ButtonEnabled = true;
                }
            });

            try
            {
                await Task.Run(() => { return Simulation.RunDRRSimulation(token, queues); });
            }
            catch
            {
                if (!token.IsCancellationRequested)
                {
                    MessageBox.Show("Wystąpił błąd w trakcie symulacji, została ona zatrzymana.", "Błąd symulacji", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnStart.Text = "Uruchom symulację";
                    btnAddQueue.Enabled = true;
                    btnStart.Click += new EventHandler(this.btnStart_Click);
                    btnStart.Click -= new EventHandler(this.btnStop_Click);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            Simulation.AlgorithmSpeed = tbSpeed.Value;
        }

        private void chkDelay_CheckedChanged(object sender, EventArgs e)
        {
            chkStepped.Checked = false;
            Simulation.AlgorithmDelay = chkDelay.Checked;
        }

        private void chkStepped_CheckedChanged(object sender, EventArgs e)
        {
            Simulation.AlgorithmStepped = chkStepped.Checked;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            btnStep.Enabled = false;
            Simulation.AlgorithmNextStepAvailable = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int lines = 0, processed = 0;

            using (StreamReader strumienOdczytu = new StreamReader("packets.csv", Encoding.Default, true))
            {            
                while (!strumienOdczytu.EndOfStream)
                {
                    lines++;
                    string line = strumienOdczytu.ReadLine();
                    string[] dane = line.Split(';');

                    if (dane.Length != 2)
                        continue;

                    int length = 0, queue = 0;

                    if(int.TryParse(dane[0], out length) && int.TryParse(dane[1], out queue))
                    {                        
                        if (queues.Count < queue)
                            continue;

                        queue--;

                        Packet p = new Packet(length);
                        BlockControl bc = new BlockControl();
                        bc.SetText(length.ToString());
                        p.Block = bc;

                        if (queues[queue].Enqueue(p))
                        {
                            QueueContainer qc = queues[queue].QueueContainer;

                            if (qc != null)
                            {
                                bc.Width = qc.Width - bc.Margin.Left - bc.Margin.Right;
                                bc.Height = (int)((float)p.Length / queues[queue].MaxLength * qc.Height * 0.95f);

                                qc.Controls.Add(bc);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    processed++;
                }
            }

            MessageBox.Show("Wczytywanie zakończone. Wczytano " + processed + " z " + lines + " pakietów", "Wczytywanie zakończone", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
