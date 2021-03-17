using System;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;


/// <summary>
/// Summary description for BelNamKeyfiyyet
/// </summary>
public class BelNamKeyfiyyet
{
	public BelNamKeyfiyyet()
	{
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");

	}

    public static List<BelNam> CreateResListOfBelNam(string FormDate)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        //string strSQL = "select mmcd.SurnameOfCandidate, mmcd.NameOfCandidate, mmcd.PatronymicOfCandidate, mmcd.JobAndPosition, mmcd.EducationalInstitution,mmcd.MainCandidate,mmcd.MaleCandidate,mmcd.CECApprove,mmcd.BirthYearOfCandidate, mmcd.EducationOfCandidate, mmcd.PartyMembership,mmc.CandidateID, " +
        //                "mmc.RegionID,mmc.Municipality "+
        //                " from MunMemberCandidate mmc inner join MunMemberCandidateDetails mmcd " +
        //                "on mmc.CandidateID=mmcd.CandidateID";
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPosition, EducationalInstitution,MainCandidate,MaleCandidate,CECApprove,BirthYearOfCandidate, EducationOfCandidate, PartyMembership,CandidateID, " +
                      "RegionID,Municipality " +
                      " from MunQuery ";
        if (FormDate != null)
        {
            strSQL = strSQL + " where CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " where FormDate=(select max(FormDate) from MunMemberCandidate)";
        }
        List<BelNam> lbn = new List<BelNam>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam bn = new BelNam();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate= sdr.GetString(1);
                bn.PatronymicOfCandidate =  sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution =  sdr.GetString(4);
                bn.CandidateType = sdr.GetBoolean(5);
                bn.Gender = sdr.GetBoolean(6);
                bn.IsCECApprove = sdr.GetBoolean(7);
                bn.BirthYearOfCandidate = (int)sdr.GetInt16(8);
                bn.EducationOfCandidate = sdr.GetByte(9);
                bn.PartyMembership = sdr.GetByte(10);
                bn.CandidateID = sdr.GetInt32(11);
                bn.RegionID = sdr.GetByte(12);
                bn.Municipality = sdr.GetByte(13);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam> CreateRegListOfBelNam(string FormDate, string reg)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPosition, EducationalInstitution,MainCandidate,MaleCandidate,CECApprove,BirthYearOfCandidate, EducationOfCandidate, PartyMembership,CandidateID, " +
                        "RegionID,Municipality " +
                        " from MunQuery ";
        if (FormDate != null)
        {
            strSQL = strSQL + " where RegionID=" + reg.ToString() + " and CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " where RegionID=" + reg.ToString() + " and FormDate=(select max(FormDate) from MunMemberCandidate where RegionID=" + reg.ToString() + ")";
        }
        List<BelNam> lbn = new List<BelNam>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam bn = new BelNam();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetBoolean(5);
                bn.Gender = sdr.GetBoolean(6);
                bn.IsCECApprove = sdr.GetBoolean(7);
                bn.BirthYearOfCandidate = (int)sdr.GetInt16(8);
                bn.EducationOfCandidate = sdr.GetByte(9);
                bn.PartyMembership = sdr.GetByte(10);
                bn.CandidateID = sdr.GetInt32(11);
                bn.RegionID = sdr.GetByte(12);
                bn.Municipality = sdr.GetByte(13);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

    public static List<BelNam> CreateMunListOfBelNam(string FormDate, string reg, string mun)
    {
        //strSQL = string.Format("SELECT MainCandidate,OtherCandidate,FemaleCandidate,MaleCandidate,CECApprove,CECNoApprove from dbo.MunMemberCandidateDetails");
        //string strSQL = "select mmcd.SurnameOfCandidate, mmcd.NameOfCandidate, mmcd.PatronymicOfCandidate, mmcd.JobAndPosition, mmcd.EducationalInstitution,mmcd.MainCandidate,mmcd.MaleCandidate,mmcd.CECApprove,mmcd.BirthYearOfCandidate, mmcd.EducationOfCandidate, mmcd.PartyMembership,mmc.CandidateID, " +
        //                "mmc.RegionID,mmc.Municipality " +
        //                " from MunMemberCandidate mmc inner join MunMemberCandidateDetails mmcd " +
        //                "on mmc.CandidateID=mmcd.CandidateID";
        string strSQL = "select SurnameOfCandidate, NameOfCandidate, PatronymicOfCandidate, JobAndPosition, EducationalInstitution,MainCandidate,MaleCandidate,CECApprove,BirthYearOfCandidate, EducationOfCandidate, PartyMembership,CandidateID, " +
                     "RegionID,Municipality " +
                     " from MunQuery ";
        if (FormDate != null)
        {
            strSQL = strSQL + " where Municipality=" + mun + " and RegionID=" + reg.ToString() + " and CONVERT(VARCHAR(10), FormDate, 104)='" + FormDate + "'";
        }
        else
        {
            strSQL = strSQL + " where Municipality=" + mun + " and RegionID=" + reg.ToString() + " and FormDate=(select max(FormDate) from MunMemberCandidate where Municipality=" + mun + " and RegionID=" + reg.ToString() + ")";
        }
        List<BelNam> lbn = new List<BelNam>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                BelNam bn = new BelNam();
                bn.SurnameOfCandidate = sdr.GetString(0);
                bn.NameOfCandidate = sdr.GetString(1);
                bn.PatronymicOfCandidate = sdr.GetString(2);
                bn.JobAndPosition = sdr.GetString(3);
                bn.EducationalInstitution = sdr.GetString(4);
                bn.CandidateType = sdr.GetBoolean(5);
                bn.Gender = sdr.GetBoolean(6);
                bn.IsCECApprove = sdr.GetBoolean(7);
                bn.BirthYearOfCandidate = (int)sdr.GetInt16(8);
                bn.EducationOfCandidate = sdr.GetByte(9);
                bn.PartyMembership = sdr.GetByte(10);
                bn.CandidateID = sdr.GetInt32(11);
                bn.RegionID = sdr.GetByte(12);
                bn.Municipality = sdr.GetByte(13);
                lbn.Add(bn);
            }
            sdr.Close();
        }
        return lbn;
    }

}
public struct BelNam
{
    private string _SurnameOfCandidate, _NameOfCandidate, _PatronymicOfCandidate, _JobAndPosition, _EducationalInstitution;
    private bool _CandidateType, _Gender, _IsCECApprove;
    private Byte _EducationOfCandidate, _PartyMembership, _RegionID, _Municipality;
    private int _BirthYearOfCandidate,_CandidateID;

    public string SurnameOfCandidate
    {
        get { return _SurnameOfCandidate; } set { _SurnameOfCandidate = value; }
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
    public bool CandidateType
    {
        get { return _CandidateType; }
        set { _CandidateType = value; }
    }
    public bool Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    public bool IsCECApprove
    {
        get { return _IsCECApprove; }
        set { _IsCECApprove = value; }
    }
    public int BirthYearOfCandidate
    {
        get { return _BirthYearOfCandidate; }
        set { _BirthYearOfCandidate = value; }
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
    public int CandidateID
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
}


