using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Koleso
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }               


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string FullName = SNL.Text;
            string NumbCar = CarNumb.Text;
            string sqlExpression = "SELECT * FROM clients WHERE SNL like @FullName OR CarNumb like @NumbCar";

            using (var connection = new SqliteConnection($"Data Source=Колесо.db;Cache=Default;Mode=ReadOnly;"))
            {
                connection.Open();

                using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                {
                    // Добавьте параметры
                    command.Parameters.AddWithValue("@FullName", SNL.Text);
                    command.Parameters.AddWithValue("@NumbCar", CarNumb.Text);
                    // Выполните запрос
                    command.ExecuteNonQuery();


                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())   // построчно считываем данные
                            {
                                SNL.Text = (string)reader.GetValue(0);
                                CarNumb.Text = (string)reader.GetValue(3);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ничего не найдено", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            SNL.Text = null;
                            CarNumb.Text = null;
                        }
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
                 
            string FullName = SNL.Text;
            using (var connection = new SqliteConnection($"Data Source=Колесо.db;Cache=Default;Mode=ReadWrite;"))
            {
                connection.Open();
                string sqlExpression = "DELETE FROM clients WHERE SNL like @FullName ";
                using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                {
                    // Добавьте параметры
                    command.Parameters.AddWithValue("@FullName", SNL.Text);
                    // Выполните запрос
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Запись удалена", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            SNL.Text = null;
            CarNumb.Text = null;
        }
    }
}
