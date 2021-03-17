using System;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;


/// <summary>
/// Rayon klassı
/// </summary>

public class Rayon
{
    public Rayon(int reg)
    {
        string strSQL;
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = "SELECT R.RegionCode, R.RegionName, R.Position, R.Link, R.Grup FROM Regions R where  R.RegionCode="+reg;
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _RegionName =(string) sreader["RegionName"];
                _RegionCode =int.Parse(sreader["RegionCode"].ToString());
            }
            sreader.Close();
        }
    }
    public Rayon(int reg, int year):this(reg)
    {
        Belediyyeler br = new Belediyyeler(reg, year);
        _RayonBelediyyeleri = br.RayonBelediyyeleri;
        _Yekun = CreateYekun(_RayonBelediyyeleri);
        string strSQL;
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = string.Format("SELECT * from dbo.MInformation MI where MI.RegionID={0} and MI.ReportYear={1}", reg, year);
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _CityNum = o2f(sreader["CityNum"]);
                _SettlementNum = o2f(sreader["SettlementNum"]);
                _VillageNum = o2f(sreader["VillageNum"]);
                _Municip01 = o2f(sreader["Municip01"]);
                _Municip02 = o2f(sreader["Municip02"]);
                _Municip03 = o2f(sreader["Municip03"]);
                _Municip04 = o2f(sreader["Municip04"]);
                _Municip05 = o2f(sreader["Municip05"]);
                _Municip06 = o2f(sreader["Municip06"]);
                _Municip07 = o2f(sreader["Municip07"]);
                _Municip08 = o2f(sreader["Municip08"]);
            }
            sreader.Close();
            //
            strSQL = string.Format("SELECT * from MInformationDetails MI where MI.RegionID={0} and MI.ReportYear={1}", reg, year);
            command = new SqlCommand(strSQL, connection);
            sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _MunicipalityMemberNumber += o2f(sreader["MunicipalityMemberNumber"]);
                _EmployeeMuniciplaty += o2f(sreader["EmployeeMuniciplaty"]);
                _PopulationOfMunicipality += o2f(sreader["PopulationOfMunicipality"]);
                _AreaOfMunicipality += o2f(sreader["AreaOfMunicipality"]);

            }
            sreader.Close();


           
        }

    }
    private Belediyye CreateYekun(List<Belediyye> _RayonBelediyyeleri)
    {
        Belediyye YekunBel = new Belediyye();
        //
        float yek = 0;
        Torpaq YekunTorpaq = new Torpaq();
        Type tpYekunTorpaq = YekunTorpaq.GetType();
        object classObject = Activator.CreateInstance(tpYekunTorpaq);
        foreach (PropertyInfo prop in classObject.GetType().GetProperties())
        {
            yek = 0;
            foreach (Belediyye bel in _RayonBelediyyeleri)
            {
                Torpaq _torpaq = bel.TorpaqInfo;
                Type tp = _torpaq.GetType();
                PropertyInfo pi = tp.GetProperty(prop.Name);
                yek +=float.Parse(pi.GetValue(_torpaq, null).ToString());
            }

            tpYekunTorpaq.GetProperty(prop.Name).SetValue(YekunTorpaq, yek, null);
            
        }
        YekunBel.TorpaqInfo = YekunTorpaq;
        //
        Emlak YekunEmlak = new Emlak();
        Type tpYekunEmlak = YekunEmlak.GetType();
        classObject = Activator.CreateInstance(tpYekunEmlak);
        foreach (PropertyInfo prop in classObject.GetType().GetProperties())
        {
            yek = 0;
            if (prop.Name == "HousingCount") continue;
            //_RayonBelediyyeleri.Reset();
            foreach (Belediyye bel in _RayonBelediyyeleri)
            {
                Emlak _emlak = bel.EmlakInfo;
                Type tp = _emlak.GetType();
                PropertyInfo pi = tp.GetProperty(prop.Name);
                yek += float.Parse(pi.GetValue(_emlak, null).ToString());
            }
            tpYekunEmlak.GetProperty(prop.Name).SetValue(YekunEmlak, yek, null);
        }
        YekunBel.EmlakInfo = YekunEmlak;
        //
        //
        Budce YekunBudce = new Budce();
        Type tpYekunBudce = YekunBudce.GetType();
        classObject = Activator.CreateInstance(tpYekunBudce);
        foreach (PropertyInfo prop in classObject.GetType().GetProperties())
        {
            yek = 0;
            if (prop.Name == "NameOfExecutedProjects") continue;
            //if (prop.Name == "GroundExpropriation") continue;
            //if (prop.Name == "MunicipalityGroundRent") continue;
            //if (prop.Name == "ExpRemunerationOfLabour") continue;
            
            
            //_RayonBelediyyeleri.Reset();
            foreach (Belediyye bel in _RayonBelediyyeleri)
            {
                if (bel.MunCode== 3)
                {
                    int p = 0;
                }
                Budce _budce = bel.BudceInfo;
                Type tp = _budce.GetType();
                PropertyInfo pi = tp.GetProperty(prop.Name);
                yek += float.Parse(pi.GetValue(_budce, null).ToString());
            }
            tpYekunBudce.GetProperty(prop.Name).SetValue(YekunBudce, yek, null);
        }
        YekunBel.BudceInfo = YekunBudce;
        //


        return YekunBel;
    }

    private float o2f(object ob)
    {
        try
        {
            return float.Parse(ob.ToString());
        }
        catch
        {
            return 0;
        }
    }

    private List<Belediyye> _RayonBelediyyeleri;
    public List<Belediyye> RayonBelediyyeleri { get { return _RayonBelediyyeleri; } }
    private string _RegionName; public string RegionName { get { return _RegionName; } }
    private int _RegionCode; public int RegionCode { get { return _RegionCode; } }
    private Belediyye _Yekun;
    public Belediyye Yekun
    {
        get { return _Yekun; }
    }


    private float _CityNum; public float CityNum { get { return _CityNum; } }
    private float _SettlementNum; public float SettlementNum { get { return _SettlementNum; } }
    private float _VillageNum; public float VillageNum { get { return _VillageNum; } }
    private float _Municip01; public float Municip01 { get { return _Municip01; } }
    private float _Municip02; public float Municip02 { get { return _Municip02; } }
    private float _Municip03; public float Municip03 { get { return _Municip03; } }
    private float _Municip04; public float Municip04 { get { return _Municip04; } }
    private float _Municip05; public float Municip05 { get { return _Municip05; } }
    private float _Municip06; public float Municip06 { get { return _Municip06; } }
    private float _Municip07; public float Municip07 { get { return _Municip07; } }
    private float _Municip08; public float Municip08 { get { return _Municip08; } }
    private float _MunicipalityMemberNumber; public float MunicipalityMemberNumber { get { return _MunicipalityMemberNumber; } }
    private float _EmployeeMuniciplaty; public float EmployeeMuniciplaty { get { return _EmployeeMuniciplaty; } }
    private float _AreaOfMunicipality; public float AreaOfMunicipality { get { return _AreaOfMunicipality; } }
    private float _PopulationOfMunicipality; public float PopulationOfMunicipality { get { return _PopulationOfMunicipality; } }

}

