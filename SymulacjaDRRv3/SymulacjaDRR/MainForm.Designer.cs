namespace SymulacjaDRR
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStep = new System.Windows.Forms.Button();
            this.chkStepped = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDelay = new System.Windows.Forms.CheckBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPacketAmount = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinLength = new System.Windows.Forms.NumericUpDown();
            this.nudMaxLength = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQueueSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.tlpVisualisation = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPacketAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueueSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStep);
            this.splitContainer1.Panel1.Controls.Add(this.chkStepped);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.chkDelay);
            this.splitContainer1.Panel1.Controls.Add(this.tbSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tlpVisualisation);
            this.splitContainer1.Size = new System.Drawing.Size(784, 488);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnStep
            // 
            this.btnStep.Enabled = false;
            this.btnStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStep.Location = new System.Drawing.Point(21, 443);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(152, 28);
            this.btnStep.TabIndex = 14;
            this.btnStep.Text = "Kolejny krok";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // chkStepped
            // 
            this.chkStepped.AutoSize = true;
            this.chkStepped.Location = new System.Drawing.Point(21, 418);
            this.chkStepped.Name = "chkStepped";
            this.chkStepped.Size = new System.Drawing.Size(154, 17);
            this.chkStepped.TabIndex = 13;
            this.chkStepped.Text = "Wykonuj algorytm krokowo";
            this.chkStepped.UseVisualStyleBackColor = true;
            this.chkStepped.CheckedChanged += new System.EventHandler(this.chkStepped_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 1);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // chkDelay
            // 
            this.chkDelay.AutoSize = true;
            this.chkDelay.Checked = true;
            this.chkDelay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelay.Location = new System.Drawing.Point(21, 374);
            this.chkDelay.Name = "chkDelay";
            this.chkDelay.Size = new System.Drawing.Size(110, 17);
            this.chkDelay.TabIndex = 11;
            this.chkDelay.Text = "Opóźnij symulację";
            this.chkDelay.UseVisualStyleBackColor = true;
            this.chkDelay.CheckedChanged += new System.EventHandler(this.chkDelay_CheckedChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(21, 330);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(152, 45);
            this.tbSpeed.TabIndex = 10;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbSpeed.Value = 3;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(21, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Uruchom symulację";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudPacketAmount);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudMinLength);
            this.groupBox2.Controls.Add(this.nudMaxLength);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 159);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generator pakietów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ilość pakietów";
            // 
            // nudPacketAmount
            // 
            this.nudPacketAmount.Location = new System.Drawing.Point(100, 19);
            this.nudPacketAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPacketAmount.Name = "nudPacketAmount";
            this.nudPacketAmount.Size = new System.Drawing.Size(61, 20);
            this.nudPacketAmount.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(9, 97);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(152, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generuj pakiety";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min. długość";
            // 
            // nudMinLength
            // 
            this.nudMinLength.Location = new System.Drawing.Point(100, 45);
            this.nudMinLength.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMinLength.Name = "nudMinLength";
            this.nudMinLength.Size = new System.Drawing.Size(61, 20);
            this.nudMinLength.TabIndex = 0;
            // 
            // nudMaxLength
            // 
            this.nudMaxLength.Location = new System.Drawing.Point(100, 71);
            this.nudMaxLength.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMaxLength.Name = "nudMaxLength";
            this.nudMaxLength.Size = new System.Drawing.Size(61, 20);
            this.nudMaxLength.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max. długość";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddQueue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudQueueSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudQuantum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tworzenie kolejki";
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.Location = new System.Drawing.Point(9, 73);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(152, 23);
            this.btnAddQueue.TabIndex = 6;
            this.btnAddQueue.Text = "Dodaj kolejkę";
            this.btnAddQueue.UseVisualStyleBackColor = true;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Przesyłany kwant";
            // 
            // nudQueueSize
            // 
            this.nudQueueSize.Location = new System.Drawing.Point(100, 21);
            this.nudQueueSize.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQueueSize.Name = "nudQueueSize";
            this.nudQueueSize.Size = new System.Drawing.Size(61, 20);
            this.nudQueueSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Długość kolejki";
            // 
            // nudQuantum
            // 
            this.nudQuantum.Location = new System.Drawing.Point(100, 47);
            this.nudQuantum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(61, 20);
            this.nudQuantum.TabIndex = 2;
            // 
            // tlpVisualisation
            // 
            this.tlpVisualisation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpVisualisation.ColumnCount = 1;
            this.tlpVisualisation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVisualisation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVisualisation.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tlpVisualisation.Location = new System.Drawing.Point(0, 0);
            this.tlpVisualisation.Name = "tlpVisualisation";
            this.tlpVisualisation.RowCount = 2;
            this.tlpVisualisation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVisualisation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpVisualisation.Size = new System.Drawing.Size(592, 488);
            this.tlpVisualisation.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(9, 130);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(152, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Wczytaj z pliku";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 488);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symulacja algorytmu Defict Round Robin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPacketAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueueSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinLength;
        private System.Windows.Forms.NumericUpDown nudMaxLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddQueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQueueSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.TableLayoutPanel tlpVisualisation;
        private System.Windows.Forms.NumericUpDown nudPacketAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.CheckBox chkDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStepped;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnLoad;
    }
}

