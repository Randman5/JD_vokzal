namespace JD_Vokzal
{
    partial class Tickets_purchased
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets_purchased));
            this.The_Passengers_grid = new System.Windows.Forms.DataGridView();
            this.Prev_pos_grid = new System.Windows.Forms.Button();
            this.next_pos_grid = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_back_now = new System.Windows.Forms.Button();
            this.Search_box = new System.Windows.Forms.TextBox();
            this.Sort_box = new System.Windows.Forms.ComboBox();
            this.First_row = new System.Windows.Forms.Button();
            this.BTN_last_row = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.now_id_box = new System.Windows.Forms.TextBox();
            this.Request_picker = new System.Windows.Forms.DateTimePicker();
            this.Panel_with_ADD = new System.Windows.Forms.Panel();
            this.BTN_add_in_table = new System.Windows.Forms.Button();
            this.Type_wagons_Box = new System.Windows.Forms.TextBox();
            this.Number_place_Box = new System.Windows.Forms.TextBox();
            this.Number_wagons_Box = new System.Windows.Forms.TextBox();
            this.Type_wagons = new System.Windows.Forms.Label();
            this.Number_train_Box = new System.Windows.Forms.TextBox();
            this.Number_place = new System.Windows.Forms.Label();
            this.Vremya_pribitiya_Box = new System.Windows.Forms.TextBox();
            this.Number_wagons = new System.Windows.Forms.Label();
            this.Vremya_otbitya_box = new System.Windows.Forms.TextBox();
            this.Number_train = new System.Windows.Forms.Label();
            this.Vremya_pribitiya = new System.Windows.Forms.Label();
            this.Vremya_otbitya = new System.Windows.Forms.Label();
            this.mesto_pribitya_Box = new System.Windows.Forms.TextBox();
            this.Mesto_otpravleniya_Box = new System.Windows.Forms.TextBox();
            this.mesto_pribitya = new System.Windows.Forms.Label();
            this.Mesto_otpravleniya = new System.Windows.Forms.Label();
            this.Data_otpravleniya_Box = new System.Windows.Forms.TextBox();
            this.Data_otpravleniya = new System.Windows.Forms.Label();
            this.Number_Box = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.Seryia_Box = new System.Windows.Forms.TextBox();
            this.Seryia = new System.Windows.Forms.Label();
            this.Otchestvo_box = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.Label();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Name_L = new System.Windows.Forms.Label();
            this.Familya_box = new System.Windows.Forms.TextBox();
            this.Familya = new System.Windows.Forms.Label();
            this.Chenge_passengers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.The_Passengers_grid)).BeginInit();
            this.Panel_with_ADD.SuspendLayout();
            this.SuspendLayout();
            // 
            // The_Passengers_grid
            // 
            this.The_Passengers_grid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.The_Passengers_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.The_Passengers_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.The_Passengers_grid.Location = new System.Drawing.Point(12, 12);
            this.The_Passengers_grid.Name = "The_Passengers_grid";
            this.The_Passengers_grid.ReadOnly = true;
            this.The_Passengers_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.The_Passengers_grid.Size = new System.Drawing.Size(765, 562);
            this.The_Passengers_grid.TabIndex = 0;
            this.The_Passengers_grid.CurrentCellChanged += new System.EventHandler(this.The_Passengers_grid_CurrentCellChanged);
            // 
            // Prev_pos_grid
            // 
            this.Prev_pos_grid.BackgroundImage = global::JD_Vokzal.Properties.Resources.Вверх1;
            this.Prev_pos_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev_pos_grid.Location = new System.Drawing.Point(783, 79);
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
            this.next_pos_grid.Location = new System.Drawing.Point(783, 144);
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
            this.BTN_Search.Location = new System.Drawing.Point(1169, 46);
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
            this.BTN_back_now.Location = new System.Drawing.Point(783, 112);
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
            this.Search_box.Location = new System.Drawing.Point(954, 46);
            this.Search_box.Name = "Search_box";
            this.Search_box.ReadOnly = true;
            this.Search_box.Size = new System.Drawing.Size(216, 22);
            this.Search_box.TabIndex = 7;
            this.Search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_box_KeyDown);
            // 
            // Sort_box
            // 
            this.Sort_box.FormattingEnabled = true;
            this.Sort_box.Items.AddRange(new object[] {
            "Код клиента",
            "Дата",
            "Код клиента и дата"});
            this.Sort_box.Location = new System.Drawing.Point(921, 67);
            this.Sort_box.Name = "Sort_box";
            this.Sort_box.Size = new System.Drawing.Size(286, 21);
            this.Sort_box.TabIndex = 10;
            this.Sort_box.Text = "Выберите категорию сортировки";
            this.Sort_box.SelectedIndexChanged += new System.EventHandler(this.Sort_box_SelectedIndexChanged);
            // 
            // First_row
            // 
            this.First_row.BackgroundImage = global::JD_Vokzal.Properties.Resources.ПерваяСтрока1;
            this.First_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.First_row.Location = new System.Drawing.Point(783, 46);
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
            this.BTN_last_row.Location = new System.Drawing.Point(783, 177);
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
            this.BTN_delete.Location = new System.Drawing.Point(783, 210);
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
            // now_id_box
            // 
            this.now_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.now_id_box.Location = new System.Drawing.Point(783, 20);
            this.now_id_box.Name = "now_id_box";
            this.now_id_box.Size = new System.Drawing.Size(50, 20);
            this.now_id_box.TabIndex = 13;
            this.now_id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.now_id_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.now_id_box_KeyDown);
            // 
            // Request_picker
            // 
            this.Request_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Request_picker.Location = new System.Drawing.Point(921, 46);
            this.Request_picker.Name = "Request_picker";
            this.Request_picker.Size = new System.Drawing.Size(249, 22);
            this.Request_picker.TabIndex = 14;
            this.Request_picker.Visible = false;
            // 
            // Panel_with_ADD
            // 
            this.Panel_with_ADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_with_ADD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_with_ADD.Controls.Add(this.BTN_add_in_table);
            this.Panel_with_ADD.Controls.Add(this.Type_wagons_Box);
            this.Panel_with_ADD.Controls.Add(this.Number_place_Box);
            this.Panel_with_ADD.Controls.Add(this.Number_wagons_Box);
            this.Panel_with_ADD.Controls.Add(this.Type_wagons);
            this.Panel_with_ADD.Controls.Add(this.Number_train_Box);
            this.Panel_with_ADD.Controls.Add(this.Number_place);
            this.Panel_with_ADD.Controls.Add(this.Vremya_pribitiya_Box);
            this.Panel_with_ADD.Controls.Add(this.Number_wagons);
            this.Panel_with_ADD.Controls.Add(this.Vremya_otbitya_box);
            this.Panel_with_ADD.Controls.Add(this.Number_train);
            this.Panel_with_ADD.Controls.Add(this.Vremya_pribitiya);
            this.Panel_with_ADD.Controls.Add(this.Vremya_otbitya);
            this.Panel_with_ADD.Controls.Add(this.mesto_pribitya_Box);
            this.Panel_with_ADD.Controls.Add(this.Mesto_otpravleniya_Box);
            this.Panel_with_ADD.Controls.Add(this.mesto_pribitya);
            this.Panel_with_ADD.Controls.Add(this.Mesto_otpravleniya);
            this.Panel_with_ADD.Controls.Add(this.Data_otpravleniya_Box);
            this.Panel_with_ADD.Controls.Add(this.Data_otpravleniya);
            this.Panel_with_ADD.Controls.Add(this.Number_Box);
            this.Panel_with_ADD.Controls.Add(this.Number);
            this.Panel_with_ADD.Controls.Add(this.Seryia_Box);
            this.Panel_with_ADD.Controls.Add(this.Seryia);
            this.Panel_with_ADD.Controls.Add(this.Otchestvo_box);
            this.Panel_with_ADD.Controls.Add(this.Otchestvo);
            this.Panel_with_ADD.Controls.Add(this.Name_box);
            this.Panel_with_ADD.Controls.Add(this.Name_L);
            this.Panel_with_ADD.Controls.Add(this.Familya_box);
            this.Panel_with_ADD.Controls.Add(this.Familya);
            this.Panel_with_ADD.Location = new System.Drawing.Point(835, 112);
            this.Panel_with_ADD.Name = "Panel_with_ADD";
            this.Panel_with_ADD.Size = new System.Drawing.Size(390, 453);
            this.Panel_with_ADD.TabIndex = 15;
            // 
            // BTN_add_in_table
            // 
            this.BTN_add_in_table.BackgroundImage = global::JD_Vokzal.Properties.Resources.Повторнаяпечать1;
            this.BTN_add_in_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_add_in_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add_in_table.Location = new System.Drawing.Point(240, 31);
            this.BTN_add_in_table.Name = "BTN_add_in_table";
            this.BTN_add_in_table.Size = new System.Drawing.Size(139, 216);
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
            // Type_wagons_Box
            // 
            this.Type_wagons_Box.Location = new System.Drawing.Point(245, 410);
            this.Type_wagons_Box.Name = "Type_wagons_Box";
            this.Type_wagons_Box.ReadOnly = true;
            this.Type_wagons_Box.Size = new System.Drawing.Size(134, 20);
            this.Type_wagons_Box.TabIndex = 5;
            // 
            // Number_place_Box
            // 
            this.Number_place_Box.Location = new System.Drawing.Point(245, 362);
            this.Number_place_Box.Name = "Number_place_Box";
            this.Number_place_Box.ReadOnly = true;
            this.Number_place_Box.Size = new System.Drawing.Size(134, 20);
            this.Number_place_Box.TabIndex = 5;
            // 
            // Number_wagons_Box
            // 
            this.Number_wagons_Box.Location = new System.Drawing.Point(245, 319);
            this.Number_wagons_Box.Name = "Number_wagons_Box";
            this.Number_wagons_Box.ReadOnly = true;
            this.Number_wagons_Box.Size = new System.Drawing.Size(134, 20);
            this.Number_wagons_Box.TabIndex = 5;
            // 
            // Type_wagons
            // 
            this.Type_wagons.AutoSize = true;
            this.Type_wagons.Location = new System.Drawing.Point(242, 394);
            this.Type_wagons.Name = "Type_wagons";
            this.Type_wagons.Size = new System.Drawing.Size(64, 13);
            this.Type_wagons.TabIndex = 0;
            this.Type_wagons.Text = "Тип вагона";
            // 
            // Number_train_Box
            // 
            this.Number_train_Box.Location = new System.Drawing.Point(245, 271);
            this.Number_train_Box.Name = "Number_train_Box";
            this.Number_train_Box.ReadOnly = true;
            this.Number_train_Box.Size = new System.Drawing.Size(134, 20);
            this.Number_train_Box.TabIndex = 5;
            // 
            // Number_place
            // 
            this.Number_place.AutoSize = true;
            this.Number_place.Location = new System.Drawing.Point(242, 346);
            this.Number_place.Name = "Number_place";
            this.Number_place.Size = new System.Drawing.Size(53, 13);
            this.Number_place.TabIndex = 0;
            this.Number_place.Text = "Место №";
            // 
            // Vremya_pribitiya_Box
            // 
            this.Vremya_pribitiya_Box.Location = new System.Drawing.Point(15, 410);
            this.Vremya_pribitiya_Box.Name = "Vremya_pribitiya_Box";
            this.Vremya_pribitiya_Box.ReadOnly = true;
            this.Vremya_pribitiya_Box.Size = new System.Drawing.Size(209, 20);
            this.Vremya_pribitiya_Box.TabIndex = 5;
            // 
            // Number_wagons
            // 
            this.Number_wagons.AutoSize = true;
            this.Number_wagons.Location = new System.Drawing.Point(242, 303);
            this.Number_wagons.Name = "Number_wagons";
            this.Number_wagons.Size = new System.Drawing.Size(51, 13);
            this.Number_wagons.TabIndex = 0;
            this.Number_wagons.Text = "Вагон №";
            // 
            // Vremya_otbitya_box
            // 
            this.Vremya_otbitya_box.Location = new System.Drawing.Point(15, 319);
            this.Vremya_otbitya_box.Name = "Vremya_otbitya_box";
            this.Vremya_otbitya_box.ReadOnly = true;
            this.Vremya_otbitya_box.Size = new System.Drawing.Size(209, 20);
            this.Vremya_otbitya_box.TabIndex = 5;
            // 
            // Number_train
            // 
            this.Number_train.AutoSize = true;
            this.Number_train.Location = new System.Drawing.Point(242, 255);
            this.Number_train.Name = "Number_train";
            this.Number_train.Size = new System.Drawing.Size(53, 13);
            this.Number_train.TabIndex = 0;
            this.Number_train.Text = "Поезд №";
            // 
            // Vremya_pribitiya
            // 
            this.Vremya_pribitiya.AutoSize = true;
            this.Vremya_pribitiya.Location = new System.Drawing.Point(12, 394);
            this.Vremya_pribitiya.Name = "Vremya_pribitiya";
            this.Vremya_pribitiya.Size = new System.Drawing.Size(92, 13);
            this.Vremya_pribitiya.TabIndex = 0;
            this.Vremya_pribitiya.Text = "Время прибытия";
            // 
            // Vremya_otbitya
            // 
            this.Vremya_otbitya.AutoSize = true;
            this.Vremya_otbitya.Location = new System.Drawing.Point(12, 303);
            this.Vremya_otbitya.Name = "Vremya_otbitya";
            this.Vremya_otbitya.Size = new System.Drawing.Size(108, 13);
            this.Vremya_otbitya.TabIndex = 0;
            this.Vremya_otbitya.Text = "Время отправления";
            // 
            // mesto_pribitya_Box
            // 
            this.mesto_pribitya_Box.Location = new System.Drawing.Point(15, 362);
            this.mesto_pribitya_Box.Name = "mesto_pribitya_Box";
            this.mesto_pribitya_Box.ReadOnly = true;
            this.mesto_pribitya_Box.Size = new System.Drawing.Size(209, 20);
            this.mesto_pribitya_Box.TabIndex = 5;
            // 
            // Mesto_otpravleniya_Box
            // 
            this.Mesto_otpravleniya_Box.Location = new System.Drawing.Point(15, 271);
            this.Mesto_otpravleniya_Box.Name = "Mesto_otpravleniya_Box";
            this.Mesto_otpravleniya_Box.ReadOnly = true;
            this.Mesto_otpravleniya_Box.Size = new System.Drawing.Size(209, 20);
            this.Mesto_otpravleniya_Box.TabIndex = 5;
            // 
            // mesto_pribitya
            // 
            this.mesto_pribitya.AutoSize = true;
            this.mesto_pribitya.Location = new System.Drawing.Point(12, 346);
            this.mesto_pribitya.Name = "mesto_pribitya";
            this.mesto_pribitya.Size = new System.Drawing.Size(91, 13);
            this.mesto_pribitya.TabIndex = 0;
            this.mesto_pribitya.Text = "Место прибытия";
            // 
            // Mesto_otpravleniya
            // 
            this.Mesto_otpravleniya.AutoSize = true;
            this.Mesto_otpravleniya.Location = new System.Drawing.Point(12, 255);
            this.Mesto_otpravleniya.Name = "Mesto_otpravleniya";
            this.Mesto_otpravleniya.Size = new System.Drawing.Size(107, 13);
            this.Mesto_otpravleniya.TabIndex = 0;
            this.Mesto_otpravleniya.Text = "Место отправления";
            // 
            // Data_otpravleniya_Box
            // 
            this.Data_otpravleniya_Box.Location = new System.Drawing.Point(15, 227);
            this.Data_otpravleniya_Box.Name = "Data_otpravleniya_Box";
            this.Data_otpravleniya_Box.ReadOnly = true;
            this.Data_otpravleniya_Box.Size = new System.Drawing.Size(209, 20);
            this.Data_otpravleniya_Box.TabIndex = 5;
            // 
            // Data_otpravleniya
            // 
            this.Data_otpravleniya.AutoSize = true;
            this.Data_otpravleniya.Location = new System.Drawing.Point(12, 211);
            this.Data_otpravleniya.Name = "Data_otpravleniya";
            this.Data_otpravleniya.Size = new System.Drawing.Size(101, 13);
            this.Data_otpravleniya.TabIndex = 0;
            this.Data_otpravleniya.Text = "Дата отправления";
            // 
            // Number_Box
            // 
            this.Number_Box.Location = new System.Drawing.Point(105, 179);
            this.Number_Box.Name = "Number_Box";
            this.Number_Box.ReadOnly = true;
            this.Number_Box.Size = new System.Drawing.Size(119, 20);
            this.Number_Box.TabIndex = 5;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(102, 163);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(41, 13);
            this.Number.TabIndex = 0;
            this.Number.Text = "Номер";
            // 
            // Seryia_Box
            // 
            this.Seryia_Box.Location = new System.Drawing.Point(15, 179);
            this.Seryia_Box.Name = "Seryia_Box";
            this.Seryia_Box.ReadOnly = true;
            this.Seryia_Box.Size = new System.Drawing.Size(84, 20);
            this.Seryia_Box.TabIndex = 4;
            // 
            // Seryia
            // 
            this.Seryia.AutoSize = true;
            this.Seryia.Location = new System.Drawing.Point(12, 163);
            this.Seryia.Name = "Seryia";
            this.Seryia.Size = new System.Drawing.Size(38, 13);
            this.Seryia.TabIndex = 0;
            this.Seryia.Text = "Серия";
            // 
            // Otchestvo_box
            // 
            this.Otchestvo_box.Location = new System.Drawing.Point(15, 131);
            this.Otchestvo_box.Name = "Otchestvo_box";
            this.Otchestvo_box.ReadOnly = true;
            this.Otchestvo_box.Size = new System.Drawing.Size(209, 20);
            this.Otchestvo_box.TabIndex = 3;
            // 
            // Otchestvo
            // 
            this.Otchestvo.AutoSize = true;
            this.Otchestvo.Location = new System.Drawing.Point(12, 115);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(54, 13);
            this.Otchestvo.TabIndex = 0;
            this.Otchestvo.Text = "Отчество";
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(15, 80);
            this.Name_box.Name = "Name_box";
            this.Name_box.ReadOnly = true;
            this.Name_box.Size = new System.Drawing.Size(209, 20);
            this.Name_box.TabIndex = 2;
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(12, 64);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(29, 13);
            this.Name_L.TabIndex = 0;
            this.Name_L.Text = "Имя";
            // 
            // Familya_box
            // 
            this.Familya_box.Location = new System.Drawing.Point(15, 31);
            this.Familya_box.Name = "Familya_box";
            this.Familya_box.ReadOnly = true;
            this.Familya_box.Size = new System.Drawing.Size(209, 20);
            this.Familya_box.TabIndex = 1;
            // 
            // Familya
            // 
            this.Familya.AutoSize = true;
            this.Familya.Location = new System.Drawing.Point(12, 12);
            this.Familya.Name = "Familya";
            this.Familya.Size = new System.Drawing.Size(56, 13);
            this.Familya.TabIndex = 0;
            this.Familya.Text = "Фамилия";
            // 
            // Chenge_passengers
            // 
            this.Chenge_passengers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Chenge_passengers.BackgroundImage = global::JD_Vokzal.Properties.Resources.ВыбоВпоиске1;
            this.Chenge_passengers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chenge_passengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chenge_passengers.Location = new System.Drawing.Point(921, 46);
            this.Chenge_passengers.Name = "Chenge_passengers";
            this.Chenge_passengers.Size = new System.Drawing.Size(34, 22);
            this.Chenge_passengers.TabIndex = 16;
            this.Chenge_passengers.UseVisualStyleBackColor = false;
            this.Chenge_passengers.Click += new System.EventHandler(this.Chenge_passengers_Click);
            this.Chenge_passengers.Enter += new System.EventHandler(this.Chenge_passengers_Enter);
            this.Chenge_passengers.Leave += new System.EventHandler(this.Chenge_passengers_Leave);
            this.Chenge_passengers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chenge_passengers_MouseDown);
            this.Chenge_passengers.MouseEnter += new System.EventHandler(this.Chenge_passengers_MouseEnter);
            this.Chenge_passengers.MouseLeave += new System.EventHandler(this.Chenge_passengers_MouseLeave);
            this.Chenge_passengers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Chenge_passengers_MouseUp);
            // 
            // Tickets_purchased
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1237, 586);
            this.Controls.Add(this.Chenge_passengers);
            this.Controls.Add(this.Request_picker);
            this.Controls.Add(this.Search_box);
            this.Controls.Add(this.Panel_with_ADD);
            this.Controls.Add(this.now_id_box);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_last_row);
            this.Controls.Add(this.First_row);
            this.Controls.Add(this.BTN_back_now);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.next_pos_grid);
            this.Controls.Add(this.Prev_pos_grid);
            this.Controls.Add(this.The_Passengers_grid);
            this.Controls.Add(this.Sort_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1253, 625);
            this.MinimumSize = new System.Drawing.Size(1253, 625);
            this.Name = "Tickets_purchased";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Билеты";
            this.Load += new System.EventHandler(this.The_passengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.The_Passengers_grid)).EndInit();
            this.Panel_with_ADD.ResumeLayout(false);
            this.Panel_with_ADD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.DataGridView The_Passengers_grid;
        private System.Windows.Forms.Button Prev_pos_grid;
        private System.Windows.Forms.Button next_pos_grid;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_back_now;
        private System.Windows.Forms.TextBox Search_box;
        private System.Windows.Forms.ComboBox Sort_box;
        private System.Windows.Forms.Button First_row;
        private System.Windows.Forms.Button BTN_last_row;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.TextBox now_id_box;
        private System.Windows.Forms.DateTimePicker Request_picker;
        private System.Windows.Forms.Panel Panel_with_ADD;
        private System.Windows.Forms.Button BTN_add_in_table;
        private System.Windows.Forms.TextBox Vremya_pribitiya_Box;
        private System.Windows.Forms.TextBox Vremya_otbitya_box;
        private System.Windows.Forms.Label Vremya_pribitiya;
        private System.Windows.Forms.Label Vremya_otbitya;
        private System.Windows.Forms.TextBox mesto_pribitya_Box;
        private System.Windows.Forms.TextBox Mesto_otpravleniya_Box;
        private System.Windows.Forms.Label mesto_pribitya;
        private System.Windows.Forms.Label Mesto_otpravleniya;
        private System.Windows.Forms.TextBox Data_otpravleniya_Box;
        private System.Windows.Forms.Label Data_otpravleniya;
        private System.Windows.Forms.TextBox Number_Box;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox Seryia_Box;
        private System.Windows.Forms.Label Seryia;
        private System.Windows.Forms.TextBox Otchestvo_box;
        private System.Windows.Forms.Label Otchestvo;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.TextBox Familya_box;
        private System.Windows.Forms.Label Familya;
        private System.Windows.Forms.TextBox Type_wagons_Box;
        private System.Windows.Forms.TextBox Number_place_Box;
        private System.Windows.Forms.TextBox Number_wagons_Box;
        private System.Windows.Forms.Label Type_wagons;
        private System.Windows.Forms.TextBox Number_train_Box;
        private System.Windows.Forms.Label Number_place;
        private System.Windows.Forms.Label Number_wagons;
        private System.Windows.Forms.Label Number_train;
        private System.Windows.Forms.Button Chenge_passengers;
    }
}