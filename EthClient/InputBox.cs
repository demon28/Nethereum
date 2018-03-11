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
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }
 


        public static string ShowInputBox(string Title)
        {
            InputBox inputbox = new InputBox();
            inputbox.Text = Title;
            
            inputbox.ShowDialog();

            return inputbox.tb_value.Text;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
