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
    public partial class BlockControl : UserControl
    {
        private static Color initialColor = Color.FromArgb(255, 255, 192);
        private static Color processingColor = Color.DarkKhaki;
        private static Color acceptanceColor = Color.LimeGreen;
        private static Color rejectionColor = Color.IndianRed;

        public BlockControl()
        {
            InitializeComponent();
            BackColor = initialColor;
        }
        internal void Destroy()
        {
            if(Parent != null && Parent.Controls.Contains(this))
            {
                if(Parent.InvokeRequired)
                {
                    Parent.Invoke(new MethodInvoker(() => Parent.Controls.Remove(this)));
                }
                else
                {
                    Parent.Controls.Remove(this);
                }
            }
        }
        internal void SetText(string text)
        {
            this.lblText.Text = text;
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
        internal void ChangeColorProcessing()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => BackColor = processingColor));
            }
            else
            {
                BackColor = processingColor;
            }
        }
        internal void ChangeColorAccepted()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(() => BackColor = acceptanceColor));
            }
            else
            {
                BackColor = acceptanceColor;
            }
        }
        internal void ChangeColorRejected()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => BackColor = rejectionColor));
            }
            else
            {
                BackColor = rejectionColor;
            }
        }
    }
}
