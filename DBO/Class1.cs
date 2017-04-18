using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;




namespace DAO
{
    public class sqlConectionDaTa
    {
        public static SqlConnection HamKetnoi()
        {
            SqlConnection cnn = new SqlConnection("Server = . ; Database =VUG;Trusted_Connection = true");
            return cnn;

        }
    }
    public class Fotball_Player_DAO

    {
        public static DataTable LoadDSTatCaCauThu()
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_TatCaCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;

        }
     
        //them 1 danh sach moi
        public static void ThemMotCauThuMoi(string Team_ID, string FP_FirstName, string FP_LastName, string Date_of_Birth_FP, string Country, string job)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_ThemCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ID_FP", SqlDbType.NVarChar,10);
            cmd.Parameters.Add("@Team_ID", SqlDbType.NVarChar,10); 
            cmd.Parameters.Add("@FP_FirstName", SqlDbType.NVarChar,50); 
            cmd.Parameters.Add("@FP_LastName", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@Date_of_Birth_FP", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@job", SqlDbType.NVarChar,50);


            //gan gia tri
            
           // cmd.Parameters["@ID_FP"].Value = footBall_Player.ID_FP;
            cmd.Parameters["@Team_ID"].Value = Team_ID;
            cmd.Parameters["@FP_FirstName"].Value = FP_FirstName;
            cmd.Parameters["@FP_LastName"].Value = FP_LastName;
            cmd.Parameters["@Date_of_Birth_FP"].Value = Date_of_Birth_FP;
            cmd.Parameters["@Country"].Value = Country;
            cmd.Parameters["@job"].Value = job;
                
    
            
                   
  
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        //tim kiem cau thu theo ma cau thu
        public static DataTable TimkiemCauThuTheoMaCauThu(String MaCauThu)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoMaCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_FP", SqlDbType.NVarChar, 10);
            cmd.Parameters["@ID_FP"].Value = MaCauThu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //tim kiem cau thu theo ten cau thu
        public static DataTable TimkiemCauThuTheoTenCauThu(String TenCauThu)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTenCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FP_LastName", SqlDbType.NVarChar, 10);
            cmd.Parameters["@FP_LastName"].Value = TenCauThu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //tim kiem cau thu theo ten cau thu va ten doi tuyen
        public static DataTable TimkiemCauThuTheoTenDoiTuyenVaTenCauThu(String TenDoiTuyen,String TenCauThu)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTenDoiVaTenCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Team_Name", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@FP_LastName", SqlDbType.NVarChar, 50);
            cmd.Parameters["@Team_Name"].Value = TenDoiTuyen;
            cmd.Parameters["@FP_LastName"].Value = TenCauThu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }

        //update cau thu

        public static void CapNhapCauThu(string ID_FP,string Team_ID, string FP_FirstName, string FP_LastName, string Date_of_Birth_FP, string Country, string job)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_SuaCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_FP", SqlDbType.NVarChar,10);
            cmd.Parameters.Add("@Team_ID", SqlDbType.NVarChar,10); 
            cmd.Parameters.Add("@FP_FirstName", SqlDbType.NVarChar,50); 
            cmd.Parameters.Add("@FP_LastName", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@Date_of_Birth_FP", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@job", SqlDbType.NVarChar,50);


            //gan gia tri
            
            cmd.Parameters["@ID_FP"].Value = ID_FP;
            cmd.Parameters["@Team_ID"].Value = Team_ID;
            cmd.Parameters["@FP_FirstName"].Value = FP_FirstName;
            cmd.Parameters["@FP_LastName"].Value = FP_LastName;
            cmd.Parameters["@Date_of_Birth_FP"].Value = Date_of_Birth_FP;
            cmd.Parameters["@Country"].Value = Country;
            cmd.Parameters["@job"].Value = job;
              
    
            
                   
  
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        //xoa cau thu
        public static void XoaCauThu(string ID_FP)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_XoaCauThu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_FP", SqlDbType.NVarChar, 10);         
            //gan gia tri
            cmd.Parameters["@ID_FP"].Value = ID_FP;       
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
      
    }
    public class Team_DAO
    {
        //load tat ca doi tuyen
        public static DataTable LoadDanhSachTatCaDoiTuyen()
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("LoadTatCaDoiTuyen", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //tim kiem doi tuyen theo ma doi
        public static DataTable TimkiemDoiTuyenTheoMaDoi(String MaDoi)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoMaDoi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_Team" ,SqlDbType.NVarChar,10);
            cmd.Parameters["@ID_Team"].Value = MaDoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //tim kiem doi tuyen theo ten doi
        public static DataTable TimkiemDoiTuyenTheoTenDoi(String TenDoi)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTenDoi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Team_Name", SqlDbType.NVarChar, 10);
            cmd.Parameters["@Team_Name"].Value = TenDoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
    public class Tranfer_DAO
    {
       /* public static void ThemMotChuyenNhuongMoi(string Date_Time, string ID_FT, string ID_Team_old,string ID_Team_new,string Price)
        {
            SqlConnection cnn = sqlConectionDaTa.HamKetnoi();
            SqlCommand cmd = new SqlCommand("sp_ThemChuyenNhuong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ID_FP", SqlDbType.NVarChar,10);
            cmd.Parameters.Add("@Date_Time", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@ID_FT", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@ID_Team_old", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@ID_Team_new", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@Price", SqlDbType.Int);


            //gan gia tri

            // cmd.Parameters["@ID_FP"].Value = footBall_Player.ID_FP;
            cmd.Parameters["@Date_Time"].Value = Date_Time;
            cmd.Parameters["@ID_FT"].Value = ID_FT;
            cmd.Parameters["@ID_Team_old"].Value = ID_Team_old;
            cmd.Parameters["@ID_Team_new"].Value = ID_Team_new;
            cmd.Parameters["@Price"].Value = Price;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }*/
    }
}
