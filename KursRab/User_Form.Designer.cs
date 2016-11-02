namespace KursRab
{
    partial class User_Form
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
            this.User_Product_Text_Box = new System.Windows.Forms.RichTextBox();
            this.User_Money_Text_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // User_Product_Text_Box
            // 
            this.User_Product_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Product_Text_Box.Location = new System.Drawing.Point(13, 110);
            this.User_Product_Text_Box.Name = "User_Product_Text_Box";
            this.User_Product_Text_Box.ReadOnly = true;
            this.User_Product_Text_Box.Size = new System.Drawing.Size(334, 236);
            this.User_Product_Text_Box.TabIndex = 0;
            this.User_Product_Text_Box.Text = "";
            // 
            // User_Money_Text_Box
            // 
            this.User_Money_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.User_Money_Text_Box.Location = new System.Drawing.Point(13, 13);
            this.User_Money_Text_Box.Multiline = true;
            this.User_Money_Text_Box.Name = "User_Money_Text_Box";
            this.User_Money_Text_Box.ReadOnly = true;
            this.User_Money_Text_Box.Size = new System.Drawing.Size(334, 90);
            this.User_Money_Text_Box.TabIndex = 1;
            this.User_Money_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(359, 358);
            this.Controls.Add(this.User_Money_Text_Box);
            this.Controls.Add(this.User_Product_Text_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "User_Form";
            this.Text = "Панель пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox User_Product_Text_Box;
        private System.Windows.Forms.TextBox User_Money_Text_Box;
    }
}