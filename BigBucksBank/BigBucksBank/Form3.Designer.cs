namespace BigBucksBank
{
    partial class Form3
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
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbReceipt = new System.Windows.Forms.Label();
            this.lbTransaction = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBalance1 = new System.Windows.Forms.TextBox();
            this.txtTransaction1 = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.lbSource = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtBalance2 = new System.Windows.Forms.TextBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.BackColor = System.Drawing.Color.Beige;
            this.lbCustomer.Enabled = false;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(29, 62);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(99, 20);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.Text = "Customer ID";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.BackColor = System.Drawing.Color.Beige;
            this.lbBalance.Enabled = false;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(161, 193);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(138, 20);
            this.lbBalance.TabIndex = 3;
            this.lbBalance.Text = "TOTAL BALANCE";
            // 
            // lbReceipt
            // 
            this.lbReceipt.AutoSize = true;
            this.lbReceipt.BackColor = System.Drawing.Color.Beige;
            this.lbReceipt.Enabled = false;
            this.lbReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceipt.Location = new System.Drawing.Point(100, 15);
            this.lbReceipt.Name = "lbReceipt";
            this.lbReceipt.Size = new System.Drawing.Size(369, 31);
            this.lbReceipt.TabIndex = 4;
            this.lbReceipt.Text = "BIG BUCKS BANK RECEIPT";
            // 
            // lbTransaction
            // 
            this.lbTransaction.AutoSize = true;
            this.lbTransaction.BackColor = System.Drawing.Color.Beige;
            this.lbTransaction.Enabled = false;
            this.lbTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransaction.Location = new System.Drawing.Point(52, 98);
            this.lbTransaction.Name = "lbTransaction";
            this.lbTransaction.Size = new System.Drawing.Size(126, 20);
            this.lbTransaction.TabIndex = 6;
            this.lbTransaction.Text = "TRANSACTION:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Beige;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(126, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 19);
            this.txtId.TabIndex = 7;
            // 
            // txtBalance1
            // 
            this.txtBalance1.BackColor = System.Drawing.Color.Beige;
            this.txtBalance1.Enabled = false;
            this.txtBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance1.Location = new System.Drawing.Point(360, 223);
            this.txtBalance1.Name = "txtBalance1";
            this.txtBalance1.Size = new System.Drawing.Size(150, 23);
            this.txtBalance1.TabIndex = 9;
            // 
            // txtTransaction1
            // 
            this.txtTransaction1.BackColor = System.Drawing.Color.Beige;
            this.txtTransaction1.Enabled = false;
            this.txtTransaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransaction1.Location = new System.Drawing.Point(181, 93);
            this.txtTransaction1.Multiline = true;
            this.txtTransaction1.Name = "txtTransaction1";
            this.txtTransaction1.Size = new System.Drawing.Size(330, 50);
            this.txtTransaction1.TabIndex = 12;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(214, 301);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(81, 26);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.BackColor = System.Drawing.Color.Beige;
            this.lbSource.Enabled = false;
            this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.Location = new System.Drawing.Point(266, 224);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(57, 20);
            this.lbSource.TabIndex = 14;
            this.lbSource.Text = "********";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "AMOUNT OF TRANSACTION:";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Beige;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(301, 158);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 23);
            this.txtAmount.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "DATE:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Beige;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(379, 62);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 19);
            this.txtDate.TabIndex = 20;
            // 
            // txtBalance2
            // 
            this.txtBalance2.BackColor = System.Drawing.Color.Beige;
            this.txtBalance2.Enabled = false;
            this.txtBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance2.Location = new System.Drawing.Point(360, 264);
            this.txtBalance2.Name = "txtBalance2";
            this.txtBalance2.Size = new System.Drawing.Size(150, 23);
            this.txtBalance2.TabIndex = 15;
            this.txtBalance2.Visible = false;
            // 
            // lbTarget
            // 
            this.lbTarget.AutoSize = true;
            this.lbTarget.BackColor = System.Drawing.Color.Beige;
            this.lbTarget.Enabled = false;
            this.lbTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarget.Location = new System.Drawing.Point(266, 266);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(57, 20);
            this.lbTarget.TabIndex = 16;
            this.lbTarget.Text = "********";
            this.lbTarget.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(548, 338);
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTarget);
            this.Controls.Add(this.txtBalance2);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtTransaction1);
            this.Controls.Add(this.txtBalance1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbTransaction);
            this.Controls.Add(this.lbReceipt);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btClose;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtBalance1;
        public System.Windows.Forms.TextBox txtTransaction1;
        public System.Windows.Forms.Label lbCustomer;
        public System.Windows.Forms.Label lbBalance;
        public System.Windows.Forms.Label lbReceipt;
        public System.Windows.Forms.Label lbTransaction;
        public System.Windows.Forms.Label lbSource;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox txtBalance2;
        public System.Windows.Forms.Label lbTarget;
    }
}