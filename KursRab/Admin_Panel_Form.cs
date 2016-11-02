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
    public partial class Admin_Panel_Form : Form
    {
        int number;

        public Admin_Panel_Form()
        {
            InitializeComponent();
            Money_in_Automat.Text = Convert.ToString(getAutomatInfo.Money.AutomatMoneyBox);
        }


        private void Add_New_Product_Click(object sender, EventArgs e)
        {
            Show_Text_Box.Text = "";

            if (Name_Text_Box.Text == "" || Price_Text_Box.Text == "" || Number_Text_Box.Text == "" || Num_Text_Box.Text == "")
                Show_Text_Box.Text = "Не все поля заполнены!" + Environment.NewLine;
            else
                if (Error_Num_Text_Box() == true && Error_Price_Text_Box() == true && Error_Number_Text_Box() == true)
                {
                    if (getAutomatInfo.Automat[number].Index == 0)
                    {
                        getAutomatInfo.Automat.addProduct(new СProduct(Name_Text_Box.Text, Convert.ToDouble(Price_Text_Box.Text),
                            Convert.ToInt32(Number_Text_Box.Text), Convert.ToInt32(Num_Text_Box.Text)));
                        Return_Form().Сhange_Color_Button(number);
                        Return_Form().Return_Show_Nam_Prod_TextBox(number).Text = Name_Text_Box.Text;
                        Return_Form().Return_Show_Price_Prod_TextBox(number).Text = Price_Text_Box.Text;
                        Show_Text_Box.Text = "Продукт успешно добавлен!";
                    }
                    else
                        Show_Text_Box.Text = "Ячейка с номером " + number + " занята!";
                }
        }
        public bool Error_Number_Text_Box()
        {
            try
            {
                int product_number = Convert.ToInt32(Number_Text_Box.Text);
                if (product_number > 0)
                    return true;
                else
                {
                    Show_Text_Box.Text = "Вводимые числа должны быть положительными!";
                    return false;
                }
            }
            catch (FormatException exception)
            {
                Show_Text_Box.Text = "Количество продукта введено не корректно!" + Environment.NewLine;
                return false;
            }
        }
        public bool Error_Price_Text_Box()
        {
            try
            {
                double product_price = Convert.ToDouble(Price_Text_Box.Text);
                if (product_price > 0)
                    return true;
                else
                {
                    Show_Text_Box.Text = "Вводимые числа должны быть положительными!";
                    return false;
                }
            }
            catch (FormatException exception)
            {
                Show_Text_Box.Text = "Цена продукта введена не корректно!" + Environment.NewLine;
                return false;
            }
        }
        public bool Error_Num_Text_Box()
        {
            try
            {
                number = Convert.ToInt32(Num_Text_Box.Text);
                if (number > 5 || number < 1)
                {
                    Show_Text_Box.Text = "Номер лотка введено не корректно!";
                    return false;
                }
                else
                    return true;
            }
            catch (FormatException exception)
            {
                Show_Text_Box.Text = "Номер лотка введено не корректно!";
                return false;
            }
        }

        public bool Error_Money_Text_Box()
        {
            try
            {
                double money = Convert.ToDouble(Money_Text_Box.Text);
                if (money <= 0)
                {
                    Show_Text_Box.Text = "Число для снатия средств должно быть положительное!";
                    return false;
                }
                else
                    return true;
            }
            catch (FormatException exception)
            {
                Show_Text_Box.Text = "Число для снатия средств введеноне некоректно!";
                return false;
            }
        }

        private void Delete_Product_Click(object sender, EventArgs e)
        {
            Show_Text_Box.Text = "";
            if (Error_Num_Text_Box() == true)
            {
                getAutomatInfo.Automat.Del_product(getAutomatInfo.Automat[number]);
                Return_Form().Return_Show_Nam_Prod_TextBox(number).Text = "";
                Return_Form().Return_Show_Price_Prod_TextBox(number).Text = "";
                Return_Form().Сhange_Color_Button(number);
            }

        }
        private void Return_Money_Button_Click(object sender, EventArgs e)
        {
            if (Error_Money_Text_Box() && getAutomatInfo.Money.AutomatMoneyBox >= Convert.ToDouble(Money_Text_Box.Text))
            {
                getAutomatInfo.Money.AutomatMoneyBox -=  Math.Round(Convert.ToDouble(Money_Text_Box.Text), 2);
                getUserInfo.Money_User += Math.Round(Convert.ToDouble(Money_Text_Box.Text), 2);
                Money_in_Automat.Text = Convert.ToString(getAutomatInfo.Money.AutomatMoneyBox);
                Show_Text_Box.Text = "Сумма " + Convert.ToString(Math.Round(Convert.ToDouble(Money_Text_Box.Text), 2)) + " снята успешно";
            }
        }

        private void Put_Money_Button_Click(object sender, EventArgs e)
        {
            if (Error_Money_Text_Box() && getAutomatInfo.Money.AutomatMoneyBox >= Convert.ToDouble(Money_Text_Box.Text))
            {
                //getAutomatInfo.Money.AutomatMoneyBox += Convert.ToDouble(Money_Text_Box.Text);
                getAutomatInfo.Money.AutomatMoneyBox += Math.Round(Convert.ToDouble(Money_Text_Box.Text), 2);
                Money_in_Automat.Text = Convert.ToString(getAutomatInfo.Money.AutomatMoneyBox);
                Show_Text_Box.Text = "Сумма " + Convert.ToString(Math.Round(Convert.ToDouble(Money_Text_Box.Text), 2)) + " добавлена успешно";
            }
        }
        
        private void replace_name_button_Click(object sender, EventArgs e)
        {
            if (Error_Num_Text_Box() != false && Error_Num_Text_Box() != false)
            {
                if (getAutomatInfo.Automat[number].Index != 0)
                {
                    getAutomatInfo.Automat[number].Name = Name_Text_Box.Text;
                    Return_Form().Return_Show_Nam_Prod_TextBox(number).Text = Name_Text_Box.Text;
                    Show_Text_Box.Text = "Имя товара в ячейке " + number + " успешно изменено!";
                }
                else
                    Show_Text_Box.Text = "В ячейке " + number + " товар отсутствует";
            }
        }

        private void replace_price_button_Click(object sender, EventArgs e)
        {
            if (Error_Num_Text_Box() != false && Error_Price_Text_Box() != false)
            {
                if (getAutomatInfo.Automat[number].index != 0)
                {
                    getAutomatInfo.Automat[number].Price = Convert.ToDouble(Price_Text_Box.Text);
                    Return_Form().Return_Show_Price_Prod_TextBox(number).Text = Price_Text_Box.Text;
                    Show_Text_Box.Text = "Цена товара в ячейке " + number + " успешно изменена!";
                }
                else
                    Show_Text_Box.Text = "В ячейке " + number + " товар отсутствует";
            }
        }

        private void replace_number_button_Click(object sender, EventArgs e)
        {
            if (Error_Num_Text_Box() != false && Error_Number_Text_Box() != false)
            {
                if (getAutomatInfo.Automat[number].Index != 0)
                {
                    getAutomatInfo.Automat[number].Number += Convert.ToInt32(Number_Text_Box.Text);
                    Return_Form().Сhange_Color_Button(number);
                    Show_Text_Box.Text = "Количество товара в ячейке " + number + " увеличено!";
                }
                else
                    Show_Text_Box.Text = "В ячейке " + number + " товар отсутствует";
            }
        }

        public Form1 Return_Form()
        {
            Form1 main = this.Owner as Form1;
            return main;
        }
    }
}
