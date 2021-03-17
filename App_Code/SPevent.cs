using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
///Azərbaycan Respublikası regionlarının 2009-2013-cü illərdə sosial-iqtisadi inkişafı Dövlət Proqramı 
/// </summary>
[Serializable]
public class SPevent
{
    public enum EventsType { Butun,Achilish, Temelqoyma, Insha, EsasliTemir, Diger, HazirObject, Berpa, YarimchiqObject };
    private string _RegionID, _RegionName, _EventCode, _Description, _Executer, _Comment,_EventDate;
    private int _ObjectTotalCost, _NewWorkPlaces;
    private EventsType _EventPurpose;
    private DateTime _ExecuteDate;
    private SPDate _StartDate, _EndDate;

	public SPevent()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string EventDate
    {
        get
        {
            return _EventDate;
        }
        set
        {
            _EventDate = value;
        }
    }
    public string RegionID
    {
        get
        {
            return _RegionID;
        }
        set
        {
            _RegionID = value;
        }
    }

    public string RegionName
    {
        get
        {
            return _RegionName;
        }
        set
        {
            _RegionName = value;
        }
    }
    public string EventCode
    {
        get
        {
            return _EventCode;
        }
        set
        {
            _EventCode = value;
        }
    }

    public string Description
    {
        get
        {
            return _Description;
        }
        set
        {
            _Description = value;
        }
    }
    public int ObjectTotalCost
    {
        get
        {
            return _ObjectTotalCost;
        }
        set
        {
            _ObjectTotalCost = value;
        }
    }
    public int NewWorkPlaces
    {
        get
        {
            return _NewWorkPlaces;
        }
        set
        {
            _NewWorkPlaces = value;
        }
    }

    public string Executer
    {
        get
        {
            return _Executer;
        }
        set
        {
            _Executer = value;
        }
    }
    public string Comment
    {
        get
        {
            return _Comment;
        }
        set
        {
            _Comment = value;
        }
    }
    public EventsType EventPurpose
    {
        get
        {
            return _EventPurpose;
        }
        set
        {
            _EventPurpose = value;
        }
    }
    public DateTime ExecuteDate
    {
        get
        {
            return _ExecuteDate;
        }
        set
        {
            _ExecuteDate = value;
        }
    }

    public SPDate StartDate
    {
        get
        {
            return _StartDate;
        }
        set
        {
            _StartDate = value;
        }
    }
    public SPDate EndDate
    {
        get
        {
            return _EndDate;
        }
        set
        {
            _EndDate = value;
        }
    }

}
[Serializable]
public class SPDate
{
    public SPDate()
    {

    }

    private string _Year, _SPDateType, _SPValue;

    public string Year
    {
        get
        {
            return _Year;
        }
        set
        {
            _Year = value;
        }
    }
    public string SPDateType
    {
        get
        {
            return _SPDateType;
        }
        set
        {
            _SPDateType = value;
        }
    }
    public string SPValue
    {
        get
        {
            return _SPValue;
        }
        set
        {
            _SPValue = value;
        }
    }

    public string InString()
    {
        string ret = "";
        switch (SPDateType)
        {
            case "1":
                ret = Year;
                break;
            case "2":
                ret = Year + ", " + SPValue + " yarımil";
                break;
            case "3":
                ret = Year + ", " +GetRub(SPValue.Trim()) + " rüb";
                break;
            case "4":
                ret = Year + ", " +GetAy( SPValue.Trim()) + " ay";
                break;
            case "5":
                ret = SPValue ;
                break;
            default:
                break;
        }
        return ret;
    }

    private string GetAy(string strAy)
    {
        string ret = "";
        switch (strAy)
        {
            case "1":
                ret = "yanvar";
                break;
            case "2":
                ret = "fevral";
                break;
            case "3":
                ret = "mart";
                break;
            case "4":
                ret = "aprel";
                break;
            case "5":
                ret = "may";
                break;
            case "6":
                ret = "iyun";
                break;
            case "7":
                ret = "iyul";
                break;
            case "8":
                ret = "avqust";
                break;
            case "9":
                ret = "sentyabr";
                break;
            case "10":
                ret = "oktyabr";
                break;
            case "11":
                ret = "noyabr";
                break;
            case "12":
                ret = "dekabr";
                break;
            default:
                break;
        }
        return ret;
    }

    private string GetRub(string strRub)
    {
        string ret = "";
        switch (strRub)
        {
            case "1":
                ret = "I";
                break;
            case "2":
                ret = "II";
                break;
            case "3":
                ret = "III";
                break;
            case "4":
                ret = "IV";
                break;
            default:
                break;
        }
        return ret;
    }
}
