namespace n1
{
    partial class Form1
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
            this.boxAmount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTango = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.Label();
            this.txtOf = new System.Windows.Forms.Label();
            this.txtAll = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNext = new System.Windows.Forms.Button();
            this.ckLog = new System.Windows.Forms.CheckBox();
            this.ckFav = new System.Windows.Forms.CheckBox();
            this.ckD = new System.Windows.Forms.RadioButton();
            this.ckC = new System.Windows.Forms.RadioButton();
            this.ckA = new System.Windows.Forms.RadioButton();
            this.ckB = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxAmount
            // 
            this.boxAmount.Location = new System.Drawing.Point(184, 13);
            this.boxAmount.Name = "boxAmount";
            this.boxAmount.Size = new System.Drawing.Size(100, 21);
            this.boxAmount.TabIndex = 0;
            this.boxAmount.Text = "100";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(290, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTango
            // 
            this.txtTango.AutoSize = true;
            this.txtTango.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTango.Location = new System.Drawing.Point(237, 44);
            this.txtTango.Name = "txtTango";
            this.txtTango.Size = new System.Drawing.Size(62, 25);
            this.txtTango.TabIndex = 2;
            this.txtTango.Text = "tango";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrent.AutoSize = true;
            this.txtCurrent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrent.Location = new System.Drawing.Point(430, 49);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrent.Size = new System.Drawing.Size(16, 16);
            this.txtCurrent.TabIndex = 3;
            this.txtCurrent.Text = "0";
            this.txtCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOf
            // 
            this.txtOf.AutoSize = true;
            this.txtOf.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOf.Location = new System.Drawing.Point(457, 49);
            this.txtOf.Name = "txtOf";
            this.txtOf.Size = new System.Drawing.Size(16, 16);
            this.txtOf.TabIndex = 4;
            this.txtOf.Text = "/";
            // 
            // txtAll
            // 
            this.txtAll.AutoSize = true;
            this.txtAll.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAll.Location = new System.Drawing.Point(469, 49);
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(16, 16);
            this.txtAll.TabIndex = 5;
            this.txtAll.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsScore});
            this.statusStrip1.Location = new System.Drawing.Point(0, 256);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(589, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsScore
            // 
            this.stsScore.Name = "stsScore";
            this.stsScore.Size = new System.Drawing.Size(52, 17);
            this.stsScore.Text = "Right: 0";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(511, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ckLog
            // 
            this.ckLog.AutoSize = true;
            this.ckLog.Checked = true;
            this.ckLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckLog.Location = new System.Drawing.Point(392, 15);
            this.ckLog.Name = "ckLog";
            this.ckLog.Size = new System.Drawing.Size(42, 16);
            this.ckLog.TabIndex = 12;
            this.ckLog.Text = "Log";
            this.ckLog.UseVisualStyleBackColor = true;
            // 
            // ckFav
            // 
            this.ckFav.AutoSize = true;
            this.ckFav.Location = new System.Drawing.Point(461, 15);
            this.ckFav.Name = "ckFav";
            this.ckFav.Size = new System.Drawing.Size(72, 16);
            this.ckFav.TabIndex = 13;
            this.ckFav.Text = "Favorite";
            this.ckFav.UseVisualStyleBackColor = true;
            // 
            // ckD
            // 
            this.ckD.AutoSize = true;
            this.ckD.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckD.Location = new System.Drawing.Point(12, 200);
            this.ckD.Name = "ckD";
            this.ckD.Size = new System.Drawing.Size(34, 20);
            this.ckD.TabIndex = 9;
            this.ckD.TabStop = true;
            this.ckD.Tag = "item";
            this.ckD.Text = "D";
            this.ckD.UseVisualStyleBackColor = true;
            this.ckD.Visible = false;
            this.ckD.CheckedChanged += new System.EventHandler(this.ckD_CheckedChanged);
            // 
            // ckC
            // 
            this.ckC.AutoSize = true;
            this.ckC.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckC.Location = new System.Drawing.Point(12, 160);
            this.ckC.Name = "ckC";
            this.ckC.Size = new System.Drawing.Size(34, 20);
            this.ckC.TabIndex = 8;
            this.ckC.TabStop = true;
            this.ckC.Tag = "item";
            this.ckC.Text = "C";
            this.ckC.UseVisualStyleBackColor = true;
            this.ckC.Visible = false;
            this.ckC.CheckedChanged += new System.EventHandler(this.ckC_CheckedChanged);
            // 
            // ckA
            // 
            this.ckA.AllowDrop = true;
            this.ckA.AutoSize = true;
            this.ckA.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckA.Location = new System.Drawing.Point(12, 80);
            this.ckA.Name = "ckA";
            this.ckA.Size = new System.Drawing.Size(34, 20);
            this.ckA.TabIndex = 6;
            this.ckA.TabStop = true;
            this.ckA.Tag = "item";
            this.ckA.Text = "A";
            this.ckA.UseVisualStyleBackColor = true;
            this.ckA.Visible = false;
            this.ckA.CheckedChanged += new System.EventHandler(this.ckA_CheckedChanged);
            // 
            // ckB
            // 
            this.ckB.AutoSize = true;
            this.ckB.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckB.Location = new System.Drawing.Point(12, 120);
            this.ckB.Name = "ckB";
            this.ckB.Size = new System.Drawing.Size(34, 20);
            this.ckB.TabIndex = 7;
            this.ckB.TabStop = true;
            this.ckB.Tag = "item";
            this.ckB.Text = "B";
            this.ckB.UseVisualStyleBackColor = true;
            this.ckB.Visible = false;
            this.ckB.CheckedChanged += new System.EventHandler(this.ckB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 278);
            this.Controls.Add(this.ckB);
            this.Controls.Add(this.ckA);
            this.Controls.Add(this.ckC);
            this.Controls.Add(this.ckFav);
            this.Controls.Add(this.ckD);
            this.Controls.Add(this.ckLog);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.txtOf);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtTango);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.boxAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxAmount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtTango;
        private System.Windows.Forms.Label txtCurrent;
        private System.Windows.Forms.Label txtOf;
        private System.Windows.Forms.Label txtAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsScore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox ckLog;
        private System.Windows.Forms.CheckBox ckFav;
        private System.Windows.Forms.RadioButton ckD;
        private System.Windows.Forms.RadioButton ckC;
        private System.Windows.Forms.RadioButton ckA;
        private System.Windows.Forms.RadioButton ckB;
    }
}

