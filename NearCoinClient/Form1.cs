using Nethereum.Hex.HexTypes;
using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearCoinClient
{
    public partial class Form1 : Form
    {

        readonly static string rpcUrl = "http://127.0.0.1:8545";

        readonly static string abi = @"[ { ""constant"": true, ""inputs"": [], ""name"": ""name"", ""outputs"": [ { ""name"": """", ""type"": ""string"", ""value"": ""NearCoin"" } ], ""payable"": false, ""stateMutability"": ""view"", ""type"": ""function"" }, { ""constant"": false, ""inputs"": [ { ""name"": ""_spender"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" } ], ""name"": ""approve"", ""outputs"": [ { ""name"": ""success"", ""type"": ""bool"" } ], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""totalSupply"", ""outputs"": [ { ""name"": """", ""type"": ""uint256"", ""value"": ""100000000000000000"" } ], ""payable"": false, ""stateMutability"": ""view"", ""type"": ""function"" }, { ""constant"": false, ""inputs"": [ { ""name"": ""_from"", ""type"": ""address"" }, { ""name"": ""_to"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" } ], ""name"": ""transferFrom"", ""outputs"": [ { ""name"": ""success"", ""type"": ""bool"" } ], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""decimals"", ""outputs"": [ { ""name"": """", ""type"": ""uint8"", ""value"": ""10"" } ], ""payable"": false, ""stateMutability"": ""view"", ""type"": ""function"" }, { ""constant"": false, ""inputs"": [ { ""name"": ""_value"", ""type"": ""uint256"" } ], ""name"": ""burn"", ""outputs"": [ { ""name"": ""success"", ""type"": ""bool"" } ], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""function"" }, { ""constant"": true, ""inputs"": [ { ""name"": """", ""type"": ""address"" } ], ""name"": ""balanceOf"", ""outputs"": [ { ""name"": """", ""type"": ""uint256"", ""value"": ""0"" } ], ""payable"": false, ""stateMutability"": ""view"", ""type"": ""function"" }, { ""constant"": false, ""inputs"": [ { ""name"": ""_from"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" } ], ""name"": ""burnFrom"", ""outputs"": [ { ""name"": ""success"", ""type"": ""bool"" } ], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""symbol"", ""outputs"": [ { ""name"": """", ""type"": ""string"", ""value"": ""NC"" } ], ""payable"": false, ""stateMutability"": ""view"", ""type"": ""function"" }, { ""constant"": false, ""inputs"": [ { ""name"": ""_to"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" } ], ""name"": ""transfer"", ""outputs"": [], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""function"" }, { ""constant"": false, ""inputs"": [ { ""name"": ""_spender"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" }, { ""name"": ""_extraData"", ""type"": ""bytes"" } ], ""name"": ""approveAndCall"", ""outputs"": [ { ""name"": ""success"", ""type"": ""bool"" } ], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""function"" }, { ""constant"": true, ""inputs"": [ { ""name"": """", ""type"": ""address"" }, { ""name"": """", ""type"": ""address"" } ], ""name"": ""allowance"", ""outputs"": [ { ""name"": """", ""type"": ""uint256"", ""value"": ""0"" } ], ""payable"": false, ""stateMutability"": ""view"", ""type"": ""function"" }, { ""inputs"": [ { ""name"": ""initialSupply"", ""type"": ""uint256"", ""index"": 0, ""typeShort"": ""uint"", ""bits"": ""256"", ""displayName"": ""initial Supply"", ""template"": ""elements_input_uint"", ""value"": ""10000000"" }, { ""name"": ""tokenName"", ""type"": ""string"", ""index"": 1, ""typeShort"": ""string"", ""bits"": """", ""displayName"": ""token Name"", ""template"": ""elements_input_string"", ""value"": ""NearCoin"" }, { ""name"": ""tokenSymbol"", ""type"": ""string"", ""index"": 2, ""typeShort"": ""string"", ""bits"": """", ""displayName"": ""token Symbol"", ""template"": ""elements_input_string"", ""value"": ""NC"" } ], ""payable"": false, ""stateMutability"": ""nonpayable"", ""type"": ""constructor"" }, { ""anonymous"": false, ""inputs"": [ { ""indexed"": true, ""name"": ""from"", ""type"": ""address"" }, { ""indexed"": true, ""name"": ""to"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""value"", ""type"": ""uint256"" } ], ""name"": ""Transfer"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [ { ""indexed"": true, ""name"": ""from"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""value"", ""type"": ""uint256"" } ], ""name"": ""Burn"", ""type"": ""event"" } ]";
        readonly static string contractAddress = "0xB03Aa55003C1a9C235A11B244e437Cbf062fB998";   //智能合约地址

        Nethereum.Web3.Web3 web3 = new Nethereum.Web3.Web3(rpcUrl);

        Nethereum.Contracts.Contract NearCoinContract;

      

        public Form1()
        {
            InitializeComponent();


            NearCoinContract = web3.Eth.GetContract(abi, contractAddress);

            web3.TransactionManager.DefaultGas = 210000;  //设置默认消耗的gas
        }

        private async void btn_queryAmount_Click(object sender, EventArgs e)
        {
            string accountAddress = this.tb_account.Text.Trim();
            if (string.IsNullOrEmpty(accountAddress))
            {
                MessageBox.Show("不能为空");
                return;
            }

            var getBalance = NearCoinContract.GetFunction("balanceOf");  //方法名为智能合约中的方法名

            var amount = await  getBalance.CallAsync<Int64>(accountAddress);   //注意单位Gwei

            this.tb_loglist.Text = amount.ToString();
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            string acc1 = this.tb_from.Text.Trim();
            string acc2 = this.tb_to.Text.Trim();
            int amount =int.Parse(this.tb_amount.Text.Trim());
            string pwd = this.tb_pwd.Text.Trim();

            if (string.IsNullOrEmpty(acc1)|| string.IsNullOrEmpty(acc2) || amount<0 || string.IsNullOrEmpty(pwd) )
            {
                MessageBox.Show("不能为空或金额不能为0");
                return;
            }


            bool unlockAccountResult;
            try
            {
                 unlockAccountResult = await web3.Personal.UnlockAccount.SendRequestAsync(acc1, pwd, 150);
            }
            catch (Exception)
            {
                this.tb_loglist.Text = "账户解锁失败！";
                return;
            }


            if (!unlockAccountResult) 
            {
                this.tb_loglist.Text = "账户解锁失败,或密码错误!";
                return;
            }
         

            var transfer = NearCoinContract.GetFunction("transfer");
            var value = await transfer.SendTransactionAsync(acc1, acc2, Convert.ToString(amount,16)); //金额为16进制


            this.tb_loglist.Text = value.ToString();

        }
    }
}
