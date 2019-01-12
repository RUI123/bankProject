namespace BigBucksBank
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDeposit = new System.Windows.Forms.RadioButton();
            this.rbtWithdrawal = new System.Windows.Forms.RadioButton();
            this.rbtCheck = new System.Windows.Forms.RadioButton();
            this.rbtTransfer = new System.Windows.Forms.RadioButton();
            this.rbtExit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // rbtDeposit
            // 
            this.rbtDeposit.AutoSize = true;
            this.rbtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDeposit.Location = new System.Drawing.Point(372, 187);
            this.rbtDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtDeposit.Name = "rbtDeposit";
            this.rbtDeposit.Size = new System.Drawing.Size(237, 35);
            this.rbtDeposit.TabIndex = 6;
            this.rbtDeposit.TabStop = true;
            this.rbtDeposit.Text = "Make a Deposit";
            this.rbtDeposit.UseVisualStyleBackColor = true;
            this.rbtDeposit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // rbtWithdrawal
            // 
            this.rbtWithdrawal.AutoSize = true;
            this.rbtWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtWithdrawal.Location = new System.Drawing.Point(372, 281);
            this.rbtWithdrawal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtWithdrawal.Name = "rbtWithdrawal";
            this.rbtWithdrawal.Size = new System.Drawing.Size(281, 35);
            this.rbtWithdrawal.TabIndex = 7;
            this.rbtWithdrawal.TabStop = true;
            this.rbtWithdrawal.Text = "Make a Withdrawal";
            this.rbtWithdrawal.UseVisualStyleBackColor = true;
            this.rbtWithdrawal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // rbtCheck
            // 
            this.rbtCheck.AutoSize = true;
            this.rbtCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCheck.Location = new System.Drawing.Point(372, 373);
            this.rbtCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtCheck.Name = "rbtCheck";
            this.rbtCheck.Size = new System.Drawing.Size(231, 35);
            this.rbtCheck.TabIndex = 8;
            this.rbtCheck.TabStop = true;
            this.rbtCheck.Text = "Check Balance";
            this.rbtCheck.UseVisualStyleBackColor = true;
            this.rbtCheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton3_MouseClick);
            // 
            // rbtTransfer
            // 
            this.rbtTransfer.AutoSize = true;
            this.rbtTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTransfer.Location = new System.Drawing.Point(369, 465);
            this.rbtTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTransfer.Name = "rbtTransfer";
            this.rbtTransfer.Size = new System.Drawing.Size(234, 35);
            this.rbtTransfer.TabIndex = 9;
            this.rbtTransfer.TabStop = true;
            this.rbtTransfer.Text = "Transfer Funds";
            this.rbtTransfer.UseVisualStyleBackColor = true;
            this.rbtTransfer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton4_MouseClick);
            // 
            // rbtExit
            // 
            this.rbtExit.AutoSize = true;
            this.rbtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtExit.Location = new System.Drawing.Point(372, 555);
            this.rbtExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtExit.Name = "rbtExit";
            this.rbtExit.Size = new System.Drawing.Size(84, 35);
            this.rbtExit.TabIndex = 10;
            this.rbtExit.TabStop = true;
            this.rbtExit.Text = "Exit";
            this.rbtExit.UseVisualStyleBackColor = true;
            this.rbtExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton5_MouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1024, 745);
            this.ControlBox = false;
            this.Controls.Add(this.rbtExit);
            this.Controls.Add(this.rbtTransfer);
            this.Controls.Add(this.rbtCheck);
            this.Controls.Add(this.rbtWithdrawal);
            this.Controls.Add(this.rbtDeposit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtDeposit;
        private System.Windows.Forms.RadioButton rbtWithdrawal;
        private System.Windows.Forms.RadioButton rbtCheck;
        private System.Windows.Forms.RadioButton rbtTransfer;
        public System.Windows.Forms.RadioButton rbtExit;
    }
}