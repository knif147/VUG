using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //khai bao co so du lieu bang Football_Player
    public class Football_Player_DTO
    {
        private string _ID_FP;


        public string ID_FP
        {
            get { return ID_FP; }
            set { ID_FP = value; }
        }
       


        
        private string _Team_ID;

        public string Team_ID
        {
          get { return _Team_ID; }
          set { _Team_ID = value; }
        }

        
        private string _FP_FirstName;

        public string FP_FirstName
        {
          get { return _FP_FirstName; }
          set { _FP_FirstName = value; }
        }

        
        private string _FP_LastName;

        public string FP_LastName
        {
          get { return _FP_LastName; }
          set { _FP_LastName = value; }
        }

        
        private string _Date_of_Birth_FP;

        public string Date_of_Birth_FP
        {
          get { return _Date_of_Birth_FP; }
          set { _Date_of_Birth_FP = value; }
        }

        
        private string _Country;

        public string Country
        {
          get { return _Country; }
          set { _Country = value; }
        }


        private string _job;
        public string job
        {
            get { return _job; }
            set { _job = value; }
        }


        public Football_Player_DTO( string Team_ID1, string FP_FirstName1, string FP_LastName1, string _Date_of_Birth_FP1, string Country1, string job1)
        {
            // TODO: Complete member initialization
            Team_ID = Team_ID1;
            FP_FirstName = FP_FirstName1;
            FP_LastName = FP_LastName1;
            Date_of_Birth_FP = _Date_of_Birth_FP1;
            Country = Country1;
            job = job1;
        }

      

        
    }


    //khai bao co so du lieu bang Coach
    public class Coach_DTO
    {
        private String _ID_Coach;

        public String ID_Coach
        {
          get { return _ID_Coach; }
          set { _ID_Coach = value; }
        }


        private String _Team_ID;

        public String Team_ID
        {
          get { return _Team_ID; }
          set { _Team_ID = value; }
        }

        
        private String _Coach_FirstName;

        public String Coach_FirstName
        {
          get { return _Coach_FirstName; }
          set { _Coach_FirstName = value; }
        }

       
        private String _Coach_LastName;

        public String Coach_LastName
        {
          get { return _Coach_LastName; }
          set { _Coach_LastName = value; }
        }

      
               
        private String _Country;

        public String Country
        {
          get { return _Country; }
          set { _Country = value; }
        }

      
    }


    //khai bao co so du lieu bang Team
    public class Team_DTO
    {
        private String _ID_Team;

        public String ID_Team
        {
          get { return _ID_Team; }
          set { _ID_Team = value; }
        }

        

        private String _ID_Coach;

        public String ID_Coach
        {
          get { return _ID_Coach; }
          set { _ID_Coach = value; }
        }

       

        private String _Team_Name;

        public String Team_Name
        {
          get { return _Team_Name; }
          set { _Team_Name = value; }
        }

        

        private DateTime _Year_Of_Establish;

        public DateTime Year_Of_Establish
        {
          get { return _Year_Of_Establish; }
          set { _Year_Of_Establish = value; }
        }

        

        private String _Dornors;

        public String Dornors
        {
          get { return _Dornors; }
          set { _Dornors = value; }
        }

        

    }

    //khai bao co so du lieu bang Tranfers
    public class Transfer_DTO
    {
        private String _ID_Transfer;

        public String ID_Transfer
        {
            get { return _ID_Transfer; }
            set { _ID_Transfer = value; }
        }
        private DateTime _Date_Time;

        public DateTime Date_Time
        {
            get { return _Date_Time; }
            set { _Date_Time = value; }
        }
        private String _ID_FT;

        public String ID_FT
        {
            get { return _ID_FT; }
            set { _ID_FT = value; }
        }
        private String _ID_Team_old;

        public String ID_Team_old
        {
            get { return _ID_Team_old; }
            set { _ID_Team_old = value; }
        }
        private String _ID_Team_new;

        public String ID_Team_new
        {
            get { return _ID_Team_new; }
            set { _ID_Team_new = value; }
        }
        private String _Price;

        public String Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

    }

    //khai bao co so du lieu bang Tournaments
    public class Tournaments_DTO
    {
        private String _ID_Tournaments;

        public String ID_Tournaments
        {
            get { return _ID_Tournaments; }
            set { _ID_Tournaments = value; }
        }
        private String _Tournaments_Name;

        public String Tournaments_Name
        {
            get { return _Tournaments_Name; }
            set { _Tournaments_Name = value; }
        }
        private String _Tournaments_first_prize;

        public String Tournaments_first_prize
        {
            get { return _Tournaments_first_prize; }
            set { _Tournaments_first_prize = value; }
        }
        private String _Tournaments_second_prize;

        public String Tournaments_second_prize
        {
            get { return _Tournaments_second_prize; }
            set { _Tournaments_second_prize = value; }
        }
        private String _Tournaments_third_prize;

        public String Tournaments_third_prize
        {
            get { return _Tournaments_third_prize; }
            set { _Tournaments_third_prize = value; }
        }
    }

    //khai bao co so du lieu bang Score
    public class Score_DTO
    {
        private String _ID_Score;

        public String ID_Score
        {
            get { return _ID_Score; }
            set { _ID_Score = value; }
        }
        private String _Team_name_1;

        public String Team_name_1
        {
            get { return _Team_name_1; }
            set { _Team_name_1 = value; }
        }
        private String _Team_name_2;

        public String Team_name_2
        {
            get { return _Team_name_2; }
            set { _Team_name_2 = value; }
        }
        private String _Team_name_win;

        public String Team_name_win
        {
            get { return _Team_name_win; }
            set { _Team_name_win = value; }
        }
        private String _Score;

        public String Score1
        {
            get { return _Score; }
            set { _Score = value; }
        }
    }

    //khai bao co so du lieu bang Penance
    public class Penance_DTO
    {
        private String _ID_Penance;

        public String ID_Penance
        {
            get { return _ID_Penance; }
            set { _ID_Penance = value; }
        }
        private String _ID_FP;

        public String ID_FP
        {
            get { return _ID_FP; }
            set { _ID_FP = value; }
        }
        private String _Penalty_rate;

        public String Penalty_rate
        {
            get { return _Penalty_rate; }
            set { _Penalty_rate = value; }
        }
        private String _ReaSon;

        public String ReaSon
        {
            get { return _ReaSon; }
            set { _ReaSon = value; }
        }
    }
}
