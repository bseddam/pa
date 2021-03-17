using System;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;

/// <summary>
/// Her formanin periodunu teyin etmek uchun
/// </summary>
public class FormPeriods
{
    private string[] _TableName;
    private string _FormName, _FormDesc, _FormSendTime;
    private int _Period;
    private bool _Mecburi;
    private List<MyBolme> _Il;
    private List<MyBolme> _YarimIl;
    private List<MyBolme> _Rub;
    private List<MyBolme> _Ay;
    private List<MyBolme> _Hefte;
    private List<MyBolme> _Gun;

    public FormPeriods(string strFormName)
    {
        _FormName = strFormName;
        string strSQL;
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=AzBIDb;Integrated Security=True"))
        {
            strSQL = string.Format("select * from FormPeriods where FormName='{0}'", _FormName.Trim());
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                _TableName = sr["TableName"].ToString().Split(';');
                _FormDesc = sr["FormDesc"].ToString();
                _FormSendTime = sr["FormSendTime"].ToString();
                _Period = int.Parse(sr["Period"].ToString());
                _Mecburi = bool.Parse(sr["Mecburi"].ToString());
            }
            sr.Close();
        }
    }

    public FormPeriods(string strFormName, string reg, string ReportYear): this(strFormName)
    {
        _Il = new List<MyBolme>();
        string strSQL;

        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par1 = { _TableName[0], reg };
            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct ReportYear from {0} where RegionID='{1}' order by ReportYear", par1);
            }
            else
            {
                strSQL = string.Format("select distinct ReportYear from {0} order by ReportYear", par1);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                Il.Add(new MyBolme(sr[0].ToString(), sr[0].ToString()));
            }
            sr.Close();
        }
        _YarimIl = new List<MyBolme>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par2 = { _TableName[0], reg, ReportYear.ToString() };

            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where RegionID='{1}' and ReportYear={2} order by SubPeriod", par2);
            }
            else
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where ReportYear={2} order by SubPeriod", par2);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                if (sr[0].ToString() == "6")
                {
                    _YarimIl.Add(new MyBolme(sr[0].ToString(), "I yarımil"));
                }
                else
                {
                    _YarimIl.Add(new MyBolme(sr[0].ToString(), "II yarımil"));
                }
            }
            sr.Close();
        }
        _Rub = new List<MyBolme>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par3 = { _TableName[0], reg, ReportYear.ToString() };

            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where RegionID='{1}' and ReportYear={2} order by SubPeriod", par3);
            }
            else
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where ReportYear={2} order by SubPeriod", par3);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                switch (sr[0].ToString())
                {
                    case "3":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "I rüb"));
                        break;
                    case "6":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "II rüb"));
                        break;
                    case "9":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "III rüb"));
                        break;
                    case "12":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "IV rüb"));
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }
        _Ay = new List<MyBolme>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par4 = { _TableName[0], reg, ReportYear.ToString() };

            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where RegionID='{1}' and ReportYear={2} order by SubPeriod", par4);
            }
            else
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where ReportYear={2} order by SubPeriod", par4);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                switch (sr[0].ToString())
                {
                    case "1":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "yanvar"));
                        break;
                    case "2":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "fevral"));
                        break;
                    case "3":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "mart"));
                        break;
                    case "4":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "aprel"));
                        break;
                    case "5":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "may"));
                        break;
                    case "6":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "iyun"));
                        break;
                    case "7":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "iyul"));
                        break;
                    case "8":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "avqust"));
                        break;
                    case "9":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "sentyabr"));
                        break;
                    case "10":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "oktyabr"));
                        break;
                    case "11":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "noyabr"));
                        break;
                    case "12":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "dekabr"));
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }

    }

    public FormPeriods(string strFormName, string reg,string mun, string ReportYear): this(strFormName)
    {
        _Il = new List<MyBolme>();
        string strSQL="";

        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par1 = { _TableName[0], reg, mun };
            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct ReportYear from {0} where RegionID='{1}' and Municipality='{2}' order by ReportYear", par1);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                Il.Add(new MyBolme(sr[0].ToString(), sr[0].ToString()));
            }
            sr.Close();
        }
        _YarimIl = new List<MyBolme>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par2 = { _TableName[0], reg, ReportYear.ToString(), mun };

            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where RegionID='{1}' and ReportYear={2} and Municipality='{3}' order by SubPeriod", par2);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                if (sr[0].ToString() == "6")
                {
                    _YarimIl.Add(new MyBolme(sr[0].ToString(), "I yarımil"));
                }
                else
                {
                    _YarimIl.Add(new MyBolme(sr[0].ToString(), "II yarımil"));
                }
            }
            sr.Close();
        }
        _Rub = new List<MyBolme>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par3 = { _TableName[0], reg, ReportYear.ToString(), mun };

            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where RegionID='{1}' and ReportYear={2} and Municipality='{3}' order by SubPeriod", par3);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                switch (sr[0].ToString())
                {
                    case "3":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "I rüb"));
                        break;
                    case "6":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "II rüb"));
                        break;
                    case "9":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "III rüb"));
                        break;
                    case "12":
                        _Rub.Add(new MyBolme(sr[0].ToString(), "IV rüb"));
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }
        _Ay = new List<MyBolme>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            string[] par4 = { _TableName[0], reg, ReportYear.ToString(), mun };

            if (!string.IsNullOrEmpty(reg))
            {
                strSQL = string.Format("select distinct SubPeriod  from {0} where RegionID='{1}' and ReportYear={2} and Municipality='{3}' order by SubPeriod", par4);
            }
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                switch (sr[0].ToString())
                {
                    case "1":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "yanvar"));
                        break;
                    case "2":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "fevral"));
                        break;
                    case "3":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "mart"));
                        break;
                    case "4":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "aprel"));
                        break;
                    case "5":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "may"));
                        break;
                    case "6":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "iyun"));
                        break;
                    case "7":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "iyul"));
                        break;
                    case "8":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "avqust"));
                        break;
                    case "9":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "sentyabr"));
                        break;
                    case "10":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "oktyabr"));
                        break;
                    case "11":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "noyabr"));
                        break;
                    case "12":
                        _Ay.Add(new MyBolme(sr[0].ToString(), "dekabr"));
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }

    }

    #region "Properties"

    public List<MyBolme> Il
    {
        get { return _Il; }
        set { _Il = value; }
    }
    public List<MyBolme> YarimIl
    {
        get { return _YarimIl; }
        set { _YarimIl = value; }
    }
    public List<MyBolme> Rub
    {
        get { return _Rub; }
        set { _Rub = value; }
    }
    public List<MyBolme> Ay
    {
        get { return _Ay; }
        set { _Ay = value; }
    }
    public List<MyBolme> Hefte
    {
        get { return _Hefte; }
        set { _Hefte = value; }
    }
    public List<MyBolme> Gun
    {
        get { return _Gun; }
        set { _Gun = value; }
    }
    public string FormName
    {
        get { return _FormName; }
        set { _FormName = value; }
    }
    public string[] TableName
    {
        get { return _TableName; }
        set { _TableName = value; }
    }
    public string FormDesc
    {
        get { return _FormDesc; }
        set { _FormDesc = value; }
    }
    public string FormSendTime
    {
        get { return _FormSendTime; }
        set { _FormSendTime = value; }
    }
    public int Period
    {
        get { return _Period; }
        set { _Period = value; }
    }
    public bool Mecburi
    {
        get { return _Mecburi; }
        set { _Mecburi = value; }
    }

    #endregion


}
public struct MyBolme
{
    string _strParValue, _strParName;
    public MyBolme(string strParValue, string strParName)
    {
        _strParValue = strParValue;
        _strParName = strParName;
    }
    public string ParValue
    {
        get { return _strParValue; }
        set { _strParValue = value; }
    }
    public string ParName
    {
        get { return _strParName; }
        set { _strParName = value; }
    }
}
