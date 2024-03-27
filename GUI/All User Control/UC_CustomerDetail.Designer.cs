namespace GUI.All_User_Control
{
    partial class UC_CustomerDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet1 = new GUI.QuanLyKhachSanDataSet1();
            this.customerTableAdapter = new GUI.QuanLyKhachSanDataSet1TableAdapters.customerTableAdapter();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txt_room_no_edit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_room_type_edit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_bed_type_edit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_mobile_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_address_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idproof_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dob_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_edit_customer = new System.Windows.Forms.Button();
            this.txt_gender_edit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_nationality_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id_edit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete_customer = new System.Windows.Forms.GroupBox();
            this.txt_id_delete = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cb_search = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.btn_delete_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.quanLyKhachSanDataSet1;
            // 
            // quanLyKhachSanDataSet1
            // 
            this.quanLyKhachSanDataSet1.DataSetName = "QuanLyKhachSanDataSet1";
            this.quanLyKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txt_room_no_edit);
            this.groupBox.Controls.Add(this.txt_room_type_edit);
            this.groupBox.Controls.Add(this.txt_bed_type_edit);
            this.groupBox.Controls.Add(this.txt_mobile_edit);
            this.groupBox.Controls.Add(this.txt_name_edit);
            this.groupBox.Controls.Add(this.label21);
            this.groupBox.Controls.Add(this.label20);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.txt_address_edit);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.txt_idproof_edit);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.txt_dob_edit);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.btn_edit_customer);
            this.groupBox.Controls.Add(this.txt_gender_edit);
            this.groupBox.Controls.Add(this.txt_nationality_edit);
            this.groupBox.Controls.Add(this.txt_id_edit);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(291, 370);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(813, 479);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "label";
            // 
            // txt_room_no_edit
            // 
            this.txt_room_no_edit.BackColor = System.Drawing.Color.Transparent;
            this.txt_room_no_edit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_room_no_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_no_edit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_no_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_no_edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_room_no_edit.ForeColor = System.Drawing.Color.Black;
            this.txt_room_no_edit.ItemHeight = 30;
            this.txt_room_no_edit.Location = new System.Drawing.Point(566, 196);
            this.txt_room_no_edit.Name = "txt_room_no_edit";
            this.txt_room_no_edit.Size = new System.Drawing.Size(202, 36);
            this.txt_room_no_edit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_room_no_edit.TabIndex = 33;
            // 
            // txt_room_type_edit
            // 
            this.txt_room_type_edit.BackColor = System.Drawing.Color.Transparent;
            this.txt_room_type_edit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_room_type_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_room_type_edit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_type_edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_room_type_edit.ForeColor = System.Drawing.Color.Black;
            this.txt_room_type_edit.ItemHeight = 30;
            this.txt_room_type_edit.Items.AddRange(new object[] {
            "AC",
            "Non Ac"});
            this.txt_room_type_edit.Location = new System.Drawing.Point(566, 154);
            this.txt_room_type_edit.Name = "txt_room_type_edit";
            this.txt_room_type_edit.Size = new System.Drawing.Size(202, 36);
            this.txt_room_type_edit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_room_type_edit.TabIndex = 33;
            this.txt_room_type_edit.SelectedIndexChanged += new System.EventHandler(this.txt_room_type_SelectedIndexChanged);
            // 
            // txt_bed_type_edit
            // 
            this.txt_bed_type_edit.BackColor = System.Drawing.Color.Transparent;
            this.txt_bed_type_edit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_bed_type_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed_type_edit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed_type_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed_type_edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_bed_type_edit.ForeColor = System.Drawing.Color.Black;
            this.txt_bed_type_edit.ItemHeight = 30;
            this.txt_bed_type_edit.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Queen"});
            this.txt_bed_type_edit.Location = new System.Drawing.Point(566, 112);
            this.txt_bed_type_edit.Name = "txt_bed_type_edit";
            this.txt_bed_type_edit.Size = new System.Drawing.Size(202, 36);
            this.txt_bed_type_edit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_bed_type_edit.TabIndex = 33;
            this.txt_bed_type_edit.SelectedIndexChanged += new System.EventHandler(this.txt_bed_type_edit_SelectedIndexChanged);
            // 
            // txt_mobile_edit
            // 
            this.txt_mobile_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mobile_edit.DefaultText = "";
            this.txt_mobile_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mobile_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mobile_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mobile_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mobile_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mobile_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mobile_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mobile_edit.Location = new System.Drawing.Point(138, 112);
            this.txt_mobile_edit.Name = "txt_mobile_edit";
            this.txt_mobile_edit.PasswordChar = '\0';
            this.txt_mobile_edit.PlaceholderText = "";
            this.txt_mobile_edit.SelectedText = "";
            this.txt_mobile_edit.Size = new System.Drawing.Size(203, 36);
            this.txt_mobile_edit.TabIndex = 32;
            // 
            // txt_name_edit
            // 
            this.txt_name_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name_edit.DefaultText = "";
            this.txt_name_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name_edit.Location = new System.Drawing.Point(138, 70);
            this.txt_name_edit.Name = "txt_name_edit";
            this.txt_name_edit.PasswordChar = '\0';
            this.txt_name_edit.PlaceholderText = "";
            this.txt_name_edit.SelectedText = "";
            this.txt_name_edit.Size = new System.Drawing.Size(203, 36);
            this.txt_name_edit.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.Location = new System.Drawing.Point(450, 196);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 21);
            this.label21.TabIndex = 29;
            this.label21.Text = "Số Phòng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(450, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 21);
            this.label20.TabIndex = 29;
            this.label20.Text = "Loại Phòng:";
            this.label20.Click += new System.EventHandler(this.txt_room_type_edit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(450, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Loại Giường:";
            // 
            // txt_address_edit
            // 
            this.txt_address_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address_edit.DefaultText = "";
            this.txt_address_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address_edit.Location = new System.Drawing.Point(566, 70);
            this.txt_address_edit.Name = "txt_address_edit";
            this.txt_address_edit.PasswordChar = '\0';
            this.txt_address_edit.PlaceholderText = "";
            this.txt_address_edit.SelectedText = "";
            this.txt_address_edit.Size = new System.Drawing.Size(202, 36);
            this.txt_address_edit.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(450, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Địa Chỉ:";
            // 
            // txt_idproof_edit
            // 
            this.txt_idproof_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idproof_edit.DefaultText = "";
            this.txt_idproof_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idproof_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idproof_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idproof_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idproof_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idproof_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idproof_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idproof_edit.Location = new System.Drawing.Point(566, 28);
            this.txt_idproof_edit.Name = "txt_idproof_edit";
            this.txt_idproof_edit.PasswordChar = '\0';
            this.txt_idproof_edit.PlaceholderText = "";
            this.txt_idproof_edit.SelectedText = "";
            this.txt_idproof_edit.Size = new System.Drawing.Size(202, 36);
            this.txt_idproof_edit.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(446, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "IDProof:";
            // 
            // txt_dob_edit
            // 
            this.txt_dob_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dob_edit.DefaultText = "";
            this.txt_dob_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dob_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dob_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dob_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dob_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dob_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dob_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dob_edit.Location = new System.Drawing.Point(138, 238);
            this.txt_dob_edit.Name = "txt_dob_edit";
            this.txt_dob_edit.PasswordChar = '\0';
            this.txt_dob_edit.PlaceholderText = "";
            this.txt_dob_edit.SelectedText = "";
            this.txt_dob_edit.Size = new System.Drawing.Size(203, 36);
            this.txt_dob_edit.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày Sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(22, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Giới Tính:";
            // 
            // btn_edit_customer
            // 
            this.btn_edit_customer.Location = new System.Drawing.Point(686, 425);
            this.btn_edit_customer.Name = "btn_edit_customer";
            this.btn_edit_customer.Size = new System.Drawing.Size(82, 32);
            this.btn_edit_customer.TabIndex = 20;
            this.btn_edit_customer.Text = "Sửa";
            this.btn_edit_customer.UseVisualStyleBackColor = true;
            this.btn_edit_customer.Click += new System.EventHandler(this.btn_edit_customer_Click);
            // 
            // txt_gender_edit
            // 
            this.txt_gender_edit.BackColor = System.Drawing.Color.Transparent;
            this.txt_gender_edit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_gender_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_gender_edit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gender_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gender_edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_gender_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_gender_edit.ItemHeight = 30;
            this.txt_gender_edit.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_gender_edit.Location = new System.Drawing.Point(138, 196);
            this.txt_gender_edit.Name = "txt_gender_edit";
            this.txt_gender_edit.Size = new System.Drawing.Size(203, 36);
            this.txt_gender_edit.TabIndex = 18;
            // 
            // txt_nationality_edit
            // 
            this.txt_nationality_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nationality_edit.DefaultText = "";
            this.txt_nationality_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nationality_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nationality_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nationality_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nationality_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nationality_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nationality_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nationality_edit.Location = new System.Drawing.Point(138, 154);
            this.txt_nationality_edit.Name = "txt_nationality_edit";
            this.txt_nationality_edit.PasswordChar = '\0';
            this.txt_nationality_edit.PlaceholderText = "";
            this.txt_nationality_edit.SelectedText = "";
            this.txt_nationality_edit.Size = new System.Drawing.Size(203, 36);
            this.txt_nationality_edit.TabIndex = 17;
            // 
            // txt_id_edit
            // 
            this.txt_id_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_edit.DefaultText = "";
            this.txt_id_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_edit.Location = new System.Drawing.Point(138, 28);
            this.txt_id_edit.Name = "txt_id_edit";
            this.txt_id_edit.PasswordChar = '\0';
            this.txt_id_edit.PlaceholderText = "";
            this.txt_id_edit.ReadOnly = true;
            this.txt_id_edit.SelectedText = "";
            this.txt_id_edit.Size = new System.Drawing.Size(203, 36);
            this.txt_id_edit.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quốc Tịch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "MãKH:";
            // 
            // btn_delete_customer
            // 
            this.btn_delete_customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_customer.Controls.Add(this.txt_id_delete);
            this.btn_delete_customer.Controls.Add(this.btn_Xoa);
            this.btn_delete_customer.Controls.Add(this.label6);
            this.btn_delete_customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_delete_customer.Location = new System.Drawing.Point(1216, 370);
            this.btn_delete_customer.Name = "btn_delete_customer";
            this.btn_delete_customer.Size = new System.Drawing.Size(393, 479);
            this.btn_delete_customer.TabIndex = 15;
            this.btn_delete_customer.TabStop = false;
            this.btn_delete_customer.Text = "Xóa";
            this.btn_delete_customer.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_id_delete
            // 
            this.txt_id_delete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_delete.DefaultText = "";
            this.txt_id_delete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_delete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_delete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_delete.Location = new System.Drawing.Point(144, 30);
            this.txt_id_delete.Name = "txt_id_delete";
            this.txt_id_delete.PasswordChar = '\0';
            this.txt_id_delete.PlaceholderText = "";
            this.txt_id_delete.ReadOnly = true;
            this.txt_id_delete.SelectedText = "";
            this.txt_id_delete.Size = new System.Drawing.Size(203, 36);
            this.txt_id_delete.TabIndex = 21;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(265, 425);
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
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xóa MãKH:";
            // 
            // dgv_customer
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_customer.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customer.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.Location = new System.Drawing.Point(98, 100);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customer.RowTemplate.Height = 32;
            this.dgv_customer.RowTemplate.ReadOnly = true;
            this.dgv_customer.Size = new System.Drawing.Size(1693, 241);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.dgv_customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_customer.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_customer.ThemeStyle.ReadOnly = false;
            this.dgv_customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer.ThemeStyle.RowsStyle.Height = 32;
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(712, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(439, 37);
            this.label12.TabIndex = 16;
            this.label12.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1361, 48);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(64, 22);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Tìm kiếm";
            // 
            // cb_search
            // 
            this.cb_search.BackColor = System.Drawing.Color.Transparent;
            this.cb_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_search.ItemHeight = 30;
            this.cb_search.Items.AddRange(new object[] {
            "All",
            "Staying In Hotel",
            "Checkout"});
            this.cb_search.Location = new System.Drawing.Point(1433, 41);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(358, 36);
            this.cb_search.TabIndex = 19;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged);
            // 
            // UC_CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_customer);
            this.Controls.Add(this.btn_delete_customer);
            this.Controls.Add(this.groupBox);
            this.Name = "UC_CustomerDetail";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_CustomerDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.btn_delete_customer.ResumeLayout(false);
            this.btn_delete_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QuanLyKhachSanDataSet1 quanLyKhachSanDataSet1;
        private QuanLyKhachSanDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_edit_customer;
        private Guna.UI2.WinForms.Guna2ComboBox txt_gender_edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_nationality_edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_id_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox btn_delete_customer;
        private Guna.UI2.WinForms.Guna2TextBox txt_id_delete;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_address_edit;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_idproof_edit;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_dob_edit;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_mobile_edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_name_edit;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_customer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cb_search;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox txt_room_no_edit;
        private Guna.UI2.WinForms.Guna2ComboBox txt_room_type_edit;
        private Guna.UI2.WinForms.Guna2ComboBox txt_bed_type_edit;
        private System.Windows.Forms.Label label11;
    }
}
