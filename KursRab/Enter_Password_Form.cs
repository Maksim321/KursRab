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
    public partial class Enter_Password_Form : Form
    {
        string password = "cisco";
        public Enter_Password_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_password_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == password)
            {
                Form1 main = this.Owner as Form1;
                main.Open_Admin_Panel();
                this.Close();
            }
        }
    }
}
