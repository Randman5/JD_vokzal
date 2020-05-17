namespace JD_Vokzal
{
    partial class Cities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cities));
            this.Cities_grid = new System.Windows.Forms.DataGridView();
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
            this.Cities_name_box = new System.Windows.Forms.TextBox();
            this.Cities_name = new System.Windows.Forms.Label();
            this.Panel_with_update = new System.Windows.Forms.Panel();
            this.BTN_Update_poly = new System.Windows.Forms.Button();
            this.Cities_name_box1 = new System.Windows.Forms.TextBox();
            this.Cities_name1 = new System.Windows.Forms.Label();
            this.redaktirovanie_check_for_panel = new System.Windows.Forms.RadioButton();
            this.Dobavlenie_check_for_panel = new System.Windows.Forms.RadioButton();
            this.now_id_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cities_grid)).BeginInit();
            this.Panel_with_ADD.SuspendLayout();
            this.Panel_with_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cities_grid
            // 
            this.Cities_grid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cities_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cities_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cities_grid.Location = new System.Drawing.Point(12, 12);
            this.Cities_grid.Name = "Cities_grid";
            this.Cities_grid.ReadOnly = true;
            this.Cities_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cities_grid.Size = new System.Drawing.Size(265, 562);
            this.Cities_grid.TabIndex = 0;
            this.Cities_grid.CurrentCellChanged += new System.EventHandler(this.Cities_grid_CurrentCellChanged);
            // 
            // Prev_pos_grid
            // 
            this.Prev_pos_grid.BackgroundImage = global::JD_Vokzal.Properties.Resources.Вверх1;
            this.Prev_pos_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev_pos_grid.Location = new System.Drawing.Point(283, 76);
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
            this.next_pos_grid.Location = new System.Drawing.Point(283, 141);
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
            this.BTN_Search.Location = new System.Drawing.Point(571, 17);
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
            this.BTN_back_now.Location = new System.Drawing.Point(283, 109);
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
            this.Search_box.Location = new System.Drawing.Point(365, 17);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(207, 22);
            this.Search_box.TabIndex = 7;
            this.Search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_box_KeyDown);
            // 
            // Sort_box
            // 
            this.Sort_box.FormattingEnabled = true;
            this.Sort_box.Items.AddRange(new object[] {
            "Код города",
            "Название города"});
            this.Sort_box.Location = new System.Drawing.Point(365, 38);
            this.Sort_box.Name = "Sort_box";
            this.Sort_box.Size = new System.Drawing.Size(244, 21);
            this.Sort_box.TabIndex = 10;
            this.Sort_box.Text = "Выберите категорию сортировки";
            // 
            // First_row
            // 
            this.First_row.BackgroundImage = global::JD_Vokzal.Properties.Resources.ПерваяСтрока1;
            this.First_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.First_row.Location = new System.Drawing.Point(283, 43);
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
            this.BTN_last_row.Location = new System.Drawing.Point(283, 174);
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
            this.BTN_delete.Location = new System.Drawing.Point(283, 207);
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
            this.Panel_with_ADD.Controls.Add(this.Cities_name_box);
            this.Panel_with_ADD.Controls.Add(this.Cities_name);
            this.Panel_with_ADD.Location = new System.Drawing.Point(365, 135);
            this.Panel_with_ADD.Name = "Panel_with_ADD";
            this.Panel_with_ADD.Size = new System.Drawing.Size(244, 129);
            this.Panel_with_ADD.TabIndex = 9;
            // 
            // BTN_add_in_table
            // 
            this.BTN_add_in_table.BackgroundImage = global::JD_Vokzal.Properties.Resources.ДобавлениеЗаписи1;
            this.BTN_add_in_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_add_in_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add_in_table.Location = new System.Drawing.Point(15, 66);
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
            // Cities_name_box
            // 
            this.Cities_name_box.Location = new System.Drawing.Point(15, 31);
            this.Cities_name_box.MaxLength = 100;
            this.Cities_name_box.Name = "Cities_name_box";
            this.Cities_name_box.Size = new System.Drawing.Size(209, 20);
            this.Cities_name_box.TabIndex = 1;
            this.Cities_name_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cities_name_box1_KeyPress);
            // 
            // Cities_name
            // 
            this.Cities_name.AutoSize = true;
            this.Cities_name.Location = new System.Drawing.Point(12, 12);
            this.Cities_name.Name = "Cities_name";
            this.Cities_name.Size = new System.Drawing.Size(95, 13);
            this.Cities_name.TabIndex = 0;
            this.Cities_name.Text = "Название города";
            // 
            // Panel_with_update
            // 
            this.Panel_with_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_with_update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_with_update.Controls.Add(this.BTN_Update_poly);
            this.Panel_with_update.Controls.Add(this.Cities_name_box1);
            this.Panel_with_update.Controls.Add(this.Cities_name1);
            this.Panel_with_update.Location = new System.Drawing.Point(365, 135);
            this.Panel_with_update.Name = "Panel_with_update";
            this.Panel_with_update.Size = new System.Drawing.Size(244, 129);
            this.Panel_with_update.TabIndex = 9;
            this.Panel_with_update.Visible = false;
            // 
            // BTN_Update_poly
            // 
            this.BTN_Update_poly.BackgroundImage = global::JD_Vokzal.Properties.Resources.Обновитьзапись1;
            this.BTN_Update_poly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Update_poly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Update_poly.Location = new System.Drawing.Point(15, 66);
            this.BTN_Update_poly.Name = "BTN_Update_poly";
            this.BTN_Update_poly.Size = new System.Drawing.Size(208, 46);
            this.BTN_Update_poly.TabIndex = 8;
            this.BTN_Update_poly.UseVisualStyleBackColor = true;
            this.BTN_Update_poly.Click += new System.EventHandler(this.Update_poly_Click);
            this.BTN_Update_poly.Enter += new System.EventHandler(this.Update_poly_Enter);
            this.BTN_Update_poly.Leave += new System.EventHandler(this.Update_poly_Leave);
            this.BTN_Update_poly.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_poly_MouseDown);
            this.BTN_Update_poly.MouseEnter += new System.EventHandler(this.Update_poly_MouseEnter);
            this.BTN_Update_poly.MouseLeave += new System.EventHandler(this.Update_poly_MouseLeave);
            this.BTN_Update_poly.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Update_poly_MouseUp);
            // 
            // Cities_name_box1
            // 
            this.Cities_name_box1.Location = new System.Drawing.Point(15, 31);
            this.Cities_name_box1.MaxLength = 50;
            this.Cities_name_box1.Name = "Cities_name_box1";
            this.Cities_name_box1.Size = new System.Drawing.Size(209, 20);
            this.Cities_name_box1.TabIndex = 1;
            this.Cities_name_box1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cities_name_box1_KeyPress);
            // 
            // Cities_name1
            // 
            this.Cities_name1.AutoSize = true;
            this.Cities_name1.Location = new System.Drawing.Point(12, 12);
            this.Cities_name1.Name = "Cities_name1";
            this.Cities_name1.Size = new System.Drawing.Size(95, 13);
            this.Cities_name1.TabIndex = 0;
            this.Cities_name1.Text = "Название города";
            // 
            // redaktirovanie_check_for_panel
            // 
            this.redaktirovanie_check_for_panel.AutoSize = true;
            this.redaktirovanie_check_for_panel.Location = new System.Drawing.Point(501, 79);
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
            this.Dobavlenie_check_for_panel.Location = new System.Drawing.Point(365, 79);
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
            this.now_id_box.Location = new System.Drawing.Point(283, 17);
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
            this.button1.Location = new System.Drawing.Point(365, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "\r\n";
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
            // Cities
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.now_id_box);
            this.Controls.Add(this.Panel_with_update);
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
            this.Controls.Add(this.Cities_grid);
            this.Controls.Add(this.Sort_box);
            this.Controls.Add(this.Panel_with_ADD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(639, 625);
            this.MinimumSize = new System.Drawing.Size(639, 625);
            this.Name = "Cities";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Города";
            this.Load += new System.EventHandler(this.The_passengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cities_grid)).EndInit();
            this.Panel_with_ADD.ResumeLayout(false);
            this.Panel_with_ADD.PerformLayout();
            this.Panel_with_update.ResumeLayout(false);
            this.Panel_with_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.DataGridView Cities_grid;
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
        private System.Windows.Forms.TextBox Cities_name_box;
        private System.Windows.Forms.Label Cities_name;
        private System.Windows.Forms.Panel Panel_with_update;
        private System.Windows.Forms.TextBox Cities_name_box1;
        private System.Windows.Forms.Label Cities_name1;
        private System.Windows.Forms.Button BTN_Update_poly;
        private System.Windows.Forms.RadioButton redaktirovanie_check_for_panel;
        private System.Windows.Forms.RadioButton Dobavlenie_check_for_panel;
        private System.Windows.Forms.TextBox now_id_box;
        private System.Windows.Forms.Button button1;
    }
}