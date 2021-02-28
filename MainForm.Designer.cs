namespace KnightsTour
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
            this.lblPlayOutput = new System.Windows.Forms.Label();
            this.btnNonIntel = new System.Windows.Forms.Button();
            this.lblTrial = new System.Windows.Forms.Label();
            this.txtTrial = new System.Windows.Forms.TextBox();
            this.lblXCoor = new System.Windows.Forms.Label();
            this.txtXcoor = new System.Windows.Forms.TextBox();
            this.txtYCoor = new System.Windows.Forms.TextBox();
            this.lblYCoor = new System.Windows.Forms.Label();
            this.btnHeuristic = new System.Windows.Forms.Button();
            this.lblTrialOutputTitle = new System.Windows.Forms.Label();
            this.lblPlayOutputTitle = new System.Windows.Forms.Label();
            this.btnNextTrial = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbTrialOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPlayOutput
            // 
            this.lblPlayOutput.AutoSize = true;
            this.lblPlayOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayOutput.Location = new System.Drawing.Point(339, 41);
            this.lblPlayOutput.Name = "lblPlayOutput";
            this.lblPlayOutput.Size = new System.Drawing.Size(0, 19);
            this.lblPlayOutput.TabIndex = 64;
            // 
            // btnNonIntel
            // 
            this.btnNonIntel.Location = new System.Drawing.Point(27, 168);
            this.btnNonIntel.Name = "btnNonIntel";
            this.btnNonIntel.Size = new System.Drawing.Size(89, 23);
            this.btnNonIntel.TabIndex = 65;
            this.btnNonIntel.Text = "Non-intelligent";
            this.btnNonIntel.UseVisualStyleBackColor = true;
            this.btnNonIntel.Click += new System.EventHandler(this.btnNonIntel_Click);
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Location = new System.Drawing.Point(24, 29);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(41, 13);
            this.lblTrial.TabIndex = 66;
            this.lblTrial.Text = "Trial(s):";
            // 
            // txtTrial
            // 
            this.txtTrial.Location = new System.Drawing.Point(71, 26);
            this.txtTrial.Name = "txtTrial";
            this.txtTrial.Size = new System.Drawing.Size(110, 20);
            this.txtTrial.TabIndex = 67;
            // 
            // lblXCoor
            // 
            this.lblXCoor.AutoSize = true;
            this.lblXCoor.Location = new System.Drawing.Point(48, 62);
            this.lblXCoor.Name = "lblXCoor";
            this.lblXCoor.Size = new System.Drawing.Size(17, 13);
            this.lblXCoor.TabIndex = 68;
            this.lblXCoor.Text = "X:";
            // 
            // txtXcoor
            // 
            this.txtXcoor.Location = new System.Drawing.Point(71, 59);
            this.txtXcoor.Name = "txtXcoor";
            this.txtXcoor.Size = new System.Drawing.Size(26, 20);
            this.txtXcoor.TabIndex = 69;
            // 
            // txtYCoor
            // 
            this.txtYCoor.Location = new System.Drawing.Point(155, 59);
            this.txtYCoor.Name = "txtYCoor";
            this.txtYCoor.Size = new System.Drawing.Size(26, 20);
            this.txtYCoor.TabIndex = 71;
            // 
            // lblYCoor
            // 
            this.lblYCoor.AutoSize = true;
            this.lblYCoor.Location = new System.Drawing.Point(132, 62);
            this.lblYCoor.Name = "lblYCoor";
            this.lblYCoor.Size = new System.Drawing.Size(17, 13);
            this.lblYCoor.TabIndex = 70;
            this.lblYCoor.Text = "Y:";
            // 
            // btnHeuristic
            // 
            this.btnHeuristic.Location = new System.Drawing.Point(27, 139);
            this.btnHeuristic.Name = "btnHeuristic";
            this.btnHeuristic.Size = new System.Drawing.Size(89, 23);
            this.btnHeuristic.TabIndex = 72;
            this.btnHeuristic.Text = "Heuristic";
            this.btnHeuristic.UseVisualStyleBackColor = true;
            this.btnHeuristic.Click += new System.EventHandler(this.btnHeuristic_Click);
            // 
            // lblTrialOutputTitle
            // 
            this.lblTrialOutputTitle.AutoSize = true;
            this.lblTrialOutputTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrialOutputTitle.Location = new System.Drawing.Point(339, 213);
            this.lblTrialOutputTitle.Name = "lblTrialOutputTitle";
            this.lblTrialOutputTitle.Size = new System.Drawing.Size(135, 19);
            this.lblTrialOutputTitle.TabIndex = 73;
            this.lblTrialOutputTitle.Text = "Trial Summary:";
            // 
            // lblPlayOutputTitle
            // 
            this.lblPlayOutputTitle.AutoSize = true;
            this.lblPlayOutputTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayOutputTitle.Location = new System.Drawing.Point(339, 9);
            this.lblPlayOutputTitle.Name = "lblPlayOutputTitle";
            this.lblPlayOutputTitle.Size = new System.Drawing.Size(180, 19);
            this.lblPlayOutputTitle.TabIndex = 75;
            this.lblPlayOutputTitle.Text = "Knight\'s movements:";
            // 
            // btnNextTrial
            // 
            this.btnNextTrial.Location = new System.Drawing.Point(390, 415);
            this.btnNextTrial.Name = "btnNextTrial";
            this.btnNextTrial.Size = new System.Drawing.Size(75, 23);
            this.btnNextTrial.TabIndex = 76;
            this.btnNextTrial.Text = "Next Trial";
            this.btnNextTrial.UseVisualStyleBackColor = true;
            this.btnNextTrial.Click += new System.EventHandler(this.btnNextTrial_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(590, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 77;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtbTrialOutput
            // 
            this.rtbTrialOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbTrialOutput.Location = new System.Drawing.Point(343, 235);
            this.rtbTrialOutput.Name = "rtbTrialOutput";
            this.rtbTrialOutput.Size = new System.Drawing.Size(488, 149);
            this.rtbTrialOutput.TabIndex = 79;
            this.rtbTrialOutput.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.rtbTrialOutput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNextTrial);
            this.Controls.Add(this.lblPlayOutputTitle);
            this.Controls.Add(this.lblTrialOutputTitle);
            this.Controls.Add(this.btnHeuristic);
            this.Controls.Add(this.txtYCoor);
            this.Controls.Add(this.lblYCoor);
            this.Controls.Add(this.txtXcoor);
            this.Controls.Add(this.lblXCoor);
            this.Controls.Add(this.txtTrial);
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.btnNonIntel);
            this.Controls.Add(this.lblPlayOutput);
            this.Name = "MainForm";
            this.Text = "Knight\'s Tour problem";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayOutput;
        private System.Windows.Forms.Button btnNonIntel;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.TextBox txtTrial;
        private System.Windows.Forms.Label lblXCoor;
        private System.Windows.Forms.TextBox txtXcoor;
        private System.Windows.Forms.TextBox txtYCoor;
        private System.Windows.Forms.Label lblYCoor;
        private System.Windows.Forms.Button btnHeuristic;
        private System.Windows.Forms.Label lblTrialOutputTitle;
        private System.Windows.Forms.Label lblPlayOutputTitle;
        private System.Windows.Forms.Button btnNextTrial;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rtbTrialOutput;
    }
}

