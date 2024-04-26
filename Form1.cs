using System;
using System.Windows.Forms;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Data.Sqlite;


namespace Koleso
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            Form3 Reg = new Form3();
            Reg.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Form2 Reg = new Form2();
            Reg.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Form6 Reg = new Form6();
            Reg.ShowDialog();
        }
    }
}