public class Belediyyeler//: IEnumerator,IEnumerable
{

    public Belediyyeler(int reg, int year)
    {
        _RayonBelediyyeleri = new List<Belediyye>();
        //
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            string strSQL = string.Format("select MunCode from MunCodes2010 where RegionID={0} and Created<={1} and isnull(Deleted,2100)>{1}", reg, year);
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                Belediyye bel = new Belediyye(reg, int.Parse(sreader[0].ToString()), year);

                _RayonBelediyyeleri.Add(bel);
            }
            sreader.Close();
        }
    }

    public Belediyyeler(int reg, int year,string type)
    {
        _RayonBelediyyeleri = new List<Belediyye>();
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            connection.Open();
            string strSQL = string.Format("select MunCode from MunCodes2010 where RegionID={0} and Created<={1} and isnull(Deleted,2100)>{1}", reg, year);
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                Belediyye bel = new Belediyye(reg, int.Parse(sreader[0].ToString()), year);

                _RayonBelediyyeleri.Add(bel);
            }
            sreader.Close();
        }

    }

    private float o2f(object ob)
    {
        try
        {
            return float.Parse(ob.ToString());
        }
        catch
        {
            return 0;
        }
    }

    private List<Belediyye> _RayonBelediyyeleri;
    public List<Belediyye> RayonBelediyyeleri
    {
        get
        {
            return _RayonBelediyyeleri;
        }
    }

    
    
    

    //int position = -1;
    ////IEnumerator and IEnumerable require these methods.
    //public IEnumerator GetEnumerator()
    //{
    //    return (IEnumerator)this;
    //}

    ////IEnumerator
    //public bool MoveNext()
    //{
    //    position++;
    //    return (position < _RayonBelediyyeleri.Count);
    //}

    ////IEnumerable
    //public void Reset()
    //{ position = 0; }

    ////IEnumerable
    //public object Current
    //{
    //    get { return _RayonBelediyyeleri[position]; }
    //}

}


