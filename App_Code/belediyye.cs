using System;
using System.Data;


using System.Data.SqlClient;

/// <summary>
/// Bələdiyyə klassı
/// </summary>

public class Belediyye
{
    public Belediyye() { }
    public Belediyye(int reg, int mun)
    {
        string strSQL;
        using (SqlConnection connection =
        new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = string.Format("select * from MunCodes2010 where RegionID={0} and MunCode={1}", reg, mun);
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _RegionID = int.Parse(sreader["RegionID"].ToString());
                _MunCode = int.Parse(sreader["MunCode"].ToString());
                _MunName = sreader["MunName"].ToString();
                _MunTerritory = sreader["MunTerritory"].ToString();
                _Created = int.Parse(sreader["Created"].ToString());
                try { _Deleted = int.Parse(sreader["Deleted"].ToString()); }
                catch { _Deleted = 0; }
                try { _ChangedDate = int.Parse(sreader["ChangedDate"].ToString()); }
                catch { _ChangedDate = 0; }
                try { _NewCode = int.Parse(sreader["NewCode"].ToString()); }
                catch { _NewCode = 0; }
            }
            sreader.Close();
        }
    }

    public Belediyye(int reg,int mun,int year):this(reg,mun)
    {
        string strSQL;
        using (SqlConnection connection =
        new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = string.Format("SELECT * from MInformationDetails MI where MI.RegionID=" + reg + " and MI.Municipality={0} and MI.ReportYear={1}", mun, year);
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _AreaOfMunicipality = o2f(sreader["AreaOfMunicipality"]);
                _PopulationOfMunicipality = o2f(sreader["PopulationOfMunicipality"]);
                _ChiarmanOfMunicipalityInitial = sreader["ChiarmanOfMunicipalityİnitial"].ToString();
                _MunicipalityMemberYear = o2f(sreader["MunicipalityMemberYear"].ToString());
                _ChairmanYear = o2f(sreader["ChairmanYear"]);
                _MunicipalityMemberNumber = o2f(sreader["MunicipalityMemberNumber"]);
                _EmployeeMuniciplaty = o2f(sreader["EmployeeMuniciplaty"]);
                _ListOfMunicipalMembers = sreader["ListOfMunicipalMembers"].ToString();
            }
            sreader.Close();
            //
            /*
            strSQL = string.Format("select * from MunCodes2010 where RegionID={0} and MunCode={1}", reg, mun);
            command = new SqlCommand(strSQL, connection);
            sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _RegionID = int.Parse(sreader["RegionID"].ToString());
                _MunCode = int.Parse(sreader["MunCode"].ToString());
                _MunName = sreader["MunName"].ToString();
                _MunTerritory = sreader["MunTerritory"].ToString();
                _Created = int.Parse(sreader["Created"].ToString());
                try { _Deleted = int.Parse(sreader["Deleted"].ToString()); }catch { _Deleted = 0; }
                try { _ChangedDate = int.Parse(sreader["ChangedDate"].ToString()); }catch { _ChangedDate = 0; }
                try { _NewCode = int.Parse(sreader["NewCode"].ToString()); }catch { _NewCode = 0; }
            }
            sreader.Close();
            */
            _TorpaqInfo = new Torpaq(reg, mun, year);
            _EmlakInfo = new Emlak(reg, mun, year);
            _BudceInfo = new Budce(reg, mun, year);
        }
    }
    //

    private int _RegionID; public int RegionID { get { return _RegionID; } }
    private int _MunCode; public int MunCode { get { return _MunCode; } }
    private string _MunName; public string MunName { get { return _MunName; } }
    private string _MunTerritory; public string MunTerritory { get { return _MunTerritory; } }
    private int _Created; public int Created { get { return _Created; } }
    private int _Deleted; public int Deleted { get { return _Deleted; } }
    private int _ChangedDate; public int ChangedDate { get { return _ChangedDate; } }
    private int _NewCode; public int NewCode { get { return _NewCode; } }

    private float _AreaOfMunicipality; public float AreaOfMunicipality { get { return _AreaOfMunicipality; } }
    private float _PopulationOfMunicipality; public float PopulationOfMunicipality { get { return _PopulationOfMunicipality; } }
    private string _ChiarmanOfMunicipalityInitial; public string ChiarmanOfMunicipalityInitial { get { return _ChiarmanOfMunicipalityInitial; } }
    private float _MunicipalityMemberYear; public float MunicipalityMemberYear { get { return _MunicipalityMemberYear; } }
    private float _ChairmanYear; public float ChairmanYear { get { return _ChairmanYear; } }
    private float _MunicipalityMemberNumber; public float MunicipalityMemberNumber { get { return _MunicipalityMemberNumber; } }
    private float _EmployeeMuniciplaty; public float EmployeeMuniciplaty { get { return _EmployeeMuniciplaty; } }
    private string _ListOfMunicipalMembers; public string ListOfMunicipalMembers { get { return _ListOfMunicipalMembers; } }

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
    //
    private Torpaq _TorpaqInfo;
    public Torpaq TorpaqInfo 
    {
        get
        {
            return _TorpaqInfo;   
        }
        set
        {
            _TorpaqInfo = value;
        }
    }
    private Emlak _EmlakInfo;
    public Emlak EmlakInfo
    {
        get
        {
            return _EmlakInfo;
        }
        set
        {
            _EmlakInfo = value;
        }
    }
    private Budce _BudceInfo;
    public Budce BudceInfo
    {
        get
        {
            return _BudceInfo;
        }
        set
        {
            _BudceInfo = value;
        }
    }

}

