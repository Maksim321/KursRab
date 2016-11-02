using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursRab
{
    public partial class Enter_Money_Form : Form
    {
        public Enter_Money_Form()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            addMoney(1);
        }
        private void Two_Click(object sender, EventArgs e)
        {
            addMoney(2);
        }
        private void Five_Click(object sender, EventArgs e)
        {
            addMoney(5);
        }
        private void Ten_Click(object sender, EventArgs e)
        {
            addMoney(10);
        }
        private void Twenty_Five_Cents_Click(object sender, EventArgs e)
        {
            addMoney(0.25);
        }
        private void Fifty_Cents_Click(object sender, EventArgs e)
        {
            addMoney(0.5);
        }

        private void addMoney(double money)
        {
            Form1 main = this.Owner as Form1;
            if(getUserInfo.Money_User>=money)
            {
                getAutomatInfo.Money.CashBox += money;
                getUserInfo.Money_User -= money;
                main.money_scoreboard.Text = Convert.ToString(getAutomatInfo.Money.CashBox);
            }
        }
    }
}
