namespace BLL.All_User_Control
{
    partial class UC_AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_price_Sua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_roomid_Sua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_roomno_Sua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bed_Sua = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_room_type_Sua = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Xoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet = new GUI.QuanLyKhachSanDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_room = new System.Windows.Forms.Button();
            this.txt_bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_room_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_room_no = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomsTableAdapter = new GUI.QuanLyKhachSanDataSetTableAdapters.roomsTableAdapter();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.dgv_rooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_search_room = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_group_by = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.notifyIcon_add_success = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Location = new System.Drawing.Point(255, 284);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 32);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txt_price_Sua);
            this.groupBox3.Controls.Add(this.txt_roomid_Sua);
            this.groupBox3.Controls.Add(this.txt_roomno_Sua);
            this.groupBox3.Controls.Add(this.txt_bed_Sua);
            this.groupBox3.Controls.Add(this.txt_room_type_Sua);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(1279, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 442);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa";
            // 
            // txt_price_Sua
            // 
            this.txt_price_Sua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price_Sua.DefaultText = "";
            this.txt_price_Sua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price_Sua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price_Sua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price_Sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_price_Sua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price_Sua.Location = new System.Drawing.Point(154, 197);
            this.txt_price_Sua.Name = "txt_price_Sua";
            this.txt_price_Sua.PasswordChar = '\0';
            this.txt_price_Sua.PlaceholderText = "";
            this.txt_price_Sua.SelectedText = "";
            this.txt_price_Sua.Size = new System.Drawing.Size(203, 36);
            this.txt_price_Sua.TabIndex = 21;
            // 
            // txt_roomid_Sua
            // 
            this.txt_roomid_Sua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_roomid_Sua.DefaultText = "";
            this.txt_roomid_Sua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_roomid_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_roomid_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_roomid_Sua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_roomid_Sua.Enabled = false;
            this.txt_roomid_Sua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomid_Sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_roomid_Sua.ForeColor = System.Drawing.Color.White;
            this.txt_roomid_Sua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomid_Sua.Location = new System.Drawing.Point(154, 30);
            this.txt_roomid_Sua.Name = "txt_roomid_Sua";
            this.txt_roomid_Sua.PasswordChar = '\0';
            this.txt_roomid_Sua.PlaceholderText = "";
            this.txt_roomid_Sua.SelectedText = "";
            this.txt_roomid_Sua.Size = new System.Drawing.Size(203, 36);
            this.txt_roomid_Sua.TabIndex = 6;
            // 
            // txt_roomno_Sua
            // 
            this.txt_roomno_Sua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_roomno_Sua.DefaultText = "";
            this.txt_roomno_Sua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_roomno_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_roomno_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_roomno_Sua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_roomno_Sua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomno_Sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_roomno_Sua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomno_Sua.Location = new System.Drawing.Point(154, 72);
            this.txt_roomno_Sua.Name = "txt_roomno_Sua";
            this.txt_roomno_Sua.PasswordChar = '\0';
            this.txt_roomno_Sua.PlaceholderText = "";
            this.txt_roomno_Sua.SelectedText = "";
            this.txt_roomno_Sua.Size = new System.Drawing.Size(203, 36);
            this.txt_roomno_Sua.TabIndex = 7;
            // 
            // txt_bed_Sua
            // 
            this.txt_bed_Sua.BackColor = System.Drawing.Color.Transparent;
            this.txt_bed_Sua.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_bed_Sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed_Sua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed_Sua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed_Sua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_bed_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_bed_Sua.ItemHeight = 30;
            this.txt_bed_Sua.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Queen"});
            this.txt_bed_Sua.Location = new System.Drawing.Point(154, 155);
            this.txt_bed_Sua.Name = "txt_bed_Sua";
            this.txt_bed_Sua.Size = new System.Drawing.Size(203, 36);
            this.txt_bed_Sua.TabIndex = 9;
            // 
            // txt_room_type_Sua
            // 
            this.txt_room_type_Sua.BackColor = System.Drawing.Color.Transparent;
            this.txt_room_type_Sua.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_room_type_Sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_type_Sua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type_Sua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type_Sua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_room_type_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_room_type_Sua.ItemHeight = 30;
            this.txt_room_type_Sua.Items.AddRange(new object[] {
            "Ac",
            "Non Ac"});
            this.txt_room_type_Sua.Location = new System.Drawing.Point(154, 114);
            this.txt_room_type_Sua.Name = "txt_room_type_Sua";
            this.txt_room_type_Sua.Size = new System.Drawing.Size(203, 36);
            this.txt_room_type_Sua.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Loại Giường:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Đơn giá(VNĐ):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID Phòng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 12;
            this.label12.Text = "Loại Phòng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Số phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Xoa);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(745, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 436);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa";
            // 
            // txt_Xoa
            // 
            this.txt_Xoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Xoa.DefaultText = "";
            this.txt_Xoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Xoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Xoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Xoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Xoa.Location = new System.Drawing.Point(144, 30);
            this.txt_Xoa.Name = "txt_Xoa";
            this.txt_Xoa.PasswordChar = '\0';
            this.txt_Xoa.PlaceholderText = "";
            this.txt_Xoa.SelectedText = "";
            this.txt_Xoa.Size = new System.Drawing.Size(203, 36);
            this.txt_Xoa.TabIndex = 5;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Location = new System.Drawing.Point(265, 284);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 32);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xóa RoomID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá(VNĐ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại Phòng:";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(777, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "QUẢN LÝ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_add_room);
            this.groupBox1.Controls.Add(this.txt_bed);
            this.groupBox1.Controls.Add(this.txt_room_type);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_room_no);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(186, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 425);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm";
            // 
            // btn_add_room
            // 
            this.btn_add_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_room.Location = new System.Drawing.Point(259, 284);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(82, 32);
            this.btn_add_room.TabIndex = 20;
            this.btn_add_room.Text = "Thêm";
            this.btn_add_room.UseVisualStyleBackColor = true;
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // txt_bed
            // 
            this.txt_bed.BackColor = System.Drawing.Color.Transparent;
            this.txt_bed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_bed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_bed.ItemHeight = 30;
            this.txt_bed.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Queen"});
            this.txt_bed.Location = new System.Drawing.Point(138, 113);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.Size = new System.Drawing.Size(203, 36);
            this.txt_bed.TabIndex = 3;
            // 
            // txt_room_type
            // 
            this.txt_room_type.BackColor = System.Drawing.Color.Transparent;
            this.txt_room_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_room_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_room_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_room_type.ItemHeight = 30;
            this.txt_room_type.Items.AddRange(new object[] {
            "Ac",
            "Non Ac"});
            this.txt_room_type.Location = new System.Drawing.Point(138, 72);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.Size = new System.Drawing.Size(203, 36);
            this.txt_room_type.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Location = new System.Drawing.Point(138, 155);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.Size = new System.Drawing.Size(203, 36);
            this.txt_price.TabIndex = 4;
            // 
            // txt_room_no
            // 
            this.txt_room_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_room_no.DefaultText = "";
            this.txt_room_no.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_room_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_room_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_room_no.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_room_no.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_no.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_room_no.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_no.Location = new System.Drawing.Point(138, 30);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.PasswordChar = '\0';
            this.txt_room_no.PlaceholderText = "";
            this.txt_room_no.SelectedText = "";
            this.txt_room_no.Size = new System.Drawing.Size(203, 36);
            this.txt_room_no.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại Giường:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phòng:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToAddRows = false;
            this.dgv_rooms.AllowUserToDeleteRows = false;
            this.dgv_rooms.AllowUserToResizeColumns = false;
            this.dgv_rooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rooms.ColumnHeadersHeight = 40;
            this.dgv_rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.Location = new System.Drawing.Point(98, 100);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.ReadOnly = true;
            this.dgv_rooms.RowHeadersVisible = false;
            this.dgv_rooms.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.RowTemplate.Height = 36;
            this.dgv_rooms.RowTemplate.ReadOnly = true;
            this.dgv_rooms.Size = new System.Drawing.Size(1693, 241);
            this.dgv_rooms.TabIndex = 0;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.dgv_rooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_rooms.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_rooms.ThemeStyle.ReadOnly = true;
            this.dgv_rooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_rooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_rooms.ThemeStyle.RowsStyle.Height = 36;
            this.dgv_rooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rooms_CellClick);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(462, 64);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 22);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Tìm kiếm";
            // 
            // txt_search_room
            // 
            this.txt_search_room.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_room.DefaultText = "";
            this.txt_search_room.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_room.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_room.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_search_room.ForeColor = System.Drawing.Color.Black;
            this.txt_search_room.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_room.Location = new System.Drawing.Point(98, 57);
            this.txt_search_room.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search_room.Name = "txt_search_room";
            this.txt_search_room.PasswordChar = '\0';
            this.txt_search_room.PlaceholderText = "Nhập tên phòng";
            this.txt_search_room.SelectedText = "";
            this.txt_search_room.Size = new System.Drawing.Size(358, 36);
            this.txt_search_room.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_search_room.TabIndex = 22;
            this.txt_search_room.TextChanged += new System.EventHandler(this.txt_search_room_TextChanged);
            // 
            // cb_group_by
            // 
            this.cb_group_by.BackColor = System.Drawing.Color.Transparent;
            this.cb_group_by.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_group_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_group_by.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_group_by.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_group_by.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_group_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_group_by.ItemHeight = 30;
            this.cb_group_by.Items.AddRange(new object[] {
            "All",
            "Room Type",
            "Bed Type",
            "State"});
            this.cb_group_by.Location = new System.Drawing.Point(967, 57);
            this.cb_group_by.Name = "cb_group_by";
            this.cb_group_by.Size = new System.Drawing.Size(358, 36);
            this.cb_group_by.TabIndex = 25;
            this.cb_group_by.SelectedIndexChanged += new System.EventHandler(this.cb_group_by_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(883, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(78, 22);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Nhóm theo";
            // 
            // cb_filter
            // 
            this.cb_filter.BackColor = System.Drawing.Color.Transparent;
            this.cb_filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_filter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_filter.ItemHeight = 30;
            this.cb_filter.Items.AddRange(new object[] {
            "All",
            "Room Type: Ac",
            "Room Type: Non Ac",
            "Bed Type: Don",
            "Bed Type: Doi",
            "Bed Type: Queen",
            "State: Booked",
            "State: Empty"});
            this.cb_filter.Location = new System.Drawing.Point(1461, 57);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(330, 36);
            this.cb_filter.TabIndex = 27;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(1410, 64);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(45, 22);
            this.guna2HtmlLabel3.TabIndex = 26;
            this.guna2HtmlLabel3.Text = "Bộ lọc";
            // 
            // notifyIcon_add_success
            // 
            this.notifyIcon_add_success.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon_add_success.BalloonTipTitle = "Thông báo";
            this.notifyIcon_add_success.Text = "Thêm phòng mới thành công";
            this.notifyIcon_add_success.Visible = true;
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cb_group_by);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txt_search_room);
            this.Controls.Add(this.dgv_rooms);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private GUI.QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private GUI.QuanLyKhachSanDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txt_room_no;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ComboBox txt_room_type;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2ComboBox txt_bed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_room;
        private Guna.UI2.WinForms.Guna2TextBox txt_roomno_Sua;
        private Guna.UI2.WinForms.Guna2TextBox txt_price_Sua;
        private Guna.UI2.WinForms.Guna2ComboBox txt_bed_Sua;
        private Guna.UI2.WinForms.Guna2ComboBox txt_room_type_Sua;
        private Guna.UI2.WinForms.Guna2TextBox txt_Xoa;
        private Guna.UI2.WinForms.Guna2TextBox txt_roomid_Sua;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_rooms;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_search_room;
        private Guna.UI2.WinForms.Guna2ComboBox cb_group_by;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_filter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.NotifyIcon notifyIcon_add_success;
    }
}
