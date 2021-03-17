using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for RiaisForm
/// </summary>
public class RiaisForm
{
    private bool _InsertOrUpdate;
    public bool InsertOrUpdate
    {
        get { return _InsertOrUpdate; }
        set { _InsertOrUpdate = value; }
    }
    private string _SubPeriod;
    public string SubPeriod
    {
        get { return _SubPeriod; }
        set { _SubPeriod = value; }
    }

    private string _FormYear;
    public string FormYear
    {
        get { return _FormYear; }
        set { _FormYear = value; }
    }
    private string _RegionID;
    public string RegionID
    {
        get { return _RegionID; }
        set { _RegionID = value; }
    }
    private string _TableName;
    public string TableName
    {
        get { return _TableName; }
        set { _TableName = value; }
    }
    private string _FormName;

    public string FormName
    {
        get { return _FormName; }
        set { _FormName = value; }
    }
    private string _FormDesc;
    public string FormDesc
    {
        get { return _FormDesc; }
        set { _FormDesc = value; }
    }
    private string _FormSendTimeIlkin;
    public string FormSendTimeIlkin
    {
        get { return _FormSendTimeIlkin; }
        set { _FormSendTimeIlkin = value; }
    }
    private string _FormSendTimeDeqiq;
    public string FormSendTimeDeqiq
    {
        get { return _FormSendTimeDeqiq; }
        set { _FormSendTimeDeqiq = value; }
    }
    
    private string _Period;
    public string Period
    {
        get
        {
            return _Period;
        }
        set
        {
            _Period = value;
        }
    }

	public RiaisForm()
	{

	}
}