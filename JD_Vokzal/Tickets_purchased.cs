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
    public partial class Tickets_purchased : Form
    {

        public Tickets_purchased()
        {
            InitializeComponent();
            
        }

        private void Show_ALL_info_in_table()
        {
            string Order = "SELECT Билеты.Код_билета, Билеты.Код_клиента, Билеты.Номер_поезда, Билеты.Номер_вагона, Билеты.Номер_места, Вагоны.Тип_вагона, Билеты.Дата FROM Билеты, Вагоны " +
                " WHERE Вагоны.Номер_типа = Билеты.Тип_вагона";

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                // Создаем объект DataAdapter
                OleDbDataAdapter adapter = new OleDbDataAdapter(Order, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                The_Passengers_grid.DataSource = ds.Tables[0];
                
            }
        }

        private void Show_ALL_info_in_table(string OrederRec)
        {
            string Order = OrederRec;

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                // Создаем объект DataAdapter
                OleDbDataAdapter adapter = new OleDbDataAdapter(Order, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                try
                {
                    adapter.Fill(ds);
                }
                catch (Exception)
                {
                    MessageBox.Show("при поиске данной категории используются только цифры");
                    goto zeroREqest;
                }
                // Отображаем данные
                The_Passengers_grid.DataSource = ds.Tables[0];
            }
            zeroREqest:;
        }



        // проверка поиска для searcj_box на смену поиска в datatimepicker
        private void Sort_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sort_box.Text != "")
            {
                string sort_category = Sort_box.SelectedItem.ToString();

                if (sort_category == "Дата")
                {
                    Point Point = new Point(921, 46);
                    Request_picker.Location = Point;
                    Chenge_passengers.Visible = false;
                    Request_picker.Visible = true;
                    Search_box.Visible = false;
                    

                }
                else if (sort_category == "Код клиента и дата")
                {
                    Point Point = new Point(921, 25);
                    Request_picker.Location = Point;
                    Chenge_passengers.Visible = true;
                    Request_picker.Visible = true;
                    Search_box.Visible = true;
                    
                }
                else
                {
                    Request_picker.Visible = false;
                    Search_box.Visible = true;
                    Chenge_passengers.Visible = true;
                }
            }
        }

        

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
        private string nomer_mesta_;
        private string type_wagona_;
        
        private void execute_pessenger_data()
        {
            string Order = String.Format("SELECT * FROM Пассажиры WHERE Код_клиента = {0} ", id_for_client);
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();

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

        private void execute_Train_data()
        {
            string Order = String.Format("SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as пункт_отправления, " +
                " Города_1.Название_города as пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) and (Рейсы.Пункт_назначения = Города_1.Код_города) AND (Рейсы.Номер_поезда = {0}) ", Id_number_train);

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        Mesto_otpravleniya_Box.Text = mesto_otpravlenya_= (reader["пункт_отправления"]).ToString();
                        Vremya_otbitya_box.Text = Vremya_otpravlenya_ = (reader["Время_отправки"]).ToString();

                        mesto_pribitya_Box.Text = mesto_pribitya_ = (reader["пункт_назначения"]).ToString();
                        Vremya_pribitiya_Box.Text = Vremya_pribitya_ = (reader["Время_прибытия"]).ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("строка отсутствует");
                }
            }
        }

        private string OrderRec;
        private bool check_for_delete;
        private void Show_Request_info_in_table(string Category, string SerchRequest, string SerchRequest_for_data_time_picker)
        {
            OrderRec = "";

            if (Search_box.Visible == true && SerchRequest == "")
            {
                MessageBox.Show("Вы не ввели значение");
                goto zeroREqest;
            }
            else if (Category == "Код клиента")
            {
                OrderRec = String.Format("SELECT Билеты.Код_билета, Билеты.Код_клиента, Билеты.Номер_поезда, Билеты.Номер_вагона, Билеты.Номер_места, Вагоны.Тип_вагона, Билеты.Дата FROM Билеты, Вагоны " +
                " WHERE (Вагоны.Номер_типа = Билеты.Тип_вагона) AND (Билеты.Код_клиента = {0} )", SerchRequest);
            }
            else if (Category == "Дата")
            {
                OrderRec = String.Format("SELECT Билеты.Код_билета, Билеты.Код_клиента, Билеты.Номер_поезда, Билеты.Номер_вагона, Билеты.Номер_места, Вагоны.Тип_вагона, Билеты.Дата FROM Билеты, Вагоны " +
                " WHERE (Вагоны.Номер_типа = Билеты.Тип_вагона) AND (Билеты.Дата = '{0}' )", SerchRequest_for_data_time_picker);
            }
            else if (Category == "Код клиента и дата")
            {
                OrderRec = String.Format("SELECT Билеты.Код_билета, Билеты.Код_клиента, Билеты.Номер_поезда, Билеты.Номер_вагона, Билеты.Номер_места, Вагоны.Тип_вагона, Билеты.Дата FROM Билеты, Вагоны " +
                " WHERE (Вагоны.Номер_типа = Билеты.Тип_вагона) AND (Билеты.Код_клиента = {0} AND (Билеты.Дата = '{1}' ))", SerchRequest, SerchRequest_for_data_time_picker);
            }
            else
            {
                MessageBox.Show("Выберите категорию для сортировки");
                goto zeroREqest;
            }

            check_for_delete = true;
            Show_ALL_info_in_table(OrderRec);

        zeroREqest:;
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

        private void end_opiraciy(string Msg)
        {
            if (Id_for_ != "")
            {
                int totalRowsCount = The_Passengers_grid.Rows.Count;
                int currentIndex = The_Passengers_grid.CurrentCell.RowIndex;

                if (check_for_delete == false)
                {
                    Show_ALL_info_in_table();
                }
                else
                {
                    Show_ALL_info_in_table(OrderRec);
                }


                if (currentIndex < (totalRowsCount - totalRowsCount))
                {
                    currentIndex++;
                    The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
                }
                
            }
            else
            {
                MessageBox.Show(Msg);
            }
        }

        private void chenge_ID()
        {
            int totalRowsCount = The_Passengers_grid.Rows.Count;
            int currentIndex = The_Passengers_grid.CurrentCell.RowIndex;

            int index;
            try
            {
               index = Convert.ToInt32(now_id_box.Text);
                if (index <= totalRowsCount && index >= (totalRowsCount - totalRowsCount))
                {
                    The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[index].Cells[0];
                }
                else
                {
                    MessageBox.Show("вы ввели индекс за границами диапозона");
                    The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
                    now_id_box.Text = currentIndex.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("в данном поле можно вводить только числа");
                The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
            }
            
        }


        private string Id_for_;
        private string id_for_client;
        private string Id_number_train;


        private void The_Passengers_grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (The_Passengers_grid.CurrentCell == null)
            {
                return;
            }
            DataGridViewCellCollection cells = The_Passengers_grid.CurrentCell.OwningRow.Cells;

            object[] cellDatas = new object[cells.Count];

            //string af = "";
            for (int i = 0; i < cells.Count; i++)
            {
                cellDatas[i] = cells[i].Value;
               // af = af + " " + cellDatas[i];
            }

            Id_for_ = cellDatas[0].ToString();
            id_for_client = cellDatas[1].ToString();
            Number_train_Box.Text = nomer_poezda_ = Id_number_train = cellDatas[2].ToString();

            
            Number_wagons_Box.Text = nomer_wagona_ = cellDatas[3].ToString();
            Number_place_Box.Text = nomer_mesta_ = cellDatas[4].ToString();
            Type_wagons_Box.Text = type_wagona_ = cellDatas[5].ToString();
            Data_otpravleniya_Box.Text = Data_Otpravlenya_ = cellDatas[6].ToString();


            now_id_box.Text = The_Passengers_grid.CurrentCell.RowIndex.ToString();

            execute_pessenger_data();
            execute_Train_data();



            //if (Panel_with_update.Enabled != false)
            //{
            //    Familya_box1.Text = cellDatas[1].ToString();
            //    Name_box1.Text = cellDatas[2].ToString();
            //    Otchestvo_box1.Text = cellDatas[3].ToString();
            //    Seryia_Box1.Text = cellDatas[4].ToString();
            //    Number_Box1.Text = cellDatas[5].ToString();
            //    Data_vidachi_Picker1.Text = cellDatas[6].ToString();
            //    Kem_vidan_Box1.Text = cellDatas[7].ToString();
            //}

            ///////////////////////////

            //for (int i = 0; i < cellDatas.Length; i++)
            //{
            //    af = af + " " + cellDatas[i];
            //}
            //Console.WriteLine(cellDatas[0]);
            //Console.WriteLine(af);
        }



        private void The_passengers_Load(object sender, EventArgs e)
        {
            check_for_delete = false;
            Show_ALL_info_in_table();
        }

        // btn следующая позиция грида
        private void next_pos_grid_MouseEnter(object sender, EventArgs e) { next_pos_grid.BackgroundImage = Properties.Resources.Вниз2; }
        private void next_pos_grid_MouseLeave(object sender, EventArgs e) { next_pos_grid.BackgroundImage = Properties.Resources.Вниз1; }
        private void next_pos_grid_MouseDown(object sender, MouseEventArgs e) { next_pos_grid.BackgroundImage = Properties.Resources.Вниз3; }
        private void next_pos_grid_MouseUp(object sender, MouseEventArgs e) { next_pos_grid.BackgroundImage = Properties.Resources.Вниз2; }
        private void next_pos_grid_Enter(object sender, EventArgs e) { next_pos_grid.BackgroundImage = Properties.Resources.Вниз2; }
        private void next_pos_grid_Leave(object sender, EventArgs e) { next_pos_grid.BackgroundImage = Properties.Resources.Вниз1; }
        private void next_pos_grid_Click(object sender, EventArgs e)
        {
            next_pos_grid.BackgroundImage = Properties.Resources.Вниз3;
            ////--------------------------------------------------------
            int totalRowsCount = The_Passengers_grid.Rows.Count;
            int currentIndex = The_Passengers_grid.CurrentCell.RowIndex;

            currentIndex = (currentIndex + 1) % totalRowsCount;

            The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
            ////--------------------------------------------------------
            next_pos_grid.BackgroundImage = Properties.Resources.Вниз2;
        }
        
        // btn предыдущяя позиция грида
        private void Prev_pos_grid_MouseEnter(object sender, EventArgs e) { Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх2; }
        private void Prev_pos_grid_MouseLeave(object sender, EventArgs e) { Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх1; }
        private void Prev_pos_grid_MouseDown(object sender, MouseEventArgs e) { Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх3; }
        private void Prev_pos_grid_MouseUp(object sender, MouseEventArgs e) { Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх2; }
        private void Prev_pos_grid_Enter(object sender, EventArgs e) { Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх2; }
        private void Prev_pos_grid_Leave(object sender, EventArgs e) { Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх1; }
        private void Prev_pos_grid_Click(object sender, EventArgs e)
        {
            Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх3;
            ////--------------------------------------------------------------------------
            int totalRowsCount = The_Passengers_grid.Rows.Count;
            int currentIndex = The_Passengers_grid.CurrentCell.RowIndex;

            currentIndex--;
            if(currentIndex < 0)
            {
                currentIndex = totalRowsCount - 1;
            }

            The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
            ////--------------------------------------------------------------------------
            Prev_pos_grid.BackgroundImage = Properties.Resources.Вверх2;
        }



        //bool dup = false;
        //Нажатие enter в поиске
        private void Search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Search_Click(sender, e);
            }
            //Show_Request_info_in_table(Sort_box.Text, Search_box.Text);
        }
        //Нажатие enter в поиске id
        private void now_id_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chenge_ID();
                BTN_Search.BackgroundImage = Properties.Resources.Поиск1;
            }
        }



        //btn поиск
        private void BTN_Search_MouseEnter(object sender, EventArgs e) { BTN_Search.BackgroundImage = Properties.Resources.Поиск2; }
        private void BTN_Search_MouseLeave(object sender, EventArgs e) { BTN_Search.BackgroundImage = Properties.Resources.Поиск1; }
        private void BTN_Search_MouseDown(object sender, MouseEventArgs e) { BTN_Search.BackgroundImage = Properties.Resources.Поиск3; }
        private void BTN_Search_MouseUp(object sender, MouseEventArgs e) { BTN_Search.BackgroundImage = Properties.Resources.Поиск2; }
        private void BTN_Search_Enter(object sender, EventArgs e) { BTN_Search.BackgroundImage = Properties.Resources.Поиск2; }
        private void BTN_Search_Leave(object sender, EventArgs e) { BTN_Search.BackgroundImage = Properties.Resources.Поиск1; }
        private void BTN_Search_Click(object sender, EventArgs e)
        {
            BTN_Search.BackgroundImage = Properties.Resources.Поиск3;
            ////------------------------------------------------------
            Show_Request_info_in_table(Sort_box.Text, Search_box.Text, Request_picker.Text);

            ////------------------------------------------------------
            BTN_Search.BackgroundImage = Properties.Resources.Поиск2;
            Console.WriteLine(Sort_box.Text);
        }

        // btn назад
        private void BTN_back_now_MouseEnter(object sender, EventArgs e) { BTN_back_now.BackgroundImage = Properties.Resources.Назад2; }
        private void BTN_back_now_MouseLeave(object sender, EventArgs e) { BTN_back_now.BackgroundImage = Properties.Resources.Назад1; }
        private void BTN_back_now_MouseDown(object sender, MouseEventArgs e) { BTN_back_now.BackgroundImage = Properties.Resources.Назад3; }
        private void BTN_back_now_MouseUp(object sender, MouseEventArgs e) { BTN_back_now.BackgroundImage = Properties.Resources.Назад2; }
        private void BTN_back_now_Enter(object sender, EventArgs e) { BTN_back_now.BackgroundImage = Properties.Resources.Назад2; }
        private void BTN_back_now_Leave(object sender, EventArgs e) { BTN_back_now.BackgroundImage = Properties.Resources.Назад1; }
        private void BTN_back_now_Click(object sender, EventArgs e)
        {
            BTN_back_now.BackgroundImage = Properties.Resources.Назад3;
            ////---------------------------------------------------------------------
            
            Show_ALL_info_in_table();
            check_for_delete = false;
            
            ////----------------------------------------------------------------------
            BTN_back_now.BackgroundImage = Properties.Resources.Назад2;
        }

        // btn первая строка
        private void First_row_MouseEnter(object sender, EventArgs e) { First_row.BackgroundImage = Properties.Resources.ПерваяСтрока2; }
        private void First_row_MouseLeave(object sender, EventArgs e) { First_row.BackgroundImage = Properties.Resources.ПерваяСтрока1; }
        private void First_row_MouseDown(object sender, MouseEventArgs e) { First_row.BackgroundImage = Properties.Resources.ПерваяСтрока3; }
        private void First_row_MouseUp(object sender, MouseEventArgs e) { First_row.BackgroundImage = Properties.Resources.ПерваяСтрока2; }
        private void First_row_Enter(object sender, EventArgs e) { First_row.BackgroundImage = Properties.Resources.ПерваяСтрока2; }
        private void First_row_Leave(object sender, EventArgs e) { First_row.BackgroundImage = Properties.Resources.ПерваяСтрока1; }
        private void First_row_Click(object sender, EventArgs e)
        {
            First_row.BackgroundImage = Properties.Resources.ПерваяСтрока3;
            //--------------------------------------------------------------------------
            int totalRowsCount = The_Passengers_grid.Rows.Count;
            int currentIndex = The_Passengers_grid.CurrentCell.RowIndex;

            currentIndex = (totalRowsCount - totalRowsCount);
            
            The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
            //--------------------------------------------------------------------------
            First_row.BackgroundImage = Properties.Resources.ПерваяСтрока2;
        }

        // btn последняя строка
        private void BTN_last_row_MouseEnter(object sender, EventArgs e) { BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока2; }
        private void BTN_last_row_MouseLeave(object sender, EventArgs e) { BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока1; }
        private void BTN_last_row_MouseDown(object sender, MouseEventArgs e) { BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока3; }
        private void BTN_last_row_MouseUp(object sender, MouseEventArgs e) { BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока2; }
        private void BTN_last_row_Enter(object sender, EventArgs e) { BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока2; }
        private void BTN_last_row_Leave(object sender, EventArgs e) { BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока1; }
        private void BTN_last_row_Click(object sender, EventArgs e)
        {
            BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока3;
            //--------------------------------------------------------------------------
            int totalRowsCount = The_Passengers_grid.Rows.Count;
            int currentIndex = The_Passengers_grid.CurrentCell.RowIndex;

            currentIndex = totalRowsCount - 2;
            
            The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
            //-------------------------------------------------------------------------- 
            BTN_last_row.BackgroundImage = Properties.Resources.ЛастСтрока2;
        }
        

        // btn Удаления Записи
        private void BTN_delete_MouseEnter(object sender, EventArgs e) { BTN_delete.BackgroundImage = Properties.Resources.Удаление2; }
        private void BTN_delete_MouseLeave(object sender, EventArgs e) { BTN_delete.BackgroundImage = Properties.Resources.Удаление1; }
        private void BTN_delete_MouseDown(object sender, MouseEventArgs e) { BTN_delete.BackgroundImage = Properties.Resources.Удаление3; }
        private void BTN_delete_MouseUp(object sender, MouseEventArgs e) { BTN_delete.BackgroundImage = Properties.Resources.Удаление2; }
        private void BTN_delete_Enter(object sender, EventArgs e) { BTN_delete.BackgroundImage = Properties.Resources.Удаление2; }
        private void BTN_delete_Leave(object sender, EventArgs e) { BTN_delete.BackgroundImage = Properties.Resources.Удаление1; }
        private void BTN_delete_Click(object sender, EventArgs e)
        {
            BTN_delete.BackgroundImage = Properties.Resources.Удаление3;
            //-------------------------------------------------------------------------------------------
            string Order = $"DELETE FROM Билеты WHERE Код_билета = {Id_for_}";
            
            if (Id_for_ != "")
            {
                using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                    command.ExecuteNonQuery();
                    //Console.WriteLine($"удален обьект №{Id_for_}");

                }

                int totalRowsCount = The_Passengers_grid.Rows.Count;
                int currentIndex = The_Passengers_grid.CurrentCell.RowIndex -1;

                if (check_for_delete == false)
                {
                    Show_ALL_info_in_table();
                }
                else
                {
                    Show_ALL_info_in_table(OrderRec);
                }
                

                if (currentIndex < (totalRowsCount - totalRowsCount))
                {
                    currentIndex++;
                    The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    The_Passengers_grid.CurrentCell = The_Passengers_grid.Rows[currentIndex].Cells[0];
                }

            }
            else
            {
                MessageBox.Show("Невозможно удалить данную строку");
            }
            
            
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                Order = String.Format("UPDATE Составы SET Место_{0} = 0  " +
                "WHERE (Номер_поезда = {1}) AND (Номер_вагона = {2}) AND (Дата = '{3}')",
                nomer_mesta_, Convert.ToInt32(nomer_poezda_), Convert.ToInt32(nomer_wagona_), Data_Otpravlenya_);

                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                command.ExecuteNonQuery();
                //Console.WriteLine($"удален обьект №{Id_for_}");

            }

            //---------------------------------------------------------------------------------------------
            BTN_delete.BackgroundImage = Properties.Resources.Удаление2;
        }

        // текст для печати
        private string result = "";

        private void BTN_add_in_table_MouseEnter(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Повторнаяпечать2; }
        private void BTN_add_in_table_MouseLeave(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Повторнаяпечать1; }
        private void BTN_add_in_table_MouseDown(object sender, MouseEventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Повторнаяпечать3; }
        private void BTN_add_in_table_MouseUp(object sender, MouseEventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Повторнаяпечать2; }
        private void BTN_add_in_table_Enter(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Повторнаяпечать2; }
        private void BTN_add_in_table_Leave(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.Повторнаяпечать1; }
        // обработчик события нажатия на кнопку Печать
        private void BTN_add_in_table_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result =  "Экспресс\t\t";
            result += $"Билет\n\n";
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
        }

        // обработчик события печати1
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen,100, 50, 450, 360);
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

        


        // кнопка поиска по id клиента
        private int number_selected_IdClient;

        private void Chenge_passengers_MouseEnter(object sender, EventArgs e) { Chenge_passengers.BackgroundImage = Properties.Resources.ВыбоВпоиске2; }
        private void Chenge_passengers_MouseLeave(object sender, EventArgs e) { Chenge_passengers.BackgroundImage = Properties.Resources.ВыбоВпоиске1; }
        private void Chenge_passengers_MouseDown(object sender, MouseEventArgs e) { Chenge_passengers.BackgroundImage = Properties.Resources.ВыбоВпоиске3; }
        private void Chenge_passengers_MouseUp(object sender, MouseEventArgs e) { Chenge_passengers.BackgroundImage = Properties.Resources.ВыбоВпоиске2; }
        private void Chenge_passengers_Enter(object sender, EventArgs e) { Chenge_passengers.BackgroundImage = Properties.Resources.ВыбоВпоиске2; }
        private void Chenge_passengers_Leave(object sender, EventArgs e) { Chenge_passengers.BackgroundImage = Properties.Resources.ВыбоВпоиске1; }
        private void Chenge_passengers_Click(object sender, EventArgs e)
        {
            The_passengers The_passengers = new The_passengers();
            The_passengers.add_in_other_forms_Btn_visible = true;
            The_passengers.ShowDialog();

            if (The_passengers.change_check == true)
            {
                number_selected_IdClient = Convert.ToInt32(The_passengers.Id_for_);
                Search_box.Text = The_passengers.Id_for_.ToString();
            }
        }

        
    }
}
