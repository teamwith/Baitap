/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 11/28/2019
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PhieuKhamBenh
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox5;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private  void  InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenbenhnhan = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTiensubenh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKetluan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttentrieuchung3 = new System.Windows.Forms.TextBox();
            this.txttentrieuchung2 = new System.Windows.Forms.TextBox();
            this.txttentrieuchung1 = new System.Windows.Forms.TextBox();
            this.txtmatrieuchung3 = new System.Windows.Forms.TextBox();
            this.txtmatrieuchung2 = new System.Windows.Forms.TextBox();
            this.txtmatrieuchung1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.Donvi = new System.Windows.Forms.Label();
            this.txtBacsykham = new System.Windows.Forms.TextBox();
            this.Bacsykham = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.errorChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvKetqua = new System.Windows.Forms.DataGridView();
            this.maphieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbenhnhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiensubenhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bacsykhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrieuchungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentrieuchungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketluanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieukhambenhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khambenhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kham_benhDataSet = new PhieuKhamBenh.Kham_benhDataSet();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.phieukhambenhTableAdapter = new PhieuKhamBenh.Kham_benhDataSetTableAdapters.PhieukhambenhTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieukhambenhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khambenhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kham_benhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox5, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1Paint);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiền sử bệnh";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(145, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(90, 30);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(145, 78);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(467, 25);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên bệnh nhân:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(145, 41);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(469, 30);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(145, 110);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(467, 28);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bác sỹ khám";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(145, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 8);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(145, 145);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(465, 29);
            this.richTextBox5.TabIndex = 11;
            this.richTextBox5.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(531, 716);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(241, 44);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(178, 716);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnNhaplai_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnQuaylai.Location = new System.Drawing.Point(6, 716);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(140, 44);
            this.btnQuaylai.TabIndex = 3;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1369, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "PHIẾU KHÁM BỆNH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // txtTenbenhnhan
            // 
            this.txtTenbenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenbenhnhan.Location = new System.Drawing.Point(225, 41);
            this.txtTenbenhnhan.Name = "txtTenbenhnhan";
            this.txtTenbenhnhan.Size = new System.Drawing.Size(285, 30);
            this.txtTenbenhnhan.TabIndex = 10;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDiachi.Location = new System.Drawing.Point(225, 97);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(285, 30);
            this.txtDiachi.TabIndex = 8;
            // 
            // txtTiensubenh
            // 
            this.txtTiensubenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTiensubenh.Location = new System.Drawing.Point(761, 97);
            this.txtTiensubenh.Name = "txtTiensubenh";
            this.txtTiensubenh.Size = new System.Drawing.Size(181, 30);
            this.txtTiensubenh.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(518, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 33);
            this.label15.TabIndex = 23;
            this.label15.Text = "Tiền sử bệnh";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(518, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 33);
            this.label11.TabIndex = 11;
            this.label11.Text = "Giới tính";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 34);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã phiếu:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKetluan
            // 
            this.txtKetluan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKetluan.Location = new System.Drawing.Point(225, 346);
            this.txtKetluan.Multiline = true;
            this.txtKetluan.Name = "txtKetluan";
            this.txtKetluan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKetluan.Size = new System.Drawing.Size(285, 78);
            this.txtKetluan.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(5, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 33);
            this.label14.TabIndex = 21;
            this.label14.Text = "Kết luận";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttentrieuchung3
            // 
            this.txttentrieuchung3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txttentrieuchung3.Location = new System.Drawing.Point(518, 310);
            this.txttentrieuchung3.Name = "txttentrieuchung3";
            this.txttentrieuchung3.Size = new System.Drawing.Size(235, 30);
            this.txttentrieuchung3.TabIndex = 20;
            this.txttentrieuchung3.TextChanged += new System.EventHandler(this.txttentrieuchung3_TextChanged);
            // 
            // txttentrieuchung2
            // 
            this.txttentrieuchung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txttentrieuchung2.Location = new System.Drawing.Point(518, 268);
            this.txttentrieuchung2.Name = "txttentrieuchung2";
            this.txttentrieuchung2.Size = new System.Drawing.Size(235, 30);
            this.txttentrieuchung2.TabIndex = 19;
            // 
            // txttentrieuchung1
            // 
            this.txttentrieuchung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txttentrieuchung1.Location = new System.Drawing.Point(518, 222);
            this.txttentrieuchung1.Name = "txttentrieuchung1";
            this.txttentrieuchung1.Size = new System.Drawing.Size(235, 30);
            this.txttentrieuchung1.TabIndex = 18;
            // 
            // txtmatrieuchung3
            // 
            this.txtmatrieuchung3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtmatrieuchung3.Location = new System.Drawing.Point(225, 310);
            this.txtmatrieuchung3.Name = "txtmatrieuchung3";
            this.txtmatrieuchung3.Size = new System.Drawing.Size(215, 30);
            this.txtmatrieuchung3.TabIndex = 17;
            // 
            // txtmatrieuchung2
            // 
            this.txtmatrieuchung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtmatrieuchung2.Location = new System.Drawing.Point(225, 268);
            this.txtmatrieuchung2.Name = "txtmatrieuchung2";
            this.txtmatrieuchung2.Size = new System.Drawing.Size(215, 30);
            this.txtmatrieuchung2.TabIndex = 16;
            // 
            // txtmatrieuchung1
            // 
            this.txtmatrieuchung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtmatrieuchung1.Location = new System.Drawing.Point(225, 222);
            this.txtmatrieuchung1.Name = "txtmatrieuchung1";
            this.txtmatrieuchung1.Size = new System.Drawing.Size(215, 30);
            this.txtmatrieuchung1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(518, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 33);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tên triệu chứng";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(5, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 33);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã triệu chứng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 33);
            this.label10.TabIndex = 9;
            this.label10.Text = "Địa chỉ";
            // 
            // txtDonvi
            // 
            this.txtDonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDonvi.Location = new System.Drawing.Point(761, 139);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(181, 30);
            this.txtDonvi.TabIndex = 3;
            // 
            // Donvi
            // 
            this.Donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donvi.ForeColor = System.Drawing.Color.Black;
            this.Donvi.Location = new System.Drawing.Point(518, 136);
            this.Donvi.Name = "Donvi";
            this.Donvi.Size = new System.Drawing.Size(161, 33);
            this.Donvi.TabIndex = 4;
            this.Donvi.Text = "Đơn vị";
            this.Donvi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBacsykham
            // 
            this.txtBacsykham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtBacsykham.Location = new System.Drawing.Point(225, 139);
            this.txtBacsykham.Name = "txtBacsykham";
            this.txtBacsykham.Size = new System.Drawing.Size(285, 30);
            this.txtBacsykham.TabIndex = 2;
            this.txtBacsykham.TextChanged += new System.EventHandler(this.txtBacsy_TextChanged);
            // 
            // Bacsykham
            // 
            this.Bacsykham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bacsykham.ForeColor = System.Drawing.Color.Black;
            this.Bacsykham.Location = new System.Drawing.Point(5, 136);
            this.Bacsykham.Name = "Bacsykham";
            this.Bacsykham.Size = new System.Drawing.Size(161, 33);
            this.Bacsykham.TabIndex = 0;
            this.Bacsykham.Text = "Bác sỹ khám";
            this.Bacsykham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bacsykham.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 33);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên bệnh nhân";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphieu.Location = new System.Drawing.Point(225, 5);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(171, 30);
            this.txtMaphieu.TabIndex = 6;
            this.txtMaphieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maphieu);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel2.Controls.Add(this.txtMaphieu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bacsykham, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtBacsykham, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Donvi, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txttentrieuchung2, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.txttentrieuchung3, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtKetluan, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDiachi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTenbenhnhan, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTiensubenh, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtmatrieuchung1, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtmatrieuchung2, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtmatrieuchung3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtDonvi, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.txttentrieuchung1, 2, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(193, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(959, 473);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.radioNam, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(761, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(74, 48);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.ForeColor = System.Drawing.Color.Black;
            this.radioNam.Location = new System.Drawing.Point(3, 3);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(58, 18);
            this.radioNam.TabIndex = 0;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            this.radioNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // errorChiTiet
            // 
            this.errorChiTiet.ContainerControl = this;
            // 
            // dgvKetqua
            // 
            this.dgvKetqua.AllowUserToOrderColumns = true;
            this.dgvKetqua.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetqua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetqua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieuDataGridViewTextBoxColumn,
            this.tenbenhnhanDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.tiensubenhDataGridViewTextBoxColumn,
            this.bacsykhamDataGridViewTextBoxColumn,
            this.donviDataGridViewTextBoxColumn,
            this.matrieuchungDataGridViewTextBoxColumn,
            this.tentrieuchungDataGridViewTextBoxColumn,
            this.ketluanDataGridViewTextBoxColumn});
            this.dgvKetqua.DataSource = this.phieukhambenhBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetqua.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKetqua.Location = new System.Drawing.Point(28, 527);
            this.dgvKetqua.Name = "dgvKetqua";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetqua.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvKetqua.RowHeadersWidth = 51;
            this.dgvKetqua.RowTemplate.Height = 24;
            this.dgvKetqua.Size = new System.Drawing.Size(1306, 166);
            this.dgvKetqua.TabIndex = 6;
            this.dgvKetqua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetqua_CellContentClick);
            // 
            // maphieuDataGridViewTextBoxColumn
            // 
            this.maphieuDataGridViewTextBoxColumn.DataPropertyName = "Maphieu";
            this.maphieuDataGridViewTextBoxColumn.HeaderText = "Maphieu";
            this.maphieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maphieuDataGridViewTextBoxColumn.Name = "maphieuDataGridViewTextBoxColumn";
            this.maphieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenbenhnhanDataGridViewTextBoxColumn
            // 
            this.tenbenhnhanDataGridViewTextBoxColumn.DataPropertyName = "Tenbenhnhan";
            this.tenbenhnhanDataGridViewTextBoxColumn.HeaderText = "Tenbenhnhan";
            this.tenbenhnhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenbenhnhanDataGridViewTextBoxColumn.Name = "tenbenhnhanDataGridViewTextBoxColumn";
            this.tenbenhnhanDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioitinhDataGridViewCheckBoxColumn
            // 
            this.gioitinhDataGridViewCheckBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.HeaderText = "Gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gioitinhDataGridViewCheckBoxColumn.Name = "gioitinhDataGridViewCheckBoxColumn";
            this.gioitinhDataGridViewCheckBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tiensubenhDataGridViewTextBoxColumn
            // 
            this.tiensubenhDataGridViewTextBoxColumn.DataPropertyName = "Tiensubenh";
            this.tiensubenhDataGridViewTextBoxColumn.HeaderText = "Tiensubenh";
            this.tiensubenhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tiensubenhDataGridViewTextBoxColumn.Name = "tiensubenhDataGridViewTextBoxColumn";
            this.tiensubenhDataGridViewTextBoxColumn.Width = 125;
            // 
            // bacsykhamDataGridViewTextBoxColumn
            // 
            this.bacsykhamDataGridViewTextBoxColumn.DataPropertyName = "Bacsykham";
            this.bacsykhamDataGridViewTextBoxColumn.HeaderText = "Bacsykham";
            this.bacsykhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bacsykhamDataGridViewTextBoxColumn.Name = "bacsykhamDataGridViewTextBoxColumn";
            this.bacsykhamDataGridViewTextBoxColumn.Width = 125;
            // 
            // donviDataGridViewTextBoxColumn
            // 
            this.donviDataGridViewTextBoxColumn.DataPropertyName = "Donvi";
            this.donviDataGridViewTextBoxColumn.HeaderText = "Donvi";
            this.donviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donviDataGridViewTextBoxColumn.Name = "donviDataGridViewTextBoxColumn";
            this.donviDataGridViewTextBoxColumn.Width = 125;
            // 
            // matrieuchungDataGridViewTextBoxColumn
            // 
            this.matrieuchungDataGridViewTextBoxColumn.DataPropertyName = "Matrieuchung";
            this.matrieuchungDataGridViewTextBoxColumn.HeaderText = "Matrieuchung";
            this.matrieuchungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matrieuchungDataGridViewTextBoxColumn.Name = "matrieuchungDataGridViewTextBoxColumn";
            this.matrieuchungDataGridViewTextBoxColumn.Width = 125;
            // 
            // tentrieuchungDataGridViewTextBoxColumn
            // 
            this.tentrieuchungDataGridViewTextBoxColumn.DataPropertyName = "Tentrieuchung";
            this.tentrieuchungDataGridViewTextBoxColumn.HeaderText = "Tentrieuchung";
            this.tentrieuchungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tentrieuchungDataGridViewTextBoxColumn.Name = "tentrieuchungDataGridViewTextBoxColumn";
            this.tentrieuchungDataGridViewTextBoxColumn.Width = 125;
            // 
            // ketluanDataGridViewTextBoxColumn
            // 
            this.ketluanDataGridViewTextBoxColumn.DataPropertyName = "Ketluan";
            this.ketluanDataGridViewTextBoxColumn.HeaderText = "Ketluan";
            this.ketluanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ketluanDataGridViewTextBoxColumn.Name = "ketluanDataGridViewTextBoxColumn";
            this.ketluanDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieukhambenhBindingSource
            // 
            this.phieukhambenhBindingSource.DataMember = "Phieukhambenh";
            this.phieukhambenhBindingSource.DataSource = this.khambenhDataSetBindingSource;
            // 
            // khambenhDataSetBindingSource
            // 
            this.khambenhDataSetBindingSource.DataSource = this.kham_benhDataSet;
            this.khambenhDataSetBindingSource.Position = 0;
            // 
            // kham_benhDataSet
            // 
            this.kham_benhDataSet.DataSetName = "Kham_benhDataSet";
            this.kham_benhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(372, 716);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 44);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(810, 716);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 44);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(1194, 716);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 44);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(1026, 716);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 44);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // phieukhambenhTableAdapter
            // 
            this.phieukhambenhTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1369, 773);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvKetqua);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Location = new System.Drawing.Point(684, 537);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Click += new System.EventHandler(this.btnHuy_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieukhambenhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khambenhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kham_benhDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenbenhnhan;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTiensubenh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKetluan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttentrieuchung3;
        private System.Windows.Forms.TextBox txttentrieuchung2;
        private System.Windows.Forms.TextBox txttentrieuchung1;
        private System.Windows.Forms.TextBox txtmatrieuchung3;
        private System.Windows.Forms.TextBox txtmatrieuchung2;
        private System.Windows.Forms.TextBox txtmatrieuchung1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.Label Donvi;
        private System.Windows.Forms.TextBox txtBacsykham;
        private System.Windows.Forms.Label Bacsykham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ErrorProvider errorChiTiet;
        private System.Windows.Forms.DataGridView dgvKetqua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.BindingSource khambenhDataSetBindingSource;
        private Kham_benhDataSet kham_benhDataSet;
        private System.Windows.Forms.BindingSource phieukhambenhBindingSource;
        private Kham_benhDataSetTableAdapters.PhieukhambenhTableAdapter phieukhambenhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbenhnhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiensubenhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bacsykhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrieuchungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentrieuchungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketluanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton radioNam;
    }
}