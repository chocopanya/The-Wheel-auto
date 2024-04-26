//Проект по разработке информационной системы для автомастерской "The Wheel".
//Проект включает в себя такие действия как: добавление клиента, редактирование статуса ремонта, удаление клиента, а также поиск клиента по ФИО или Номеру машины. 
//При редактировании и удалении, система запрашивает пароль и сверяет его с достоверным(при совпадении информацию можно менять/удалять).

![image](https://github.com/chocopanya/The-Wheel/assets/167647167/4492e504-58a3-4bde-a095-86a6675aa594)
//окно выбора действий (добавление клиента, редактирование данных по статусу ремонта и удаление)

![image](https://github.com/chocopanya/The-Wheel/assets/167622587/5526cd96-0b32-4db1-b204-aa044843c0f2)
//происходит запись всех данных по клиенту для внесения в базу sqlite 

![image](https://github.com/chocopanya/The-Wheel/assets/167622587/aae6deff-4f66-49da-82c8-6ee0127f6560)
//требование ввода пароля для будущей проверки достоверности

![image](https://github.com/chocopanya/The-Wheel/assets/167622587/dd535051-6618-46e6-9400-747ae36bfee4)
//окно поиска клиента по данным для редактирования статуса ремонта 

![image](https://github.com/chocopanya/The-Wheel/assets/167622587/d4d430a9-5a48-433d-83d7-a9dc8d6c0f38)
//окно поиска клиента по данным для удаления из базы


//добавление клиента в базу данных

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


//удаление клиента из базы данных

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


//поиск данных в базе

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
