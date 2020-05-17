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
    public partial class Flights : Form
    {

        public Flights()
        {
            InitializeComponent();
            
        }

        private void Show_ALL_info_in_table()
        {
            string Order = "SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as пункт_отправления, " +
                " Города_1.Название_города as пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) and (Рейсы.Пункт_назначения = Города_1.Код_города) ORDER BY Рейсы.Номер_поезда ";

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

        private void Sort_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sort_box.Text != "")
            {
                string sort_category = Sort_box.SelectedItem.ToString();

                if (sort_category == "Пункт отправления")
                {
                    CengeCItyes_for_reqest.Visible = true;
                    CengeCItyes_for_reqest1.Visible = false;
                    Search_box.ReadOnly = true;
                    Search_box.Text = "";
                    serch_MSG2 = "";
                }
                else if(sort_category == "Пункт назначения")
                {
                    CengeCItyes_for_reqest.Visible = true;
                    CengeCItyes_for_reqest1.Visible = false;
                    Search_box.ReadOnly = true;
                    Search_box.Text = "";
                    serch_MSG2 = "";
                }
                else if (sort_category == "Пункт отправления - пункт назначения")
                {
                    CengeCItyes_for_reqest1.Visible = true;
                    CengeCItyes_for_reqest.Visible = true;
                    Search_box.ReadOnly = true;
                }
                else
                {
                    CengeCItyes_for_reqest.Visible = false;
                    CengeCItyes_for_reqest1.Visible = false;
                    Search_box.ReadOnly = false;
                    Search_box.Text = "";
                }
            }
        }

        private string OrderRec;
        private bool check_for_delete;
        private void Show_Request_info_in_table(string Category, string SerchRequest, int number_selected_city_for_request)
        {
            OrderRec = "";

            if (SerchRequest == "")
            {
                MessageBox.Show("Вы не ввели значение");
                goto zeroREqest;
            }
            else if (Category == "Номер поезда")
            {
                OrderRec = String.Format("SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as Пункт_отправления, " +
                " Города_1.Название_города as Пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) AND (Рейсы.Пункт_назначения = Города_1.Код_города) AND (Номер_поезда = {0}) ", SerchRequest);
            }
            else if (Category == "Пункт отправления")
            {
                OrderRec = String.Format("SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as Пункт_отправления, " +
                " Города_1.Название_города as Пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) AND (Рейсы.Пункт_назначения = Города_1.Код_города) AND (Пункт_отправления = {0}) ", number_selected_city_for_request);
            }
            else if (Category == "Пункт назначения")
            {
                OrderRec = String.Format("SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as Пункт_отправления, " +
                " Города_1.Название_города as Пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) AND (Рейсы.Пункт_назначения = Города_1.Код_города) AND (Пункт_назначения = {0}) ", number_selected_city_for_request);
            }
            else if (Category == "Пункт отправления - пункт назначения")
            {
                OrderRec = String.Format("SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as Пункт_отправления, " +
                " Города_1.Название_города as Пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) AND (Рейсы.Пункт_назначения = Города_1.Код_города) AND (Пункт_отправления = {0}) AND (Пункт_назначения = {1}) ", number_selected_city_for_request, number_selected_city_for_request1);
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


        public string Id_for_ { get; private set; }
        public string City_name { get; private set; }
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
            now_id_box.Text = The_Passengers_grid.CurrentCell.RowIndex.ToString();

            if (Panel_with_update.Enabled != false)
            {
                Number_train_box1.Text = cellDatas[0].ToString();
                Time_start_box1.Text = cellDatas[1].ToString();
                Start_position_box1.Text = cellDatas[2].ToString();
                Position_end_Box1.Text = cellDatas[3].ToString();
                Time_end_Box1.Text = cellDatas[4].ToString();
            }
            execute_cities();
            ///////////////////////////

            //for (int i = 0; i < cellDatas.Length; i++)
            //{
            //    af = af + " " + cellDatas[i];
            //}
            //Console.WriteLine(cellDatas[0]);
            //Console.WriteLine(af);
        }

        private void execute_cities()
        {
            string Order = String.Format("SELECT * FROM Рейсы WHERE Номер_поезда = {0} ", Id_for_);
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        number_selected_city_start1 = Convert.ToInt32(reader["Пункт_отправления"]);
                        number_selected_city_end1 = Convert.ToInt32(reader["Пункт_назначения"]);
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(number_selected_city_start1 + " " + number_selected_city_end1);
                }


            }
        }

        

        private void insert_in_table
            (TextBox T1, TextBox T2, TextBox T3, TextBox T4, TextBox T5, string Order){

            bool B1 = false;
            bool B2 = false;
            bool B3 = false;
            bool B4 = false;
            bool B5 = false;

            string errormsg = "Вы не ввели ";

            if (T1.Text != "")
            {
                B1 = true;
            }
            else
            {
                
                errormsg += "номер поезда, ";
            }

            if (T2.Text != "")
            {
                B2 = true;
            }
            else
            {
                errormsg += "время отбытия, ";
            }

            if (T3.Text != "")
            {
                B3 = true;
            }
            else
            {
                errormsg += "пункт отправления, ";
            }

            if (T4.Text != "")
            {
                B4 = true;
            }
            else
            {
                errormsg += "пункт назначения, ";
            }

            if (T5.Text != "")
            {
                B5 = true;
            }
            else
            {
                errormsg += "время прибытбытия, ";
            }

            errormsg = urezanie_texta(errormsg, 2);
            errormsg += "!!!";

            if (B1 != true | B2 != true | B3 != true | B4 != true | B5 != true ){
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

                    MessageBox.Show("имеются связные записи в таблице билеты или в таблице составы");
                    goto ZeroMetka;
                }

            }
            Number_train_box.Text = ""; Time_start_box.Text = ""; Start_position_box.Text = ""; Position_end_Box.Text = ""; Time_end_Box.Text = "";
            
            ZeroMetka:;
        }
        
        private void The_passengers_Load(object sender, EventArgs e)
        {
            check_for_delete = false;

            if (add_in_other_forms_Btn_visible == true)
            {
                button1.Visible = true;
            }

            change_check = false;
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
            Show_Request_info_in_table(Sort_box.Text, Search_box.Text , number_selected_city_for_request);

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
            string Order = $"DELETE FROM Рейсы WHERE Номер_поезда = {Id_for_}";
            
            if (Id_for_ != "")
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

                        MessageBox.Show("имеются связные записи в таблице билеты или в таблице составы");
                    }
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
            string Order = String.Format("INSERT INTO Рейсы (Номер_поезда, Время_отправки, Пункт_отправления, Пункт_назначения, Время_прибытия) " +
                "VALUES ( '{0}', '{1}', {2}, {3}, '{4}')", Number_train_box.Text, Time_start_box.Text, number_selected_city_start, number_selected_city_end, Time_end_Box.Text);

            insert_in_table(Number_train_box, Time_start_box, Start_position_box, Position_end_Box, Time_end_Box, Order);

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
            string Order = String.Format("UPDATE Рейсы SET Номер_поезда = '{0}', Время_отправки = '{1}', Пункт_отправления = {2},Пункт_назначения = {3}, Время_прибытия = '{4}' " +
                " WHERE Номер_поезда = {5}", Number_train_box1.Text, Time_start_box1.Text, number_selected_city_start1, number_selected_city_end1, Time_end_Box1.Text, Id_for_);

            //string Order = String.Format("UPDATE Рейсы SET  Время_отправки = '{0}', Пункт_отправления = {1},Пункт_назначения = {2}, Время_прибытия = '{3}' " +
            //    " WHERE Номер_поезда = {4} ", Time_start_box1.Text, number_selected_city_start1, number_selected_city_end1, Time_end_Box1.Text, Id_for_);

            insert_in_table(Number_train_box1, Time_start_box1, Start_position_box1, Position_end_Box1, Time_end_Box1, Order);

            end_opiraciy("Невозможно Обновить данную строку");
            //-------------------------------------------------------------------------
            Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись2;
        }


        // обработка нажатия кнопок выбрать и отмена для добавления записи
        private int number_selected_city_start;

        private void Chenge_start_city_MouseEnter(object sender, EventArgs e) { Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_start_city_MouseLeave(object sender, EventArgs e) { Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_start_city_MouseDown(object sender, MouseEventArgs e) { Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void Chenge_start_city_MouseUp(object sender, MouseEventArgs e) { Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_start_city_Enter(object sender, EventArgs e) { Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_start_city_Leave(object sender, EventArgs e) { Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_start_city_Click(object sender, EventArgs e)
        {
            Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода3;
            //---------------------------------------------------
            Cities Cities = new Cities();
            Cities.add_in_other_forms_Btn_visible = true;
            Cities.ShowDialog();

            if (Cities.change_check == true)
            {
                number_selected_city_start = Convert.ToInt32(Cities.Id_for_);
                Start_position_box.Text = Cities.City_name;
            }
            else
            {
                number_selected_city_start = 0;
            }
            //---------------------------------------------------
            Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода2;
        }

        private int number_selected_city_end;

        private void Chenge_end_city_MouseEnter(object sender, EventArgs e) { Chenge_end_city.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_end_city_MouseLeave(object sender, EventArgs e) { Chenge_end_city.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_end_city_MouseDown(object sender, MouseEventArgs e) { Chenge_end_city.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void Chenge_end_city_MouseUp(object sender, MouseEventArgs e) { Chenge_end_city.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_end_city_Enter(object sender, EventArgs e) { Chenge_end_city.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_end_city_Leave(object sender, EventArgs e) { Chenge_end_city.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_end_city_Click(object sender, EventArgs e)
        {
            Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода3;
            //---------------------------------------------------
            Cities Cities = new Cities();
            Cities.add_in_other_forms_Btn_visible = true;
            Cities.ShowDialog();

            if (Cities.change_check == true)
            {
                number_selected_city_end = Convert.ToInt32(Cities.Id_for_);
                Position_end_Box.Text = Cities.City_name;
            }
            else
            {
                number_selected_city_end = 0;
            }
            //---------------------------------------------------
            Chenge_start_city.BackgroundImage = Properties.Resources.ВыборКода2;
        }

        // обработка нажатия кнопок выбрать и отмена для обновления записи
        private int number_selected_city_start1;


        private void Chenge_start_city1_MouseEnter(object sender, EventArgs e) { Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_start_city1_MouseLeave(object sender, EventArgs e) { Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_start_city1_MouseDown(object sender, MouseEventArgs e) { Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void Chenge_start_city1_MouseUp(object sender, MouseEventArgs e) { Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_start_city1_Enter(object sender, EventArgs e) { Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_start_city1_Leave(object sender, EventArgs e) { Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_start_city1_Click(object sender, EventArgs e)
        {

            Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода3;
            //---------------------------------------------------
            Cities Cities = new Cities();
            Cities.add_in_other_forms_Btn_visible = true;
            Cities.ShowDialog();

            if (Cities.change_check == true)
            {
                number_selected_city_start1 = Convert.ToInt32(Cities.Id_for_);
                Start_position_box1.Text = Cities.City_name;
            }
            else
            {
                number_selected_city_start1 = 0;
            }
            //---------------------------------------------------
            Chenge_start_city1.BackgroundImage = Properties.Resources.ВыборКода2;
        }

        private int number_selected_city_end1;

        private void Chenge_end_city1_MouseEnter(object sender, EventArgs e) { Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_end_city1_MouseLeave(object sender, EventArgs e) { Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_end_city1_MouseDown(object sender, MouseEventArgs e) { Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода3; }
        private void Chenge_end_city1_MouseUp(object sender, MouseEventArgs e) { Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_end_city1_Enter(object sender, EventArgs e) { Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода2; }
        private void Chenge_end_city1_Leave(object sender, EventArgs e) { Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода1; }
        private void Chenge_end_city1_Click(object sender, EventArgs e)
        {
            Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода3;
            //----------------------------------------------------------
            Cities Cities = new Cities();
            Cities.add_in_other_forms_Btn_visible = true;
            Cities.ShowDialog();

            if (Cities.change_check == true)
            {
                number_selected_city_end1 = Convert.ToInt32(Cities.Id_for_);
                Position_end_Box1.Text = Cities.City_name;
            }
            else
            {
                number_selected_city_end1 = 0;
            }
            //----------------------------------------------------------
            Chenge_end_city1.BackgroundImage = Properties.Resources.ВыборКода2;
        }


        private string serch_MSG1 = "";
        private string serch_MSG2 = "";
        // Кнопка для вызыва формы сортировки по городам1
        private int number_selected_city_for_request;

        private void CengeCItyes_for_reqest_MouseEnter(object sender, EventArgs e) { CengeCItyes_for_reqest.BackgroundImage = Properties.Resources.ВыборГорода2; }
        private void CengeCItyes_for_reqest_MouseLeave(object sender, EventArgs e) { CengeCItyes_for_reqest.BackgroundImage = Properties.Resources.ВыборГорода1; }
        private void CengeCItyes_for_reqest_MouseDown(object sender, MouseEventArgs e) { CengeCItyes_for_reqest.BackgroundImage = Properties.Resources.ВыборГорода3; }
        private void CengeCItyes_for_reqest_MouseUp(object sender, MouseEventArgs e) { CengeCItyes_for_reqest.BackgroundImage = Properties.Resources.ВыборГорода2; }
        private void CengeCItyes_for_reqest_Enter(object sender, EventArgs e) { CengeCItyes_for_reqest.BackgroundImage = Properties.Resources.ВыборГорода2; }
        private void CengeCItyes_for_reqest_Leave(object sender, EventArgs e) { CengeCItyes_for_reqest.BackgroundImage = Properties.Resources.ВыборГорода1; }
        private void CengeCItyes_for_reqest_Click(object sender, EventArgs e)
        {
            Cities Cities = new Cities();
            Cities.add_in_other_forms_Btn_visible = true;
            Cities.ShowDialog();

            if (Cities.change_check == true)
            {
                number_selected_city_for_request = Convert.ToInt32(Cities.Id_for_);
                serch_MSG1 = Cities.City_name;
                Search_box.Text = serch_MSG1 + " - " + serch_MSG2;
            }
            else
            {
                number_selected_city_for_request = 0;
            }
        }

        // Кнопка для вызыва формы сортировки по городам2
        private int number_selected_city_for_request1;


        private void CengeCItyes_for_reqest1_MouseEnter(object sender, EventArgs e) { CengeCItyes_for_reqest1.BackgroundImage = Properties.Resources.ВыборГорода2; }
        private void CengeCItyes_for_reqest1_MouseLeave(object sender, EventArgs e) { CengeCItyes_for_reqest1.BackgroundImage = Properties.Resources.ВыборГорода1; }
        private void CengeCItyes_for_reqest1_MouseDown(object sender, MouseEventArgs e) { CengeCItyes_for_reqest1.BackgroundImage = Properties.Resources.ВыборГорода3; }
        private void CengeCItyes_for_reqest1_MouseUp(object sender, MouseEventArgs e) { CengeCItyes_for_reqest1.BackgroundImage = Properties.Resources.ВыборГорода2; }
        private void CengeCItyes_for_reqest1_Enter(object sender, EventArgs e) { CengeCItyes_for_reqest1.BackgroundImage = Properties.Resources.ВыборГорода2; }
        private void CengeCItyes_for_reqest1_Leave(object sender, EventArgs e) { CengeCItyes_for_reqest1.BackgroundImage = Properties.Resources.ВыборГорода1; }
        private void CengeCItyes_for_reqest1_Click(object sender, EventArgs e)
        {
            Cities Cities = new Cities();
            Cities.add_in_other_forms_Btn_visible = true;
            Cities.ShowDialog();
            
            if (Cities.change_check == true)
            {
                number_selected_city_for_request1 = Convert.ToInt32(Cities.Id_for_);
                serch_MSG2 = Cities.City_name;
                Search_box.Text = serch_MSG1 + " - " + serch_MSG2;
            }
            else
            {
                number_selected_city_for_request1 = 0;
            }
        }


        // обработка нажатия кнопок выбрать и отмена
        public bool add_in_other_forms_Btn_visible { get; set; }
        public bool change_check { get; private set; }


        private void button1_MouseEnter(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.Выбор2; }
        private void button1_MouseLeave(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.Выбор1; }
        private void button1_MouseDown(object sender, MouseEventArgs e) { button1.BackgroundImage = Properties.Resources.Выбор3; }
        private void button1_MouseUp(object sender, MouseEventArgs e) { button1.BackgroundImage = Properties.Resources.Выбор2; }
        private void button1_Enter(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.Выбор2; }
        private void button1_Leave(object sender, EventArgs e) { button1.BackgroundImage = Properties.Resources.Выбор1; }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Выбор3;
            //-------------------------------------------------------
            change_check = true;
            this.Close();
            //-------------------------------------------------------
            button1.BackgroundImage = Properties.Resources.Выбор2;
        }
        
        
        // обработчик события печати2
        void PrintPageHandler2(object sender, PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString(result_otchet, new Font("Times New Roman", 14), Brushes.Black, 100, 50);
        }


        string result_otchet;
        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string Order = "SELECT Рейсы.Номер_поезда, Рейсы.Время_отправки, Города.Название_города as пункт_отправления, " +
                " Города_1.Название_города as пункт_назначения,Рейсы.Время_прибытия FROM Рейсы,Города, Города_1 " +
                "WHERE (Рейсы.Пункт_отправления = Города.Код_города) and (Рейсы.Пункт_назначения = Города_1.Код_города) ORDER BY Рейсы.Номер_поезда ";


            result_otchet = "Расписание с " + DateTime.Today;
            result_otchet = urezanie_texta(result_otchet,7);
            result_otchet += "\n\n";
            result_otchet += "\n№ поезда  Время отбытия  Пункт отправления Пункт назначения  Время прибытия\n\n";
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(Order, connection);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        result_otchet += (reader["Номер_поезда"]).ToString() + "\t   ";
                        result_otchet += (reader["Время_отправки"]).ToString() + " \t\t";
                        result_otchet += (reader["Пункт_отправления"]).ToString() + " \t\t ";
                        result_otchet += (reader["Пункт_назначения"]).ToString() + "    \t    ";
                        result_otchet += (reader["Время_прибытия"]).ToString() + "\t\n";

                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(number_selected_city_start1 + " " + number_selected_city_end1);
                }


            }
            

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler2;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;
            try
            {
                // если в диалоге было нажато ОК
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print(); // печатаем
            }
            catch (Exception)
            {

                MessageBox.Show("закройте открытый файл и попробуйте заново");
            }
            
        }


        // фильтр всех боксов
        private void Number_train_box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Time_start_box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsControl(e.KeyChar)| Char.IsPunctuation(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }


}