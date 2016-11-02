namespace KursRab
{
    partial class Enter_Money_Form
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
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.Button();
            this.Twenty_Five_Cents = new System.Windows.Forms.Button();
            this.Fifty_Cents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.One.Location = new System.Drawing.Point(12, 12);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(120, 50);
            this.One.TabIndex = 0;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Two.Location = new System.Drawing.Point(152, 12);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(120, 50);
            this.Two.TabIndex = 1;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Five.Location = new System.Drawing.Point(12, 68);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(120, 50);
            this.Five.TabIndex = 2;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Ten
            // 
            this.Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Ten.Location = new System.Drawing.Point(152, 68);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(120, 50);
            this.Ten.TabIndex = 3;
            this.Ten.Text = "10";
            this.Ten.UseVisualStyleBackColor = true;
            this.Ten.Click += new System.EventHandler(this.Ten_Click);
            // 
            // Twenty_Five_Cents
            // 
            this.Twenty_Five_Cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Twenty_Five_Cents.Location = new System.Drawing.Point(12, 124);
            this.Twenty_Five_Cents.Name = "Twenty_Five_Cents";
            this.Twenty_Five_Cents.Size = new System.Drawing.Size(120, 50);
            this.Twenty_Five_Cents.TabIndex = 4;
            this.Twenty_Five_Cents.Text = "0,25";
            this.Twenty_Five_Cents.UseVisualStyleBackColor = true;
            this.Twenty_Five_Cents.Click += new System.EventHandler(this.Twenty_Five_Cents_Click);
            // 
            // Fifty_Cents
            // 
            this.Fifty_Cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Fifty_Cents.Location = new System.Drawing.Point(152, 124);
            this.Fifty_Cents.Name = "Fifty_Cents";
            this.Fifty_Cents.Size = new System.Drawing.Size(120, 50);
            this.Fifty_Cents.TabIndex = 5;
            this.Fifty_Cents.Text = "0,50";
            this.Fifty_Cents.UseVisualStyleBackColor = true;
            this.Fifty_Cents.Click += new System.EventHandler(this.Fifty_Cents_Click);
            // 
            // Enter_Money_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.Fifty_Cents);
            this.Controls.Add(this.Twenty_Five_Cents);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Enter_Money_Form";
            this.Text = "Ввод денег";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Ten;
        private System.Windows.Forms.Button Twenty_Five_Cents;
        private System.Windows.Forms.Button Fifty_Cents;
    }
}