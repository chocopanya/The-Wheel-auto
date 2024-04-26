namespace Koleso
{
    partial class Form5
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
            this.initials = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarNumb = new System.Windows.Forms.TextBox();
            this.SNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initials
            // 
            this.initials.AutoSize = true;
            this.initials.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.initials.Location = new System.Drawing.Point(42, 320);
            this.initials.Name = "initials";
            this.initials.Size = new System.Drawing.Size(198, 23);
            this.initials.TabIndex = 2;
            this.initials.Text = "Введите статус ремонта:";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(45, 356);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(349, 20);
            this.Status.TabIndex = 3;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Edit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(387, 398);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(108, 36);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(41, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номеру машины:";
            // 
            // CarNumb
            // 
            this.CarNumb.Location = new System.Drawing.Point(45, 188);
            this.CarNumb.Name = "CarNumb";
            this.CarNumb.Size = new System.Drawing.Size(349, 20);
            this.CarNumb.TabIndex = 9;
            // 
            // SNL
            // 
            this.SNL.Location = new System.Drawing.Point(45, 88);
            this.SNL.Name = "SNL";
            this.SNL.Size = new System.Drawing.Size(349, 20);
            this.SNL.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск по...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(198, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "или";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(202, 239);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 35);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(507, 446);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SNL);
            this.Controls.Add(this.CarNumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.initials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form5";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initials;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarNumb;
        private System.Windows.Forms.TextBox SNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Search;
    }
}