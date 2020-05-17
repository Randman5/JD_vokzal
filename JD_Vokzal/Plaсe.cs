using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace JD_Vokzal
{
    public partial class Place_form : Form
    {
        public Place_form()
        {
            InitializeComponent();
        }


        private bool[] plaselist = new bool[66];
        

        private void execute_plase()
        {

            //////////////////////////////////////////////////////
            /////////////////////////////////////////////////////
            ///

            int countFreePlase=0;
            int IDPlaseFromWagons=0;
            int countPlaseFromWagons=0;

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {

                try
                {
                    string Order = String.Format("SELECT * FROM Составы WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'"
                            , Convert.ToInt32(nomer_poezda_), Convert.ToInt32(nomer_wagona_), Data_Otpravlenya_);

                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < 66; i++)
                        {

                            IDPlaseFromWagons = Convert.ToInt32(reader["Тип_вагона"]);
                        }
                    }

                    //MessageBox.Show(countFreePlase.ToString());
                }
                catch (Exception)
                {
                    //MessageBox.Show(number_selected_city_start1 + " " + number_selected_city_end1);
                }
            }

            ///////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////
            ///
            string Order1 = String.Format("SELECT * FROM Вагоны WHERE Номер_типа = {0} "
                , Convert.ToInt32(IDPlaseFromWagons));

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order1, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        countPlaseFromWagons = Convert.ToInt32(reader["Кол_во_мест"]);

                    }
                    //MessageBox.Show(countFreePlase.ToString());
                }
                catch (Exception)
                {
                    //MessageBox.Show(number_selected_city_start1 + " " + number_selected_city_end1);
                }
            }

            //////////////////////////////////////////////////////
            /////////////////////////////////////////////////////
            countFreePlase = 0;
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {

                try
                {
                    string Order = String.Format("SELECT * FROM Составы WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'"
                                , Convert.ToInt32(nomer_poezda_), Convert.ToInt32(nomer_wagona_), Data_Otpravlenya_);
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < countPlaseFromWagons; i++)
                        {
                            place[i] = Convert.ToBoolean(reader[$"Место_{i + 1}"]);
                            if (Convert.ToBoolean(reader[$"Место_{i + 1}"]) == false)
                            {
                                countFreePlase++;
                            }
                            IDPlaseFromWagons = Convert.ToInt32(reader["Тип_вагона"]);
                        }
                    }

                    //MessageBox.Show(countFreePlase.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("eeeeerr");
                }
            }



            //label2.Text = countFreePlase.ToString();
            //label4.Text = countPlaseFromWagons.ToString();
        }




        bool[] place;
        int maxplace;

        private string Client_kod;
        private string Familya_;
        private string Imya_;
        private string Otchestvo_;
        private string Seria_;
        private string nomer_;
        private string Data_Otpravlenya_;
        private string mesto_otpravlenya_;
        private string Vremya_otpravlenya_;
        private string mesto_pribitya_;
        private string Vremya_pribitya_;
        private string nomer_poezda_;
        private string nomer_wagona_;
        private string nomer_wagona_kod_tipa;
        private string nomer_mesta_;
        private string type_wagona_;


        public void set_mas_data_train( object[] mas_param_train)
        {
            Number_train_Box.Text = nomer_poezda_  = mas_param_train[0].ToString();
            Number_wagons_Box.Text = nomer_wagona_  = mas_param_train[1].ToString();
            Type_wagons_Box.Text = type_wagona_ = mas_param_train[2].ToString();
            Data_otpravleniya_Box.Text = Data_Otpravlenya_ = mas_param_train[3].ToString();
        }


        private void execute_Train_data_Number_Wagon()
        {
            try
            {
                string Order = String.Format("SELECT  * FROM Составы" +
                " WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'",
                 Convert.ToInt32(nomer_poezda_), Convert.ToInt32(nomer_wagona_), Data_Otpravlenya_);

                using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                    try
                    {
                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            nomer_wagona_kod_tipa = (reader["Тип_вагона"]).ToString();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Eror");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Это пустая запись");
            }
            
        }

        private void execute_Train_data()
        {
            string Order = String.Format("SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as пункт_отправления, " +
                " Города_1.Название_города as пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) and (Рейсы.Пункт_назначения = Города_1.Код_города) AND (Рейсы.Номер_поезда = {0}) ", nomer_poezda_);

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        Mesto_otpravleniya_Box.Text = mesto_otpravlenya_ = (reader["пункт_отправления"]).ToString();
                        Vremya_otbitya_box.Text = Vremya_otpravlenya_ = (reader["Время_отправки"]).ToString();

                        mesto_pribitya_Box.Text = mesto_pribitya_ = (reader["пункт_назначения"]).ToString();
                        Vremya_pribitiya_Box.Text = Vremya_pribitya_ = (reader["Время_прибытия"]).ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Eror");
                }
            }
        }

        private void execute_pessenger_data()
        {
            string Order = String.Format("SELECT * FROM Пассажиры WHERE Код_клиента = {0} ", ID_for_client);
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    Client_kod = ID_for_client.ToString();
                    while (reader.Read())
                    {
                        Familya_box.Text = Familya_ = (reader["Фамилия"]).ToString();
                        Name_box.Text = Imya_ = (reader["Имя"]).ToString();
                        Otchestvo_box.Text = Otchestvo_ = (reader["Отчество"]).ToString();
                        Seryia_Box.Text = Seria_ = (reader["Серия"]).ToString();
                        Number_Box.Text = nomer_ = (reader["Номер"]).ToString();
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("");
                }
            }
        }

        public void takeMassivePlase(bool[] place1)
        {
            this.place = place1;
        }
        public void takemaxplace(int maxplace1)
        {
            this.maxplace = maxplace1;
        }

        private void loadbtn(bool[] place, int maxcountmas)
        {
            int d = 1;
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < maxplace; i++)
            {
                Button newButton = new Button();
                newButton.Text = d.ToString();
                newButton.Visible = true;
                if (place[i] == false)
                {
                    newButton.Enabled = true;
                }
                else
                {
                    newButton.Enabled = false;
                }
                newButton.Click += new EventHandler(button1_Click);
                flowLayoutPanel1.Controls.Add(newButton);
                buttons.Add(newButton);
                d++;
            }
        }

        private void Plase_Load(object sender, EventArgs e)
        {
            loadbtn(place, maxplace);
            execute_Train_data();
            execute_Train_data_Number_Wagon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Вы выбрали место: "+(sender as Button).Text);
            Number_place_Box.Text = nomer_mesta_ = (sender as Button).Text;
        }

        

        // выбор пассажира для регистации
        private int ID_for_client;

        private void button1_MouseEnter(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыборПассажира2; }
        private void button1_MouseLeave(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыборПассажира1; }
        private void button1_MouseDown(object sender, MouseEventArgs e) { button1.BackgroundImage = Properties.Resources.ВыборПассажира3; }
        private void button1_MouseUp(object sender, MouseEventArgs e) { button1.BackgroundImage = Properties.Resources.ВыборПассажира2; }
        private void button1_Enter(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыборПассажира2; }
        private void button1_Leave(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыборПассажира1; }
        private void button1_Click_1(object sender, EventArgs e)
        {
            The_passengers The_passengers = new The_passengers();
            The_passengers.add_in_other_forms_Btn_visible = true;
            The_passengers.ShowDialog();

            if (The_passengers.change_check == true)
            {
                ID_for_client = Convert.ToInt32(The_passengers.Id_for_);
                Client_id_box.Text = The_passengers.Id_for_;
                execute_pessenger_data();
            }
            else
            {
                ID_for_client = 0;
            }
        }

        private string urezanie_texta(string text, int count_with_end)
        {
            if (text != "")
            {
                string text1 = text;
                int ind = text.Length - count_with_end;
                text = text.Remove(ind);

            }

            return text.ToString();
        }



        private void insert_in_table( string Order)
        {
            
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error MI1");

                }

            }
            Client_id_box.Text = ""; Familya_box.Text = ""; Name_box.Text = ""; Otchestvo_box.Text = ""; Seryia_Box.Text = ""; Number_Box.Text = "";
            
        }


        private void BTN_add_in_table_MouseEnter(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Регистрация2; }
        private void BTN_add_in_table_MouseLeave(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Регистрация1; }
        private void BTN_add_in_table_MouseDown(object sender, MouseEventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Регистрация3; }
        private void BTN_add_in_table_MouseUp(object sender, MouseEventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Регистрация2; }
        private void BTN_add_in_table_Enter(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Регистрация2; }
        private void BTN_add_in_table_Leave(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Регистрация1; }
        private void BTN_add_in_table_Click(object sender, EventArgs e)
        {
            if (ID_for_client == 0 | Familya_box.Text == "")
            {
                MessageBox.Show("вы не выбрали клиента");
                goto zerometka;
            }

            if (nomer_mesta_ == "" | Number_place_Box.Text == "")
            {
                MessageBox.Show("вы не выбрали место");
                goto zerometka;
            }
            

            try
            {

                string Order = String.Format("INSERT INTO Билеты (Код_клиента, Номер_поезда, Номер_вагона, Тип_вагона, Номер_места, Дата) " +
                "VALUES ({0}, {1}, {2}, {3}, {4}, '{5}')",
                Convert.ToInt32(Client_kod), Convert.ToInt32(nomer_poezda_), Convert.ToInt32(nomer_wagona_),
                Convert.ToInt32(nomer_wagona_kod_tipa), Convert.ToInt32(nomer_mesta_), Data_Otpravlenya_);

                insert_in_table(Order);

                string Order1 = String.Format("UPDATE Составы SET Место_{0} = 1 " +
                " WHERE Номер_поезда = {1} AND Номер_вагона = {2} AND Дата = '{3}'",
                nomer_mesta_, Convert.ToInt32(nomer_poezda_), Convert.ToInt32(nomer_wagona_), Data_Otpravlenya_);

                insert_in_table(Order1);

                flowLayoutPanel1.Controls[Convert.ToInt32(nomer_mesta_)-1].Enabled = false;
                ID_for_client = 0;
                
                Number_place_Box.Text = "";
                //////////////////////////////////////////////////////
                // задаем текст для печати
                result = "Экспресс\t\t";
                result += "Билет\n\n";
                result += $"Фамилия:\t\t{Familya_}\n";
                result += $"Имя:\t\t\t{Imya_}\n";
                result += $"Отчество:\t\t{Otchestvo_}\n";
                result += $"Серия:\t\t\t{Seria_}\n";
                result += $"номер:\t\t\t{nomer_}\n";
                result += $"дата отправления:\t\t{Data_Otpravlenya_}\n";
                result += $"Место отправления:\t{mesto_otpravlenya_}\n";
                result += $"Время отправления:\t{Vremya_otpravlenya_}\n";
                result += $"Место назначения:\t{mesto_pribitya_}\n";
                result += $"Время прибытия:\t\t{Vremya_pribitya_}\n";

                result += $"Поезд№:\t\t\t{nomer_poezda_}\n";
                result += $"Вагон№:\t\t\t{nomer_wagona_}\n";
                result += $"Место№:\t\t{nomer_mesta_}\n";
                result += $"Тип вагона:\t\t{type_wagona_}\n";

                // объект для печати
                PrintDocument printDocument = new PrintDocument();

                // обработчик события печати
                printDocument.PrintPage += PrintPageHandler;

                // диалог настройки печати
                PrintDialog printDialog = new PrintDialog();

                // установка объекта печати для его настройки
                printDialog.Document = printDocument;

                // если в диалоге было нажато ОК
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print(); // печатаем


                nomer_mesta_ = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Error ADD");
            }



        zerometka:;
        }




        // текст для печати
        private string result = "";
        

        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen, 100, 50, 450, 360);
            e.Graphics.DrawLine(pen, 100, 73, 550, 73);
            int h = 96;
            for (int i = 0; i < 14; i++)
            {
                e.Graphics.DrawLine(pen, 100, h, 550, h);
                h += 22;
            }
            e.Graphics.DrawLine(pen, 325, 50, 325, 410);
            e.Graphics.DrawString(result, new Font("Times New Roman", 14), Brushes.Black, 100, 50);
        }

        
    }
}
