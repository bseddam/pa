using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
 
/// <summary>
/// Summary description for Parametr
/// </summary>
namespace RefElectionHTMLMap
{
    public class Parametr
    {
        private string engDescription;
        private string azDescription;
        private string tableName;
        private int compareNum;
        private int paramID;

        public Parametr()
        {  }

        public string EngDescription
        {
            get { return engDescription; }
            set { engDescription = value; }
        }
        public string AzDescription
        {
            get { return azDescription; }
            set { azDescription = value; }
        }
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        public int CompareNum
        {
            get { return compareNum; }
            set { compareNum = value; }
        }
        public int ParamID
        {
            get { return paramID; }
            set { paramID = value; }
        }
    }
}
