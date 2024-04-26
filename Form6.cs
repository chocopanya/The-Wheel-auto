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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string psw = "87654321";
            if (psw == password.Text)
            {
                Form4 Reg = new Form4();
                Reg.ShowDialog();
            }

            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