public class Torpaq
{
    public Torpaq() { }
    public Torpaq(int reg, int mun, int year)
    {
        string strSQL;
        using (SqlConnection connection =
        new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = string.Format("SELECT top 1 * from MGroundDetails MI where MI.RegionID=" + reg + " and MI.Municipality={0} and MI.ReportYear={1} order by SubPeriod desc", mun, year);
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _SumRes = o2f(sreader["SumRes"]);
                _ExpResIndHousingLand = o2f(sreader["ExpResIndHousingLand"]);
                _ExpResAgricultLand = o2f(sreader["ExpResAgricultLand"]);
                _ExpResEntrLand = o2f(sreader["ExpResEntrLand"]);
                _ExpResOtherLand = o2f(sreader["ExpResOtherLand"]);
                _RResAgricultLand = o2f(sreader["RResAgricultLand"]);
                _RResEntrLand = o2f(sreader["RResEntrLand"]);
                _RResOtherLand = o2f(sreader["RResOtherLand"]);
                _SumPer = o2f(sreader["SumPer"]);
                _ExpPindhousingLand = o2f(sreader["ExpPindhousingLand"]);
                _ExpPAgrcultLand = o2f(sreader["ExpPAgrcultLand"]);
                _ExpPEntrLand = o2f(sreader["ExpPEntrLand"]);
                _ExpPOtherLand = o2f(sreader["ExpPOtherLand"]);
                _RPAgricultLand = o2f(sreader["RPAgricultLand"]);
                _RPEntrLand = o2f(sreader["RPEntrLand"]);
                _RPOtherLand = o2f(sreader["RPOtherLand"]);
                _SumFiertile = o2f(sreader["SumFiertile"]);
                _ExpFIndhousingLand = o2f(sreader["ExpFIndhousingLand"]);
                _ExpFAgricultLand = o2f(sreader["ExpFAgricultLand"]);
                _ExpFEntrLand = o2f(sreader["ExpFEntrLand"]);
                _ExpFOtherLand = o2f(sreader["ExpFOtherLand"]);
                _RFAgricultLand = o2f(sreader["RFAgricultLand"]);
                _RFEntrLand = o2f(sreader["RFEntrLand"]);
                _RFOtherLand = o2f(sreader["RFOtherLand"]);
                _SumNoFiertile = o2f(sreader["SumNoFiertile"]);
                _ExpNoFIndhousingLand = o2f(sreader["ExpNoFIndhousingLand"]);
                _ExpNoFAgricultLand = o2f(sreader["ExpNoFAgricultLand"]);
                _ExpNoFEntrLand = o2f(sreader["ExpNoFEntrLand"]);
                _ExpNoFOtherLand = o2f(sreader["ExpNoFOtherLand"]);
                _RNoFAgricultLand = o2f(sreader["RNoFAgricultLand"]);
                _RNoFEntrLand = o2f(sreader["RNoFEntrLand"]);
                _RNoFOtherLand = o2f(sreader["RNoFOtherLand"]);
                _SumGenUse = o2f(sreader["SumGenUse"]);
                _ExpGenuseIndhousingLand = o2f(sreader["ExpGenuseIndhousingLand"]);
                _ExpGenuseAgricultLand = o2f(sreader["ExpGenuseAgricultLand"]);
                _ExpGenuseEntrLand = o2f(sreader["ExpGenuseEntrLand"]);
                _ExpGenuseOtherLand = o2f(sreader["ExpGenuseOtherLand"]);
                _RGenUseAgricultLand = o2f(sreader["RGenUseAgricultLand"]);
                _RGenuseEntrLand = o2f(sreader["RGenuseEntrLand"]);
                _RGenuseOtherLand = o2f(sreader["RGenuseOtherLand"]);
                _OtherLand = o2f(sreader["OtherLand"]);
                _AuctionSale = o2f(sreader["AuctionSale"]);
                _AuctionRent = o2f(sreader["AuctionRent"]);

                _S_torpaq=_SumRes + _SumGenUse + _OtherLand;
                _S_ozg=_ExpResIndHousingLand + _ExpResAgricultLand + _ExpResEntrLand + _ExpResOtherLand + _ExpGenuseIndhousingLand + _ExpGenuseAgricultLand + _ExpGenuseEntrLand + _ExpGenuseOtherLand;
_S_ozg_ferdi=_ExpResIndHousingLand + _ExpGenuseIndhousingLand;
_S_ozg_kend=_ExpResAgricultLand + _ExpGenuseAgricultLand;
_S_ozg_sahibkar=_ExpResEntrLand + _ExpGenuseEntrLand;
_S_ozg_diger=_ExpResOtherLand + _ExpGenuseOtherLand;
_S_icare=_RResAgricultLand + _RResEntrLand + _RResOtherLand + _RGenUseAgricultLand + _RGenuseEntrLand + _RGenuseOtherLand;
_S_icare_kend=_RResAgricultLand + _RGenUseAgricultLand;
_S_icare_sahib=_RResEntrLand + _RGenuseEntrLand;
_S_icare_diger=_RResOtherLand + _RGenuseOtherLand;
_S_eht_ozg=_ExpResIndHousingLand + _ExpResAgricultLand + _ExpResEntrLand + _ExpResOtherLand;
_S_eht_icare=_RResAgricultLand + _RResEntrLand + _RResOtherLand;
_S_per_ozg=_ExpPindhousingLand + _ExpPAgrcultLand + _ExpPEntrLand + _ExpPOtherLand;
_S_per_icare=_RPAgricultLand + _RPEntrLand + _RPOtherLand;
_S_yar_ozg=_ExpFIndhousingLand + _ExpFAgricultLand + _ExpFEntrLand + _ExpFOtherLand;
_S_yar_icare=_RFAgricultLand + _RFEntrLand + _RFOtherLand;
_S_yarsiz_ozg=_ExpNoFIndhousingLand + _ExpNoFAgricultLand + _ExpNoFEntrLand + _ExpNoFOtherLand;
_S_yar_icare=_RNoFAgricultLand + _RNoFEntrLand + _RNoFOtherLand;
_S_umumi_ist_ozg=_ExpGenuseIndhousingLand + _ExpGenuseAgricultLand + _ExpGenuseEntrLand + _ExpGenuseOtherLand;
_S_umumi_ist_icare = _RGenUseAgricultLand + _RGenuseEntrLand + _RGenuseOtherLand;




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




//
private float _S_torpaq; public float S_torpaq{get{return _S_torpaq;} set {_S_torpaq= value; }}
private float _S_ozg; public float S_ozg{get{return _S_ozg;} set {_S_ozg= value; }}
private float _S_ozg_ferdi; public float S_ozg_ferdi{get{return _S_ozg_ferdi;} set {_S_ozg_ferdi= value; }}
private float _S_ozg_kend; public float S_ozg_kend{get{return _S_ozg_kend;} set {_S_ozg_kend= value; }}
private float _S_ozg_sahibkar; public float S_ozg_sahibkar{get{return _S_ozg_sahibkar;} set {_S_ozg_sahibkar= value; }}
private float _S_ozg_diger; public float S_ozg_diger{get{return _S_ozg_diger;} set {_S_ozg_diger= value; }}
private float _S_icare; public float S_icare{get{return _S_icare;} set {_S_icare= value; }}
private float _S_icare_kend; public float S_icare_kend{get{return _S_icare_kend;} set {_S_icare_kend= value; }}
private float _S_icare_sahib; public float S_icare_sahib{get{return _S_icare_sahib;} set {_S_icare_sahib= value; }}
private float _S_icare_diger; public float S_icare_diger{get{return _S_icare_diger;} set {_S_icare_diger= value; }}
private float _S_eht_ozg; public float S_eht_ozg{get{return _S_eht_ozg;} set {_S_eht_ozg= value; }}
private float _S_eht_icare; public float S_eht_icare{get{return _S_eht_icare;} set {_S_eht_icare= value; }}
private float _S_per_ozg; public float S_per_ozg{get{return _S_per_ozg;} set {_S_per_ozg= value; }}
private float _S_per_icare; public float S_per_icare{get{return _S_per_icare;} set {_S_per_icare= value; }}
private float _S_yar_ozg; public float S_yar_ozg{get{return _S_yar_ozg;} set {_S_yar_ozg= value; }}
private float _S_yar_icare; public float S_yar_icare{get{return _S_yar_icare;} set {_S_yar_icare= value; }}
private float _S_yarsiz_ozg; public float S_yarsiz_ozg{get{return _S_yarsiz_ozg;} set {_S_yarsiz_ozg= value; }}
private float _S_yarsiz_icare; public float S_yarsiz_icare { get { return _S_yarsiz_icare; } set { _S_yarsiz_icare = value; } }
private float _S_umumi_ist_ozg; public float S_umumi_ist_ozg{get{return _S_umumi_ist_ozg;} set {_S_umumi_ist_ozg= value; }}
private float _S_umumi_ist_icare; public float S_umumi_ist_icare{get{return _S_umumi_ist_icare;} set {_S_umumi_ist_icare= value; }}

//

    private float _SumRes; public float SumRes { get { return _SumRes; } set { _SumRes = value; } }
    private float _ExpResIndHousingLand; public float ExpResIndHousingLand { get { return _ExpResIndHousingLand; } set { _ExpResIndHousingLand = value; } }
    private float _ExpResAgricultLand; public float ExpResAgricultLand { get { return _ExpResAgricultLand; } set { _ExpResAgricultLand = value; } }
    private float _ExpResEntrLand; public float ExpResEntrLand { get { return _ExpResEntrLand; } set { _ExpResEntrLand = value; } }
    private float _ExpResOtherLand; public float ExpResOtherLand { get { return _ExpResOtherLand; } set { _ExpResOtherLand = value; } }
    private float _RResAgricultLand; public float RResAgricultLand { get { return _RResAgricultLand; } set { _RResAgricultLand = value; } }
    private float _RResEntrLand; public float RResEntrLand { get { return _RResEntrLand; } set { _RResEntrLand = value; } }
    private float _RResOtherLand; public float RResOtherLand { get { return _RResOtherLand; } set { _RResOtherLand = value; } }
    private float _SumPer; public float SumPer { get { return _SumPer; } set { _SumPer = value; } }
    private float _ExpPindhousingLand; public float ExpPindhousingLand { get { return _ExpPindhousingLand; } set { _ExpPindhousingLand = value; } }
    private float _ExpPAgrcultLand; public float ExpPAgrcultLand { get { return _ExpPAgrcultLand; } set { _ExpPAgrcultLand = value; } }
    private float _ExpPEntrLand; public float ExpPEntrLand { get { return _ExpPEntrLand; } set { _ExpPEntrLand = value; } }
    private float _ExpPOtherLand; public float ExpPOtherLand { get { return _ExpPOtherLand; } set { _ExpPOtherLand = value; } }
    private float _RPAgricultLand; public float RPAgricultLand { get { return _RPAgricultLand; } set { _RPAgricultLand = value; } }
    private float _RPEntrLand; public float RPEntrLand { get { return _RPEntrLand; } set { _RPEntrLand = value; } }
    private float _RPOtherLand; public float RPOtherLand { get { return _RPOtherLand; } set { _RPOtherLand = value; } }
    private float _SumFiertile; public float SumFiertile { get { return _SumFiertile; } set { _SumFiertile = value; } }
    private float _ExpFIndhousingLand; public float ExpFIndhousingLand { get { return _ExpFIndhousingLand; } set { _ExpFIndhousingLand = value; } }
    private float _ExpFAgricultLand; public float ExpFAgricultLand { get { return _ExpFAgricultLand; } set { _ExpFAgricultLand = value; } }
    private float _ExpFEntrLand; public float ExpFEntrLand { get { return _ExpFEntrLand; } set { _ExpFEntrLand = value; } }
    private float _ExpFOtherLand; public float ExpFOtherLand { get { return _ExpFOtherLand; } set { _ExpFOtherLand = value; } }
    private float _RFAgricultLand; public float RFAgricultLand { get { return _RFAgricultLand; } set { _RFAgricultLand = value; } }
    private float _RFEntrLand; public float RFEntrLand { get { return _RFEntrLand; } set { _RFEntrLand = value; } }
    private float _RFOtherLand; public float RFOtherLand { get { return _RFOtherLand; } set { _RFOtherLand = value; } }
    private float _SumNoFiertile; public float SumNoFiertile { get { return _SumNoFiertile; } set { _SumNoFiertile = value; } }
    private float _ExpNoFIndhousingLand; public float ExpNoFIndhousingLand { get { return _ExpNoFIndhousingLand; } set { _ExpNoFIndhousingLand = value; } }
    private float _ExpNoFAgricultLand; public float ExpNoFAgricultLand { get { return _ExpNoFAgricultLand; } set { _ExpNoFAgricultLand = value; } }
    private float _ExpNoFEntrLand; public float ExpNoFEntrLand { get { return _ExpNoFEntrLand; } set { _ExpNoFEntrLand = value; } }
    private float _ExpNoFOtherLand; public float ExpNoFOtherLand { get { return _ExpNoFOtherLand; } set { _ExpNoFOtherLand = value; } }
    private float _RNoFAgricultLand; public float RNoFAgricultLand { get { return _RNoFAgricultLand; } set { _RNoFAgricultLand = value; } }
    private float _RNoFEntrLand; public float RNoFEntrLand { get { return _RNoFEntrLand; } set { _RNoFEntrLand = value; } }
    private float _RNoFOtherLand; public float RNoFOtherLand { get { return _RNoFOtherLand; } set { _RNoFOtherLand = value; } }
    private float _SumGenUse; public float SumGenUse { get { return _SumGenUse; } set { _SumGenUse = value; } }
    private float _ExpGenuseIndhousingLand; public float ExpGenuseIndhousingLand { get { return _ExpGenuseIndhousingLand; } set { _ExpGenuseIndhousingLand = value; } }
    private float _ExpGenuseAgricultLand; public float ExpGenuseAgricultLand { get { return _ExpGenuseAgricultLand; } set { _ExpGenuseAgricultLand = value; } }
    private float _ExpGenuseEntrLand; public float ExpGenuseEntrLand { get { return _ExpGenuseEntrLand; } set { _ExpGenuseEntrLand = value; } }
    private float _ExpGenuseOtherLand; public float ExpGenuseOtherLand { get { return _ExpGenuseOtherLand; } set { _ExpGenuseOtherLand = value; } }
    private float _RGenUseAgricultLand; public float RGenUseAgricultLand { get { return _RGenUseAgricultLand; } set { _RGenUseAgricultLand = value; } }
    private float _RGenuseEntrLand; public float RGenuseEntrLand { get { return _RGenuseEntrLand; } set { _RGenuseEntrLand = value; } }
    private float _RGenuseOtherLand; public float RGenuseOtherLand { get { return _RGenuseOtherLand; } set { _RGenuseOtherLand = value; } }
    private float _OtherLand; public float OtherLand { get { return _OtherLand; } set { _OtherLand = value; } }
    private float _AuctionSale; public float AuctionSale { get { return _AuctionSale; } set { _AuctionSale = value; } }
    private float _AuctionRent; public float AuctionRent { get { return _AuctionRent; } set { _AuctionRent = value; } }


}

public class Emlak
{
    public Emlak() { }
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
    public Emlak(int reg, int mun, int year)
    {
        string strSQL;
        using (SqlConnection connection =
        new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = string.Format("SELECT * from MPropertyDetails MI where MI.RegionID=" + reg + " and MI.Municipality={0} and MI.ReportYear={1}", mun, year);
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _AsphaltRoad = o2f(sreader["AsphaltRoad"]);
                _RepairAsphaltRoad = o2f(sreader["RepairAsphaltRoad"]);
                _GravelRoad = o2f(sreader["GravelRoad"]);
                _RepairGravelRoad = o2f(sreader["RepairGravelRoad"]);
                _EarthRoad = o2f(sreader["EarthRoad"]);
                _RepairEarthRoad = o2f(sreader["RepairEarthRoad"]);
                _LocalManEnterpriseCount = o2f(sreader["LocalManEnterpriseCount"]);
                _LocalManEnterpriseFunc = o2f(sreader["LocalManEnterpriseFunc"]);
                _LocalManEnterpriseWorkPlaceCount = o2f(sreader["LocalManEnterpriseWorkPlaceCount"]);
                _LocalManEnterpriseVolume = o2f(sreader["LocalManEnterpriseVolume"]);
                _TradePubCatDomServCount = o2f(sreader["TradePubCatDomServCount"]);
                _TradePubCatDomServFunc = o2f(sreader["TradePubCatDomServFunc"]);
                _TradePubCatDomServWorkPlaceCount = o2f(sreader["TradePubCatDomServWorkPlaceCount"]);
                _TradePubCatDomServVolume = o2f(sreader["TradePubCatDomServVolume"]);
                _LocalFreightServCount = o2f(sreader["LocalFreightServCount"]);
                _LocalFreightServFunc = o2f(sreader["LocalFreightServFunc"]);
                _LocalFreightServWorkPlaceCount = o2f(sreader["LocalFreightServWorkPlaceCount"]);
                _LocalFreightServVolume = o2f(sreader["LocalFreightServVolume"]);
                _AgrarianSectorCount = o2f(sreader["AgrarianSectorCount"]);
                _AgrarianSectorFunc = o2f(sreader["AgrarianSectorFunc"]);
                _AgrarianSectorWorkPlaceCount = o2f(sreader["AgrarianSectorWorkPlaceCount"]);
                _AgrarianSectorVolume = o2f(sreader["AgrarianSectorVolume"]);
                _ForestryCount = o2f(sreader["ForestryCount"]);
                _ForestryFunc = o2f(sreader["ForestryFunc"]);
                _ForestryWorkPlaceCount = o2f(sreader["ForestryWorkPlaceCount"]);
                _ForestryVolume = o2f(sreader["ForestryVolume"]);
                _FishingCount = o2f(sreader["FishingCount"]);
                _FishingFunc = o2f(sreader["FishingFunc"]);
                _FishingWorkPlaceCount = o2f(sreader["FishingWorkPlaceCount"]);
                _FishingVolume = o2f(sreader["FishingVolume"]);
                _HunterCount = o2f(sreader["HunterCount"]);
                _HunterFunc = o2f(sreader["HunterFunc"]);
                _HunterWorkPlaceCount = o2f(sreader["HunterWorkPlaceCount"]);
                _HunterVolume = o2f(sreader["HunterVolume"]);
                _OtherSectorCount = o2f(sreader["OtherSectorCount"]);
                _OtherSectorFunc = o2f(sreader["OtherSectorFunc"]);
                _OtherSectorWorkPlaceCount = o2f(sreader["OtherSectorWorkPlaceCount"]);
                _OtherSectorVolume = o2f(sreader["OtherSectorVolume"]);
                _OfficeBuildingCount = o2f(sreader["OfficeBuildingCount"]);
                _OfficeBuildingTotalArea = o2f(sreader["OfficeBuildingTotalArea"]);
                _OfficeBuildingRepair = o2f(sreader["OfficeBuildingRepair"]);
                _OfficeBuildingBuild = o2f(sreader["OfficeBuildingBuild"]);
                _OfficeBuildingRent = o2f(sreader["OfficeBuildingRent"]);
                _OfficeBuildingUse = o2f(sreader["OfficeBuildingUse"]);
                _EducationObjectCount = o2f(sreader["EducationObjectCount"]);
                _EducationObjectTotalArea = o2f(sreader["EducationObjectTotalArea"]);
                _EducationObjectRepair = o2f(sreader["EducationObjectRepair"]);
                _EducationObjectBuild = o2f(sreader["EducationObjectBuild"]);
                _EducationObjectRent = o2f(sreader["EducationObjectRent"]);
                _EducationObjectUse = o2f(sreader["EducationObjectUse"]);
                _HealthObjectCount = o2f(sreader["HealthObjectCount"]);
                _HealthObjectTotalArea = o2f(sreader["HealthObjectTotalArea"]);
                _HealthObjectRepair = o2f(sreader["HealthObjectRepair"]);
                _HealthObjectBuild = o2f(sreader["HealthObjectBuild"]);
                _HealthObjectRent = o2f(sreader["HealthObjectRent"]);
                _HealthObjectUse = o2f(sreader["HealthObjectUse"]);
                _CultureObjectCount = o2f(sreader["CultureObjectCount"]);
                _CultureObjectTotalArea = o2f(sreader["CultureObjectTotalArea"]);
                _CultureObjectRepair = o2f(sreader["CultureObjectRepair"]);
                _CultureObjectBuild = o2f(sreader["CultureObjectBuild"]);
                _CultureObjectRent = o2f(sreader["CultureObjectRent"]);
                _CultureObjectUse = o2f(sreader["CultureObjectUse"]);
                _TradeObjectCount = o2f(sreader["TradeObjectCount"]);
                _TradeObjectTotalArea = o2f(sreader["TradeObjectTotalArea"]);
                _TradeObjectRepair = o2f(sreader["TradeObjectRepair"]);
                _TradeObjectBuild = o2f(sreader["TradeObjectBuild"]);
                _TradeObjectRent = o2f(sreader["TradeObjectRent"]);
                _TradeObjectUse = o2f(sreader["TradeObjectUse"]);
                _ConstructionForCeremonyCount = o2f(sreader["ConstructionForCeremonyCount"]);
                _ConstructionForCeremonyTotalArea = o2f(sreader["ConstructionForCeremonyTotalArea"]);
                _ConstructionForCeremonyRepair = o2f(sreader["ConstructionForCeremonyRepair"]);
                _ConstructionForCeremonyBuild = o2f(sreader["ConstructionForCeremonyBuild"]);
                _ConstructionForCeremonyRent = o2f(sreader["ConstructionForCeremonyRent"]);
                _ConstructionForCeremonyUse = o2f(sreader["ConstructionForCeremonyUse"]);
                _ApartmentHousesCount = o2f(sreader["ApartmentHousesCount"]);
                _ApartmentHousesTotalArea = o2f(sreader["ApartmentHousesTotalArea"]);
                _ApartmentHousesRepair = o2f(sreader["ApartmentHousesRepair"]);
                _ApartmentHousesBuild = o2f(sreader["ApartmentHousesBuild"]);
                _ApartmentHousesRent = o2f(sreader["ApartmentHousesRent"]);
                _ApartmentHousesUse = o2f(sreader["ApartmentHousesUse"]);
                _HousingCount = o2f(sreader["HousingCount"]);
                _HousingTotalArea = o2f(sreader["HousingTotalArea"]);
                _HousingRepair = o2f(sreader["HousingRepair"]);
                _HousingBuild = o2f(sreader["HousingBuild"]);
                _HousingRent = o2f(sreader["HousingRent"]);
                _HousingUse = o2f(sreader["HousingUse"]);
                _SportsGroundCount = o2f(sreader["SportsGroundCount"]);
                _SportsGroundTotalArea = o2f(sreader["SportsGroundTotalArea"]);
                _SportsGroundRepair = o2f(sreader["SportsGroundRepair"]);
                _SportsGroundBuild = o2f(sreader["SportsGroundBuild"]);
                _SportsGroundRent = o2f(sreader["SportsGroundRent"]);
                _SportsGroundUse = o2f(sreader["SportsGroundUse"]);
                _ParkCount = o2f(sreader["ParkCount"]);
                _ParkTotalArea = o2f(sreader["ParkTotalArea"]);
                _ParkRepair = o2f(sreader["ParkRepair"]);
                _ParkBuild = o2f(sreader["ParkBuild"]);
                _ParkRent = o2f(sreader["ParkRent"]);
                _ParkUse = o2f(sreader["ParkUse"]);
                _AvenueCount = o2f(sreader["AvenueCount"]);
                _AvenueTotalArea = o2f(sreader["AvenueTotalArea"]);
                _AvenueRepair = o2f(sreader["AvenueRepair"]);
                _AvenueBuild = o2f(sreader["AvenueBuild"]);
                _AvenueRent = o2f(sreader["AvenueRent"]);
                _AvenueUse = o2f(sreader["AvenueUse"]);
                _TransportCount = o2f(sreader["TransportCount"]);
                _TransportRepair = o2f(sreader["TransportRepair"]);
                _TransportBuild = o2f(sreader["TransportBuild"]);
                _TransportRent = o2f(sreader["TransportRent"]);
                _TransportUse = o2f(sreader["TransportUse"]);
                _SpecialPurposeMachineCount = o2f(sreader["SpecialPurposeMachineCount"]);
                _SpecialPurposeMachineRepair = o2f(sreader["SpecialPurposeMachineRepair"]);
                _SpecialPurposeMachineBuild = o2f(sreader["SpecialPurposeMachineBuild"]);
                _SpecialPurposeMachineRent = o2f(sreader["SpecialPurposeMachineRent"]);
                _SpecialPurposeMachineUse = o2f(sreader["SpecialPurposeMachineUse"]);
                _OtherPropertyCount = o2f(sreader["OtherPropertyCount"]);
                _OtherPropertyTotalArea = o2f(sreader["OtherPropertyTotalArea"]);
                _OtherPropertyRepair = o2f(sreader["OtherPropertyRepair"]);
                _OtherPropertyBuild = o2f(sreader["OtherPropertyBuild"]);
                _OtherPropertyRent = o2f(sreader["OtherPropertyRent"]);
                _OtherPropertyUse = o2f(sreader["OtherPropertyUse"]);

                _S_avt_cemi=_AsphaltRoad + _GravelRoad + _EarthRoad;
                _S_avt_temir=_RepairAsphaltRoad + _RepairGravelRoad + _RepairEarthRoad;
                _S_ist_sayi=_LocalManEnterpriseCount + _TradePubCatDomServCount + _LocalFreightServCount + _AgrarianSectorCount + _ForestryCount + _FishingCount + _HunterCount + _OtherSectorCount;
                _S_ist_feal=_LocalManEnterpriseFunc + _TradePubCatDomServFunc + _LocalFreightServFunc + _AgrarianSectorFunc + _ForestryFunc + _FishingFunc + _HunterFunc + _OtherSectorFunc;
                _S_ist_ish_yerleri=_LocalManEnterpriseWorkPlaceCount + _TradePubCatDomServWorkPlaceCount + _LocalFreightServWorkPlaceCount + _AgrarianSectorWorkPlaceCount + _ForestryWorkPlaceCount + _FishingWorkPlaceCount + _HunterWorkPlaceCount + _OtherSectorWorkPlaceCount;
                _S_ist_dovriyye=_LocalManEnterpriseVolume + _TradePubCatDomServVolume + _LocalFreightServVolume + _AgrarianSectorVolume + _ForestryVolume + _FishingVolume + _HunterVolume + _OtherSectorVolume;
                _S_qyb_sayi=_EducationObjectCount + _HealthObjectCount + _CultureObjectCount + _TradeObjectCount + _ConstructionForCeremonyCount;
                _S_qyb_umumi=_EducationObjectTotalArea + _HealthObjectTotalArea + _CultureObjectTotalArea + _TradeObjectTotalArea + _ConstructionForCeremonyTotalArea;
                _S_qyb_temir=_EducationObjectRepair + _HealthObjectRepair + _CultureObjectRepair + _TradeObjectRepair + _ConstructionForCeremonyRepair;
                _S_qyb_insha=_EducationObjectBuild + _HealthObjectBuild + _CultureObjectBuild + _TradeObjectBuild + _ConstructionForCeremonyBuild;
                _S_qyb_icare=_EducationObjectRent + _HealthObjectRent + _CultureObjectRent + _TradeObjectRent + _ConstructionForCeremonyRent;
                _S_qyb_ist = _EducationObjectUse + _HealthObjectUse + _CultureObjectUse + _TradeObjectUse + _ConstructionForCeremonyUse;



            }
            sreader.Close();
        }
    }
    private float _AsphaltRoad; public float AsphaltRoad { get { return _AsphaltRoad; } set { _AsphaltRoad = value; } }
    private float _RepairAsphaltRoad; public float RepairAsphaltRoad { get { return _RepairAsphaltRoad; } set { _RepairAsphaltRoad = value; } }
    private float _GravelRoad; public float GravelRoad { get { return _GravelRoad; } set { _GravelRoad = value; } }
    private float _RepairGravelRoad; public float RepairGravelRoad { get { return _RepairGravelRoad; } set { _RepairGravelRoad = value; } }
    private float _EarthRoad; public float EarthRoad { get { return _EarthRoad; } set { _EarthRoad = value; } }
    private float _RepairEarthRoad; public float RepairEarthRoad { get { return _RepairEarthRoad; } set { _RepairEarthRoad = value; } }
    private float _LocalManEnterpriseCount; public float LocalManEnterpriseCount { get { return _LocalManEnterpriseCount; } set { _LocalManEnterpriseCount = value; } }
    private float _LocalManEnterpriseFunc; public float LocalManEnterpriseFunc { get { return _LocalManEnterpriseFunc; } set { _LocalManEnterpriseFunc = value; } }
    private float _LocalManEnterpriseWorkPlaceCount; public float LocalManEnterpriseWorkPlaceCount { get { return _LocalManEnterpriseWorkPlaceCount; } set { _LocalManEnterpriseWorkPlaceCount = value; } }
    private float _LocalManEnterpriseVolume; public float LocalManEnterpriseVolume { get { return _LocalManEnterpriseVolume; } set { _LocalManEnterpriseVolume = value; } }
    private float _TradePubCatDomServCount; public float TradePubCatDomServCount { get { return _TradePubCatDomServCount; } set { _TradePubCatDomServCount = value; } }
    private float _TradePubCatDomServFunc; public float TradePubCatDomServFunc { get { return _TradePubCatDomServFunc; } set { _TradePubCatDomServFunc = value; } }
    private float _TradePubCatDomServWorkPlaceCount; public float TradePubCatDomServWorkPlaceCount { get { return _TradePubCatDomServWorkPlaceCount; } set { _TradePubCatDomServWorkPlaceCount = value; } }
    private float _TradePubCatDomServVolume; public float TradePubCatDomServVolume { get { return _TradePubCatDomServVolume; } set { _TradePubCatDomServVolume = value; } }
    private float _LocalFreightServCount; public float LocalFreightServCount { get { return _LocalFreightServCount; } set { _LocalFreightServCount = value; } }
    private float _LocalFreightServFunc; public float LocalFreightServFunc { get { return _LocalFreightServFunc; } set { _LocalFreightServFunc = value; } }
    private float _LocalFreightServWorkPlaceCount; public float LocalFreightServWorkPlaceCount { get { return _LocalFreightServWorkPlaceCount; } set { _LocalFreightServWorkPlaceCount = value; } }
    private float _LocalFreightServVolume; public float LocalFreightServVolume { get { return _LocalFreightServVolume; } set { _LocalFreightServVolume = value; } }
    private float _AgrarianSectorCount; public float AgrarianSectorCount { get { return _AgrarianSectorCount; } set { _AgrarianSectorCount = value; } }
    private float _AgrarianSectorFunc; public float AgrarianSectorFunc { get { return _AgrarianSectorFunc; } set { _AgrarianSectorFunc = value; } }
    private float _AgrarianSectorWorkPlaceCount; public float AgrarianSectorWorkPlaceCount { get { return _AgrarianSectorWorkPlaceCount; } set { _AgrarianSectorWorkPlaceCount = value; } }
    private float _AgrarianSectorVolume; public float AgrarianSectorVolume { get { return _AgrarianSectorVolume; } set { _AgrarianSectorVolume = value; } }
    private float _ForestryCount; public float ForestryCount { get { return _ForestryCount; } set { _ForestryCount = value; } }
    private float _ForestryFunc; public float ForestryFunc { get { return _ForestryFunc; } set { _ForestryFunc = value; } }
    private float _ForestryWorkPlaceCount; public float ForestryWorkPlaceCount { get { return _ForestryWorkPlaceCount; } set { _ForestryWorkPlaceCount = value; } }
    private float _ForestryVolume; public float ForestryVolume { get { return _ForestryVolume; } set { _ForestryVolume = value; } }
    private float _FishingCount; public float FishingCount { get { return _FishingCount; } set { _FishingCount = value; } }
    private float _FishingFunc; public float FishingFunc { get { return _FishingFunc; } set { _FishingFunc = value; } }
    private float _FishingWorkPlaceCount; public float FishingWorkPlaceCount { get { return _FishingWorkPlaceCount; } set { _FishingWorkPlaceCount = value; } }
    private float _FishingVolume; public float FishingVolume { get { return _FishingVolume; } set { _FishingVolume = value; } }
    private float _HunterCount; public float HunterCount { get { return _HunterCount; } set { _HunterCount = value; } }
    private float _HunterFunc; public float HunterFunc { get { return _HunterFunc; } set { _HunterFunc = value; } }
    private float _HunterWorkPlaceCount; public float HunterWorkPlaceCount { get { return _HunterWorkPlaceCount; } set { _HunterWorkPlaceCount = value; } }
    private float _HunterVolume; public float HunterVolume { get { return _HunterVolume; } set { _HunterVolume = value; } }
    private float _OtherSectorCount; public float OtherSectorCount { get { return _OtherSectorCount; } set { _OtherSectorCount = value; } }
    private float _OtherSectorFunc; public float OtherSectorFunc { get { return _OtherSectorFunc; } set { _OtherSectorFunc = value; } }
    private float _OtherSectorWorkPlaceCount; public float OtherSectorWorkPlaceCount { get { return _OtherSectorWorkPlaceCount; } set { _OtherSectorWorkPlaceCount = value; } }
    private float _OtherSectorVolume; public float OtherSectorVolume { get { return _OtherSectorVolume; } set { _OtherSectorVolume = value; } }
    private float _OfficeBuildingCount; public float OfficeBuildingCount { get { return _OfficeBuildingCount; } set { _OfficeBuildingCount = value; } }
    private float _OfficeBuildingTotalArea; public float OfficeBuildingTotalArea { get { return _OfficeBuildingTotalArea; } set { _OfficeBuildingTotalArea = value; } }
    private float _OfficeBuildingRepair; public float OfficeBuildingRepair { get { return _OfficeBuildingRepair; } set { _OfficeBuildingRepair = value; } }
    private float _OfficeBuildingBuild; public float OfficeBuildingBuild { get { return _OfficeBuildingBuild; } set { _OfficeBuildingBuild = value; } }
    private float _OfficeBuildingRent; public float OfficeBuildingRent { get { return _OfficeBuildingRent; } set { _OfficeBuildingRent = value; } }
    private float _OfficeBuildingUse; public float OfficeBuildingUse { get { return _OfficeBuildingUse; } set { _OfficeBuildingUse = value; } }
    private float _EducationObjectCount; public float EducationObjectCount { get { return _EducationObjectCount; } set { _EducationObjectCount = value; } }
    private float _EducationObjectTotalArea; public float EducationObjectTotalArea { get { return _EducationObjectTotalArea; } set { _EducationObjectTotalArea = value; } }
    private float _EducationObjectRepair; public float EducationObjectRepair { get { return _EducationObjectRepair; } set { _EducationObjectRepair = value; } }
    private float _EducationObjectBuild; public float EducationObjectBuild { get { return _EducationObjectBuild; } set { _EducationObjectBuild = value; } }
    private float _EducationObjectRent; public float EducationObjectRent { get { return _EducationObjectRent; } set { _EducationObjectRent = value; } }
    private float _EducationObjectUse; public float EducationObjectUse { get { return _EducationObjectUse; } set { _EducationObjectUse = value; } }
    private float _HealthObjectCount; public float HealthObjectCount { get { return _HealthObjectCount; } set { _HealthObjectCount = value; } }
    private float _HealthObjectTotalArea; public float HealthObjectTotalArea { get { return _HealthObjectTotalArea; } set { _HealthObjectTotalArea = value; } }
    private float _HealthObjectRepair; public float HealthObjectRepair { get { return _HealthObjectRepair; } set { _HealthObjectRepair = value; } }
    private float _HealthObjectBuild; public float HealthObjectBuild { get { return _HealthObjectBuild; } set { _HealthObjectBuild = value; } }
    private float _HealthObjectRent; public float HealthObjectRent { get { return _HealthObjectRent; } set { _HealthObjectRent = value; } }
    private float _HealthObjectUse; public float HealthObjectUse { get { return _HealthObjectUse; } set { _HealthObjectUse = value; } }
    private float _CultureObjectCount; public float CultureObjectCount { get { return _CultureObjectCount; } set { _CultureObjectCount = value; } }
    private float _CultureObjectTotalArea; public float CultureObjectTotalArea { get { return _CultureObjectTotalArea; } set { _CultureObjectTotalArea = value; } }
    private float _CultureObjectRepair; public float CultureObjectRepair { get { return _CultureObjectRepair; } set { _CultureObjectRepair = value; } }
    private float _CultureObjectBuild; public float CultureObjectBuild { get { return _CultureObjectBuild; } set { _CultureObjectBuild = value; } }
    private float _CultureObjectRent; public float CultureObjectRent { get { return _CultureObjectRent; } set { _CultureObjectRent = value; } }
    private float _CultureObjectUse; public float CultureObjectUse { get { return _CultureObjectUse; } set { _CultureObjectUse = value; } }
    private float _TradeObjectCount; public float TradeObjectCount { get { return _TradeObjectCount; } set { _TradeObjectCount = value; } }
    private float _TradeObjectTotalArea; public float TradeObjectTotalArea { get { return _TradeObjectTotalArea; } set { _TradeObjectTotalArea = value; } }
    private float _TradeObjectRepair; public float TradeObjectRepair { get { return _TradeObjectRepair; } set { _TradeObjectRepair = value; } }
    private float _TradeObjectBuild; public float TradeObjectBuild { get { return _TradeObjectBuild; } set { _TradeObjectBuild = value; } }
    private float _TradeObjectRent; public float TradeObjectRent { get { return _TradeObjectRent; } set { _TradeObjectRent = value; } }
    private float _TradeObjectUse; public float TradeObjectUse { get { return _TradeObjectUse; } set { _TradeObjectUse = value; } }
    private float _ConstructionForCeremonyCount; public float ConstructionForCeremonyCount { get { return _ConstructionForCeremonyCount; } set { _ConstructionForCeremonyCount = value; } }
    private float _ConstructionForCeremonyTotalArea; public float ConstructionForCeremonyTotalArea { get { return _ConstructionForCeremonyTotalArea; } set { _ConstructionForCeremonyTotalArea = value; } }
    private float _ConstructionForCeremonyRepair; public float ConstructionForCeremonyRepair { get { return _ConstructionForCeremonyRepair; } set { _ConstructionForCeremonyRepair = value; } }
    private float _ConstructionForCeremonyBuild; public float ConstructionForCeremonyBuild { get { return _ConstructionForCeremonyBuild; } set { _ConstructionForCeremonyBuild = value; } }
    private float _ConstructionForCeremonyRent; public float ConstructionForCeremonyRent { get { return _ConstructionForCeremonyRent; } set { _ConstructionForCeremonyRent = value; } }
    private float _ConstructionForCeremonyUse; public float ConstructionForCeremonyUse { get { return _ConstructionForCeremonyUse; } set { _ConstructionForCeremonyUse = value; } }
    private float _ApartmentHousesCount; public float ApartmentHousesCount { get { return _ApartmentHousesCount; } set { _ApartmentHousesCount = value; } }
    private float _ApartmentHousesTotalArea; public float ApartmentHousesTotalArea { get { return _ApartmentHousesTotalArea; } set { _ApartmentHousesTotalArea = value; } }
    private float _ApartmentHousesRepair; public float ApartmentHousesRepair { get { return _ApartmentHousesRepair; } set { _ApartmentHousesRepair = value; } }
    private float _ApartmentHousesBuild; public float ApartmentHousesBuild { get { return _ApartmentHousesBuild; } set { _ApartmentHousesBuild = value; } }
    private float _ApartmentHousesRent; public float ApartmentHousesRent { get { return _ApartmentHousesRent; } set { _ApartmentHousesRent = value; } }
    private float _ApartmentHousesUse; public float ApartmentHousesUse { get { return _ApartmentHousesUse; } set { _ApartmentHousesUse = value; } }
    private float _HousingCount; public float HousingCount { get { return _HousingCount; } set { _HousingCount = value; } }
    private float _HousingTotalArea; public float HousingTotalArea { get { return _HousingTotalArea; } set { _HousingTotalArea = value; } }
    private float _HousingRepair; public float HousingRepair { get { return _HousingRepair; } set { _HousingRepair = value; } }
    private float _HousingBuild; public float HousingBuild { get { return _HousingBuild; } set { _HousingBuild = value; } }
    private float _HousingRent; public float HousingRent { get { return _HousingRent; } set { _HousingRent = value; } }
    private float _HousingUse; public float HousingUse { get { return _HousingUse; } set { _HousingUse = value; } }
    private float _SportsGroundCount; public float SportsGroundCount { get { return _SportsGroundCount; } set { _SportsGroundCount = value; } }
    private float _SportsGroundTotalArea; public float SportsGroundTotalArea { get { return _SportsGroundTotalArea; } set { _SportsGroundTotalArea = value; } }
    private float _SportsGroundRepair; public float SportsGroundRepair { get { return _SportsGroundRepair; } set { _SportsGroundRepair = value; } }
    private float _SportsGroundBuild; public float SportsGroundBuild { get { return _SportsGroundBuild; } set { _SportsGroundBuild = value; } }
    private float _SportsGroundRent; public float SportsGroundRent { get { return _SportsGroundRent; } set { _SportsGroundRent = value; } }
    private float _SportsGroundUse; public float SportsGroundUse { get { return _SportsGroundUse; } set { _SportsGroundUse = value; } }
    private float _ParkCount; public float ParkCount { get { return _ParkCount; } set { _ParkCount = value; } }
    private float _ParkTotalArea; public float ParkTotalArea { get { return _ParkTotalArea; } set { _ParkTotalArea = value; } }
    private float _ParkRepair; public float ParkRepair { get { return _ParkRepair; } set { _ParkRepair = value; } }
    private float _ParkBuild; public float ParkBuild { get { return _ParkBuild; } set { _ParkBuild = value; } }
    private float _ParkRent; public float ParkRent { get { return _ParkRent; } set { _ParkRent = value; } }
    private float _ParkUse; public float ParkUse { get { return _ParkUse; } set { _ParkUse = value; } }
    private float _AvenueCount; public float AvenueCount { get { return _AvenueCount; } set { _AvenueCount = value; } }
    private float _AvenueTotalArea; public float AvenueTotalArea { get { return _AvenueTotalArea; } set { _AvenueTotalArea = value; } }
    private float _AvenueRepair; public float AvenueRepair { get { return _AvenueRepair; } set { _AvenueRepair = value; } }
    private float _AvenueBuild; public float AvenueBuild { get { return _AvenueBuild; } set { _AvenueBuild = value; } }
    private float _AvenueRent; public float AvenueRent { get { return _AvenueRent; } set { _AvenueRent = value; } }
    private float _AvenueUse; public float AvenueUse { get { return _AvenueUse; } set { _AvenueUse = value; } }
    private float _TransportCount; public float TransportCount { get { return _TransportCount; } set { _TransportCount = value; } }
    private float _TransportRepair; public float TransportRepair { get { return _TransportRepair; } set { _TransportRepair = value; } }
    private float _TransportBuild; public float TransportBuild { get { return _TransportBuild; } set { _TransportBuild = value; } }
    private float _TransportRent; public float TransportRent { get { return _TransportRent; } set { _TransportRent = value; } }
    private float _TransportUse; public float TransportUse { get { return _TransportUse; } set { _TransportUse = value; } }
    private float _SpecialPurposeMachineCount; public float SpecialPurposeMachineCount { get { return _SpecialPurposeMachineCount; } set { _SpecialPurposeMachineCount = value; } }
    private float _SpecialPurposeMachineRepair; public float SpecialPurposeMachineRepair { get { return _SpecialPurposeMachineRepair; } set { _SpecialPurposeMachineRepair = value; } }
    private float _SpecialPurposeMachineBuild; public float SpecialPurposeMachineBuild { get { return _SpecialPurposeMachineBuild; } set { _SpecialPurposeMachineBuild = value; } }
    private float _SpecialPurposeMachineRent; public float SpecialPurposeMachineRent { get { return _SpecialPurposeMachineRent; } set { _SpecialPurposeMachineRent = value; } }
    private float _SpecialPurposeMachineUse; public float SpecialPurposeMachineUse { get { return _SpecialPurposeMachineUse; } set { _SpecialPurposeMachineUse = value; } }
    private float _OtherPropertyCount; public float OtherPropertyCount { get { return _OtherPropertyCount; } set { _OtherPropertyCount = value; } }
    private float _OtherPropertyTotalArea; public float OtherPropertyTotalArea { get { return _OtherPropertyTotalArea; } set { _OtherPropertyTotalArea = value; } }
    private float _OtherPropertyRepair; public float OtherPropertyRepair { get { return _OtherPropertyRepair; } set { _OtherPropertyRepair = value; } }
    private float _OtherPropertyBuild; public float OtherPropertyBuild { get { return _OtherPropertyBuild; } set { _OtherPropertyBuild = value; } }
    private float _OtherPropertyRent; public float OtherPropertyRent { get { return _OtherPropertyRent; } set { _OtherPropertyRent = value; } }
    private float _OtherPropertyUse; public float OtherPropertyUse { get { return _OtherPropertyUse; } set { _OtherPropertyUse = value; } }

    private float _S_avt_cemi; public float S_avt_cemi { get { return _S_avt_cemi; } set { _S_avt_cemi = value; } }
    private float _S_avt_temir; public float S_avt_temir { get { return _S_avt_temir; } set { _S_avt_temir = value; } }
    private float _S_ist_sayi; public float S_ist_sayi { get { return _S_ist_sayi; } set { _S_ist_sayi = value; } }
    private float _S_ist_feal; public float S_ist_feal { get { return _S_ist_feal; } set { _S_ist_feal = value; } }
    private float _S_ist_ish_yerleri; public float S_ist_ish_yerleri { get { return _S_ist_ish_yerleri; } set { _S_ist_ish_yerleri = value; } }
    private float _S_ist_dovriyye; public float S_ist_dovriyye { get { return _S_ist_dovriyye; } set { _S_ist_dovriyye = value; } }
    private float _S_qyb_sayi; public float S_qyb_sayi { get { return _S_qyb_sayi; } set { _S_qyb_sayi = value; } }
    private float _S_qyb_umumi; public float S_qyb_umumi { get { return _S_qyb_umumi; } set { _S_qyb_umumi = value; } }
    private float _S_qyb_temir; public float S_qyb_temir { get { return _S_qyb_temir; } set { _S_qyb_temir = value; } }
    private float _S_qyb_insha; public float S_qyb_insha { get { return _S_qyb_insha; } set { _S_qyb_insha = value; } }
    private float _S_qyb_icare; public float S_qyb_icare { get { return _S_qyb_icare; } set { _S_qyb_icare = value; } }
    private float _S_qyb_ist; public float S_qyb_ist { get { return _S_qyb_ist; } set { _S_qyb_ist = value; } }



}

public class Budce
{
    public Budce() { }
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
    public Budce(int reg, int mun, int year)
    {
        string strSQL;
        using (SqlConnection connection =
        new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = string.Format("SELECT top 1 * from MBudjetPrognosisDetails MI where MI.RegionID=" + reg + " and MI.Municipality={0} and MI.ReportYear={1}  order by SubPeriod desc", mun, year);
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _MunicipalBudgetIncomingPrognosis = o2f(sreader["MunicipalBudgetIncomingPrognosis"]);
                _MunicipalBudgetExpensePrognosis = o2f(sreader["MunicipalBudgetExpensePrognosis"]);

            }
            sreader.Close();
            ////////////////
            strSQL = string.Format("SELECT top 1 * from MBudgetDetails MI where MI.RegionID=" + reg + " and MI.Municipality={0} and MI.ReportYear={1}  order by SubPeriod desc", mun, year);
            command = new SqlCommand(strSQL, connection);
            sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _LandTaxNaturalPerson = o2f(sreader["LandTaxNaturalPerson"]);
                _AssessedTaxNaturalPerson = o2f(sreader["AssessedTaxNaturalPerson"]);
                _TaxConstructionMaterials = o2f(sreader["TaxConstructionMaterials"]);
                _ProfitTaxEnterprise = o2f(sreader["ProfitTaxEnterprise"]);
                _AdvertisePayment = o2f(sreader["AdvertisePayment"]);
                _TouristServicePayment = o2f(sreader["TouristServicePayment"]);
                _CarParkPayment = o2f(sreader["CarParkPayment"]);
                _PropertyExpropriation = o2f(sreader["PropertyExpropriation"]);
                _GroundExpropriation = o2f(sreader["GroundExpropriation"]);
                _MunicipalityPropertyRent = o2f(sreader["MunicipalityPropertyRent"]);
                _MunicipalityGroundRent = o2f(sreader["MunicipalityGroundRent"]);
                _OtherServicePayment = o2f(sreader["OtherServicePayment"]);
                _FinancialSupportFizLegEntity = o2f(sreader["FinancialSupportFizLegEntity"]);
                _FinancialSupportGrantIntOrg = o2f(sreader["FinancialSupportGrantIntOrg"]);
                _StateBudgetSubsidy = o2f(sreader["StateBudgetSubsidy"]);
                _AccruadPercentSanction = o2f(sreader["AccruadPercentSanction"]);
                _OtherIncomings = o2f(sreader["OtherIncomings"]);
                _ExpLocGovBody = o2f(sreader["ExpLocGovBody"]);
                _ExpRemunerationOfLabour = o2f(sreader["ExpRemunerationOfLabour"]);
                _ExpEducationRepair = o2f(sreader["ExpEducationRepair"]);
                _ExpEducationConstruction = o2f(sreader["ExpEducationConstruction"]);
                _ExpEducationProcurement = o2f(sreader["ExpEducationProcurement"]);
                _ExpEducationTrainingTasks = o2f(sreader["ExpEducationTrainingTasks"]);
                _ExpEducationOtherExpense = o2f(sreader["ExpEducationOtherExpense"]);
                _ExpHealthRepair = o2f(sreader["ExpHealthRepair"]);
                _ExpHealthConstruction = o2f(sreader["ExpHealthConstruction"]);
                _ExpOrgSanitaryEnterprise = o2f(sreader["ExpOrgSanitaryEnterprise"]);
                _ExpHealthProcurement = o2f(sreader["ExpHealthProcurement"]);
                _ExpHealthOtherExpense = o2f(sreader["ExpHealthOtherExpense"]);
                _ExpCultureRepair = o2f(sreader["ExpCultureRepair"]);
                _ExpCultureConstruction = o2f(sreader["ExpCultureConstruction"]);
                _ExpCultureHistoricalSite = o2f(sreader["ExpCultureHistoricalSite"]);
                _ExpCultureProcurement = o2f(sreader["ExpCultureProcurement"]);
                _ExpCultureOtherExpense = o2f(sreader["ExpCultureOtherExpense"]);
                _ExpSportsGroundRepair = o2f(sreader["ExpSportsGroundRepair"]);
                _ExpSportsGroundConstruction = o2f(sreader["ExpSportsGroundConstruction"]);
                _ExpSportsGroundProcurement = o2f(sreader["ExpSportsGroundProcurement"]);
                _ExpSportsGroundOtherExpense = o2f(sreader["ExpSportsGroundOtherExpense"]);
                _ExpMunicipalRoadRepair = o2f(sreader["ExpMunicipalRoadRepair"]);
                _ExpMunicipalRoadConstruction = o2f(sreader["ExpMunicipalRoadConstruction"]);
                _ExpHousingHome = o2f(sreader["ExpHousingHome"]);
                _ExpHousing = o2f(sreader["ExpHousing"]);
                _ExpConstructionOfFuneralHomes = o2f(sreader["ExpConstructionOfFuneralHomes"]);
                _ExpStreetsAndSquares = o2f(sreader["ExpStreetsAndSquares"]);
                _ExpPark = o2f(sreader["ExpPark"]);
                _ExpAvenue = o2f(sreader["ExpAvenue"]);
                _ExpCemetery = o2f(sreader["ExpCemetery"]);
                _ExpLighting = o2f(sreader["ExpLighting"]);
                _ExpRepairElectricLines = o2f(sreader["ExpRepairElectricLines"]);
                _ExpRepairGazLines = o2f(sreader["ExpRepairGazLines"]);
                _ExpRepairHeatingLines = o2f(sreader["ExpRepairHeatingLines"]);
                _ExpRepairSewerLines = o2f(sreader["ExpRepairSewerLines"]);
                _ExpSupportWaterChannels = o2f(sreader["ExpSupportWaterChannels"]);
                _ExpDisposalOfHouseHoldWaste = o2f(sreader["ExpDisposalOfHouseHoldWaste"]);
                _ExpReconstructionOtherExpense = o2f(sreader["ExpReconstructionOtherExpense"]);
                _ExpDrinkingWaterSupply = o2f(sreader["ExpDrinkingWaterSupply"]);
                _ExpIrrigation = o2f(sreader["ExpIrrigation"]);
                _ExpLocEnterprise = o2f(sreader["ExpLocEnterprise"]);
                _ExpTradeService = o2f(sreader["ExpTradeService"]);
                _ExpLocTransport = o2f(sreader["ExpLocTransport"]);
                _ExpComServ = o2f(sreader["ExpComServ"]);
                _ExpLocMinerals = o2f(sreader["ExpLocMinerals"]);
                _ExpAgrarian = o2f(sreader["ExpAgrarian"]);
                _ExpForestry = o2f(sreader["ExpForestry"]);
                _ExpFishing = o2f(sreader["ExpFishing"]);
                _ExpHunter = o2f(sreader["ExpHunter"]);
                _ExpOtherSector = o2f(sreader["ExpOtherSector"]);
                _ExpEcologicalBalance = o2f(sreader["ExpEcologicalBalance"]);
                _ExpWaterPollution = o2f(sreader["ExpWaterPollution"]);
                _ExpOtherActivity = o2f(sreader["ExpOtherActivity"]);
                _ExpHomelessness = o2f(sreader["ExpHomelessness"]);
                _ExpFuneral = o2f(sreader["ExpFuneral"]);
                _ExpSocialProtectionOtherActivity = o2f(sreader["ExpSocialProtectionOtherActivity"]);
                _ExpFamilyFarm = o2f(sreader["ExpFamilyFarm"]);
                _ExpPressActivity = o2f(sreader["ExpPressActivity"]);
                _ExpServiceNoMainSection = o2f(sreader["ExpServiceNoMainSection"]);
                _NameOfExecutedProjects = sreader["NameOfExecutedProjects"].ToString();

                _S_gelir_cemi=_LandTaxNaturalPerson + _AssessedTaxNaturalPerson + _TaxConstructionMaterials + _ProfitTaxEnterprise + _AdvertisePayment + _TouristServicePayment + _CarParkPayment + _PropertyExpropriation + _MunicipalityPropertyRent + _OtherServicePayment + _FinancialSupportFizLegEntity + _FinancialSupportGrantIntOrg + _StateBudgetSubsidy + _AccruadPercentSanction + _OtherIncomings;
                _S_xerc_cemi=_ExpLocGovBody + _ExpEducationRepair + _ExpEducationConstruction + _ExpEducationProcurement + _ExpEducationTrainingTasks + _ExpEducationOtherExpense + _ExpHealthRepair + _ExpHealthConstruction + _ExpOrgSanitaryEnterprise + _ExpHealthProcurement + _ExpHealthOtherExpense + _ExpCultureRepair + _ExpCultureConstruction + _ExpCultureHistoricalSite + _ExpCultureProcurement + _ExpCultureOtherExpense + _ExpSportsGroundRepair + _ExpSportsGroundConstruction + _ExpSportsGroundProcurement + _ExpSportsGroundOtherExpense + _ExpMunicipalRoadRepair + _ExpMunicipalRoadConstruction + _ExpHousingHome + _ExpHousing + _ExpConstructionOfFuneralHomes + _ExpStreetsAndSquares + _ExpPark + _ExpAvenue + _ExpCemetery + _ExpLighting + _ExpRepairElectricLines + _ExpRepairGazLines + _ExpRepairHeatingLines + _ExpRepairSewerLines + _ExpSupportWaterChannels + _ExpDisposalOfHouseHoldWaste + _ExpReconstructionOtherExpense + _ExpDrinkingWaterSupply + _ExpIrrigation + _ExpLocEnterprise + _ExpTradeService + _ExpLocTransport + _ExpComServ + _ExpLocMinerals + _ExpAgrarian + _ExpForestry + _ExpFishing + _ExpHunter + _ExpOtherSector + _ExpEcologicalBalance + _ExpWaterPollution + _ExpOtherActivity + _ExpHomelessness + _ExpFuneral + _ExpSocialProtectionOtherActivity + _ExpFamilyFarm + _ExpPressActivity + _ExpServiceNoMainSection;
                _S_xerc_tehsil=_ExpEducationRepair + _ExpEducationConstruction + _ExpEducationProcurement + _ExpEducationTrainingTasks + _ExpEducationOtherExpense;
                _S_xerc_sehiyye=_ExpHealthRepair + _ExpHealthConstruction + _ExpOrgSanitaryEnterprise + _ExpHealthProcurement + _ExpHealthOtherExpense;
                _S_xerc_medeniyyet=_ExpCultureRepair + _ExpCultureConstruction + _ExpCultureHistoricalSite + _ExpCultureProcurement + _ExpCultureOtherExpense;
                _S_xerc_idman=_ExpSportsGroundRepair + _ExpSportsGroundConstruction + _ExpSportsGroundProcurement + _ExpSportsGroundOtherExpense;
                _S_xerc_yollar=_ExpMunicipalRoadRepair + _ExpMunicipalRoadConstruction;
                _S_xerc_kommunal=_ExpHousingHome + _ExpHousing + _ExpConstructionOfFuneralHomes + _ExpStreetsAndSquares + _ExpPark + _ExpAvenue + _ExpCemetery + _ExpLighting + _ExpRepairElectricLines + _ExpRepairGazLines + _ExpRepairHeatingLines + _ExpRepairSewerLines + _ExpSupportWaterChannels + _ExpDisposalOfHouseHoldWaste + _ExpReconstructionOtherExpense;


                _S_xerc_su=_ExpDrinkingWaterSupply + _ExpIrrigation;
                _S_xerc_iqtisadi=_ExpLocEnterprise + _ExpTradeService + _ExpLocTransport + _ExpComServ + _ExpLocMinerals + _ExpAgrarian + _ExpForestry + _ExpFishing + _ExpHunter + _ExpOtherSector;
                _S_xerc_ekoloji=_ExpEcologicalBalance + _ExpWaterPollution + _ExpOtherActivity;
                _S_xerc_sosial = _ExpHomelessness + _ExpFuneral + _ExpSocialProtectionOtherActivity;
                _S_xerc_qeyri_yash=_ExpConstructionOfFuneralHomes + _ExpStreetsAndSquares + _ExpPark + _ExpAvenue + _ExpCemetery + _ExpLighting + _ExpRepairElectricLines + _ExpRepairGazLines + _ExpRepairHeatingLines + _ExpRepairSewerLines + _ExpSupportWaterChannels + _ExpDisposalOfHouseHoldWaste + _ExpReconstructionOtherExpense;
                _S_xerc_erazi_abad = _ExpStreetsAndSquares + _ExpPark + _ExpAvenue + _ExpCemetery + _ExpLighting + _ExpRepairElectricLines + _ExpRepairGazLines + _ExpRepairHeatingLines + _ExpRepairSewerLines + _ExpSupportWaterChannels + _ExpDisposalOfHouseHoldWaste + _ExpReconstructionOtherExpense;



            }
            sreader.Close();
        }
    }
    private float _MunicipalBudgetIncomingPrognosis; public float MunicipalBudgetIncomingPrognosis { get { return _MunicipalBudgetIncomingPrognosis; } set { _MunicipalBudgetIncomingPrognosis = value; } }
    private float _MunicipalBudgetExpensePrognosis; public float MunicipalBudgetExpensePrognosis { get { return _MunicipalBudgetExpensePrognosis; } set { _MunicipalBudgetExpensePrognosis = value; } }
    private float _LandTaxNaturalPerson; public float LandTaxNaturalPerson { get { return _LandTaxNaturalPerson; } set { _LandTaxNaturalPerson = value; } }
    private float _AssessedTaxNaturalPerson; public float AssessedTaxNaturalPerson { get { return _AssessedTaxNaturalPerson; } set { _AssessedTaxNaturalPerson = value; } }
    private float _TaxConstructionMaterials; public float TaxConstructionMaterials { get { return _TaxConstructionMaterials; } set { _TaxConstructionMaterials = value; } }
    private float _ProfitTaxEnterprise; public float ProfitTaxEnterprise { get { return _ProfitTaxEnterprise; } set { _ProfitTaxEnterprise = value; } }
    private float _AdvertisePayment; public float AdvertisePayment { get { return _AdvertisePayment; } set { _AdvertisePayment = value; } }
    private float _TouristServicePayment; public float TouristServicePayment { get { return _TouristServicePayment; } set { _TouristServicePayment = value; } }
    private float _CarParkPayment; public float CarParkPayment { get { return _CarParkPayment; } set { _CarParkPayment = value; } }
    private float _PropertyExpropriation; public float PropertyExpropriation { get { return _PropertyExpropriation; } set { _PropertyExpropriation = value; } }
    private float _GroundExpropriation; public float GroundExpropriation { get { return _GroundExpropriation; } set { _GroundExpropriation = value; } }
    private float _MunicipalityPropertyRent; public float MunicipalityPropertyRent { get { return _MunicipalityPropertyRent; } set { _MunicipalityPropertyRent = value; } }
    private float _MunicipalityGroundRent; public float MunicipalityGroundRent { get { return _MunicipalityGroundRent; } set { _MunicipalityGroundRent = value; } }
    private float _OtherServicePayment; public float OtherServicePayment { get { return _OtherServicePayment; } set { _OtherServicePayment = value; } }
    private float _FinancialSupportFizLegEntity; public float FinancialSupportFizLegEntity { get { return _FinancialSupportFizLegEntity; } set { _FinancialSupportFizLegEntity = value; } }
    private float _FinancialSupportGrantIntOrg; public float FinancialSupportGrantIntOrg { get { return _FinancialSupportGrantIntOrg; } set { _FinancialSupportGrantIntOrg = value; } }
    private float _StateBudgetSubsidy; public float StateBudgetSubsidy { get { return _StateBudgetSubsidy; } set { _StateBudgetSubsidy = value; } }
    private float _AccruadPercentSanction; public float AccruadPercentSanction { get { return _AccruadPercentSanction; } set { _AccruadPercentSanction = value; } }
    private float _OtherIncomings; public float OtherIncomings { get { return _OtherIncomings; } set { _OtherIncomings = value; } }
    private float _ExpLocGovBody; public float ExpLocGovBody { get { return _ExpLocGovBody; } set { _ExpLocGovBody = value; } }
    private float _ExpRemunerationOfLabour; public float ExpRemunerationOfLabour { get { return _ExpRemunerationOfLabour; } set { _ExpRemunerationOfLabour = value; } }
    private float _ExpEducationRepair; public float ExpEducationRepair { get { return _ExpEducationRepair; } set { _ExpEducationRepair = value; } }
    private float _ExpEducationConstruction; public float ExpEducationConstruction { get { return _ExpEducationConstruction; } set { _ExpEducationConstruction = value; } }
    private float _ExpEducationProcurement; public float ExpEducationProcurement { get { return _ExpEducationProcurement; } set { _ExpEducationProcurement = value; } }
    private float _ExpEducationTrainingTasks; public float ExpEducationTrainingTasks { get { return _ExpEducationTrainingTasks; } set { _ExpEducationTrainingTasks = value; } }
    private float _ExpEducationOtherExpense; public float ExpEducationOtherExpense { get { return _ExpEducationOtherExpense; } set { _ExpEducationOtherExpense = value; } }
    private float _ExpHealthRepair; public float ExpHealthRepair { get { return _ExpHealthRepair; } set { _ExpHealthRepair = value; } }
    private float _ExpHealthConstruction; public float ExpHealthConstruction { get { return _ExpHealthConstruction; } set { _ExpHealthConstruction = value; } }
    private float _ExpOrgSanitaryEnterprise; public float ExpOrgSanitaryEnterprise { get { return _ExpOrgSanitaryEnterprise; } set { _ExpOrgSanitaryEnterprise = value; } }
    private float _ExpHealthProcurement; public float ExpHealthProcurement { get { return _ExpHealthProcurement; } set { _ExpHealthProcurement = value; } }
    private float _ExpHealthOtherExpense; public float ExpHealthOtherExpense { get { return _ExpHealthOtherExpense; } set { _ExpHealthOtherExpense = value; } }
    private float _ExpCultureRepair; public float ExpCultureRepair { get { return _ExpCultureRepair; } set { _ExpCultureRepair = value; } }
    private float _ExpCultureConstruction; public float ExpCultureConstruction { get { return _ExpCultureConstruction; } set { _ExpCultureConstruction = value; } }
    private float _ExpCultureHistoricalSite; public float ExpCultureHistoricalSite { get { return _ExpCultureHistoricalSite; } set { _ExpCultureHistoricalSite = value; } }
    private float _ExpCultureProcurement; public float ExpCultureProcurement { get { return _ExpCultureProcurement; } set { _ExpCultureProcurement = value; } }
    private float _ExpCultureOtherExpense; public float ExpCultureOtherExpense { get { return _ExpCultureOtherExpense; } set { _ExpCultureOtherExpense = value; } }
    private float _ExpSportsGroundRepair; public float ExpSportsGroundRepair { get { return _ExpSportsGroundRepair; } set { _ExpSportsGroundRepair = value; } }
    private float _ExpSportsGroundConstruction; public float ExpSportsGroundConstruction { get { return _ExpSportsGroundConstruction; } set { _ExpSportsGroundConstruction = value; } }
    private float _ExpSportsGroundProcurement; public float ExpSportsGroundProcurement { get { return _ExpSportsGroundProcurement; } set { _ExpSportsGroundProcurement = value; } }
    private float _ExpSportsGroundOtherExpense; public float ExpSportsGroundOtherExpense { get { return _ExpSportsGroundOtherExpense; } set { _ExpSportsGroundOtherExpense = value; } }
    private float _ExpMunicipalRoadRepair; public float ExpMunicipalRoadRepair { get { return _ExpMunicipalRoadRepair; } set { _ExpMunicipalRoadRepair = value; } }
    private float _ExpMunicipalRoadConstruction; public float ExpMunicipalRoadConstruction { get { return _ExpMunicipalRoadConstruction; } set { _ExpMunicipalRoadConstruction = value; } }
    private float _ExpHousingHome; public float ExpHousingHome { get { return _ExpHousingHome; } set { _ExpHousingHome = value; } }
    private float _ExpHousing; public float ExpHousing { get { return _ExpHousing; } set { _ExpHousing = value; } }
    private float _ExpConstructionOfFuneralHomes; public float ExpConstructionOfFuneralHomes { get { return _ExpConstructionOfFuneralHomes; } set { _ExpConstructionOfFuneralHomes = value; } }
    private float _ExpStreetsAndSquares; public float ExpStreetsAndSquares { get { return _ExpStreetsAndSquares; } set { _ExpStreetsAndSquares = value; } }
    private float _ExpPark; public float ExpPark { get { return _ExpPark; } set { _ExpPark = value; } }
    private float _ExpAvenue; public float ExpAvenue { get { return _ExpAvenue; } set { _ExpAvenue = value; } }
    private float _ExpCemetery; public float ExpCemetery { get { return _ExpCemetery; } set { _ExpCemetery = value; } }
    private float _ExpLighting; public float ExpLighting { get { return _ExpLighting; } set { _ExpLighting = value; } }
    private float _ExpRepairElectricLines; public float ExpRepairElectricLines { get { return _ExpRepairElectricLines; } set { _ExpRepairElectricLines = value; } }
    private float _ExpRepairGazLines; public float ExpRepairGazLines { get { return _ExpRepairGazLines; } set { _ExpRepairGazLines = value; } }
    private float _ExpRepairHeatingLines; public float ExpRepairHeatingLines { get { return _ExpRepairHeatingLines; } set { _ExpRepairHeatingLines = value; } }
    private float _ExpRepairSewerLines; public float ExpRepairSewerLines { get { return _ExpRepairSewerLines; } set { _ExpRepairSewerLines = value; } }
    private float _ExpSupportWaterChannels; public float ExpSupportWaterChannels { get { return _ExpSupportWaterChannels; } set { _ExpSupportWaterChannels = value; } }
    private float _ExpDisposalOfHouseHoldWaste; public float ExpDisposalOfHouseHoldWaste { get { return _ExpDisposalOfHouseHoldWaste; } set { _ExpDisposalOfHouseHoldWaste = value; } }
    private float _ExpReconstructionOtherExpense; public float ExpReconstructionOtherExpense { get { return _ExpReconstructionOtherExpense; } set { _ExpReconstructionOtherExpense = value; } }
    private float _ExpDrinkingWaterSupply; public float ExpDrinkingWaterSupply { get { return _ExpDrinkingWaterSupply; } set { _ExpDrinkingWaterSupply = value; } }
    private float _ExpIrrigation; public float ExpIrrigation { get { return _ExpIrrigation; } set { _ExpIrrigation = value; } }
    private float _ExpLocEnterprise; public float ExpLocEnterprise { get { return _ExpLocEnterprise; } set { _ExpLocEnterprise = value; } }
    private float _ExpTradeService; public float ExpTradeService { get { return _ExpTradeService; } set { _ExpTradeService = value; } }
    private float _ExpLocTransport; public float ExpLocTransport { get { return _ExpLocTransport; } set { _ExpLocTransport = value; } }
    private float _ExpComServ; public float ExpComServ { get { return _ExpComServ; } set { _ExpComServ = value; } }
    private float _ExpLocMinerals; public float ExpLocMinerals { get { return _ExpLocMinerals; } set { _ExpLocMinerals = value; } }
    private float _ExpAgrarian; public float ExpAgrarian { get { return _ExpAgrarian; } set { _ExpAgrarian = value; } }
    private float _ExpForestry; public float ExpForestry { get { return _ExpForestry; } set { _ExpForestry = value; } }
    private float _ExpFishing; public float ExpFishing { get { return _ExpFishing; } set { _ExpFishing = value; } }
    private float _ExpHunter; public float ExpHunter { get { return _ExpHunter; } set { _ExpHunter = value; } }
    private float _ExpOtherSector; public float ExpOtherSector { get { return _ExpOtherSector; } set { _ExpOtherSector = value; } }
    private float _ExpEcologicalBalance; public float ExpEcologicalBalance { get { return _ExpEcologicalBalance; } set { _ExpEcologicalBalance = value; } }
    private float _ExpWaterPollution; public float ExpWaterPollution { get { return _ExpWaterPollution; } set { _ExpWaterPollution = value; } }
    private float _ExpOtherActivity; public float ExpOtherActivity { get { return _ExpOtherActivity; } set { _ExpOtherActivity = value; } }
    private float _ExpHomelessness; public float ExpHomelessness { get { return _ExpHomelessness; } set { _ExpHomelessness = value; } }
    private float _ExpFuneral; public float ExpFuneral { get { return _ExpFuneral; } set { _ExpFuneral = value; } }
    private float _ExpSocialProtectionOtherActivity; public float ExpSocialProtectionOtherActivity { get { return _ExpSocialProtectionOtherActivity; } set { _ExpSocialProtectionOtherActivity = value; } }
    private float _ExpFamilyFarm; public float ExpFamilyFarm { get { return _ExpFamilyFarm; } set { _ExpFamilyFarm = value; } }
    private float _ExpPressActivity; public float ExpPressActivity { get { return _ExpPressActivity; } set { _ExpPressActivity = value; } }
    private float _ExpServiceNoMainSection; public float ExpServiceNoMainSection { get { return _ExpServiceNoMainSection; } set { _ExpServiceNoMainSection = value; } }

    private string _NameOfExecutedProjects; public string NameOfExecutedProjects { get { return _NameOfExecutedProjects; } set { _NameOfExecutedProjects = value; } }

    private float _S_gelir_cemi; public float S_gelir_cemi { get { return _S_gelir_cemi; } set { _S_gelir_cemi = value; } }
    private float _S_xerc_cemi; public float S_xerc_cemi { get { return _S_xerc_cemi; } set { _S_xerc_cemi = value; } }
    private float _S_xerc_tehsil; public float S_xerc_tehsil { get { return _S_xerc_tehsil; } set { _S_xerc_tehsil = value; } }
    private float _S_xerc_sehiyye; public float S_xerc_sehiyye { get { return _S_xerc_sehiyye; } set { _S_xerc_sehiyye = value; } }
    private float _S_xerc_medeniyyet; public float S_xerc_medeniyyet { get { return _S_xerc_medeniyyet; } set { _S_xerc_medeniyyet = value; } }
    private float _S_xerc_idman; public float S_xerc_idman { get { return _S_xerc_idman; } set { _S_xerc_idman = value; } }
    private float _S_xerc_yollar; public float S_xerc_yollar { get { return _S_xerc_yollar; } set { _S_xerc_yollar = value; } }
    private float _S_xerc_kommunal; public float S_xerc_kommunal { get { return _S_xerc_kommunal; } set { _S_xerc_kommunal = value; } }
    private float _S_xerc_su; public float S_xerc_su { get { return _S_xerc_su; } set { _S_xerc_su = value; } }
    private float _S_xerc_iqtisadi; public float S_xerc_iqtisadi { get { return _S_xerc_iqtisadi; } set { _S_xerc_iqtisadi = value; } }
    private float _S_xerc_ekoloji; public float S_xerc_ekoloji { get { return _S_xerc_ekoloji; } set { _S_xerc_ekoloji = value; } }
    private float _S_xerc_sosial; public float S_xerc_sosial { get { return _S_xerc_sosial; } set { _S_xerc_sosial = value; } }

    private float _S_xerc_qeyri_yash; public float S_xerc_qeyri_yash { get { return _S_xerc_qeyri_yash; } set { _S_xerc_qeyri_yash = value; } }
    private float _S_xerc_erazi_abad; public float S_xerc_erazi_abad { get { return _S_xerc_erazi_abad; } set { _S_xerc_erazi_abad = value; } }


}

/*

S_torpaq
S_ozg
S_ozg_ferdi
S_ozg_kend
S_ozg_sahibkar
S_ozg_diger
S_icare
S_icare_kend
S_icare_sahib
S_icare_diger
S_eht_ozg
S_eht_icare
S_per_ozg
S_per_icare
S_yar_ozg
S_yar_icare
S_yarsiz_ozg
S_yar_icare
S_umumi_ist_ozg
S_umumi_ist_icare
 
S_avt_cemi
S_avt_temir
S_ist_sayi
S_ist_feal
S_ist_ish_yerleri
S_ist_dovriyye
S_qyb_sayi
S_qyb_umumi
S_qyb_temir
S_qyb_insha
S_qyb_icare
S_qyb_ist

S_gelir_cemi
S_gelir_xerc
S_gelir_tehsil
S_gelir_sehiyye
S_gelir_medeniyyet
S_gelir_idman
S_gelir_yollar
S_gelir_kommunal
S_gelir_su
S_gelir_iqtisadi
S_gelir_ekoloji
S_gelir_sosial

*/
