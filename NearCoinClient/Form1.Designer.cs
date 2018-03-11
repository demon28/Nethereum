namespace NearCoinClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_queryAmount = new System.Windows.Forms.Button();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_loglist = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_queryAmount
            // 
            this.btn_queryAmount.Location = new System.Drawing.Point(298, 38);
            this.btn_queryAmount.Name = "btn_queryAmount";
            this.btn_queryAmount.Size = new System.Drawing.Size(75, 23);
            this.btn_queryAmount.TabIndex = 0;
            this.btn_queryAmount.Text = "查询余额";
            this.btn_queryAmount.UseVisualStyleBackColor = true;
            this.btn_queryAmount.Click += new System.EventHandler(this.btn_queryAmount_Click);
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(82, 39);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(211, 21);
            this.tb_account.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "钱包地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "转出地址：";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(84, 108);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(209, 21);
            this.tb_from.TabIndex = 4;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(300, 225);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "代币转账";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(84, 150);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(209, 21);
            this.tb_to.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "转入地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "转账金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "钱包密码：";
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(84, 191);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(209, 21);
            this.tb_amount.TabIndex = 10;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(83, 226);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(210, 21);
            this.tb_pwd.TabIndex = 11;
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(8, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(380, 59);
            this.gb1.TabIndex = 12;
            this.gb1.TabStop = false;
            this.gb1.Text = "查询";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "转账";
            // 
            // tb_loglist
            // 
            this.tb_loglist.Location = new System.Drawing.Point(6, 20);
            this.tb_loglist.Multiline = true;
            this.tb_loglist.Name = "tb_loglist";
            this.tb_loglist.Size = new System.Drawing.Size(365, 74);
            this.tb_loglist.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_loglist);
            this.groupBox2.Location = new System.Drawing.Point(8, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 397);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.btn_queryAmount);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "NearCoin";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_queryAmount;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_loglist;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

