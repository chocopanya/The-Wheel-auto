using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace Koleso
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
            //var connection = new SqliteConnection("Data Source=Колесо.db");
            //connection.Open();
            //using (var connection = new SqliteConnection("Data Source=Колесо.db"))
            //{
            //    connection.Open();
            //}

        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            if (SNL.Text != "" && PhoneNumb.Text != "")
            {

                string FullName = SNL.Text;
                string NumbPhone = PhoneNumb.Text;
                string BrendCar = Car.Text;
                string NumbCar = CarNumb.Text;
                string RegionCar = Region.Text;
                string TypeBreak = Break.Text;


                using (var connection = new SqliteConnection($"Data Source=Колесо.db;Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();
                    string sqlExpression = "INSERT INTO clients (SNL, PhoneNumb, Car, CarNumb, Region, Break) VALUES (@FullName, @NumbPhone, @BrendCar, @NumbCar, @RegionCar, @TypeBreak)";
                    using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                    {
                        // Добавьте параметры
                        command.Parameters.AddWithValue("@FullName", SNL.Text);
                        command.Parameters.AddWithValue("@NumbPhone", PhoneNumb.Text);
                        command.Parameters.AddWithValue("@BrendCar", Car.Text);
                        command.Parameters.AddWithValue("@NumbCar", CarNumb.Text);
                        command.Parameters.AddWithValue("@RegionCar", Region.Text);
                        command.Parameters.AddWithValue("@TypeBreak", Break.Text);
                        
                        // Выполните запрос
                        command.ExecuteNonQuery();
                    }
                    //string sqlExpression = "SELECT * FROM clients";
                    //SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                    //using (SqliteDataReader reader = command.ExecuteReader())
                    //{
                    //    if (reader.HasRows) // если есть данные
                    //    {
                    //        while (reader.Read())   // построчно считываем данные
                    //        {
                    //        }
                    //    }
                    //}
                }
                MessageBox.Show("Пользователь добавлен", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                SNL.Text = null;
                PhoneNumb.Text = null;
                Car.Text = null;
                CarNumb.Text = null;
                Region.Text = null;
                Break.Text = null;
            }
        }
        private void SNL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
