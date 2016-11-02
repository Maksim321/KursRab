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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            money_scoreboard.Text = Convert.ToString(getAutomatInfo.Money.CashBox);
            for (int i = 1; i <= 5;i++)
                Сhange_Color_Button(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buy_Button(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Buy_Button(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Buy_Button(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Buy_Button(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Buy_Button(5);
        }
        public void Buy_Button(int index)
        {
            if (getAutomatInfo.Automat[index].index == index)
            {
                Сhange_Color_Button(index);
                show_result(buy(index));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Enter_Money_Form a = new Enter_Money_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }

        private void Return_Money_Button_Click(object sender, EventArgs e)
        {
            if (getAutomatInfo.Money.CashBox > 0)
            {
                getUserInfo.Money_User += getAutomatInfo.Money.Return_Money();
                money_scoreboard.Text = Convert.ToString(getAutomatInfo.Money.CashBox);
                show_status.Text = "Деньги возввращены";
            }
        }

        public void Сhange_Color_Button(int index)
        {
            switch (index)
            {
                case 1:
                    if (getAutomatInfo.Automat[index].Index == 1)
                        if (getAutomatInfo.Automat[index].number > 0)
                            this.button1.BackColor = System.Drawing.Color.Green;
                        else this.button1.BackColor = System.Drawing.Color.Red;
                    else
                        this.button1.BackColor = System.Drawing.Color.Silver;
                    break;
                case 2:
                    if (getAutomatInfo.Automat[index].Index == 2)
                        if (getAutomatInfo.Automat[index].number > 0)
                            this.button2.BackColor = System.Drawing.Color.Green;
                        else this.button2.BackColor = System.Drawing.Color.Red;
                    else
                        this.button2.BackColor = System.Drawing.Color.Silver;
                    break;
                case 3:
                    if (getAutomatInfo.Automat[index].Index == 3)
                        if (getAutomatInfo.Automat[index].number > 0)
                            this.button3.BackColor = System.Drawing.Color.Green;
                        else this.button3.BackColor = System.Drawing.Color.Red;
                    else
                        this.button3.BackColor = System.Drawing.Color.Silver;
                    break;
                case 4:
                    if (getAutomatInfo.Automat[index].Index == 4)
                        if (getAutomatInfo.Automat[index].number > 0)
                            this.button4.BackColor = System.Drawing.Color.Green;
                        else this.button4.BackColor = System.Drawing.Color.Red;
                    else
                        this.button4.BackColor = System.Drawing.Color.Silver;
                    break;
                case 5:
                    if (getAutomatInfo.Automat[index].Index == 5)
                        if (getAutomatInfo.Automat[index].number > 0)
                            this.button5.BackColor = System.Drawing.Color.Green;
                        else this.button5.BackColor = System.Drawing.Color.Red;
                    else
                        this.button5.BackColor = System.Drawing.Color.Silver;
                    break;
            }
        }

        private int buy(int index)
        {
            if (getAutomatInfo.Automat[index].Number > 0)
            {
                if (getAutomatInfo.Money.Price_CashBox_Difference(getAutomatInfo.Automat[index].Price) >= 0)
                {
                    double retMon = getAutomatInfo.Money.Return_Remaining_Money(getAutomatInfo.Automat[index].Price);
                    if (retMon >= 0)
                    {
                        getUserInfo.Money_User += retMon;
                        getAutomatInfo.Money.AutomatMoneyBox += getAutomatInfo.Money.Return_Money();
                        getAutomatInfo.Automat[index].number--;
                        getAutomatInfo.ProductInBox.addProduct(getAutomatInfo.Automat[index].DeepCopy());
                        money_scoreboard.Text = Convert.ToString(getAutomatInfo.Money.CashBox);
                        Сhange_Color_Button(index);
                        return 1;
                    }
                    else return 3;
                }
                else return 2;
            }
            else return -1;
        }

        private void show_result(int res)
        {
            switch (res)
            {
                case 1:
                    show_status.Text = Convert.ToString("Покупка прошла успешно!");
                    break;
                case 2:
                    show_status.Text = Convert.ToString("Для покупки недостаточно средств!");
                    break;
                case 3:
                    show_status.Text = Convert.ToString("В автмате не достаточно средств, введите другую сумму!");
                    break;
                case -1:
                    show_status.Text = Convert.ToString("Выбранного товара нет в наличии!");
                    break;
            }

        }

        private void Admin_Panel_Button_Click(object sender, EventArgs e)
        {
            Enter_Password_Form a = new Enter_Password_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }

        public void Open_Admin_Panel()
        {
            Admin_Panel_Form a = new Admin_Panel_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }

        private void Give_Product_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < getAutomatInfo.ProductInBox.products.Count; i++)
                getUserInfo.User.addProduct(getAutomatInfo.ProductInBox.Return_Product(i));
            getAutomatInfo.ProductInBox.products.Clear();
        }

        public TextBox Return_Show_Nam_Prod_TextBox(int index)
        {
            switch (index)
            {
                case 1:
                    return Show_Nam_Prod_One;
                case 2:
                    return Show_Nam_Prod_Two;
                case 3:
                    return Show_Nam_Prod_Three;
                case 4:
                    return Show_Nam_Prod_Four;
                case 5:
                    return Show_Nam_Prod_Five;
                default:
                    return new TextBox();
            }
        }

        public TextBox Return_Show_Price_Prod_TextBox(int index)
        {
            switch (index)
            {
                case 1:
                    return Show_Price_Prod_One;
                case 2:
                    return Show_Price_Prod_Two;
                case 3:
                    return Show_Price_Prod_Three;
                case 4:
                    return Show_Price_Prod_Four;
                case 5:
                    return Show_Price_Prod_Five;
                default:
                    return new TextBox();
            }
        }

        private void User_Form_Open_Button_Click(object sender, EventArgs e)
        {
            User_Form a = new User_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }
    }
}
