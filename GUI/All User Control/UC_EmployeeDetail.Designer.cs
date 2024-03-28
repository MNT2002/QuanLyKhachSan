namespace GUI.All_User_Control
{
    partial class UC_EmployeeDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet1 = new GUI.QuanLyKhachSanDataSet1();
            this.customerTableAdapter = new GUI.QuanLyKhachSanDataSet1TableAdapters.customerTableAdapter();
            this.quanLyKhachSanDataSet2 = new GUI.QuanLyKhachSanDataSet2();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new GUI.QuanLyKhachSanDataSet2TableAdapters.employeeTableAdapter();
            this.quanLyKhachSanDataSet3 = new GUI.QuanLyKhachSanDataSet3();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new GUI.QuanLyKhachSanDataSet3TableAdapters.employeeTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet11 = new GUI.QuanLyKhachSanDataSet1();
            this.customerTableAdapter1 = new GUI.QuanLyKhachSanDataSet1TableAdapters.customerTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_Xoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_dob = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_fullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_Suanv = new System.Windows.Forms.Button();
            this.txt_nv_role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_password_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dob_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fullname_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addnv = new System.Windows.Forms.Button();
            this.txt_role_Add = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_email_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nvid = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.quanLyKhachSanDataSet1;
            this.customerBindingSource.CurrentChanged += new System.EventHandler(this.customerBindingSource_CurrentChanged);
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
            // quanLyKhachSanDataSet2
            // 
            this.quanLyKhachSanDataSet2.DataSetName = "QuanLyKhachSanDataSet2";
            this.quanLyKhachSanDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.quanLyKhachSanDataSet2;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyKhachSanDataSet3
            // 
            this.quanLyKhachSanDataSet3.DataSetName = "QuanLyKhachSanDataSet3";
            this.quanLyKhachSanDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "employee";
            this.employeeBindingSource1.DataSource = this.quanLyKhachSanDataSet3;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "customer";
            this.bindingSource1.DataSource = this.quanLyKhachSanDataSet11;
            // 
            // quanLyKhachSanDataSet11
            // 
            this.quanLyKhachSanDataSet11.DataSetName = "QuanLyKhachSanDataSet1";
            this.quanLyKhachSanDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(712, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(400, 37);
            this.label12.TabIndex = 24;
            this.label12.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.AllowUserToResizeColumns = false;
            this.dgv_employee.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgv_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_employee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_employee.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_employee.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_employee.Location = new System.Drawing.Point(97, 103);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.RowHeadersVisible = false;
            this.dgv_employee.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_employee.RowTemplate.Height = 32;
            this.dgv_employee.RowTemplate.ReadOnly = true;
            this.dgv_employee.Size = new System.Drawing.Size(1693, 241);
            this.dgv_employee.TabIndex = 23;
            this.dgv_employee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_employee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_employee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_employee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_employee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_employee.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.dgv_employee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_employee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_employee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_employee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_employee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_employee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_employee.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_employee.ThemeStyle.ReadOnly = true;
            this.dgv_employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_employee.ThemeStyle.RowsStyle.Height = 32;
            this.dgv_employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_CellClick);
            this.dgv_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xóa MãNV:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(265, 376);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 32);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.txt_Xoa.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Xoa);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1287, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 430);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txt_nvid);
            this.groupBox3.Controls.Add(this.txt_password);
            this.groupBox3.Controls.Add(this.txt_username);
            this.groupBox3.Controls.Add(this.txt_address);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_dob);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_fullname);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btn_Suanv);
            this.groupBox3.Controls.Add(this.txt_nv_role);
            this.groupBox3.Controls.Add(this.txt_email);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(689, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 430);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa";
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(138, 114);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(203, 36);
            this.txt_password.TabIndex = 32;
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(138, 72);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(203, 36);
            this.txt_username.TabIndex = 31;
            // 
            // txt_address
            // 
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(138, 324);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(203, 36);
            this.txt_address.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(21, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Địa Chỉ:";
            // 
            // txt_dob
            // 
            this.txt_dob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dob.DefaultText = "";
            this.txt_dob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dob.Location = new System.Drawing.Point(138, 282);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.PasswordChar = '\0';
            this.txt_dob.PlaceholderText = "";
            this.txt_dob.SelectedText = "";
            this.txt_dob.Size = new System.Drawing.Size(203, 36);
            this.txt_dob.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(18, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "Họ Tên:";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fullname.DefaultText = "";
            this.txt_fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fullname.Location = new System.Drawing.Point(138, 240);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.PasswordChar = '\0';
            this.txt_fullname.PlaceholderText = "";
            this.txt_fullname.SelectedText = "";
            this.txt_fullname.Size = new System.Drawing.Size(203, 36);
            this.txt_fullname.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(18, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 21);
            this.label15.TabIndex = 23;
            this.label15.Text = "Ngày Sinh:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(18, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 21;
            this.label17.Text = "Role:";
            // 
            // btn_Suanv
            // 
            this.btn_Suanv.Location = new System.Drawing.Point(259, 376);
            this.btn_Suanv.Name = "btn_Suanv";
            this.btn_Suanv.Size = new System.Drawing.Size(82, 32);
            this.btn_Suanv.TabIndex = 20;
            this.btn_Suanv.Text = "Sửa";
            this.btn_Suanv.UseVisualStyleBackColor = true;
            this.btn_Suanv.Click += new System.EventHandler(this.btn_Suanv_Click);
            // 
            // txt_nv_role
            // 
            this.txt_nv_role.BackColor = System.Drawing.Color.Transparent;
            this.txt_nv_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_nv_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_nv_role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nv_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nv_role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_nv_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_nv_role.ItemHeight = 30;
            this.txt_nv_role.Items.AddRange(new object[] {
            "0",
            "1"});
            this.txt_nv_role.Location = new System.Drawing.Point(138, 198);
            this.txt_nv_role.Name = "txt_nv_role";
            this.txt_nv_role.Size = new System.Drawing.Size(203, 36);
            this.txt_nv_role.TabIndex = 18;
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(138, 156);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(203, 36);
            this.txt_email.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(18, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 21);
            this.label18.TabIndex = 7;
            this.label18.Text = "Password:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(18, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(18, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Username:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.Location = new System.Drawing.Point(18, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "MãNV:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_password_Add);
            this.groupBox1.Controls.Add(this.txt_username_Add);
            this.groupBox1.Controls.Add(this.txt_address_Add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dob_Add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_fullname_Add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_addnv);
            this.groupBox1.Controls.Add(this.txt_role_Add);
            this.groupBox1.Controls.Add(this.txt_email_Add);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(119, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 430);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm";
            // 
            // txt_password_Add
            // 
            this.txt_password_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password_Add.DefaultText = "";
            this.txt_password_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password_Add.Location = new System.Drawing.Point(138, 81);
            this.txt_password_Add.Name = "txt_password_Add";
            this.txt_password_Add.PasswordChar = '\0';
            this.txt_password_Add.PlaceholderText = "";
            this.txt_password_Add.SelectedText = "";
            this.txt_password_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_password_Add.TabIndex = 32;
            // 
            // txt_username_Add
            // 
            this.txt_username_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username_Add.DefaultText = "";
            this.txt_username_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username_Add.Location = new System.Drawing.Point(138, 39);
            this.txt_username_Add.Name = "txt_username_Add";
            this.txt_username_Add.PasswordChar = '\0';
            this.txt_username_Add.PlaceholderText = "";
            this.txt_username_Add.SelectedText = "";
            this.txt_username_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_username_Add.TabIndex = 31;
            // 
            // txt_address_Add
            // 
            this.txt_address_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address_Add.DefaultText = "";
            this.txt_address_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address_Add.Location = new System.Drawing.Point(138, 291);
            this.txt_address_Add.Name = "txt_address_Add";
            this.txt_address_Add.PasswordChar = '\0';
            this.txt_address_Add.PlaceholderText = "";
            this.txt_address_Add.SelectedText = "";
            this.txt_address_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_address_Add.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txt_dob_Add
            // 
            this.txt_dob_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dob_Add.DefaultText = "";
            this.txt_dob_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dob_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dob_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dob_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dob_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dob_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dob_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dob_Add.Location = new System.Drawing.Point(138, 249);
            this.txt_dob_Add.Name = "txt_dob_Add";
            this.txt_dob_Add.PasswordChar = '\0';
            this.txt_dob_Add.PlaceholderText = "";
            this.txt_dob_Add.SelectedText = "";
            this.txt_dob_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_dob_Add.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Họ Tên:";
            // 
            // txt_fullname_Add
            // 
            this.txt_fullname_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fullname_Add.DefaultText = "";
            this.txt_fullname_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fullname_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fullname_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fullname_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fullname_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fullname_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_fullname_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fullname_Add.Location = new System.Drawing.Point(138, 207);
            this.txt_fullname_Add.Name = "txt_fullname_Add";
            this.txt_fullname_Add.PasswordChar = '\0';
            this.txt_fullname_Add.PlaceholderText = "";
            this.txt_fullname_Add.SelectedText = "";
            this.txt_fullname_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_fullname_Add.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Role:";
            // 
            // btn_addnv
            // 
            this.btn_addnv.Location = new System.Drawing.Point(259, 376);
            this.btn_addnv.Name = "btn_addnv";
            this.btn_addnv.Size = new System.Drawing.Size(82, 32);
            this.btn_addnv.TabIndex = 20;
            this.btn_addnv.Text = "Thêm";
            this.btn_addnv.UseVisualStyleBackColor = true;
            this.btn_addnv.Click += new System.EventHandler(this.btn_addnv_Click);
            // 
            // txt_role_Add
            // 
            this.txt_role_Add.BackColor = System.Drawing.Color.Transparent;
            this.txt_role_Add.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_role_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_role_Add.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_role_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_role_Add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_role_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_role_Add.ItemHeight = 30;
            this.txt_role_Add.Items.AddRange(new object[] {
            "0",
            "1"});
            this.txt_role_Add.Location = new System.Drawing.Point(138, 165);
            this.txt_role_Add.Name = "txt_role_Add";
            this.txt_role_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_role_Add.TabIndex = 18;
            // 
            // txt_email_Add
            // 
            this.txt_email_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email_Add.DefaultText = "";
            this.txt_email_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email_Add.Location = new System.Drawing.Point(138, 123);
            this.txt_email_Add.Name = "txt_email_Add";
            this.txt_email_Add.PasswordChar = '\0';
            this.txt_email_Add.PlaceholderText = "";
            this.txt_email_Add.SelectedText = "";
            this.txt_email_Add.Size = new System.Drawing.Size(203, 36);
            this.txt_email_Add.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(18, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username:";
            // 
            // txt_nvid
            // 
            this.txt_nvid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nvid.DefaultText = "";
            this.txt_nvid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nvid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nvid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nvid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nvid.Enabled = false;
            this.txt_nvid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nvid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nvid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nvid.Location = new System.Drawing.Point(138, 30);
            this.txt_nvid.Name = "txt_nvid";
            this.txt_nvid.PasswordChar = '\0';
            this.txt_nvid.PlaceholderText = "";
            this.txt_nvid.ReadOnly = true;
            this.txt_nvid.SelectedText = "";
            this.txt_nvid.Size = new System.Drawing.Size(203, 36);
            this.txt_nvid.TabIndex = 33;
            // 
            // UC_EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_EmployeeDetail";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QuanLyKhachSanDataSet1 quanLyKhachSanDataSet1;
        private QuanLyKhachSanDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private QuanLyKhachSanDataSet2 quanLyKhachSanDataSet2;
        private QuanLyKhachSanDataSet2TableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private QuanLyKhachSanDataSet3 quanLyKhachSanDataSet3;
        private QuanLyKhachSanDataSet3TableAdapters.employeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QuanLyKhachSanDataSet1 quanLyKhachSanDataSet11;
        private QuanLyKhachSanDataSet1TableAdapters.customerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_employee;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txt_dob;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txt_fullname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Suanv;
        private Guna.UI2.WinForms.Guna2ComboBox txt_nv_role;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Xoa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_password_Add;
        private Guna.UI2.WinForms.Guna2TextBox txt_username_Add;
        private Guna.UI2.WinForms.Guna2TextBox txt_address_Add;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_dob_Add;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_fullname_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addnv;
        private Guna.UI2.WinForms.Guna2ComboBox txt_role_Add;
        private Guna.UI2.WinForms.Guna2TextBox txt_email_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_nvid;
    }
}
