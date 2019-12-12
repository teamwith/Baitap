using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhieuKhamBenh
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại loca
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
        {

        }
        void MainFormLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kham_benhDataSet.Phieukhambenh' table. You can move, or remove it, as needed.
            this.phieukhambenhTableAdapter.Fill(this.kham_benhDataSet.Phieukhambenh);
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            con.ConnectionString = @"server=DESKTOP-19EPU5O\SQLEXPRESS; database = Kham_benh ; user id = sa; password = 123";
            //Gọi phương thức Load dự liệu
            LoadDuLieu("Select * from Phieukhambenh");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }
        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            DataSet ds = new DataSet();
           SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
              dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
           dgvKetqua.DataSource = ds.Tables[0];
        }
        void TableLayoutPanel2Paint(object sender, PaintEventArgs e)
        {

        }
        void Label11Click(object sender, EventArgs e)
        {

        }
        void Panel2Paint(object sender, PaintEventArgs e)
        {

        }
        void RichTextBox14TextChanged(object sender, EventArgs e)
        {

        }
        void Panel1Paint(object sender, PaintEventArgs e)
        {

        }
        void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void TableLayoutPanel4Paint(object sender, PaintEventArgs e)
        {

        }
        void TableLayoutPanel9Paint(object sender, PaintEventArgs e)
        {

        }
        void RichTextBox12TextChanged(object sender, EventArgs e)
        {

        }

        void Label19Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

           string sql = "";

            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên sản phầm có bị để trống không

            if (txtTenbenhnhan.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtTenbenhnhan, "Bạn không thể để trống tên bệnh nhân!");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            //Kiểm tra ngày sản xuất, lỗi nếu người sử dụng nhập vào ngày sản xuất lớn hơn ngày hiện tại
            if (radioNam.Checked.ToString() == "")
            {
                errorChiTiet.SetError(radioNam, "Bạn cần phải chọn giới tính !");
                    return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            //Kiểm tra đơn vị xem có để trống không
            if (txtDiachi.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtDiachi, "Bạn không thể để trống địa chỉ!");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            //Kiểm tra đơn giá
            if (txtTiensubenh.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtTiensubenh, "Bạn không thể để trống tiền sử bệnh!");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            /*//Nếu nút Thêm enable thì thực hiện thêm mới
            //Dùng ký tự N' trước mỗi giá trị kiểu text để insert giá trị có dấu tiếng việt vào CSDL được đúng
          
            if (btnThem.Enabled == true)
            {
                //Kiểm tra xem ô nhập Maphieu có bị trống không
                if (txtMaphieu.Text.Trim() == "")
                {
                    errorChiTiet.SetError(txtMaphieu, "Bạn không để trống mã phiếu trường này!");
                    return;
                }
                else
                {
                    //Kiểm tra xem mã phiếu đã tồn tại chưa đẻ tránh việc insert mới bị lỗi  
                    sql = "Select Count(*) From Phieukhambenh Where Maphieu ='" + txtMaphieu.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    int val = (int)cmd.ExecuteScalar();
                    if (val > 0)
                    {
                        errorChiTiet.SetError(txtMaphieu, "Mã phiếu trùng trong cơ sở dữ liệu");
                        return;
                    }
                    errorChiTiet.Clear();
                }
                */
            { 
                //Insert vao CSDL
                sql = "INSERT INTO Phieukhambenh(Maphieu,Tenbenhnhan,Gioitinh,Diachi,Tiensubenh,Bacsykham,Donvi,Matrieuchung,Tentrieuchung,Ketluan) VALUES (";
                sql += "N'" + txtMaphieu.Text + "',N'" + txtTenbenhnhan.Text + "','" + radioNam.Checked+ "','" +txtDiachi.Text + "',N'" + txtTiensubenh.Text + "',N'" + txtBacsykham.Text + "',N'" + txtDonvi.Text + "',N'" + ((txtmatrieuchung1.Text) + (txtmatrieuchung2.Text) + (txtmatrieuchung3.Text)) + "',N'" + ((txttentrieuchung1.Text)+ (txttentrieuchung2.Text)+ (txttentrieuchung3.Text)) + "',N'" + txtKetluan.Text + "')";
            }
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btnSua.Enabled == true)
            {
                sql = "Update Phieukhambenh SET ";
                sql += "Tenbenhnhan = N'" + txtTenbenhnhan.Text + "',";
                sql += "Diachi = '" + txtDiachi.Text+ "',";
                sql += "Tiensubenh = '" + txtTiensubenh + "',";
                sql += "Donvi = N'" + txtDonvi.Text + "',";
                sql += "Matrieuchung ='" + txtmatrieuchung1.Text + "',";
                sql += "Matrieuchung ='" + txtmatrieuchung2.Text + "',";
                sql += "Matrieuchung ='" + txtmatrieuchung3.Text + "',";
                sql += "Tentrieuchung = '" + txttentrieuchung1.Text + "',";
                sql += "Tentrieuchung = '" + txttentrieuchung2.Text + "',";
                sql += "Tentrieuchung = '" + txttentrieuchung3.Text + "',";
                sql += "Ketluan = N'" + txtKetluan.Text + "' ";
                sql += "Where Maphieu = '" + txtMaphieu.Text + "'";
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnXoa.Enabled == true)
            {
                sql = "Delete From Phieukhambenh Where Maphieu =N'" + txtMaphieu.Text + "'";
            }
            //Thuc thi cau lenh sql
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from ";
            LoadDuLieu(sql);
            //dong ket noi
            con.Close();
            //Ẩn hiện các nút phù hợp chức năng
            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
      
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thaotac tt = new Thaotac();
            tt.Show();
        }

        private void RadiobtnNam_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void Phieukhambenh_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BtnNhaplai_Click(object sender, EventArgs e)
        {
            //Xoa trang GroupBox 
            XoaTrangChiTiet();
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);

        }
        private void XoaTrangChiTiet()
        {
            txtMaphieu.Clear();
            txtTenbenhnhan.Clear();
            txtDiachi.Clear();
            txtBacsykham.Clear();
            txtDonvi.Clear();
            txtmatrieuchung1.Clear();
            txtmatrieuchung2.Clear();
            txtmatrieuchung3.Clear();
            txttentrieuchung1.Clear();
            txttentrieuchung2.Clear();
            txttentrieuchung2.Clear();
            txtKetluan.Clear();
        }
        private void HienChiTiet(Boolean hien)
        {
            txtMaphieu.Enabled = hien;
            txtTenbenhnhan.Enabled = hien;
            txtDiachi.Enabled = hien;
            radioNam.Enabled = hien;
            txtBacsykham.Enabled = hien;
            txtDonvi.Enabled = hien;
            txtmatrieuchung1.Enabled = hien;
            txtmatrieuchung2.Enabled = hien;
            txtmatrieuchung3.Enabled = hien;
            txttentrieuchung1.Enabled = hien;
            txttentrieuchung2.Enabled = hien;
            txttentrieuchung2.Enabled = hien;
            txtKetluan.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;

        }
        private void RichTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ketluan_Click(object sender, EventArgs e)
        {
           
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private  void txtBacsy_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Sự kiện Click của nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Ẩn hai nút Thêm và Sửa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            //xoa trang
            XoaTrangChiTiet();
            //Cam nhap
            HienChiTiet(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Bật Message Box cảnh báo người sử dụng
            if (MessageBox.Show("Bạn có chắc chắn xóa mã phiếu " + txtMaphieu.Text + " không? Nếu có ấn nút xoá, không thì ấn nút Hủy", "Xóa phiếu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                //Hiện gropbox chi tiết
                HienChiTiet(true);
            }
        }

        private void dgvKetqua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaphieu.Text = dgvKetqua[0, e.RowIndex].Value.ToString();
                txtTenbenhnhan.Text = dgvKetqua[1, e.RowIndex].Value.ToString();
                txtDiachi.Text = dgvKetqua[3, e.RowIndex].Value.ToString();
                txtTiensubenh.Text = dgvKetqua[4, e.RowIndex].Value.ToString();
                txtBacsykham.Text = dgvKetqua[5, e.RowIndex].Value.ToString();
                txtDonvi.Text = dgvKetqua[6, e.RowIndex].Value.ToString();
                txtmatrieuchung1.Text = dgvKetqua[7, e.RowIndex].Value.ToString();
                txtmatrieuchung2.Text = dgvKetqua[7, e.RowIndex].Value.ToString();
                txtmatrieuchung3.Text = dgvKetqua[7, e.RowIndex].Value.ToString();
                txttentrieuchung1.Text = dgvKetqua[8, e.RowIndex].Value.ToString();
                txttentrieuchung2.Text = dgvKetqua[8, e.RowIndex].Value.ToString();
                txttentrieuchung3.Text = dgvKetqua[8, e.RowIndex].Value.ToString();
                txtKetluan.Text = dgvKetqua[9, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
        private void txttentrieuchung3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}