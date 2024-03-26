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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_bed_Sua = new System.Windows.Forms.ComboBox();
            this.txt_room_type_Sua = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_price_Sua = new System.Windows.Forms.TextBox();
            this.txt_roomno_Sua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_Xoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_room = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_rooms = new System.Windows.Forms.DataGridView();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet = new GUI.QuanLyKhachSanDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bed = new System.Windows.Forms.ComboBox();
            this.txt_room_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomsTableAdapter = new GUI.QuanLyKhachSanDataSetTableAdapters.roomsTableAdapter();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(155, 217);
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
            this.groupBox3.Controls.Add(this.txt_bed_Sua);
            this.groupBox3.Controls.Add(this.txt_room_type_Sua);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_price_Sua);
            this.groupBox3.Controls.Add(this.txt_roomno_Sua);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(1275, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 442);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa";
            // 
            // txt_bed_Sua
            // 
            this.txt_bed_Sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed_Sua.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Queen"});
            this.txt_bed_Sua.Location = new System.Drawing.Point(155, 98);
            this.txt_bed_Sua.Name = "txt_bed_Sua";
            this.txt_bed_Sua.Size = new System.Drawing.Size(203, 28);
            this.txt_bed_Sua.TabIndex = 17;
            // 
            // txt_room_type_Sua
            // 
            this.txt_room_type_Sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_type_Sua.Items.AddRange(new object[] {
            "Ac",
            "Non Ac"});
            this.txt_room_type_Sua.Location = new System.Drawing.Point(155, 57);
            this.txt_room_type_Sua.Name = "txt_room_type_Sua";
            this.txt_room_type_Sua.Size = new System.Drawing.Size(203, 28);
            this.txt_room_type_Sua.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Loại Giường:";
            // 
            // txt_price_Sua
            // 
            this.txt_price_Sua.Location = new System.Drawing.Point(155, 134);
            this.txt_price_Sua.Name = "txt_price_Sua";
            this.txt_price_Sua.Size = new System.Drawing.Size(203, 26);
            this.txt_price_Sua.TabIndex = 14;
            // 
            // txt_roomno_Sua
            // 
            this.txt_roomno_Sua.Location = new System.Drawing.Point(155, 24);
            this.txt_roomno_Sua.Name = "txt_roomno_Sua";
            this.txt_roomno_Sua.Size = new System.Drawing.Size(203, 26);
            this.txt_roomno_Sua.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Đơn giá(VNĐ):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Loại Phòng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Số phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.txt_Xoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(741, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 436);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(149, 203);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 32);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_Xoa
            // 
            this.txt_Xoa.Location = new System.Drawing.Point(128, 26);
            this.txt_Xoa.Name = "txt_Xoa";
            this.txt_Xoa.Size = new System.Drawing.Size(219, 26);
            this.txt_Xoa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xóa RoomID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phòng:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btn_add_room
            // 
            this.btn_add_room.Location = new System.Drawing.Point(150, 203);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(103, 32);
            this.btn_add_room.TabIndex = 5;
            this.btn_add_room.Text = "Thêm";
            this.btn_add_room.UseVisualStyleBackColor = true;
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(138, 139);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(203, 26);
            this.txt_price.TabIndex = 2;
            // 
            // txt_room_no
            // 
            this.txt_room_no.Location = new System.Drawing.Point(138, 29);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.Size = new System.Drawing.Size(203, 26);
            this.txt_room_no.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá(VNĐ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại Phòng:";
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToAddRows = false;
            this.dgv_rooms.AllowUserToDeleteRows = false;
            this.dgv_rooms.AutoGenerateColumns = false;
            this.dgv_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomidDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.bedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.bookedDataGridViewTextBoxColumn});
            this.dgv_rooms.DataSource = this.roomsBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rooms.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_rooms.Location = new System.Drawing.Point(128, 66);
            this.dgv_rooms.MultiSelect = false;
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_rooms.RowHeadersWidth = 51;
            this.dgv_rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rooms.Size = new System.Drawing.Size(1693, 241);
            this.dgv_rooms.TabIndex = 11;
            this.dgv_rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rooms_CellClick);
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
            this.label5.Location = new System.Drawing.Point(916, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "QUẢN LÝ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_bed);
            this.groupBox1.Controls.Add(this.txt_room_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_add_room);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_room_no);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(182, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 425);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm";
            // 
            // txt_bed
            // 
            this.txt_bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Queen"});
            this.txt_bed.Location = new System.Drawing.Point(138, 103);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.Size = new System.Drawing.Size(203, 28);
            this.txt_bed.TabIndex = 9;
            // 
            // txt_room_type
            // 
            this.txt_room_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_type.Items.AddRange(new object[] {
            "Ac",
            "Non Ac"});
            this.txt_room_type.Location = new System.Drawing.Point(138, 62);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.Size = new System.Drawing.Size(203, 28);
            this.txt_room_type.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại Giường:";
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "roomid";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "roomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedDataGridViewTextBoxColumn
            // 
            this.bedDataGridViewTextBoxColumn.DataPropertyName = "bed";
            this.bedDataGridViewTextBoxColumn.HeaderText = "Bed";
            this.bedDataGridViewTextBoxColumn.Name = "bedDataGridViewTextBoxColumn";
            this.bedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedDataGridViewTextBoxColumn
            // 
            this.bookedDataGridViewTextBoxColumn.DataPropertyName = "booked";
            this.bookedDataGridViewTextBoxColumn.HeaderText = "Booked";
            this.bookedDataGridViewTextBoxColumn.Name = "bookedDataGridViewTextBoxColumn";
            this.bookedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_rooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(2000, 1200);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_rooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_room;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private GUI.QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private GUI.QuanLyKhachSanDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_bed;
        private System.Windows.Forms.ComboBox txt_room_type;
        private System.Windows.Forms.ComboBox txt_bed_Sua;
        private System.Windows.Forms.ComboBox txt_room_type_Sua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_price_Sua;
        private System.Windows.Forms.TextBox txt_roomno_Sua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedDataGridViewTextBoxColumn;
    }
}
