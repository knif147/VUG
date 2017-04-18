using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace VUG
{
    public partial class bntLoadDs : Form
    {
        public bntLoadDs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vUGDataSet13.Transfer' table. You can move, or remove it, as needed.
            this.transferTableAdapter1.Fill(this.vUGDataSet13.Transfer);
            // TODO: This line of code loads data into the 'vUGDataSet12.Transfer' table. You can move, or remove it, as needed.
           // this.transferTableAdapter.Fill(this.vUGDataSet12.Transfer);
            // TODO: This line of code loads data into the 'vUGDataSet11.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.vUGDataSet11.Coach);
            // TODO: This line of code loads data into the 'vUGDataSet10.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.vUGDataSet10.Team);
            // TODO: This line of code loads data into the 'vUGDataSet9.Penance' table. You can move, or remove it, as needed.
           // this.penanceTableAdapter.Fill(this.vUGDataSet9.Penance);
            // TODO: This line of code loads data into the 'vUGDataSet8.LichThiDauVong4' table. You can move, or remove it, as needed.
            this.lichThiDauVong4TableAdapter.Fill(this.vUGDataSet8.LichThiDauVong4);
            // TODO: This line of code loads data into the 'vUGDataSet7.LichThiDauVong3' table. You can move, or remove it, as needed.
            this.lichThiDauVong3TableAdapter.Fill(this.vUGDataSet7.LichThiDauVong3);
            // TODO: This line of code loads data into the 'vUGDataSet6.LichThiDauVong2' table. You can move, or remove it, as needed.
            this.lichThiDauVong2TableAdapter.Fill(this.vUGDataSet6.LichThiDauVong2);
            // TODO: This line of code loads data into the 'vUGDataSet5.LichThiDauVong1' table. You can move, or remove it, as needed.
            this.lichThiDauVong1TableAdapter.Fill(this.vUGDataSet5.LichThiDauVong1);
            // TODO: This line of code loads data into the 'vUGDataSet.Fotball_Player' table. You can move, or remove it, as needed.
            this.fotball_PlayerTableAdapter.Fill(this.vUGDataSet.Fotball_Player);
            // TODO: This line of code loads data into the 'vUGDataSet2.Coach' table. You can move, or remove it, as needed.
           // this.coachTableAdapter.Fill(this.vUGDataSet2.Coach);
            // TODO: This line of code loads data into the 'vUGDataSet1.Team' table. You can move, or remove it, as needed.
           // this.teamTableAdapter.Fill(this.vUGDataSet1.Team);
            dataGridView2.DataSource = Fotball_Player_BUS.LoadDanhSachTatCaCauThu();
        }

        private void bntLoadDSDoiTuyen_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Team_BUS.LoadDanhSachTatCaDoiTuyen();
        }

        private void bntLoadDSCauThu_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Fotball_Player_BUS.LoadDanhSachTatCaCauThu();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //tim theo ma doi
            if(cbMaDoi.Checked)
            {
                dataGridView2.DataSource = Team_BUS.TimKiemDoiTuyenTheoMaDoi(tbSearch.Text.ToString());
            }
            else
            //tim kiem theo ten doi
                if(cbTenĐoi.Checked)
                {
                    dataGridView2.DataSource = Team_BUS.TimKiemTheoTenDoi(tbSearch.Text.ToString());
                }
                else
                    if(cbMaCauThu.Checked)
                    {
                        dataGridView2.DataSource = Fotball_Player_BUS.TimKiemCauThuTheoMaCauThu(tbSearch.Text.ToString());
                    }
                    else
                        if (cbCauThu.Checked)
                        {
                            dataGridView2.DataSource = Fotball_Player_BUS.TimKiemTheoTenCauThu(tbSearch.Text.ToString());
                        }

        }

        private void cbMaDoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCauThu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTenDoiVaTenCauThu_CheckedChanged(object sender, EventArgs e)
        {
            lbTenCauThu.Visible = true;
            lbTenDoi.Visible = true;
            tbTenDoiHiden.Visible = true;
            tbTenCauThuHiden.Visible = true;
            btSearch2.Visible = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSearch2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Fotball_Player_BUS.TimKiemTheoTenDoiTuyenVaTenCauThu(tbTenDoiHiden.Text.ToString(), tbTenCauThuHiden.Text.ToString());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            //String ID_FP =  tbID_FP.Text.ToString();
            string Team_ID = tbTeam.Text;
            string FP_FirstName = tbFirst_Name.Text;
            string FP_LastName = tbFP_LastName.Text;

            string Date_of_Birth_FP = "";
            string Country = "VietNam";
            string job = tbjob.Text.ToString();

            
            Fotball_Player_BUS.ThemCauThu(Team_ID,  FP_FirstName,  FP_LastName, Date_of_Birth_FP,Country, job);

            dataGridView1.DataSource = Fotball_Player_BUS.TimKiemTheoTenCauThu(tbFP_LastName.Text.ToString());
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

            string ID_FP = tbMaCauThu.Text.ToString();
            string Team_ID = tbTeam.Text;
            string FP_FirstName = tbFirst_Name.Text;
            string FP_LastName = tbFP_LastName.Text;

            string Date_of_Birth_FP = "";
            string Country = "VietNam";
            string job = tbjob.Text.ToString();


            Fotball_Player_BUS.CapNhapCauThu(ID_FP,Team_ID, FP_FirstName, FP_LastName, Date_of_Birth_FP, Country, job);

            dataGridView1.DataSource = Fotball_Player_BUS.TimKiemCauThuTheoMaCauThu(ID_FP);
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            string id_fp = tbMaCauThu.Text.ToString();
            Fotball_Player_BUS.XoaCauThu(id_fp);
            dataGridView1.DataSource = Fotball_Player_BUS.LoadDanhSachTatCaCauThu();
        }


        private void Form1_Paint(int x1, int y1, int x2, int y2, Color m)
        {
            Graphics dohoa = this.CreateGraphics();
            /*int x1 = 200, y1 = 50;
            int x2 = 400, y2 = 100;*/
            dohoa.DrawLine(new Pen(m, 5), x1, y1, x2, y2);
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //label22.Text = 
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        /*private void button12_Click(object sender, EventArgs e)
        {
            string ID_FT = cbTenCauThu.SelectedValue.ToString();
            string ID_Team_old = cbDoituyencu.SelectedText.ToString();
            string ID_Team_new = cbTendoituyenmoi.SelectedText.ToString();
            int price = int.Parse(cbGia.Text.ToString());

            Tranfer_BUS.ThemMotChuyenNhuongMoi(ID_FT, ID_Team_new, ID_Team_old, price);
            dataGridView9.Refresh(); 
        }*/

       
    }
    }

