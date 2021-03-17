using System;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;


/// <summary>
/// Summary description for BelNamKeyfiyyet 2014
/// </summary>

public class BelNamKeyfiyyet2014
{
    public BelNamKeyfiyyet2014()
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");

    }

    public static List<BelNam2014> CreateResListOfBelNam(string FormDate, byte settings)
    {

        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                        "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                        "RegionID,Municipality," +
                        "Notification,NotificationRejection,NotificationCancellation," +
                        "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                        "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                        "Register,Cancellation,CallBack,Election1999,Election2004,Election2009,FormDate,RecommendParty,NationalityOfCandidate,Recommend,Selected,DateElectionOfChief,DateElectionOfViceChief  " +
                        " from MunQuery2014 where 1=1  ";
        if (settings != 1)
        {
            //if (FormDate != null)
            //{
            //    strSQL = strSQL + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
            //}
            //else
            //{
            //    strSQL = strSQL + " and  FormDate=(select max(FormDate) from MunCandidateInformation)";
            //}
            strSQL = strSQL + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + "  and  Notification=0 ";
        }
        List<BelNam2014> lbn = new List<BelNam2014>();
        using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2014 bn = new BelNam2014();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetString(5);
                bn.Gender = sdr.GetString(6);
                bn.DateBirthOfCandidate = sdr.GetDateTime(7);
                bn.EducationOfCandidate = sdr.GetByte(8);
                bn.PartyMembership = sdr.GetByte(9);
                bn.CandidateID = (int)sdr.GetInt32(10);
                bn.RegionID = sdr.GetByte(11);
                bn.Municipality = (int)sdr.GetInt32(12);
                bn.Notification = sdr.GetBoolean(13);
                bn.NotificationRejection = sdr.GetBoolean(14);
                bn.NotificationCancellation = sdr.GetBoolean(15);
                bn.SubscriptionListTake = sdr.GetBoolean(16);
                bn.SubscriptionListTakeRejection = sdr.GetBoolean(17);
                bn.SubscriptionListTakeCancellation = sdr.GetBoolean(18);
                bn.SubscriptionListReturn = sdr.GetBoolean(19);
                bn.SubscriptionListReturnRejection = sdr.GetBoolean(20);
                bn.SubscriptionListReturnCancellation = sdr.GetBoolean(21);
                bn.Register = sdr.GetBoolean(22);
                bn.Cancellation = sdr.GetBoolean(23);
                bn.CallBack = sdr.GetBoolean(24);
                bn.Election1999 = sdr.GetBoolean(25);
                bn.Election2004 = sdr.GetBoolean(26);
                bn.Election2009 = sdr.GetBoolean(27);
                bn.RecommendParty = sdr.IsDBNull(29) ? 0 : Convert.ToInt32(sdr[29].ToString());
                bn.NationalityOfCandidate = sdr.IsDBNull(30) ? 0 : Convert.ToInt32(sdr[30].ToString());
                bn.Recommend = sdr.IsDBNull(31) ? "" : sdr[31].ToString();
                bn.Selected = sdr.GetBoolean(32);
                bn.DateElectionOfChief = sdr.IsDBNull(33) ? DateTime.MinValue : sdr.GetDateTime(33);
                bn.DateElectionOfViceChief=  sdr.IsDBNull(34) ? DateTime.MinValue:sdr.GetDateTime(34);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam2014> CreateRegListOfBelNam(string FormDate, string reg, byte settings)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                       "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                       "RegionID,Municipality," +
                       "Notification,NotificationRejection,NotificationCancellation," +
                       "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                       "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                       "Register,Cancellation,CallBack,Election1999,Election2004,Election2009,FormDate,RecommendParty,NationalityOfCandidate,Recommend,Selected,DateElectionOfChief,DateElectionOfViceChief " +
                       " from MunQuery2014 where 1=1 ";
        if (settings != 1)
        {
            //if (FormDate != null)
            //{
            //    strSQL = strSQL + " and  RegionID=" + reg.ToString() + " and CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
            //}
            //else
            //{
            //    strSQL = strSQL + " and  RegionID=" + reg.ToString() + " and FormDate=(select max(FormDate) from MunCandidateInformation where RegionID=" + reg.ToString() + ")";
            //}
            strSQL = strSQL + " and  RegionID=" + reg.ToString() + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " and  Notification=0 and  RegionID=" + reg.ToString();//
        }
        List<BelNam2014> lbn = new List<BelNam2014>();
        using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2014 bn = new BelNam2014();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetString(5);
                bn.Gender = sdr.GetString(6);
                bn.DateBirthOfCandidate = sdr.GetDateTime(7);
                bn.EducationOfCandidate = sdr.GetByte(8);
                bn.PartyMembership = sdr.GetByte(9);
                bn.CandidateID = (int)sdr.GetInt32(10);
                bn.RegionID = sdr.GetByte(11);
                bn.Municipality = (int)sdr.GetInt32(12);
                bn.Notification = sdr.GetBoolean(13);
                bn.NotificationRejection = sdr.GetBoolean(14);
                bn.NotificationCancellation = sdr.GetBoolean(15);
                bn.SubscriptionListTake = sdr.GetBoolean(16);
                bn.SubscriptionListTakeRejection = sdr.GetBoolean(17);
                bn.SubscriptionListTakeCancellation = sdr.GetBoolean(18);
                bn.SubscriptionListReturn = sdr.GetBoolean(19);
                bn.SubscriptionListReturnRejection = sdr.GetBoolean(20);
                bn.SubscriptionListReturnCancellation = sdr.GetBoolean(21);
                bn.Register = sdr.GetBoolean(22);
                bn.Cancellation = sdr.GetBoolean(23);
                bn.CallBack = sdr.GetBoolean(24);
                bn.Election1999 = sdr.GetBoolean(25);
                bn.Election2004 = sdr.GetBoolean(26);
                bn.Election2009 = sdr.GetBoolean(27);
                bn.RecommendParty = sdr.IsDBNull(29) ? 0 : Convert.ToInt32(sdr[29].ToString());
                bn.NationalityOfCandidate = sdr.IsDBNull(30) ? 0 : Convert.ToInt32(sdr[30].ToString());
                bn.Recommend = sdr.IsDBNull(31) ? "" : sdr[31].ToString();
                bn.Selected = sdr.GetBoolean(32);
                bn.DateElectionOfChief = sdr.IsDBNull(33) ? DateTime.MinValue : sdr.GetDateTime(33);
                bn.DateElectionOfViceChief = sdr.IsDBNull(34) ? DateTime.MinValue : sdr.GetDateTime(34);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam2014> CreateMunListOfBelNam(string FormDate, string reg, string mun, byte settings)
    {
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                          "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                          "RegionID,Municipality," +
                          "Notification,NotificationRejection,NotificationCancellation," +
                          "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                          "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                          "Register,Cancellation,CallBack,Election1999,Election2004,Election2009,FormDate,RecommendParty,NationalityOfCandidate,Recommend,Selected,DateElectionOfChief,DateElectionOfViceChief " +
                          " from MunQuery2014 where 1=1 ";
        if (settings != 1)
        {
            //if (FormDate != null)
            //{
            //    strSQL = strSQL + "  and Municipality=" + mun + " and RegionID=" + reg.ToString() + " and CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
            //}
            //else
            //{
            //    strSQL = strSQL + "  and Municipality=" + mun + " and RegionID=" + reg.ToString() + " and FormDate=(select max(FormDate) from RegionMunicipality where Municipality=" + mun + " and RegionID=" + reg.ToString() + ")";
            //}
            strSQL = strSQL + "  and Municipality=" + mun + " and  RegionID=" + reg.ToString() + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " and  Notification=0 and Municipality=" + mun + " and RegionID=" + reg.ToString();
        }
        List<BelNam2014> lbn = new List<BelNam2014>();
        using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2014 bn = new BelNam2014();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetString(5);
                bn.Gender = sdr.GetString(6);
                bn.DateBirthOfCandidate = sdr.GetDateTime(7);
                bn.EducationOfCandidate = sdr.GetByte(8);
                bn.PartyMembership = sdr.GetByte(9);
                bn.CandidateID = (int)sdr.GetInt32(10);
                bn.RegionID = sdr.GetByte(11);
                bn.Municipality = (int)sdr.GetInt32(12);
                bn.Notification = sdr.GetBoolean(13);
                bn.NotificationRejection = sdr.GetBoolean(14);
                bn.NotificationCancellation = sdr.GetBoolean(15);
                bn.SubscriptionListTake = sdr.GetBoolean(16);
                bn.SubscriptionListTakeRejection = sdr.GetBoolean(17);
                bn.SubscriptionListTakeCancellation = sdr.GetBoolean(18);
                bn.SubscriptionListReturn = sdr.GetBoolean(19);
                bn.SubscriptionListReturnRejection = sdr.GetBoolean(20);
                bn.SubscriptionListReturnCancellation = sdr.GetBoolean(21);
                bn.Register = sdr.GetBoolean(22);
                bn.Cancellation = sdr.GetBoolean(23);
                bn.CallBack = sdr.GetBoolean(24);
                bn.Election1999 = sdr.GetBoolean(25);
                bn.Election2004 = sdr.GetBoolean(26);
                bn.Election2009 = sdr.GetBoolean(27);
                bn.RecommendParty = sdr.IsDBNull(29) ? 0 : Convert.ToInt32(sdr[29].ToString());
                bn.NationalityOfCandidate = sdr.IsDBNull(30) ? 0 : Convert.ToInt32(sdr[30].ToString());
                bn.Recommend = string.IsNullOrEmpty(sdr[31].ToString()) ? "" : sdr[31].ToString();
                bn.Selected = sdr.GetBoolean(32);
                bn.DateElectionOfChief = sdr.IsDBNull(33) ? DateTime.MinValue : sdr.GetDateTime(33);
                bn.DateElectionOfViceChief = sdr.IsDBNull(34) ? DateTime.MinValue : sdr.GetDateTime(34);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam2014> CreateResListOfBelNamPre(string FormDate, byte settings)
    {

        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                        "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                        "RegionID,Municipality," +
                        "Notification,NotificationRejection,NotificationCancellation," +
                        "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                        "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                        "Register,Cancellation,CallBack,Election1999,Election2004,Election2009,FormDate  " +
                        " from MunQuery2014 where 1=1  "; //convert(varchar,FORMDATE,104)='25.10.2014'
        strSQL = strSQL + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "' ";
        List<BelNam2014> lbn = new List<BelNam2014>();
        using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2014 bn = new BelNam2014();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetString(5);
                bn.Gender = sdr.GetString(6);
                bn.DateBirthOfCandidate = sdr.GetDateTime(7);
                bn.EducationOfCandidate = sdr.GetByte(8);
                bn.PartyMembership = sdr.GetByte(9);
                bn.CandidateID = (int)sdr.GetInt32(10);
                bn.RegionID = sdr.GetByte(11);
                bn.Municipality = (int)sdr.GetInt32(12);
                bn.Notification = sdr.GetBoolean(13);
                bn.NotificationRejection = sdr.GetBoolean(14);
                bn.NotificationCancellation = sdr.GetBoolean(15);
                bn.SubscriptionListTake = sdr.GetBoolean(16);
                bn.SubscriptionListTakeRejection = sdr.GetBoolean(17);
                bn.SubscriptionListTakeCancellation = sdr.GetBoolean(18);
                bn.SubscriptionListReturn = sdr.GetBoolean(19);
                bn.SubscriptionListReturnRejection = sdr.GetBoolean(20);
                bn.SubscriptionListReturnCancellation = sdr.GetBoolean(21);
                bn.Register = sdr.GetBoolean(22);
                bn.Cancellation = sdr.GetBoolean(23);
                bn.CallBack = sdr.GetBoolean(24);
                bn.Election1999 = sdr.GetBoolean(25);
                bn.Election2004 = sdr.GetBoolean(26);
                bn.Election2009 = sdr.GetBoolean(27);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam2014> CreateRegListOfBelNamPre(string FormDate, string reg, byte settings)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                       "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                       "RegionID,Municipality," +
                       "Notification,NotificationRejection,NotificationCancellation," +
                       "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                       "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                       "Register,Cancellation,CallBack,Election1999,Election2004,Election2009 " +
                       " from MunQuery2014 where 1=1   ";
        strSQL = strSQL + " and  RegionID=" + reg.ToString() + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        List<BelNam2014> lbn = new List<BelNam2014>();
        using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2014 bn = new BelNam2014();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetString(5);
                bn.Gender = sdr.GetString(6);
                bn.DateBirthOfCandidate = sdr.GetDateTime(7);
                bn.EducationOfCandidate = sdr.GetByte(8);
                bn.PartyMembership = sdr.GetByte(9);
                bn.CandidateID = (int)sdr.GetInt32(10);
                bn.RegionID = sdr.GetByte(11);
                bn.Municipality = (int)sdr.GetInt32(12);
                bn.Notification = sdr.GetBoolean(13);
                bn.NotificationRejection = sdr.GetBoolean(14);
                bn.NotificationCancellation = sdr.GetBoolean(15);
                bn.SubscriptionListTake = sdr.GetBoolean(16);
                bn.SubscriptionListTakeRejection = sdr.GetBoolean(17);
                bn.SubscriptionListTakeCancellation = sdr.GetBoolean(18);
                bn.SubscriptionListReturn = sdr.GetBoolean(19);
                bn.SubscriptionListReturnRejection = sdr.GetBoolean(20);
                bn.SubscriptionListReturnCancellation = sdr.GetBoolean(21);
                bn.Register = sdr.GetBoolean(22);
                bn.Cancellation = sdr.GetBoolean(23);
                bn.CallBack = sdr.GetBoolean(24);
                bn.Election1999 = sdr.GetBoolean(25);
                bn.Election2004 = sdr.GetBoolean(26);
                bn.Election2009 = sdr.GetBoolean(27);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam2014> CreateMunListOfBelNamPre(string FormDate, string reg, string mun, byte settings)
    {
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                          "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                          "RegionID,Municipality," +
                          "Notification,NotificationRejection,NotificationCancellation," +
                          "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                          "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                          "Register,Cancellation,CallBack,Election1999,Election2004,Election2009 " +
                          " from MunQuery2014 where 1=1   ";
        strSQL = strSQL + "  and Municipality=" + mun + " and  RegionID=" + reg.ToString() + " and  CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";

        List<BelNam2014> lbn = new List<BelNam2014>();
        using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2014 bn = new BelNam2014();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetString(5);
                bn.Gender = sdr.GetString(6);
                bn.DateBirthOfCandidate = sdr.GetDateTime(7);
                bn.EducationOfCandidate = sdr.GetByte(8);
                bn.PartyMembership = sdr.GetByte(9);
                bn.CandidateID = (int)sdr.GetInt32(10);
                bn.RegionID = sdr.GetByte(11);
                bn.Municipality = (int)sdr.GetInt32(12);
                bn.Notification = sdr.GetBoolean(13);
                bn.NotificationRejection = sdr.GetBoolean(14);
                bn.NotificationCancellation = sdr.GetBoolean(15);
                bn.SubscriptionListTake = sdr.GetBoolean(16);
                bn.SubscriptionListTakeRejection = sdr.GetBoolean(17);
                bn.SubscriptionListTakeCancellation = sdr.GetBoolean(18);
                bn.SubscriptionListReturn = sdr.GetBoolean(19);
                bn.SubscriptionListReturnRejection = sdr.GetBoolean(20);
                bn.SubscriptionListReturnCancellation = sdr.GetBoolean(21);
                bn.Register = sdr.GetBoolean(22);
                bn.Cancellation = sdr.GetBoolean(23);
                bn.CallBack = sdr.GetBoolean(24);
                bn.Election1999 = sdr.GetBoolean(25);
                bn.Election2004 = sdr.GetBoolean(26);
                bn.Election2009 = sdr.GetBoolean(27);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

}


public struct BelNam2014
{
    private string _SurnameOfCandidate, _NameOfCandidate, _PatronymicOfCandidate, _JobAndPosition, _EducationalInstitution, _CandidateType, _Gender, _Recommend;
    private bool _IsCECApprove;
    private Byte _EducationOfCandidate, _PartyMembership, _RegionID;
    private int _Municipality, _NationalityOfCandidate, _RecommendParty;
    private long _CandidateID;
    private DateTime _DateBirthOfCandidate, _DateElectionOfChief, _DateElectionOfViceChief;

    public string SurnameOfCandidate
    {
        get { return _SurnameOfCandidate; }
        set { _SurnameOfCandidate = value; }
    }
    public string NameOfCandidate
    {
        get { return _NameOfCandidate; }
        set { _NameOfCandidate = value; }
    }
    public string PatronymicOfCandidate
    {
        get { return _PatronymicOfCandidate; }
        set { _PatronymicOfCandidate = value; }
    }
    public string JobAndPosition
    {
        get { return _JobAndPosition; }
        set { _JobAndPosition = value; }
    }
    public string EducationalInstitution
    {
        get { return _EducationalInstitution; }
        set { _EducationalInstitution = value; }
    }
    public string CandidateType
    {
        get { return _CandidateType; }
        set { _CandidateType = value; }
    }
    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }

    public DateTime DateElectionOfChief
    {
        get { return _DateElectionOfChief; }
        set { _DateElectionOfChief = value; }
    }
    public DateTime DateElectionOfViceChief
    {
        get { return _DateElectionOfViceChief; }
        set { _DateElectionOfViceChief = value; }
    }
    public DateTime DateBirthOfCandidate
    {
        get { return _DateBirthOfCandidate; }
        set { _DateBirthOfCandidate = value; }
    }
    public byte EducationOfCandidate
    {
        get { return _EducationOfCandidate; }
        set { _EducationOfCandidate = value; }
    }
    public string Recommend
    {
        get { return _Recommend; }
        set { _Recommend = value; }
    }
    public int RecommendParty
    {
        get { return _RecommendParty; }
        set { _RecommendParty = value; }
    }
    public int NationalityOfCandidate
    {
        get { return _NationalityOfCandidate; }
        set { _NationalityOfCandidate = value; }
    }

    public byte PartyMembership
    {
        get { return _PartyMembership; }
        set { _PartyMembership = value; }
    }
    public long CandidateID
    {
        get { return _CandidateID; }
        set { _CandidateID = value; }
    }
    public byte RegionID
    {
        get { return _RegionID; }
        set { _RegionID = value; }
    }
    public int Municipality
    {
        get { return _Municipality; }
        set { _Municipality = value; }
    }
    /*
     "Notification,NotificationRejection,NotificationCancellation,"+
                        "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation,"+
                        "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation,"+
                        "Register,Cancellation,CallBack " +
     */
    private bool _Notification, _NotificationRejection, _NotificationCancellation,
                _SubscriptionListTake, _SubscriptionListTakeRejection, _SubscriptionListTakeCancellation,
                _SubscriptionListReturn, _SubscriptionListReturnRejection, _SubscriptionListReturnCancellation,
                _Register, _Cancellation, _CallBack,
                _Election1999, _Election2004, _Election2009, _Selected;
    public bool IsCECApprove
    {
        get { return _IsCECApprove; }
        set { _IsCECApprove = value; }
    }
    public bool Notification
    {
        get { return _Notification; }
        set { _Notification = value; }
    }
    public bool NotificationRejection
    {
        get { return _NotificationRejection; }
        set { _NotificationRejection = value; }
    }
    public bool NotificationCancellation
    {
        get { return _NotificationCancellation; }
        set { _NotificationCancellation = value; }
    }

    public bool SubscriptionListTake
    {
        get { return _SubscriptionListTake; }
        set { _SubscriptionListTake = value; }
    }
    public bool SubscriptionListTakeRejection
    {
        get { return _SubscriptionListTakeRejection; }
        set { _SubscriptionListTakeRejection = value; }
    }
    public bool SubscriptionListTakeCancellation
    {
        get { return _SubscriptionListTakeCancellation; }
        set { _SubscriptionListTakeCancellation = value; }
    }

    public bool SubscriptionListReturn
    {
        get { return _SubscriptionListReturn; }
        set { _SubscriptionListReturn = value; }
    }
    public bool SubscriptionListReturnRejection
    {
        get { return _SubscriptionListReturnRejection; }
        set { _SubscriptionListReturnRejection = value; }
    }
    public bool SubscriptionListReturnCancellation
    {
        get { return _SubscriptionListReturnCancellation; }
        set { _SubscriptionListReturnCancellation = value; }
    }
    public bool Selected
    {
        get { return _Selected; }
        set { _Selected = value; }
    }
    public bool Register
    {
        get { return _Register; }
        set { _Register = value; }
    }
    public bool Cancellation
    {
        get { return _Cancellation; }
        set { _Cancellation = value; }
    }
    public bool CallBack
    {
        get { return _CallBack; }
        set { _CallBack = value; }
    }

    public bool Election1999
    {
        get { return _Election1999; }
        set { _Election1999 = value; }
    }
    public bool Election2004
    {
        get { return _Election2004; }
        set { _Election2004 = value; }
    }
    public bool Election2009
    {
        get { return _Election2009; }
        set { _Election2009 = value; }
    }
}
