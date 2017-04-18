using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class Fotball_Player_BUS

    {
        //load danh sach tat ca cau thu
        public static DataTable LoadDanhSachTatCaCauThu()
        {
            return Fotball_Player_DAO.LoadDSTatCaCauThu();
        }
      
        //them 1 sach moi

        public static void ThemCauThu(string Team_ID1, string FP_FirstName1, string FP_LastName1, string _Date_of_Birth_FP1, string Country1, string job1)
        {
            Fotball_Player_DAO.ThemMotCauThuMoi( Team_ID1,  FP_FirstName1,  FP_LastName1, _Date_of_Birth_FP1,  Country1,  job1);
        }


        public static DataTable TimKiemCauThuTheoMaCauThu(String MaCauThu)
        {

            return Fotball_Player_DAO.TimkiemCauThuTheoMaCauThu(MaCauThu);
        }
        public static DataTable TimKiemTheoTenCauThu(String TenCauThu)
        {
            return Fotball_Player_DAO.TimkiemCauThuTheoTenCauThu(TenCauThu);
        }
        public static DataTable TimKiemTheoTenDoiTuyenVaTenCauThu(String TenDoiTuyen,String TenCauThu)
        {
            return Fotball_Player_DAO.TimkiemCauThuTheoTenDoiTuyenVaTenCauThu(TenDoiTuyen,TenCauThu);
        }
        public static void CapNhapCauThu(string ID_FP, string Team_ID, string FP_FirstName, string FP_LastName, string Date_of_Birth_FP, string Country, string job)

        {
            Fotball_Player_DAO.CapNhapCauThu(ID_FP,Team_ID,FP_FirstName,FP_LastName,Date_of_Birth_FP,Country,job);
        }
        public static void XoaCauThu(string ID_FP)
        {
            Fotball_Player_DAO.XoaCauThu(ID_FP);
        }
   
    }
    public class Team_BUS
    {
        public static DataTable LoadDanhSachTatCaDoiTuyen()
        {
            return Team_DAO.LoadDanhSachTatCaDoiTuyen();
        }
        public static DataTable TimKiemDoiTuyenTheoMaDoi(String MaDoi)
        {
            
            return Team_DAO.TimkiemDoiTuyenTheoMaDoi(MaDoi);
        }
        public static DataTable TimKiemTheoTenDoi(String TenDoi)
        {
            return Team_DAO.TimkiemDoiTuyenTheoTenDoi(TenDoi);
        }


    }
    public class Tranfer_BUS
    {
        ///public static void ThemMotChuyenNhuongMoi(string Date_Time, string ID_FT, string ID_Team_old, string ID_Team_new, string Price)
        //{
      //      Tranfer_DAO.ThemMotChuyenNhuongMoi(Date_Time, ID_FT, ID_Team_old, ID_Team_new, Price);
     //   }

       
    }
}
