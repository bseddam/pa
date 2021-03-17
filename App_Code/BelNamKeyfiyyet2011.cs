using System;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;


/// <summary>
/// Summary description for BelNamKeyfiyyet 2011
/// </summary>
public class BelNamKeyfiyyet2011
{
    public BelNamKeyfiyyet2011()
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");

    }

    public static List<BelNam2011> CreateResListOfBelNam(string FormDate)
    {
        
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                        "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                        "RegionID,Municipality," +
                        "Notification,NotificationRejection,NotificationCancellation," +
                        "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                        "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                        "Register,Cancellation,CallBack,Election1999,Election2004,Election2009 " +
                        " from MunQuery2011 ";
        if (FormDate != null)
        {
            strSQL = strSQL + " where CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " where FormDate=(select max(FormDate) from MunCandidateInformation)";
        }
        List<BelNam2011> lbn = new List<BelNam2011>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2011 bn = new BelNam2011();
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
                bn.Municipality = sdr.GetByte(12);
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

    public static List<BelNam2011> CreateRegListOfBelNam(string FormDate, string reg)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                       "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                       "RegionID,Municipality," +
                       "Notification,NotificationRejection,NotificationCancellation," +
                       "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                       "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                       "Register,Cancellation,CallBack,Election1999,Election2004,Election2009 " +
                       " from MunQuery2011 ";
        if (FormDate != null)
        {
            strSQL = strSQL + " where RegionID=" + reg.ToString() + " and CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " where RegionID=" + reg.ToString() + " and FormDate=(select max(FormDate) from MunCandidateInformation where RegionID=" + reg.ToString() + ")";
        }
        List<BelNam2011> lbn = new List<BelNam2011>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2011 bn = new BelNam2011();
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
                bn.Municipality = sdr.GetByte(12);
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

    public static List<BelNam2011> CreateMunListOfBelNam(string FormDate, string reg, string mun)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        //string strSQL = "select mmcd.SurnameOfCandidate, mmcd.NameOfCandidate, mmcd.PatronymicOfCandidate, mmcd.JobAndPosition, mmcd.EducationalInstitution,mmcd.MainCandidate,mmcd.MaleCandidate,mmcd.CECApprove,mmcd.DateBirthOfCandidate, mmcd.EducationOfCandidate, mmcd.PartyMembership,mmc.CandidateID, " +
        //                "mmc.RegionID,mmc.Municipality " +
        //                " from MunMemberCandidate mmc inner join MunMemberCandidateDetails mmcd " +
        //                "on mmc.CandidateID=mmcd.CandidateID";
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPositionOfCandidate, EducationalInstitutionOfCandidate," +
                          "CandidateTip,CandidateSex,DateBirthOfCandidate, EducationOfCandidate, PartyMembershipOfCandidate,CandidateID, " +
                          "RegionID,Municipality," +
                          "Notification,NotificationRejection,NotificationCancellation," +
                          "SubscriptionListTake,SubscriptionListTakeRejection,SubscriptionListTakeCancellation," +
                          "SubscriptionListReturn,SubscriptionListReturnRejection,SubscriptionListReturnCancellation," +
                          "Register,Cancellation,CallBack,Election1999,Election2004,Election2009 " +
                          " from MunQuery2011 ";
        if (FormDate != null)
        {
            strSQL = strSQL + " where Municipality=" + mun + " and RegionID=" + reg.ToString() + " and CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " where Municipality=" + mun + " and RegionID=" + reg.ToString() + " and FormDate=(select max(FormDate) from RegionMunicipality where Municipality=" + mun + " and RegionID=" + reg.ToString() + ")";
        }
        List<BelNam2011> lbn = new List<BelNam2011>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam2011 bn = new BelNam2011();
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
                bn.Municipality = sdr.GetByte(12);
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


public struct BelNam2011
{
    private string _SurnameOfCandidate, _NameOfCandidate, _PatronymicOfCandidate, _JobAndPosition, _EducationalInstitution, _CandidateType, _Gender;
    private bool _IsCECApprove;
    private Byte _EducationOfCandidate, _PartyMembership, _RegionID, _Municipality;
    private long _CandidateID;
    private DateTime _DateBirthOfCandidate;

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
    public byte Municipality
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
                _Election1999, _Election2004, _Election2009;
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
