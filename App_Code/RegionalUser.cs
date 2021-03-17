using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for RegionalUser
/// </summary>
public class RegionalUser
{
	public RegionalUser()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public enum UserTypes
    {
        RiaisOperator,Kurator,Administrator
    }

    public UserTypes _UserType;
    public UserTypes UserType
    {
        get { return _UserType; }
        set { _UserType = value; }
    }
    public string _UserName;
    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    
    public string _Password;
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    public string _RegionID;
    public string RegionID
    {
        get { return _RegionID; }
        set { _RegionID = value; }
    }
    public string RegionName;
    public string _RegionName
    {
        get { return _RegionName; }
        set { _RegionName = value; }
    }

}