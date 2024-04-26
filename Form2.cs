using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koleso
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string psw = "12345678";
            if (psw == password.Text)
            {
                Form5 Reg = new Form5();
                Reg.ShowDialog();
            }

            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
