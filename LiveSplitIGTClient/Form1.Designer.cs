namespace LiveSplitIGTClient {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonMark = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioNumberOfSeconds = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.inputMarkIGT = new System.Windows.Forms.TextBox();
            this.radioHHMMSS = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioMarkOnRelease = new System.Windows.Forms.RadioButton();
            this.radioMarkOnPress = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMark
            // 
            this.buttonMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMark.Location = new System.Drawing.Point(12, 12);
            this.buttonMark.Name = "buttonMark";
            this.buttonMark.Size = new System.Drawing.Size(307, 96);
            this.buttonMark.TabIndex = 0;
            this.buttonMark.Text = "Mark";
            this.buttonMark.UseVisualStyleBackColor = true;
            this.buttonMark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonMark_KeyDown);
            this.buttonMark.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonMark_KeyUp);
            this.buttonMark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMark_MouseDown);
            this.buttonMark.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMark_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioNumberOfSeconds, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputMarkIGT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioHHMMSS, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 81);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // radioNumberOfSeconds
            // 
            this.radioNumberOfSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioNumberOfSeconds.AutoSize = true;
            this.radioNumberOfSeconds.Location = new System.Drawing.Point(156, 52);
            this.radioNumberOfSeconds.Name = "radioNumberOfSeconds";
            this.radioNumberOfSeconds.Size = new System.Drawing.Size(119, 17);
            this.radioNumberOfSeconds.TabIndex = 3;
            this.radioNumberOfSeconds.Text = "Number of Seconds";
            this.radioNumberOfSeconds.UseVisualStyleBackColor = true;
            this.radioNumberOfSeconds.CheckedChanged += new System.EventHandler(this.radioNumberOfSeconds_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark IGT:";
            // 
            // inputMarkIGT
            // 
            this.inputMarkIGT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMarkIGT.Location = new System.Drawing.Point(156, 10);
            this.inputMarkIGT.Name = "inputMarkIGT";
            this.inputMarkIGT.Size = new System.Drawing.Size(148, 20);
            this.inputMarkIGT.TabIndex = 1;
            this.inputMarkIGT.TextChanged += new System.EventHandler(this.inputMarkIGT_TextChanged);
            // 
            // radioHHMMSS
            // 
            this.radioHHMMSS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioHHMMSS.AutoSize = true;
            this.radioHHMMSS.Checked = true;
            this.radioHHMMSS.Location = new System.Drawing.Point(71, 52);
            this.radioHHMMSS.Name = "radioHHMMSS";
            this.radioHHMMSS.Size = new System.Drawing.Size(79, 17);
            this.radioHHMMSS.TabIndex = 2;
            this.radioHHMMSS.TabStop = true;
            this.radioHHMMSS.Text = "HH:MM:SS";
            this.radioHHMMSS.UseVisualStyleBackColor = true;
            this.radioHHMMSS.CheckedChanged += new System.EventHandler(this.radioHHMMSS_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioMarkOnRelease, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioMarkOnPress, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 202);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // radioMarkOnRelease
            // 
            this.radioMarkOnRelease.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioMarkOnRelease.AutoSize = true;
            this.radioMarkOnRelease.Location = new System.Drawing.Point(156, 11);
            this.radioMarkOnRelease.Name = "radioMarkOnRelease";
            this.radioMarkOnRelease.Size = new System.Drawing.Size(106, 17);
            this.radioMarkOnRelease.TabIndex = 4;
            this.radioMarkOnRelease.Text = "Mark on Release";
            this.radioMarkOnRelease.UseVisualStyleBackColor = true;
            // 
            // radioMarkOnPress
            // 
            this.radioMarkOnPress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioMarkOnPress.AutoSize = true;
            this.radioMarkOnPress.Checked = true;
            this.radioMarkOnPress.Location = new System.Drawing.Point(57, 11);
            this.radioMarkOnPress.Name = "radioMarkOnPress";
            this.radioMarkOnPress.Size = new System.Drawing.Size(93, 17);
            this.radioMarkOnPress.TabIndex = 3;
            this.radioMarkOnPress.TabStop = true;
            this.radioMarkOnPress.Text = "Mark on Press";
            this.radioMarkOnPress.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 257);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonMark);
            this.Name = "Form1";
            this.Text = "LiveSplit IGT Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputMarkIGT;
        private System.Windows.Forms.RadioButton radioNumberOfSeconds;
        private System.Windows.Forms.RadioButton radioHHMMSS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioMarkOnRelease;
        private System.Windows.Forms.RadioButton radioMarkOnPress;
    }
}

