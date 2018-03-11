using Nethereum.Hex.HexTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthClient
{
    public partial class Form1 : Form
    {

        static string rpcUrl = "http://127.0.0.1:8545";

        Nethereum.Web3.Web3 web3 = new Nethereum.Web3.Web3(rpcUrl);
     
        public Form1()
        {
            InitializeComponent();
        }


        private async void btn_queryAllAccount_Click(object sender, EventArgs e)
        {
            
            var accounts = await web3.Eth.Accounts.SendRequestAsync();
            var acclist = accounts.ToList();
            for (int i = 0; i < acclist.Count; i++)
            {
                this.tb_logList.Text += "账户" + i + ":" + acclist[i] + "\r\n";
            }
        }

        private async void btn_newAccount_Click(object sender, EventArgs e)
        {
            string pwd = this.tb_Pwd.Text.Trim();
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            var createAccount = await web3.Personal.NewAccount.SendRequestAsync(pwd);
            this.tb_logList.Text =  createAccount;
        }

        private async void btn_BlanceOf_Click(object sender, EventArgs e)
        {
            string accountAddress = this.tb_address.Text.Trim();
            if (string.IsNullOrEmpty(accountAddress))
            {
                MessageBox.Show("不能为空");
                return;
            }

            var value= await web3.Eth.GetBalance.SendRequestAsync(accountAddress);
            this.tb_logList.Text = value.Value.ToString();
        }

        private async void btn_unlock_Click(object sender, EventArgs e)
        {
            string accountAddress = this.tb_lockAccount.Text.Trim();
            string unLockPwd = this.tb_unlockPwd.Text;

            if (string.IsNullOrEmpty(accountAddress) || string.IsNullOrEmpty(unLockPwd))
            {
                MessageBox.Show("不能为空");
                return;
            }

            try
            {
                var res = await web3.Personal.UnlockAccount.SendRequestAsync(accountAddress, unLockPwd, 1500);
                this.tb_logList.Text = res.ToString();
            }
            catch (Exception ex)
            {
                this.tb_logList.Text ="密码错误！";
            }
        }

        private async void btn_sendTransfer_Click(object sender, EventArgs e)
        {
            string AccountFrom = this.tb_from.Text.Trim();
            string AccountTo = this.tb_to.Text;


            if (string.IsNullOrEmpty(AccountFrom) || string.IsNullOrEmpty(AccountTo))
            {
                MessageBox.Show("不能为空");
                return;
            }

           string AccountPwd=  InputBox.ShowInputBox("请输入密码！");

            bool unlockres = false;
            try
            {
                unlockres = await web3.Personal.UnlockAccount.SendRequestAsync(AccountFrom, AccountPwd, 1500);
                
            }
            catch (Exception ex)
            {
                this.tb_logList.Text = "钱包密码错误！";
                return;
            }

            if (!unlockres)
            {
                this.tb_logList.Text = "钱包密码错误！";
                return;
            }

           

            Nethereum.RPC.Eth.DTOs.TransactionInput input = new Nethereum.RPC.Eth.DTOs.TransactionInput();
            input.From = AccountFrom;
            input.To = AccountTo;

            HexBigInteger gas = new HexBigInteger(2100000);   //设置转账小号的gas
            input.Gas = gas;

            HexBigInteger price = new HexBigInteger(13000000000000000); //单位：wei
            input.Value =  price;

            var Block = await web3.Eth.Transactions.SendTransaction.SendRequestAsync(input);

            this.tb_logList.Text = Block;

        }
    }
}
