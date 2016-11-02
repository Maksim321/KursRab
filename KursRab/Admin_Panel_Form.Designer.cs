namespace KursRab
{
    partial class Admin_Panel_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_New_Product = new System.Windows.Forms.Button();
            this.Delete_Product = new System.Windows.Forms.Button();
            this.Show_Text_Box = new System.Windows.Forms.TextBox();
            this.Num_Text_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Price_Text_Box = new System.Windows.Forms.TextBox();
            this.Number_Text_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Money_in_Automat = new System.Windows.Forms.TextBox();
            this.Return_Money_Button = new System.Windows.Forms.Button();
            this.replace_name_button = new System.Windows.Forms.Button();
            this.replace_price_button = new System.Windows.Forms.Button();
            this.replace_number_button = new System.Windows.Forms.Button();
            this.Money_Text_Box = new System.Windows.Forms.TextBox();
            this.Put_Money_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_New_Product
            // 
            this.Add_New_Product.Location = new System.Drawing.Point(31, 148);
            this.Add_New_Product.Name = "Add_New_Product";
            this.Add_New_Product.Size = new System.Drawing.Size(187, 72);
            this.Add_New_Product.TabIndex = 0;
            this.Add_New_Product.Text = "Добавить";
            this.Add_New_Product.UseVisualStyleBackColor = true;
            this.Add_New_Product.Click += new System.EventHandler(this.Add_New_Product_Click);
            // 
            // Delete_Product
            // 
            this.Delete_Product.Location = new System.Drawing.Point(381, 104);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(251, 38);
            this.Delete_Product.TabIndex = 1;
            this.Delete_Product.Text = "Удалить продукт";
            this.Delete_Product.UseVisualStyleBackColor = true;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Show_Text_Box
            // 
            this.Show_Text_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Show_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Show_Text_Box.Location = new System.Drawing.Point(31, 12);
            this.Show_Text_Box.Multiline = true;
            this.Show_Text_Box.Name = "Show_Text_Box";
            this.Show_Text_Box.ReadOnly = true;
            this.Show_Text_Box.Size = new System.Drawing.Size(601, 86);
            this.Show_Text_Box.TabIndex = 2;
            this.Show_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Num_Text_Box
            // 
            this.Num_Text_Box.Location = new System.Drawing.Point(224, 104);
            this.Num_Text_Box.Multiline = true;
            this.Num_Text_Box.Name = "Num_Text_Box";
            this.Num_Text_Box.Size = new System.Drawing.Size(89, 22);
            this.Num_Text_Box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите номер ячейки(1-5)";
            // 
            // Name_Text_Box
            // 
            this.Name_Text_Box.Location = new System.Drawing.Point(381, 148);
            this.Name_Text_Box.Name = "Name_Text_Box";
            this.Name_Text_Box.Size = new System.Drawing.Size(251, 20);
            this.Name_Text_Box.TabIndex = 5;
            // 
            // Price_Text_Box
            // 
            this.Price_Text_Box.Location = new System.Drawing.Point(381, 174);
            this.Price_Text_Box.Name = "Price_Text_Box";
            this.Price_Text_Box.Size = new System.Drawing.Size(251, 20);
            this.Price_Text_Box.TabIndex = 6;
            // 
            // Number_Text_Box
            // 
            this.Number_Text_Box.Location = new System.Drawing.Point(381, 200);
            this.Number_Text_Box.Name = "Number_Text_Box";
            this.Number_Text_Box.Size = new System.Drawing.Size(251, 20);
            this.Number_Text_Box.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество";
            // 
            // Money_in_Automat
            // 
            this.Money_in_Automat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Money_in_Automat.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Money_in_Automat.Location = new System.Drawing.Point(381, 280);
            this.Money_in_Automat.Multiline = true;
            this.Money_in_Automat.Name = "Money_in_Automat";
            this.Money_in_Automat.ReadOnly = true;
            this.Money_in_Automat.Size = new System.Drawing.Size(251, 66);
            this.Money_in_Automat.TabIndex = 11;
            // 
            // Return_Money_Button
            // 
            this.Return_Money_Button.Location = new System.Drawing.Point(224, 335);
            this.Return_Money_Button.Name = "Return_Money_Button";
            this.Return_Money_Button.Size = new System.Drawing.Size(151, 37);
            this.Return_Money_Button.TabIndex = 12;
            this.Return_Money_Button.Text = "Забрать";
            this.Return_Money_Button.UseVisualStyleBackColor = true;
            this.Return_Money_Button.Click += new System.EventHandler(this.Return_Money_Button_Click);
            // 
            // replace_name_button
            // 
            this.replace_name_button.Location = new System.Drawing.Point(224, 148);
            this.replace_name_button.Name = "replace_name_button";
            this.replace_name_button.Size = new System.Drawing.Size(75, 23);
            this.replace_name_button.TabIndex = 13;
            this.replace_name_button.Text = "Изменить";
            this.replace_name_button.UseVisualStyleBackColor = true;
            this.replace_name_button.Click += new System.EventHandler(this.replace_name_button_Click);
            // 
            // replace_price_button
            // 
            this.replace_price_button.Location = new System.Drawing.Point(224, 174);
            this.replace_price_button.Name = "replace_price_button";
            this.replace_price_button.Size = new System.Drawing.Size(75, 23);
            this.replace_price_button.TabIndex = 14;
            this.replace_price_button.Text = "Изменить";
            this.replace_price_button.UseVisualStyleBackColor = true;
            this.replace_price_button.Click += new System.EventHandler(this.replace_price_button_Click);
            // 
            // replace_number_button
            // 
            this.replace_number_button.Location = new System.Drawing.Point(224, 200);
            this.replace_number_button.Name = "replace_number_button";
            this.replace_number_button.Size = new System.Drawing.Size(75, 23);
            this.replace_number_button.TabIndex = 15;
            this.replace_number_button.Text = "Добавить";
            this.replace_number_button.UseVisualStyleBackColor = true;
            this.replace_number_button.Click += new System.EventHandler(this.replace_number_button_Click);
            // 
            // Money_Text_Box
            // 
            this.Money_Text_Box.Location = new System.Drawing.Point(381, 352);
            this.Money_Text_Box.Name = "Money_Text_Box";
            this.Money_Text_Box.Size = new System.Drawing.Size(251, 20);
            this.Money_Text_Box.TabIndex = 16;
            // 
            // Put_Money_Button
            // 
            this.Put_Money_Button.Location = new System.Drawing.Point(224, 280);
            this.Put_Money_Button.Name = "Put_Money_Button";
            this.Put_Money_Button.Size = new System.Drawing.Size(151, 37);
            this.Put_Money_Button.TabIndex = 17;
            this.Put_Money_Button.Text = "Положить";
            this.Put_Money_Button.UseVisualStyleBackColor = true;
            this.Put_Money_Button.Click += new System.EventHandler(this.Put_Money_Button_Click);
            // 
            // Admin_Panel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(644, 389);
            this.Controls.Add(this.Put_Money_Button);
            this.Controls.Add(this.Money_Text_Box);
            this.Controls.Add(this.replace_number_button);
            this.Controls.Add(this.replace_price_button);
            this.Controls.Add(this.replace_name_button);
            this.Controls.Add(this.Return_Money_Button);
            this.Controls.Add(this.Money_in_Automat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Number_Text_Box);
            this.Controls.Add(this.Price_Text_Box);
            this.Controls.Add(this.Name_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num_Text_Box);
            this.Controls.Add(this.Show_Text_Box);
            this.Controls.Add(this.Delete_Product);
            this.Controls.Add(this.Add_New_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin_Panel_Form";
            this.Text = "Панель Администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_New_Product;
        private System.Windows.Forms.Button Delete_Product;
        private System.Windows.Forms.TextBox Show_Text_Box;
        private System.Windows.Forms.TextBox Num_Text_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Text_Box;
        private System.Windows.Forms.TextBox Price_Text_Box;
        private System.Windows.Forms.TextBox Number_Text_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Money_in_Automat;
        private System.Windows.Forms.Button Return_Money_Button;
        private System.Windows.Forms.Button replace_name_button;
        private System.Windows.Forms.Button replace_price_button;
        private System.Windows.Forms.Button replace_number_button;
        private System.Windows.Forms.TextBox Money_Text_Box;
        private System.Windows.Forms.Button Put_Money_Button;
    }
}