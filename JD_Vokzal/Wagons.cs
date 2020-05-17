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
    public partial class Wagons : Form
    {

        public Wagons()
        {
            InitializeComponent();
            
        }

        private void Show_ALL_info_in_table()
        {
            string Order = "SELECT * FROM Вагоны ";

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
                Wagons_grid.DataSource = ds.Tables[0];
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
                Wagons_grid.DataSource = ds.Tables[0];
            }
            zeroREqest:;
        }

        private string OrderRec;
        private bool check_for_delete;
        private void Show_Request_info_in_table(string Category, string SerchRequest)
        {
            OrderRec = "";

            if (SerchRequest == "")
            {
                MessageBox.Show("Вы не ввели значение");
                goto zeroREqest;
            }
            else if (Category == "Номер типа")
            {
                OrderRec = String.Format("SELECT * FROM Вагоны WHERE Номер_типа = {0} ", SerchRequest);
            }
            else if (Category == "Тип вагона")
            {
                OrderRec = String.Format("SELECT * FROM Вагоны WHERE Тип_вагона = '{0}' ", SerchRequest);
            }
            else if (Category == "Кол-во мест")
            {
                OrderRec = String.Format("SELECT * FROM Вагоны WHERE Кол_во_мест = {0}", SerchRequest);
            }
            else
            {
                MessageBox.Show("Выберите категорию для сортировки");
                goto zeroREqest;
            }

            check_for_delete = true;
            using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
            {
                connection.Open();
                // Создаем объект DataAdapter
                OleDbDataAdapter adapter = new OleDbDataAdapter(OrderRec, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                try
                {
                    adapter.Fill(ds);
                }
                catch (Exception)
                {
                    MessageBox.Show("при поиске Номера типа и кол-во мест используются только цифры");
                    goto zeroREqest;
                }
                // Отображаем данные
                Wagons_grid.DataSource = ds.Tables[0];
            }
            zeroREqest:;
        }


        private string urezanie_texta(string text,int count_with_end)
        {
            if (text !="")
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
                int totalRowsCount = Wagons_grid.Rows.Count;
                int currentIndex = Wagons_grid.CurrentCell.RowIndex;

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
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
                }

            }
            else
            {
                MessageBox.Show(Msg);
            }
        }

        private void chenge_ID()
        {
            int totalRowsCount = Wagons_grid.Rows.Count;
            int currentIndex = Wagons_grid.CurrentCell.RowIndex;

            int index;
            try
            {
               index = Convert.ToInt32(now_id_box.Text);
                if (index <= totalRowsCount && index >= (totalRowsCount - totalRowsCount))
                {
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[index].Cells[0];
                }
                else
                {
                    MessageBox.Show("вы ввели индекс за границами диапозона");
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
                    now_id_box.Text = currentIndex.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("в данном поле можно вводить только числа");
                Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
            }
            
        }


        public string Id_for_ { get; private set; }
        public string Wagon_name { get; private set; }
        private void The_Passengers_grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (Wagons_grid.CurrentCell == null)
            {
                return;
            }
            DataGridViewCellCollection cells = Wagons_grid.CurrentCell.OwningRow.Cells;

            object[] cellDatas = new object[cells.Count];

            //string af = "";
            for (int i = 0; i < cells.Count; i++)
            {
                cellDatas[i] = cells[i].Value;
               // af = af + " " + cellDatas[i];
            }

            Id_for_ = cellDatas[0].ToString();
            Wagon_name = cellDatas[1].ToString();
            now_id_box.Text = Wagons_grid.CurrentCell.RowIndex.ToString();

            if (Panel_with_update.Enabled != false)
            {
                Tip_wagona_box1.Text = cellDatas[1].ToString();
                kolvomest_box1.Text = cellDatas[2].ToString();
            }
            
            ///////////////////////////

            //for (int i = 0; i < cellDatas.Length; i++)
            //{
            //    af = af + " " + cellDatas[i];
            //}
            //Console.WriteLine(cellDatas[0]);
            //Console.WriteLine(af);
        }

        

        private void insert_in_table
            (TextBox T1, TextBox T2, string Order){

            bool B1 = false;
            bool B2 = false;
            

            string errormsg = "Вы не ввели ";

            if (T1.Text != "")
            {
                B1 = true;
            }
            else
            {
                errormsg += "тип вагона, ";
            }

            if (T2.Text != "")
            {
                B2 = true;
            }
            else
            {
                errormsg += "кол-во мест, ";
            }


            errormsg = urezanie_texta(errormsg, 2);
            errormsg += "!!!";

            if (B1 != true | B2 != true ){
                MessageBox.Show(errormsg);
                goto ZeroMetka;
            }

            //string Order1 = Order;
                //String.Format("INSERT INTO Пассажиры (Фамилия, Имя, Отчество, Серия, Номер, Дата_выдачи, Кем_выдан) " +
                //"VALUES ('{0}', '{1}', '{2}', {3}, {4}, '{5}', '{6}')",
                //Familya_box.Text, Name_box.Text, Otchestvo_box.Text, Seryia_Box.Text, Number_Box.Text, Data_vidachi_Box.Text, Kem_vidan_Box.Text);

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

                    MessageBox.Show("В поле кол-во мест могут находится только цифры");
                    goto ZeroMetka;
                }
                
            }
            Tip_wagona_box.Text = ""; Kolvomest_box.Text = "";
            
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
            int totalRowsCount = Wagons_grid.Rows.Count;
            int currentIndex = Wagons_grid.CurrentCell.RowIndex;

            currentIndex = (currentIndex + 1) % totalRowsCount;

            Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
            ////--------------------------------------------------------
            next_pos_grid.BackgroundImage = Properties.Resources.Вниз2;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string sqlExpression = "SELECT MAX(Код_клиента) FROM Пассажиры";
        //    using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
        //    {
        //        connection.Open();
        //        OleDbCommand command = new OleDbCommand(sqlExpression, connection);
        //        int maxID = Convert.ToInt32(command.ExecuteScalar());
        //        //MessageBox.Show(maxID.ToString());
        //        command.CommandText = "SELECT MIN(Код_клиента) FROM Пассажиры";
        //        int minID = Convert.ToInt32(command.ExecuteScalar());
        //        //MessageBox.Show(minID.ToString());
        //    }
        //}


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
            int totalRowsCount = Wagons_grid.Rows.Count;
            int currentIndex = Wagons_grid.CurrentCell.RowIndex;

            currentIndex--;
            if(currentIndex < 0)
            {
                currentIndex = totalRowsCount - 1;
            }

            Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
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
            Show_Request_info_in_table(Sort_box.Text, Search_box.Text);

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
            int totalRowsCount = Wagons_grid.Rows.Count;
            int currentIndex = Wagons_grid.CurrentCell.RowIndex;

            Show_ALL_info_in_table();
            check_for_delete = false;

            if (Id_for_ != "")
            {
                

                if (currentIndex < (totalRowsCount - totalRowsCount))
                {
                    currentIndex++;
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
                }
            }
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
            int totalRowsCount = Wagons_grid.Rows.Count;
            int currentIndex = Wagons_grid.CurrentCell.RowIndex;

            currentIndex = (totalRowsCount - totalRowsCount);
            
            Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
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
            int totalRowsCount = Wagons_grid.Rows.Count;
            int currentIndex = Wagons_grid.CurrentCell.RowIndex;

            currentIndex = totalRowsCount - 2;
            
            Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
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
            string Order = $"DELETE FROM Вагоны WHERE Номер_типа = {Id_for_}";
            
            if (Id_for_ != "")
            {
                using (OleDbConnection connection = new OleDbConnection(Properties.Resources.JD_BD))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(Order, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"удален обьект №{Id_for_}");

                }

                int totalRowsCount = Wagons_grid.Rows.Count;
                int currentIndex = Wagons_grid.CurrentCell.RowIndex -1;

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
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
                }
                else
                {
                    Wagons_grid.CurrentCell = Wagons_grid.Rows[currentIndex].Cells[0];
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
            string Order = String.Format("INSERT INTO Вагоны (Тип_вагона, Кол_во_мест) " +
                "VALUES ('{0}', {1})",
                Tip_wagona_box.Text, Kolvomest_box.Text);

            insert_in_table(Tip_wagona_box, Kolvomest_box, Order);
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
            string Order = String.Format("UPDATE Вагоны SET Тип_вагона = '{0}', Кол_во_мест = {1}" +
                " WHERE Номер_типа = {2}", Tip_wagona_box1.Text, kolvomest_box1.Text,  Id_for_);

            insert_in_table(Tip_wagona_box1, kolvomest_box1, Order);

            end_opiraciy("Невозможно Обновить данную строку");
            //-------------------------------------------------------------------------
            Update_poly.BackgroundImage = Properties.Resources.Обновитьзапись2;
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

        
        // фильтр всех боксов
        private void Tip_wagona_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Kolvomest_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }


        

    }
}
