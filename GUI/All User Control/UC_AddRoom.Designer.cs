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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_room_no = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_room_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_add_room = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgv_rooms = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1118, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Phòng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.txt_room_no.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.ForeColor = System.Drawing.Color.Black;
            this.txt_room_no.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_no.Location = new System.Drawing.Point(1122, 157);
            this.txt_room_no.Margin = new System.Windows.Forms.Padding(4);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.PasswordChar = '\0';
            this.txt_room_no.PlaceholderText = "";
            this.txt_room_no.SelectedText = "";
            this.txt_room_no.Size = new System.Drawing.Size(649, 61);
            this.txt_room_no.TabIndex = 4;
            // 
            // txt_room_type
            // 
            this.txt_room_type.BackColor = System.Drawing.Color.Transparent;
            this.txt_room_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_room_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_room_type.ForeColor = System.Drawing.Color.Black;
            this.txt_room_type.ItemHeight = 30;
            this.txt_room_type.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.txt_room_type.Location = new System.Drawing.Point(1122, 331);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.Size = new System.Drawing.Size(649, 36);
            this.txt_room_type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1118, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1118, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Giường";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_bed
            // 
            this.txt_bed.BackColor = System.Drawing.Color.Transparent;
            this.txt_bed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_bed.ForeColor = System.Drawing.Color.Black;
            this.txt_bed.ItemHeight = 30;
            this.txt_bed.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Ba"});
            this.txt_bed.Location = new System.Drawing.Point(1122, 479);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.Size = new System.Drawing.Size(649, 36);
            this.txt_bed.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1118, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá Tiền";
            this.label5.Click += new System.EventHandler(this.label2_Click);
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
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Black;
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Location = new System.Drawing.Point(1122, 617);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.Size = new System.Drawing.Size(649, 61);
            this.txt_price.TabIndex = 4;
            // 
            // btn_add_room
            // 
            this.btn_add_room.BorderRadius = 18;
            this.btn_add_room.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_add_room.BorderThickness = 1;
            this.btn_add_room.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_add_room.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_add_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_room.FillColor = System.Drawing.Color.White;
            this.btn_add_room.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_room.ForeColor = System.Drawing.Color.Black;
            this.btn_add_room.Location = new System.Drawing.Point(1558, 707);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(213, 56);
            this.btn_add_room.TabIndex = 6;
            this.btn_add_room.Text = "Thêm phòng";
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToResizeColumns = false;
            this.dgv_rooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.Location = new System.Drawing.Point(64, 114);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.ReadOnly = true;
            this.dgv_rooms.RowHeadersVisible = false;
            this.dgv_rooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_rooms.Size = new System.Drawing.Size(864, 564);
            this.dgv_rooms.TabIndex = 7;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rooms.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_rooms.ThemeStyle.ReadOnly = true;
            this.dgv_rooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_rooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_rooms.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_rooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_rooms);
            this.Controls.Add(this.btn_add_room);
            this.Controls.Add(this.txt_bed);
            this.Controls.Add(this.txt_room_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(4630, 1864);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_room_no;
        private Guna.UI2.WinForms.Guna2ComboBox txt_room_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txt_bed;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2Button btn_add_room;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_rooms;
    }
}
