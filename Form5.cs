using Microsoft.Data.Sqlite;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (Status.Text != "")
            {
                string State = Status.Text;
                string FullName = SNL.Text;
                string NumbCar = CarNumb.Text;

                using (var connection = new SqliteConnection($"Data Source=Колесо.db;Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();
                    string sqlExpression = "UPDATE clients SET Status = @State WHERE SNL like @FullName ";
                    using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                    {
                        // Добавьте параметры
                        command.Parameters.AddWithValue("@State", Status.Text);
                        command.Parameters.AddWithValue("@FullName", SNL.Text);
                        command.Parameters.AddWithValue("@NumbCar", CarNumb.Text);

                        // Выполните запрос
                        command.ExecuteNonQuery();
                    }
                 
                }
                MessageBox.Show("Изменено", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Status.Text = null;
                SNL.Text = null;
                CarNumb.Text = null;
            }
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
    }
}
