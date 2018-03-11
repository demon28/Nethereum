namespace EthClient
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
            this.btn_newAccount = new System.Windows.Forms.Button();
            this.btn_queryAllAccount = new System.Windows.Forms.Button();
            this.btn_BlanceOf = new System.Windows.Forms.Button();
            this.btn_sendTransfer = new System.Windows.Forms.Button();
            this.tb_logList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_Pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.tb_lockAccount = new System.Windows.Forms.TextBox();
            this.tb_unlockPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_newAccount
            // 
            this.btn_newAccount.Location = new System.Drawing.Point(23, 58);
            this.btn_newAccount.Name = "btn_newAccount";
            this.btn_newAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_newAccount.TabIndex = 0;
            this.btn_newAccount.Text = "创建钱包";
            this.btn_newAccount.UseVisualStyleBackColor = true;
            this.btn_newAccount.Click += new System.EventHandler(this.btn_newAccount_Click);
            // 
            // btn_queryAllAccount
            // 
            this.btn_queryAllAccount.Location = new System.Drawing.Point(23, 20);
            this.btn_queryAllAccount.Name = "btn_queryAllAccount";
            this.btn_queryAllAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_queryAllAccount.TabIndex = 1;
            this.btn_queryAllAccount.Text = "钱包列表";
            this.btn_queryAllAccount.UseVisualStyleBackColor = true;
            this.btn_queryAllAccount.Click += new System.EventHandler(this.btn_queryAllAccount_Click);
            // 
            // btn_BlanceOf
            // 
            this.btn_BlanceOf.Location = new System.Drawing.Point(23, 99);
            this.btn_BlanceOf.Name = "btn_BlanceOf";
            this.btn_BlanceOf.Size = new System.Drawing.Size(75, 23);
            this.btn_BlanceOf.TabIndex = 2;
            this.btn_BlanceOf.Text = "钱包余额";
            this.btn_BlanceOf.UseVisualStyleBackColor = true;
            this.btn_BlanceOf.Click += new System.EventHandler(this.btn_BlanceOf_Click);
            // 
            // btn_sendTransfer
            // 
            this.btn_sendTransfer.Location = new System.Drawing.Point(23, 190);
            this.btn_sendTransfer.Name = "btn_sendTransfer";
            this.btn_sendTransfer.Size = new System.Drawing.Size(75, 23);
            this.btn_sendTransfer.TabIndex = 3;
            this.btn_sendTransfer.Text = "钱包转账";
            this.btn_sendTransfer.UseVisualStyleBackColor = true;
            this.btn_sendTransfer.Click += new System.EventHandler(this.btn_sendTransfer_Click);
            // 
            // tb_logList
            // 
            this.tb_logList.Location = new System.Drawing.Point(19, 258);
            this.tb_logList.Multiline = true;
            this.tb_logList.Name = "tb_logList";
            this.tb_logList.Size = new System.Drawing.Size(462, 107);
            this.tb_logList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "输出：";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(110, 99);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(322, 21);
            this.tb_address.TabIndex = 6;
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.Location = new System.Drawing.Point(110, 59);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(322, 21);
            this.tb_Pwd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "(密码)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "(地址)";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(110, 192);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(139, 21);
            this.tb_from.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "(From)";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(291, 192);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(141, 21);
            this.tb_to.TabIndex = 12;
            // 
            // btn_unlock
            // 
            this.btn_unlock.Location = new System.Drawing.Point(23, 141);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(75, 23);
            this.btn_unlock.TabIndex = 14;
            this.btn_unlock.Text = "钱包解锁";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // tb_lockAccount
            // 
            this.tb_lockAccount.Location = new System.Drawing.Point(110, 142);
            this.tb_lockAccount.Name = "tb_lockAccount";
            this.tb_lockAccount.Size = new System.Drawing.Size(173, 21);
            this.tb_lockAccount.TabIndex = 15;
            // 
            // tb_unlockPwd
            // 
            this.tb_unlockPwd.Location = new System.Drawing.Point(336, 141);
            this.tb_unlockPwd.Name = "tb_unlockPwd";
            this.tb_unlockPwd.Size = new System.Drawing.Size(96, 21);
            this.tb_unlockPwd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "(密码)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "(地址)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "(To)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_unlockPwd);
            this.Controls.Add(this.tb_lockAccount);
            this.Controls.Add(this.btn_unlock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Pwd);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_logList);
            this.Controls.Add(this.btn_sendTransfer);
            this.Controls.Add(this.btn_BlanceOf);
            this.Controls.Add(this.btn_queryAllAccount);
            this.Controls.Add(this.btn_newAccount);
            this.Name = "Form1";
            this.Text = "Nethereum客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newAccount;
        private System.Windows.Forms.Button btn_queryAllAccount;
        private System.Windows.Forms.Button btn_BlanceOf;
        private System.Windows.Forms.Button btn_sendTransfer;
        private System.Windows.Forms.TextBox tb_logList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_Pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.TextBox tb_lockAccount;
        private System.Windows.Forms.TextBox tb_unlockPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

