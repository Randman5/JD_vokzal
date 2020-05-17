namespace JD_Vokzal
{
    partial class Wagons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wagons));
            this.Wagons_grid = new System.Windows.Forms.DataGridView();
            this.Prev_pos_grid = new System.Windows.Forms.Button();
            this.next_pos_grid = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_back_now = new System.Windows.Forms.Button();
            this.Search_box = new System.Windows.Forms.TextBox();
            this.Sort_box = new System.Windows.Forms.ComboBox();
            this.First_row = new System.Windows.Forms.Button();
            this.BTN_last_row = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.Panel_with_ADD = new System.Windows.Forms.Panel();
            this.BTN_add_in_table = new System.Windows.Forms.Button();
            this.Kolvomest_box = new System.Windows.Forms.TextBox();
            this.kolvomest_L = new System.Windows.Forms.Label();
            this.Tip_wagona_box = new System.Windows.Forms.TextBox();
            this.Tip_wagona = new System.Windows.Forms.Label();
            this.Panel_with_update = new System.Windows.Forms.Panel();
            this.Update_poly = new System.Windows.Forms.Button();
            this.kolvomest_box1 = new System.Windows.Forms.TextBox();
            this.Name_L1 = new System.Windows.Forms.Label();
            this.Tip_wagona_box1 = new System.Windows.Forms.TextBox();
            this.Familya1 = new System.Windows.Forms.Label();
            this.redaktirovanie_check_for_panel = new System.Windows.Forms.RadioButton();
            this.Dobavlenie_check_for_panel = new System.Windows.Forms.RadioButton();
            this.now_id_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wagons_grid)).BeginInit();
            this.Panel_with_ADD.SuspendLayout();
            this.Panel_with_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wagons_grid
            // 
            this.Wagons_grid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Wagons_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Wagons_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Wagons_grid.Location = new System.Drawing.Point(12, 12);
            this.Wagons_grid.Name = "Wagons_grid";
            this.Wagons_grid.ReadOnly = true;
            this.Wagons_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Wagons_grid.Size = new System.Drawing.Size(366, 562);
            this.Wagons_grid.TabIndex = 0;
            this.Wagons_grid.CurrentCellChanged += new System.EventHandler(this.The_Passengers_grid_CurrentCellChanged);
            // 
            // Prev_pos_grid
            // 
            this.Prev_pos_grid.BackgroundImage = global::JD_Vokzal.Properties.Resources.Вверх1;
            this.Prev_pos_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev_pos_grid.Location = new System.Drawing.Point(384, 71);
            this.Prev_pos_grid.Name = "Prev_pos_grid";
            this.Prev_pos_grid.Size = new System.Drawing.Size(27, 27);
            this.Prev_pos_grid.TabIndex = 2;
            this.Prev_pos_grid.UseVisualStyleBackColor = true;
            this.Prev_pos_grid.Click += new System.EventHandler(this.Prev_pos_grid_Click);
            this.Prev_pos_grid.Enter += new System.EventHandler(this.Prev_pos_grid_Enter);
            this.Prev_pos_grid.Leave += new System.EventHandler(this.Prev_pos_grid_Leave);
            this.Prev_pos_grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Prev_pos_grid_MouseDown);
            this.Prev_pos_grid.MouseEnter += new System.EventHandler(this.Prev_pos_grid_MouseEnter);
            this.Prev_pos_grid.MouseLeave += new System.EventHandler(this.Prev_pos_grid_MouseLeave);
            this.Prev_pos_grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Prev_pos_grid_MouseUp);
            // 
            // next_pos_grid
            // 
            this.next_pos_grid.BackgroundImage = global::JD_Vokzal.Properties.Resources.Вниз1;
            this.next_pos_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_pos_grid.Location = new System.Drawing.Point(384, 136);
            this.next_pos_grid.Name = "next_pos_grid";
            this.next_pos_grid.Size = new System.Drawing.Size(27, 27);
            this.next_pos_grid.TabIndex = 4;
            this.next_pos_grid.UseVisualStyleBackColor = true;
            this.next_pos_grid.Click += new System.EventHandler(this.next_pos_grid_Click);
            this.next_pos_grid.Enter += new System.EventHandler(this.next_pos_grid_Enter);
            this.next_pos_grid.Leave += new System.EventHandler(this.next_pos_grid_Leave);
            this.next_pos_grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.next_pos_grid_MouseDown);
            this.next_pos_grid.MouseEnter += new System.EventHandler(this.next_pos_grid_MouseEnter);
            this.next_pos_grid.MouseLeave += new System.EventHandler(this.next_pos_grid_MouseLeave);
            this.next_pos_grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.next_pos_grid_MouseUp);
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackgroundImage = global::JD_Vokzal.Properties.Resources.Поиск1;
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Search.Location = new System.Drawing.Point(666, 10);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(38, 22);
            this.BTN_Search.TabIndex = 8;
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            this.BTN_Search.Enter += new System.EventHandler(this.BTN_Search_Enter);
            this.BTN_Search.Leave += new System.EventHandler(this.BTN_Search_Leave);
            this.BTN_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_Search_MouseDown);
            this.BTN_Search.MouseEnter += new System.EventHandler(this.BTN_Search_MouseEnter);
            this.BTN_Search.MouseLeave += new System.EventHandler(this.BTN_Search_MouseLeave);
            this.BTN_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTN_Search_MouseUp);
            // 
            // BTN_back_now
            // 
            this.BTN_back_now.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_back_now.BackgroundImage")));
            this.BTN_back_now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_back_now.Location = new System.Drawing.Point(384, 104);
            this.BTN_back_now.Name = "BTN_back_now";
            this.BTN_back_now.Size = new System.Drawing.Size(27, 27);
            this.BTN_back_now.TabIndex = 3;
            this.BTN_back_now.UseVisualStyleBackColor = true;
            this.BTN_back_now.Click += new System.EventHandler(this.BTN_back_now_Click);
            this.BTN_back_now.Enter += new System.EventHandler(this.BTN_back_now_Enter);
            this.BTN_back_now.Leave += new System.EventHandler(this.BTN_back_now_Leave);
            this.BTN_back_now.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_back_now_MouseDown);
            this.BTN_back_now.MouseEnter += new System.EventHandler(this.BTN_back_now_MouseEnter);
            this.BTN_back_now.MouseLeave += new System.EventHandler(this.BTN_back_now_MouseLeave);
            this.BTN_back_now.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTN_back_now_MouseUp);
            // 
            // Search_box
            // 
            this.Search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_box.Location = new System.Drawing.Point(460, 10);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(207, 22);
            this.Search_box.TabIndex = 7;
            this.Search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_box_KeyDown);
            // 
            // Sort_box
            // 
            this.Sort_box.FormattingEnabled = true;
            this.Sort_box.Items.AddRange(new object[] {
            "Номер типа",
            "Тип вагона",
            "Кол-во мест"});
            this.Sort_box.Location = new System.Drawing.Point(460, 31);
            this.Sort_box.Name = "Sort_box";
            this.Sort_box.Size = new System.Drawing.Size(244, 21);
            this.Sort_box.TabIndex = 10;
            this.Sort_box.Text = "Выберите категорию сортировки";
            // 
            // First_row
            // 
            this.First_row.BackgroundImage = global::JD_Vokzal.Properties.Resources.ПерваяСтрока1;
            this.First_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.First_row.Location = new System.Drawing.Point(384, 38);
            this.First_row.Name = "First_row";
            this.First_row.Size = new System.Drawing.Size(27, 27);
            this.First_row.TabIndex = 1;
            this.First_row.UseVisualStyleBackColor = true;
            this.First_row.Click += new System.EventHandler(this.First_row_Click);
            this.First_row.Enter += new System.EventHandler(this.First_row_Enter);
            this.First_row.Leave += new System.EventHandler(this.First_row_Leave);
            this.First_row.MouseDown += new System.Windows.Forms.MouseEventHandler(this.First_row_MouseDown);
            this.First_row.MouseEnter += new System.EventHandler(this.First_row_MouseEnter);
            this.First_row.MouseLeave += new System.EventHandler(this.First_row_MouseLeave);
            this.First_row.MouseUp += new System.Windows.Forms.MouseEventHandler(this.First_row_MouseUp);
            // 
            // BTN_last_row
            // 
            this.BTN_last_row.BackgroundImage = global::JD_Vokzal.Properties.Resources.ЛастСтрока1;
            this.BTN_last_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_last_row.Location = new System.Drawing.Point(384, 169);
            this.BTN_last_row.Name = "BTN_last_row";
            this.BTN_last_row.Size = new System.Drawing.Size(27, 27);
            this.BTN_last_row.TabIndex = 5;
            this.BTN_last_row.UseVisualStyleBackColor = true;
            this.BTN_last_row.Click += new System.EventHandler(this.BTN_last_row_Click);
            this.BTN_last_row.Enter += new System.EventHandler(this.BTN_last_row_Enter);
            this.BTN_last_row.Leave += new System.EventHandler(this.BTN_last_row_Leave);
            this.BTN_last_row.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_last_row_MouseDown);
            this.BTN_last_row.MouseEnter += new System.EventHandler(this.BTN_last_row_MouseEnter);
            this.BTN_last_row.MouseLeave += new System.EventHandler(this.BTN_last_row_MouseLeave);
            this.BTN_last_row.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTN_last_row_MouseUp);
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackgroundImage = global::JD_Vokzal.Properties.Resources.Удаление1;
            this.BTN_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_delete.Location = new System.Drawing.Point(384, 202);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(27, 27);
            this.BTN_delete.TabIndex = 6;
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            this.BTN_delete.Enter += new System.EventHandler(this.BTN_delete_Enter);
            this.BTN_delete.Leave += new System.EventHandler(this.BTN_delete_Leave);
            this.BTN_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_delete_MouseDown);
            this.BTN_delete.MouseEnter += new System.EventHandler(this.BTN_delete_MouseEnter);
            this.BTN_delete.MouseLeave += new System.EventHandler(this.BTN_delete_MouseLeave);
            this.BTN_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTN_delete_MouseUp);
            // 
            // Panel_with_ADD
            // 
            this.Panel_with_ADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_with_ADD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_with_ADD.Controls.Add(this.BTN_add_in_table);
            this.Panel_with_ADD.Controls.Add(this.Kolvomest_box);
            this.Panel_with_ADD.Controls.Add(this.kolvomest_L);
            this.Panel_with_ADD.Controls.Add(this.Tip_wagona_box);
            this.Panel_with_ADD.Controls.Add(this.Tip_wagona);
            this.Panel_with_ADD.Location = new System.Drawing.Point(460, 148);
            this.Panel_with_ADD.Name = "Panel_with_ADD";
            this.Panel_with_ADD.Size = new System.Drawing.Size(244, 170);
            this.Panel_with_ADD.TabIndex = 9;
            // 
            // BTN_add_in_table
            // 
            this.BTN_add_in_table.BackgroundImage = global::JD_Vokzal.Properties.Resources.ДобавлениеЗаписи1;
            this.BTN_add_in_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_add_in_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add_in_table.Location = new System.Drawing.Point(15, 111);
            this.BTN_add_in_table.Name = "BTN_add_in_table";
            this.BTN_add_in_table.Size = new System.Drawing.Size(208, 46);
            this.BTN_add_in_table.TabIndex = 8;
            this.BTN_add_in_table.UseVisualStyleBackColor = true;
            this.BTN_add_in_table.Click += new System.EventHandler(this.BTN_add_in_table_Click);
            this.BTN_add_in_table.Enter += new System.EventHandler(this.BTN_add_in_table_Enter);
            this.BTN_add_in_table.Leave += new System.EventHandler(this.BTN_add_in_table_Leave);
            this.BTN_add_in_table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_add_in_table_MouseDown);
            this.BTN_add_in_table.MouseEnter += new System.EventHandler(this.BTN_add_in_table_MouseEnter);
            this.BTN_add_in_table.MouseLeave += new System.EventHandler(this.BTN_add_in_table_MouseLeave);
            this.BTN_add_in_table.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTN_add_in_table_MouseUp);
            // 
            // Kolvomest_box
            // 
            this.Kolvomest_box.Location = new System.Drawing.Point(15, 80);
            this.Kolvomest_box.MaxLength = 2;
            this.Kolvomest_box.Name = "Kolvomest_box";
            this.Kolvomest_box.Size = new System.Drawing.Size(209, 20);
            this.Kolvomest_box.TabIndex = 2;
            this.Kolvomest_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kolvomest_box_KeyPress);
            // 
            // kolvomest_L
            // 
            this.kolvomest_L.AutoSize = true;
            this.kolvomest_L.Location = new System.Drawing.Point(12, 64);
            this.kolvomest_L.Name = "kolvomest_L";
            this.kolvomest_L.Size = new System.Drawing.Size(69, 13);
            this.kolvomest_L.TabIndex = 0;
            this.kolvomest_L.Text = "Кол-во мест";
            // 
            // Tip_wagona_box
            // 
            this.Tip_wagona_box.Location = new System.Drawing.Point(15, 31);
            this.Tip_wagona_box.MaxLength = 25;
            this.Tip_wagona_box.Name = "Tip_wagona_box";
            this.Tip_wagona_box.Size = new System.Drawing.Size(209, 20);
            this.Tip_wagona_box.TabIndex = 1;
            this.Tip_wagona_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tip_wagona_box_KeyPress);
            // 
            // Tip_wagona
            // 
            this.Tip_wagona.AutoSize = true;
            this.Tip_wagona.Location = new System.Drawing.Point(12, 12);
            this.Tip_wagona.Name = "Tip_wagona";
            this.Tip_wagona.Size = new System.Drawing.Size(64, 13);
            this.Tip_wagona.TabIndex = 0;
            this.Tip_wagona.Text = "Тип вагона";
            // 
            // Panel_with_update
            // 
            this.Panel_with_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_with_update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_with_update.Controls.Add(this.Update_poly);
            this.Panel_with_update.Controls.Add(this.kolvomest_box1);
            this.Panel_with_update.Controls.Add(this.Name_L1);
            this.Panel_with_update.Controls.Add(this.Tip_wagona_box1);
            this.Panel_with_update.Controls.Add(this.Familya1);
            this.Panel_with_update.Location = new System.Drawing.Point(460, 149);
            this.Panel_with_update.Name = "Panel_with_update";
            this.Panel_with_update.Size = new System.Drawing.Size(244, 169);
            this.Panel_with_update.TabIndex = 9;
            this.Panel_with_update.Visible = false;
            // 
            // Update_poly
            // 
            this.Update_poly.BackgroundImage = global::JD_Vokzal.Properties.Resources.Обновитьзапись1;
            this.Update_poly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Update_poly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_poly.Location = new System.Drawing.Point(15, 110);
            this.Update_poly.Name = "Update_poly";
            this.Update_poly.Size = new System.Drawing.Size(208, 46);
            this.Update_poly.TabIndex = 8;
            this.Update_poly.UseVisualStyleBackColor = true;
            this.Update_poly.Click += new System.EventHandler(this.Update_poly_Click);
            this.Update_poly.Enter += new System.EventHandler(this.Update_poly_Enter);
            this.Update_poly.Leave += new System.EventHandler(this.Update_poly_Leave);
            this.Update_poly.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_poly_MouseDown);
            this.Update_poly.MouseEnter += new System.EventHandler(this.Update_poly_MouseEnter);
            this.Update_poly.MouseLeave += new System.EventHandler(this.Update_poly_MouseLeave);
            this.Update_poly.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Update_poly_MouseUp);
            // 
            // kolvomest_box1
            // 
            this.kolvomest_box1.Location = new System.Drawing.Point(15, 80);
            this.kolvomest_box1.MaxLength = 2;
            this.kolvomest_box1.Name = "kolvomest_box1";
            this.kolvomest_box1.Size = new System.Drawing.Size(209, 20);
            this.kolvomest_box1.TabIndex = 2;
            // 
            // Name_L1
            // 
            this.Name_L1.AutoSize = true;
            this.Name_L1.Location = new System.Drawing.Point(12, 64);
            this.Name_L1.Name = "Name_L1";
            this.Name_L1.Size = new System.Drawing.Size(69, 13);
            this.Name_L1.TabIndex = 0;
            this.Name_L1.Text = "Кол-во мест";
            // 
            // Tip_wagona_box1
            // 
            this.Tip_wagona_box1.Location = new System.Drawing.Point(15, 31);
            this.Tip_wagona_box1.MaxLength = 25;
            this.Tip_wagona_box1.Name = "Tip_wagona_box1";
            this.Tip_wagona_box1.Size = new System.Drawing.Size(209, 20);
            this.Tip_wagona_box1.TabIndex = 1;
            // 
            // Familya1
            // 
            this.Familya1.AutoSize = true;
            this.Familya1.Location = new System.Drawing.Point(12, 12);
            this.Familya1.Name = "Familya1";
            this.Familya1.Size = new System.Drawing.Size(64, 13);
            this.Familya1.TabIndex = 0;
            this.Familya1.Text = "Тип вагона";
            // 
            // redaktirovanie_check_for_panel
            // 
            this.redaktirovanie_check_for_panel.AutoSize = true;
            this.redaktirovanie_check_for_panel.Location = new System.Drawing.Point(596, 81);
            this.redaktirovanie_check_for_panel.Name = "redaktirovanie_check_for_panel";
            this.redaktirovanie_check_for_panel.Size = new System.Drawing.Size(108, 17);
            this.redaktirovanie_check_for_panel.TabIndex = 11;
            this.redaktirovanie_check_for_panel.Text = "редактирование";
            this.redaktirovanie_check_for_panel.UseVisualStyleBackColor = true;
            this.redaktirovanie_check_for_panel.Enter += new System.EventHandler(this.redaktirovanie_check_for_panel_Enter);
            this.redaktirovanie_check_for_panel.MouseCaptureChanged += new System.EventHandler(this.redaktirovanie_check_for_panel_MouseCaptureChanged);
            // 
            // Dobavlenie_check_for_panel
            // 
            this.Dobavlenie_check_for_panel.AutoSize = true;
            this.Dobavlenie_check_for_panel.Checked = true;
            this.Dobavlenie_check_for_panel.Location = new System.Drawing.Point(460, 81);
            this.Dobavlenie_check_for_panel.Name = "Dobavlenie_check_for_panel";
            this.Dobavlenie_check_for_panel.Size = new System.Drawing.Size(88, 17);
            this.Dobavlenie_check_for_panel.TabIndex = 12;
            this.Dobavlenie_check_for_panel.TabStop = true;
            this.Dobavlenie_check_for_panel.Text = "Добавление";
            this.Dobavlenie_check_for_panel.UseVisualStyleBackColor = true;
            this.Dobavlenie_check_for_panel.Enter += new System.EventHandler(this.Dobavlenie_check_for_panel_Enter);
            this.Dobavlenie_check_for_panel.MouseCaptureChanged += new System.EventHandler(this.Dobavlenie_check_for_panel_MouseCaptureChanged);
            // 
            // now_id_box
            // 
            this.now_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.now_id_box.Location = new System.Drawing.Point(384, 12);
            this.now_id_box.Name = "now_id_box";
            this.now_id_box.Size = new System.Drawing.Size(50, 20);
            this.now_id_box.TabIndex = 13;
            this.now_id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.now_id_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.now_id_box_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::JD_Vokzal.Properties.Resources.Выбор1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(461, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 42);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Wagons
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.now_id_box);
            this.Controls.Add(this.Dobavlenie_check_for_panel);
            this.Controls.Add(this.redaktirovanie_check_for_panel);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_last_row);
            this.Controls.Add(this.First_row);
            this.Controls.Add(this.Search_box);
            this.Controls.Add(this.BTN_back_now);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.next_pos_grid);
            this.Controls.Add(this.Prev_pos_grid);
            this.Controls.Add(this.Wagons_grid);
            this.Controls.Add(this.Sort_box);
            this.Controls.Add(this.Panel_with_ADD);
            this.Controls.Add(this.Panel_with_update);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(743, 625);
            this.MinimumSize = new System.Drawing.Size(743, 625);
            this.Name = "Wagons";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вагоны";
            this.Load += new System.EventHandler(this.The_passengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wagons_grid)).EndInit();
            this.Panel_with_ADD.ResumeLayout(false);
            this.Panel_with_ADD.PerformLayout();
            this.Panel_with_update.ResumeLayout(false);
            this.Panel_with_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.DataGridView Wagons_grid;
        private System.Windows.Forms.Button Prev_pos_grid;
        private System.Windows.Forms.Button next_pos_grid;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_back_now;
        private System.Windows.Forms.TextBox Search_box;
        private System.Windows.Forms.ComboBox Sort_box;
        private System.Windows.Forms.Button First_row;
        private System.Windows.Forms.Button BTN_last_row;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Panel Panel_with_ADD;
        private System.Windows.Forms.Button BTN_add_in_table;
        private System.Windows.Forms.TextBox Kolvomest_box;
        private System.Windows.Forms.Label kolvomest_L;
        private System.Windows.Forms.TextBox Tip_wagona_box;
        private System.Windows.Forms.Label Tip_wagona;
        private System.Windows.Forms.Panel Panel_with_update;
        private System.Windows.Forms.TextBox kolvomest_box1;
        private System.Windows.Forms.Label Name_L1;
        private System.Windows.Forms.TextBox Tip_wagona_box1;
        private System.Windows.Forms.Label Familya1;
        private System.Windows.Forms.Button Update_poly;
        private System.Windows.Forms.RadioButton redaktirovanie_check_for_panel;
        private System.Windows.Forms.RadioButton Dobavlenie_check_for_panel;
        private System.Windows.Forms.TextBox now_id_box;
        private System.Windows.Forms.Button button1;
    }
}