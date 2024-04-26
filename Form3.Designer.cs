namespace Koleso
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.initials = new System.Windows.Forms.Label();
            this.numbphone = new System.Windows.Forms.Label();
            this.SNL = new System.Windows.Forms.TextBox();
            this.PhoneNumb = new System.Windows.Forms.TextBox();
            this.cars = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.TextBox();
            this.CarNumb = new System.Windows.Forms.TextBox();
            this.numbcars = new System.Windows.Forms.Label();
            this.Region = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Label();
            this.Break = new System.Windows.Forms.TextBox();
            this.broketip = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Внесите данные:";
            // 
            // initials
            // 
            this.initials.AutoSize = true;
            this.initials.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.initials.Location = new System.Drawing.Point(32, 66);
            this.initials.Name = "initials";
            this.initials.Size = new System.Drawing.Size(50, 23);
            this.initials.TabIndex = 1;
            this.initials.Text = "ФИО:";
            // 
            // numbphone
            // 
            this.numbphone.AutoSize = true;
            this.numbphone.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.numbphone.Location = new System.Drawing.Point(32, 151);
            this.numbphone.Name = "numbphone";
            this.numbphone.Size = new System.Drawing.Size(143, 23);
            this.numbphone.TabIndex = 2;
            this.numbphone.Text = "Номер телефона:";
            // 
            // SNL
            // 
            this.SNL.Location = new System.Drawing.Point(36, 93);
            this.SNL.Name = "SNL";
            this.SNL.Size = new System.Drawing.Size(266, 26);
            this.SNL.TabIndex = 3;
            this.SNL.TextChanged += new System.EventHandler(this.SNL_TextChanged);
            // 
            // PhoneNumb
            // 
            this.PhoneNumb.Location = new System.Drawing.Point(36, 183);
            this.PhoneNumb.Name = "PhoneNumb";
            this.PhoneNumb.Size = new System.Drawing.Size(266, 26);
            this.PhoneNumb.TabIndex = 4;
            // 
            // cars
            // 
            this.cars.AutoSize = true;
            this.cars.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cars.Location = new System.Drawing.Point(31, 246);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(132, 23);
            this.cars.TabIndex = 5;
            this.cars.Text = "Марка машины:";
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(36, 278);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(266, 26);
            this.Car.TabIndex = 6;
            // 
            // CarNumb
            // 
            this.CarNumb.Location = new System.Drawing.Point(37, 377);
            this.CarNumb.Name = "CarNumb";
            this.CarNumb.Size = new System.Drawing.Size(265, 26);
            this.CarNumb.TabIndex = 8;
            this.CarNumb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // numbcars
            // 
            this.numbcars.AutoSize = true;
            this.numbcars.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.numbcars.Location = new System.Drawing.Point(32, 345);
            this.numbcars.Name = "numbcars";
            this.numbcars.Size = new System.Drawing.Size(134, 23);
            this.numbcars.TabIndex = 7;
            this.numbcars.Text = "Номер машины:";
            this.numbcars.Click += new System.EventHandler(this.label5_Click);
            // 
            // Region
            // 
            this.Region.Location = new System.Drawing.Point(37, 480);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(265, 26);
            this.Region.TabIndex = 10;
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.reg.Location = new System.Drawing.Point(32, 448);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(67, 23);
            this.reg.TabIndex = 9;
            this.reg.Text = "Регион:";
            // 
            // Break
            // 
            this.Break.Location = new System.Drawing.Point(37, 572);
            this.Break.Name = "Break";
            this.Break.Size = new System.Drawing.Size(265, 26);
            this.Break.TabIndex = 12;
            // 
            // broketip
            // 
            this.broketip.AutoSize = true;
            this.broketip.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.broketip.Location = new System.Drawing.Point(32, 540);
            this.broketip.Name = "broketip";
            this.broketip.Size = new System.Drawing.Size(119, 23);
            this.broketip.TabIndex = 11;
            this.broketip.Text = "Тип поломки:";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(386, 627);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(151, 37);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(552, 676);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Break);
            this.Controls.Add(this.broketip);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.CarNumb);
            this.Controls.Add(this.numbcars);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.cars);
            this.Controls.Add(this.PhoneNumb);
            this.Controls.Add(this.SNL);
            this.Controls.Add(this.numbphone);
            this.Controls.Add(this.initials);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Adding";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label initials;
        private System.Windows.Forms.Label numbphone;
        private System.Windows.Forms.TextBox SNL;
        private System.Windows.Forms.TextBox PhoneNumb;
        private System.Windows.Forms.Label cars;
        private System.Windows.Forms.TextBox Car;
        private System.Windows.Forms.TextBox CarNumb;
        private System.Windows.Forms.Label numbcars;
        private System.Windows.Forms.TextBox Region;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.TextBox Break;
        private System.Windows.Forms.Label broketip;
        private System.Windows.Forms.Button Save;
    }
}