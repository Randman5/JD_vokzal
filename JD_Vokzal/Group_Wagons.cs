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

namespace JD_Vokzal
{
    public partial class Group_Wagons : Form
    {

        public Group_Wagons()
        {
            InitializeComponent();
        }

        private void Show_ALL_info_in_table()
        {
            string Order = "SELECT  Составы.Номер_поезда, Составы.Номер_вагона, Вагоны.Тип_вагона, Составы.Дата  " +
                "FROM Составы, Вагоны WHERE Составы.Тип_вагона = Вагоны.Номер_типа  ";

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
                Group_Wagons_grid.DataSource = ds.Tables[0];
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
                Group_Wagons_grid.DataSource = ds.Tables[0];
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
                    Point Point = new Point(955, 17);
                    Size size = new Size(229, 22);
                    Request_picker.Location = Point;
                    Request_picker.Size = size;
                    Request_picker.Visible = true;
                    Search_box.Visible = false;
                    button2.Visible = false;
                }
                else if (sort_category == "По номеру рейса и дате отправки")
                {
                    Request_picker.Visible = true;

                    Point Point = new Point(1040, 17);
                    Size size = new Size(144,22);
                    Request_picker.Location = Point;
                    Request_picker.Size = size;
                    Search_box.Visible = true;
                    Search_box.ReadOnly = true;
                    button2.Visible = true;
                }
                else
                {
                    Request_picker.Visible = false;
                    Search_box.Visible = true;
                    Search_box.ReadOnly = false;
                    button2.Visible = true;
                }
            }
        }

        private string OrderRec;
        private bool check_for_delete;
        private void Show_Request_info_in_table(string Category, string SerchRequest, string SerchRequest_for_data_time_picker, int COD_Flights_for_request)
        {
            OrderRec = "";

            if (Search_box.Visible == true && SerchRequest == "")
            {
                MessageBox.Show("Вы не ввели значение");
                goto zeroREqest;
            }
            else if (Category == "Номер поезда")
            {
                OrderRec = String.Format("SELECT  Составы.Номер_поезда, Составы.Номер_вагона, Вагоны.Тип_вагона, Составы.Дата  " +
                    "FROM Составы, Вагоны WHERE Составы.Тип_вагона = Вагоны.Номер_типа AND Составы.Номер_поезда = {0} ORDER BY Составы.Номер_вагона,Составы.Номер_вагона", COD_Flights_for_request);
            }
            else if (Category == "Дата")
            {
                OrderRec = String.Format("SELECT  Составы.Номер_поезда, Составы.Номер_вагона, Вагоны.Тип_вагона, Составы.Дата  " +
                    "FROM Составы, Вагоны WHERE Составы.Тип_вагона = Вагоны.Номер_типа AND Составы.Дата = '{0}'ORDER BY Составы.Номер_вагона,Составы.Номер_вагона", SerchRequest_for_data_time_picker);
            }
            else if (Category == "По номеру рейса и дате отправки")
            {
                OrderRec = String.Format("SELECT  Составы.Номер_поезда, Составы.Номер_вагона, Вагоны.Тип_вагона, Составы.Дата  " +
                    "FROM Составы, Вагоны WHERE (Составы.Тип_вагона = Вагоны.Номер_типа) AND (Составы.Номер_поезда = {0}) AND (Составы.Дата = '{1}') ORDER BY Составы.Номер_вагона,Составы.Номер_вагона"
                    , COD_Flights_for_request, SerchRequest_for_data_time_picker);
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
                int totalRowsCount = Group_Wagons_grid.Rows.Count;
                int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex;

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
                    Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
                }
                
            }
            else
            {
                MessageBox.Show(Msg);
            }
        }

        private void chenge_ID()
        {
            int totalRowsCount = Group_Wagons_grid.Rows.Count;
            int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex;

            int index;
            try
            {
               index = Convert.ToInt32(now_id_box.Text);
                if (index <= totalRowsCount && index >= (totalRowsCount - totalRowsCount))
                {
                    Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[index].Cells[0];
                }
                else
                {
                    MessageBox.Show("вы ввели индекс за границами диапозона");
                    Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
                    now_id_box.Text = currentIndex.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("в данном поле можно вводить только числа");
                Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
            }
            
        }


        private string Id_for_;
        private string column_2;
        private string column_data;
        object[] cellDatas;

        private void The_Passengers_grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (Group_Wagons_grid.CurrentCell == null)
            {
                return;
            }
            DataGridViewCellCollection cells = Group_Wagons_grid.CurrentCell.OwningRow.Cells;

            cellDatas = new object[cells.Count];

            //string af = "";
            for (int i = 0; i < cells.Count; i++)
            {
                cellDatas[i] = cells[i].Value;
               // af = af + " " + cellDatas[i];
            }

            Id_for_ = cellDatas[0].ToString();
            column_2 = cellDatas[1].ToString();
            column_data = cellDatas[3].ToString();

            now_id_box.Text = Group_Wagons_grid.CurrentCell.RowIndex.ToString();

            if (Panel_with_update.Enabled != false)
            {
                Number_train_box1.Text = cellDatas[0].ToString();
                Number_wagon_box1.Text = cellDatas[1].ToString();
                Type_wagon_box1.Text = cellDatas[2].ToString();
                Data_Otbitiya_Picker1.Text = cellDatas[3].ToString();
            }
            execute_Train_and_wagons();

            execute_plase();
            ///////////////////////////

            //for (int i = 0; i < cellDatas.Length; i++)
            //{
            //    af = af + " " + cellDatas[i];
            //}
            //Console.WriteLine(cellDatas[0]);
            //Console.WriteLine(af);
        }

        private bool[] plaselist = new bool[66];
        private int countFreePlase;
        private int IDPlaseFromWagons;
        private int countPlaseFromWagons;

        private void execute_plase()
        {
            
            //////////////////////////////////////////////////////
            /////////////////////////////////////////////////////
            //string Order = String.Format("SELECT * FROM Составы WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'"
            //    , Convert.ToInt32(Id_for_), Convert.ToInt32(column_2),column_data);

            countFreePlase = 0;

            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                
                try
                {
                        string Order = String.Format("SELECT * FROM Составы WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'"
                                , Convert.ToInt32(Id_for_), Convert.ToInt32(column_2), column_data);

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
                                    , Convert.ToInt32(Id_for_), Convert.ToInt32(column_2), column_data);
                        connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < countPlaseFromWagons; i++)
                        {
                            plaselist[i] = Convert.ToBoolean(reader[$"Место_{i + 1}"]);
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
                    //MessageBox.Show(number_selected_city_start1 + " " + number_selected_city_end1);
                }
            }



            label2.Text = countFreePlase.ToString();
            label4.Text = countPlaseFromWagons.ToString();
        }

        private void execute_Train_and_wagons()
        {
            
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                try
                {
                        string Order = String.Format("SELECT * FROM Составы WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'"
                    , Convert.ToInt32(Id_for_), Convert.ToInt32(column_2), column_data);

                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        number_selected_train_1 = Convert.ToInt32(reader["Номер_поезда"]);
                        number_selected_type_wagon_1 = Convert.ToInt32(reader["Тип_вагона"]);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Это пустая запись");
                }
            }
        }


        private void insert_in_table
            (TextBox T1, TextBox T2, TextBox T3, DateTimePicker T4, string Order){

            bool B1 = false;
            bool B2 = false;
            bool B3 = false;
            bool B4 = false;

            string errormsg = "Вы не ввели ";

            if (T1.Text != "")
            {
                B1 = true;
            }
            else
            {
                errormsg += "Номер поезда, ";
            }

            if (T2.Text != "")
            {
                B2 = true;
            }
            else
            {
                errormsg += "Тип вагона, ";
            }

            if (T3.Text != "")
            {
                B3 = true;
            }
            else
            {
                errormsg += "Тип вагона, ";
            }

            if (T4.Text != "")
            {
                B4 = true;
            }
            else
            {
                errormsg += "Дату, ";
            }

            errormsg = urezanie_texta(errormsg, 2);
            errormsg += "!!!";

            if (B1 != true | B2 != true | B3 != true | B4 != true ){
                MessageBox.Show(errormsg);
                goto ZeroMetka;
            }
            

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

                    MessageBox.Show("Невозможная комбинация");
                    goto ZeroMetka;
                }

            }
            Number_train_box.Text = ""; Number_wagon_box.Text = ""; Type_wagon_box.Text = "";Data_Otbitiya_Picker.Text = "";
            
            ZeroMetka:;
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
            int totalRowsCount = Group_Wagons_grid.Rows.Count;
            int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex;

            currentIndex = (currentIndex + 1) % totalRowsCount;

            Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
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
            int totalRowsCount = Group_Wagons_grid.Rows.Count;
            int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex;

            currentIndex--;
            if(currentIndex < 0)
            {
                currentIndex = totalRowsCount - 1;
            }

            Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
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
            Show_Request_info_in_table(Sort_box.Text, Search_box.Text, Request_picker.Text, COD_Flights_for_request);

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
            int totalRowsCount = Group_Wagons_grid.Rows.Count;
            int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex;

            currentIndex = (totalRowsCount - totalRowsCount);
            
            Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
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
            int totalRowsCount = Group_Wagons_grid.Rows.Count;
            int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex;

            currentIndex = totalRowsCount - 2;
            
            Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
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
            string Order = string.Format("DELETE FROM Составы WHERE Номер_поезда = {0} AND Номер_вагона = {1} AND Дата = '{2}'"
                    , Convert.ToInt32(Id_for_), Convert.ToInt32(column_2), column_data);

            if (Id_for_ != "")
            {
                using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                    command.ExecuteNonQuery();
                    //Console.WriteLine($"удален обьект №{Id_for_}");

                }

                int totalRowsCount = Group_Wagons_grid.Rows.Count;
                int currentIndex = Group_Wagons_grid.CurrentCell.RowIndex -1;

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
                    Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    Group_Wagons_grid.CurrentCell = Group_Wagons_grid.Rows[currentIndex].Cells[0];
                }

            }
            else
            {
                MessageBox.Show("Невозможно удалить данную строку");
            }
            //---------------------------------------------------------------------------------------------
            BTN_delete.BackgroundImage = Properties.Resources.Удаление2;
        }

        //btn добавления
        private void BTN_add_in_table_MouseEnter(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи2; }
        private void BTN_add_in_table_MouseLeave(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи1; }
        private void BTN_add_in_table_MouseDown(object sender, MouseEventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи3; }
        private void BTN_add_in_table_MouseUp(object sender, MouseEventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи2; }
        private void BTN_add_in_table_Enter(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи2; }
        private void BTN_add_in_table_Leave(object sender, EventArgs e) { BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи1; }
        private void BTN_add_in_table_Click(object sender, EventArgs e)
        {
            BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи3;
            //-----------------------------------------------------------------------------------------------
            string Order = String.Format("INSERT INTO Составы (Номер_поезда, Номер_вагона, Тип_вагона, Дата) " +
                " VALUES ({0}, {1}, '{2}', '{3}')", number_selected_train, Number_wagon_box.Text, number_selected_type_wagon, Data_Otbitiya_Picker.Text);

            insert_in_table(Number_train_box, Number_wagon_box, Type_wagon_box, Data_Otbitiya_Picker, Order);
            Show_ALL_info_in_table();
            
            //-----------------------------------------------------------------------------------------------
            BTN_add_in_table.BackgroundImage = Properties.Resources.ДобавлениеЗаписи2;
        }

        
        private void redaktirovanie_check_for_panel_Enter(object sender, EventArgs e) { redaktirovanie_check_for_panel_MouseCaptureChanged(sender, e); }
        private void redaktirovanie_check_for_panel_MouseCaptureChanged(object sender, EventArgs e)
        {
            Dobavlenie_check_for_panel.Checked = false;
            //redaktirovanie_check_for_panel.Checked = true;

            //Panel_with_update.Enabled = true;
            Panel_with_update.Visible = true;

            //Panel_with_ADD.Enabled = false;
            Panel_with_ADD.Visible = false;
        }

        private void Dobavlenie_check_for_panel_Enter(object sender, EventArgs e) { Dobavlenie_check_for_panel_MouseCaptureChanged(sender, e); }
        private void Dobavlenie_check_for_panel_MouseCaptureChanged(object sender, EventArgs e)
        {
            redaktirovanie_check_for_panel.Checked = false;
            //Dobavlenie_check_for_panel.Checked = true;

            //Panel_with_update.Enabled = false;
            Panel_with_update.Visible = false;

            //Panel_with_ADD.Enabled = true;
            Panel_with_ADD.Visible = true;
        }

        //обновления
        private void Update_poly_MouseEnter(object sender, EventArgs e) { Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись2; }
        private void Update_poly_MouseLeave(object sender, EventArgs e) { Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись1; }
        private void Update_poly_MouseDown(object sender, MouseEventArgs e) { Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись3; }
        private void Update_poly_MouseUp(object sender, MouseEventArgs e) { Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись2; }
        private void Update_poly_Enter(object sender, EventArgs e) { Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись2; }
        private void Update_poly_Leave(object sender, EventArgs e) { Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись1; }
        private void Update_poly_Click(object sender, EventArgs e)
        {
            Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись3;
            //-------------------------------------------------------------------------
            string Order = String.Format("UPDATE Составы SET Номер_поезда = '{0}', Номер_вагона = {1}, Тип_вагона = '{2}', Дата = '{3}' " +
                " WHERE Номер_поезда = {4} AND Номер_вагона = {5} AND Дата = '{6}'", number_selected_train_1, Number_wagon_box1.Text, number_selected_type_wagon_1,
                Data_Otbitiya_Picker1.Text, Convert.ToInt32(Id_for_), Convert.ToInt32(column_2), column_data);
            

            insert_in_table(Number_train_box1, Number_wagon_box1, Type_wagon_box1, Data_Otbitiya_Picker, Order);

            end_opiraciy("Невозможно Обновить данную строку");
            //-------------------------------------------------------------------------
            Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись2;
        }


        // обработка нажатия кнопок выбрать и отмена для добавления записи
        private int number_selected_train;
        

        private void Chenge_number_train_MouseEnter(object sender, EventArgs e) { Chenge_number_train.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_number_train_MouseLeave(object sender, EventArgs e) { Chenge_number_train.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_number_train_MouseDown(object sender, MouseEventArgs e) { Chenge_number_train.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void Chenge_number_train_MouseUp(object sender, MouseEventArgs e) { Chenge_number_train.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_number_train_Enter(object sender, EventArgs e) { Chenge_number_train.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_number_train_Leave(object sender, EventArgs e) { Chenge_number_train.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void number_selected_train_Click(object sender, EventArgs e)
        {
            Flights Flights = new Flights();
            Flights.add_in_other_forms_Btn_visible = true;
            Flights.ShowDialog();

            if (Flights.change_check == true)
            {
                number_selected_train = Convert.ToInt32(Flights.Id_for_);
                Number_train_box.Text = Flights.Id_for_;
            }
            else
            {
                number_selected_train = 0;
            }
        }

        private int number_selected_type_wagon;

        private void Chenge_number_type_wagon_MouseEnter(object sender, EventArgs e) { Chenge_number_type_wagon.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_number_type_wagon_MouseLeave(object sender, EventArgs e) { Chenge_number_type_wagon.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_number_type_wagon_MouseDown(object sender, MouseEventArgs e) { Chenge_number_type_wagon.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void Chenge_number_type_wagon_MouseUp(object sender, MouseEventArgs e) { Chenge_number_type_wagon.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_number_type_wagon_Enter(object sender, EventArgs e) { Chenge_number_type_wagon.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_number_type_wagon_Leave(object sender, EventArgs e) { Chenge_number_type_wagon.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void number_selected_type_wagon_Click(object sender, EventArgs e)
        {
            Wagons Wagons = new Wagons();
            Wagons.add_in_other_forms_Btn_visible = true;
            Wagons.ShowDialog();

            if (Wagons.change_check == true)
            {
                number_selected_type_wagon = Convert.ToInt32(Wagons.Id_for_);
                Type_wagon_box.Text = Wagons.Wagon_name.ToString();
            }
            else
            {
                number_selected_type_wagon = 0;
            }
        }

        // обработка нажатия кнопок выбрать и отмена для обновления записи
        private int number_selected_train_1;

        private void number_selected_train1_MouseEnter(object sender, EventArgs e) { number_selected_train1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void number_selected_train1_MouseLeave(object sender, EventArgs e) { number_selected_train1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void number_selected_train1_MouseDown(object sender, MouseEventArgs e) { number_selected_train1.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void number_selected_train1_MouseUp(object sender, MouseEventArgs e) { number_selected_train1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void number_selected_train1_Enter(object sender, EventArgs e) { number_selected_train1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void number_selected_train1_Leave(object sender, EventArgs e) { number_selected_train1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void number_selected_train1_Click(object sender, EventArgs e)
        {
            Flights Flights = new Flights();
            Flights.add_in_other_forms_Btn_visible = true;
            Flights.ShowDialog();

            if (Flights.change_check == true)
            {
                number_selected_train_1 = Convert.ToInt32(Flights.Id_for_);
                Number_train_box1.Text = Flights.Id_for_;
            }
            else
            {
                number_selected_train_1 = 0;
            }
        }

        private int number_selected_type_wagon_1;


        private void number_selected_type_wagon1_MouseEnter(object sender, EventArgs e) { number_selected_type_wagon1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void number_selected_type_wagon1_MouseLeave(object sender, EventArgs e) { number_selected_type_wagon1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void number_selected_type_wagon1_MouseDown(object sender, MouseEventArgs e) { number_selected_type_wagon1.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void number_selected_type_wagon1_MouseUp(object sender, MouseEventArgs e) { number_selected_type_wagon1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void number_selected_type_wagon1_Enter(object sender, EventArgs e) { number_selected_type_wagon1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void number_selected_type_wagon1_Leave(object sender, EventArgs e) { number_selected_type_wagon1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void number_selected_type_wagon1_Click(object sender, EventArgs e)
        {
            Wagons Wagons = new Wagons();
            Wagons.add_in_other_forms_Btn_visible = true;
            Wagons.ShowDialog();

            if (Wagons.change_check == true)
            {
                number_selected_type_wagon_1 = Convert.ToInt32(Wagons.Id_for_);
                Type_wagon_box1.Text = Wagons.Wagon_name.ToString();
            }
            else
            {
                number_selected_type_wagon_1 = 0;
            }
        }

        // кнопка выбора места
        private void button1_MouseEnter(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыбратьМесто2; }
        private void button1_MouseLeave(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыбратьМесто1; }
        private void button1_MouseDown(object sender, MouseEventArgs e) { button1.BackgroundImage = Properties.Resources.ВыбратьМесто3; }
        private void button1_MouseUp(object sender, MouseEventArgs e) { button1.BackgroundImage = Properties.Resources.ВыбратьМесто2; }
        private void button1_Enter(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыбратьМесто2; }
        private void button1_Leave(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.ВыбратьМесто1; }
        private void button1_Click(object sender, EventArgs e)
        {
            Place_form plase = new Place_form();
            execute_plase(); 
            plase.takeMassivePlase(plaselist);
            plase.takemaxplace(countPlaseFromWagons);

            plase.set_mas_data_train(cellDatas);

            plase.ShowDialog();
            //if ()
            //{

            //}
        }

        /// <summary>
        /// выбор поезда для сортировки
        /// 
        private int COD_Flights_for_request;

        private void button2_MouseEnter(object sender, EventArgs e) { button2.BackgroundImage = Properties.Resources.ВыбоВпоиске2; }
        private void button2_MouseLeave(object sender, EventArgs e) { button2.BackgroundImage = Properties.Resources.ВыбоВпоиске1; }
        private void button2_MouseDown(object sender, MouseEventArgs e) { button2.BackgroundImage = Properties.Resources.ВыбоВпоиске3; }
        private void button2_MouseUp(object sender, MouseEventArgs e) { button2.BackgroundImage = Properties.Resources.ВыбоВпоиске2; }
        private void button2_Enter(object sender, EventArgs e) { button2.BackgroundImage = Properties.Resources.ВыбоВпоиске2; }
        private void button2_Leave(object sender, EventArgs e) { button2.BackgroundImage = Properties.Resources.ВыбоВпоиске1; }
        private void button2_Click(object sender, EventArgs e)
        {
            Flights Flights = new Flights();
            Flights.add_in_other_forms_Btn_visible = true;
            Flights.ShowDialog();

            if (Flights.change_check == true)
            {
                COD_Flights_for_request = Convert.ToInt32(Flights.Id_for_);
                Search_box.Text = Flights.Id_for_.ToString();
            }
            else
            {
                COD_Flights_for_request = 0;
            }
        }


        // фильтр всех боксов
        private void Number_wagon_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
