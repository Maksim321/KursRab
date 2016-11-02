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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
            for (int i = 0; i < getUserInfo.User.products.Count; i++)
                User_Product_Text_Box.Text +=  i+ ")Продукт:" + getUserInfo.User.Return_Product(i).Name +
                    "   Цена:" + getUserInfo.User.Return_Product(i).Price + Environment.NewLine;
            User_Money_Text_Box.Text = Convert.ToString(getUserInfo.Money_User);
        }
    }
}
