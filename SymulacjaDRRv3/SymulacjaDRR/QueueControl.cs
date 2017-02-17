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
    public partial class QueueControl : UserControl
    {
        public EventHandler DeleteQueue;
        public bool ButtonEnabled
        {
            get
            {
                return btnDelete.Enabled;
            }
            set
            {
                btnDelete.Enabled = value;
            }
        }

        public QueueControl()
        {
            InitializeComponent();
        }

        internal void SetText(string text)
        {
            this.label1.Text = text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var handler = DeleteQueue;
            if(handler != null)
                handler.Invoke(this, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
