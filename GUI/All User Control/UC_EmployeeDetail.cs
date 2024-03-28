using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_User_Control
{
    public partial class UC_EmployeeDetail : UserControl
    {
        BLL_employee bLL_Employee=new BLL_employee();
        public UC_EmployeeDetail()
        {
            InitializeComponent();
        }
        public void UC_Employee_Load(object sender, EventArgs e)
        {
            BLL_employee employeedetail = new BLL_employee();
            dgv_employee.DataSource = employeedetail.LoadEmployee();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int idnv = -1;
        private void dgv_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_Xoa.Text = rowchon.ToString();
            int rowchon = e.RowIndex;
            if (rowchon == -1) return;
            txt_Xoa.Text = dgv_employee.Rows[rowchon].Cells[0].Value.ToString();
            //Load NhanVien theo ID nhân viên
            idnv = Convert.ToInt32(dgv_employee.Rows[rowchon].Cells[0].Value.ToString());
            txt_nvid.Text = dgv_employee.Rows[rowchon].Cells[0].Value.ToString();
            txt_username.Text = dgv_employee.Rows[rowchon].Cells[1].Value.ToString();
            txt_password.Text = dgv_employee.Rows[rowchon].Cells[2].Value.ToString();
            txt_email.Text = dgv_employee.Rows[rowchon].Cells[3].Value.ToString();
            txt_nv_role.Text = dgv_employee.Rows[rowchon].Cells[4].Value.ToString();
            txt_fullname.Text = dgv_employee.Rows[rowchon].Cells[5].Value.ToString();
            txt_dob.Text = dgv_employee.Rows[rowchon].Cells[6].Value.ToString();
            txt_address.Text = dgv_employee.Rows[rowchon].Cells[7].Value.ToString();
            
            /*            currentRoom = dgv_employee.Rows[rowchon].Cells[1].Value.ToString();*/
        }
        private void SelectNewlyAddedRow(DataGridView dataGridView)
        {
            // Ensure there is at least one row in the DataGridView
            if (dataGridView.Rows.Count > 0)
            {
                // Select the last row, assuming it's the newly added row
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[0];
            }
        }
        private void btn_addnv_Click(object sender, EventArgs e)
        {
            if (txt_username_Add.Text == "" || txt_password_Add.Text == "" || txt_email_Add.Text == "" || txt_dob_Add.Text == ""||txt_role_Add.Text==""||txt_address_Add.Text=="")
            {
                //Hiển thị bảng: Thiếu thông tin
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bLL_Employee.GetEmployeeByUsername(txt_username_Add.Text) != null)
            {
                MessageBox.Show(" Username đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nvid.Focus();
                return;
            }


            string username = txt_username_Add.Text;
            string password = txt_password_Add.Text;
            string email = txt_email_Add.Text;
            string fullname=txt_fullname_Add.Text;
            string dob=txt_dob_Add.Text;
            string address = txt_address_Add.Text;

            bLL_Employee.AddEmployee(username, password, email, fullname, dob, address);
            MessageBox.Show("Thêm phòng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_username_Add.Clear();
            txt_password_Add.Clear();
            txt_email_Add.Clear ();
            txt_role_Add.SelectedIndex = -1;
            txt_fullname_Add.Clear();
            txt_dob_Add.Clear();
            txt_address_Add.Clear();
            
            //Load lại dagtagridview NhanVien
            dgv_employee.DataSource = bLL_Employee.LoadEmployee();
            /*DeselectAllRows(dgv_rooms);*/

            SelectNewlyAddedRow(dgv_employee);


        }

        private void btn_Suanv_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_email.Text == "" || txt_dob.Text == "" || txt_nv_role.Text == "" || txt_address.Text == "")
            {
                //Hiển thị bảng: Thiếu thông tin
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bLL_Employee.GetEmployeeByUsername(txt_username_Add.Text) != null)
            {
                MessageBox.Show(" Username đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nvid.Focus();
                return;
            }

            string nvid= txt_nvid.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string fullname = txt_fullname.Text;
            string dob = txt_dob.Text;
            string address = txt_address.Text;
            string role = txt_nv_role.Text;

            bLL_Employee.UpdateGetEmployee(nvid,username, password,role, email, fullname, dob, address);
            MessageBox.Show("Sửa thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_username.Clear();
            txt_password.Clear();
            txt_email.Clear();
            txt_nv_role.SelectedIndex = -1;
            txt_fullname.Clear();
            txt_dob.Clear();
            txt_address.Clear();
            txt_nvid.Clear();
            txt_Xoa.Clear();

            //Load lại dagtagridview NhanVien
            dgv_employee.DataSource = bLL_Employee.LoadEmployee();
            /*DeselectAllRows(dgv_rooms);*/

            SelectNewlyAddedRow(dgv_employee);

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            employee empcanxoa = bLL_Employee.GetEmployeeByID(int.Parse(txt_Xoa.Text));
            if (empcanxoa != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa Nhân viên  " + empcanxoa.fullname, "Thông báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bLL_Employee.DeleteEmployee(Convert.ToInt32(txt_Xoa.Text));
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_employee.DataSource = bLL_Employee.LoadEmployee();
                    txt_nvid.Text = "";
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_email.Clear();
                    txt_nv_role.SelectedIndex = -1;
                    txt_fullname.Clear();
                    txt_dob.Clear();
                    txt_address.Clear();
                    txt_Xoa.Clear();

                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không có Nhân viên trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
