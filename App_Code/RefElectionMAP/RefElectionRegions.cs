using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Drawing;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace RefElectionHTMLMap
{
    public class Regions
    {
        //private members
        private string regionName;
        private List<Point> regionCoordinates;
        private Color regionColor;
        private int regionID;
        private decimal regionParametr;
        /*private int compareNumber;*/

        public Regions()
        { }
        //Constructor
        public Regions(string regionName, List<Point> regionCoordinates)
        {
            this.regionName = regionName;
            this.regionCoordinates = regionCoordinates;
        }
        //properties
        public decimal RegionParametr
        {
            get { return regionParametr; }
            set { regionParametr = value; }
        }        public int RegionID
        {
            get { return regionID; }
            set { regionID = value; }
        }
        public string RegionName
        {
            get { return regionName; }
            set { regionName = value; }
        }
        public List<Point> RegionCoordinates
        {
            get { return regionCoordinates; }
            set { regionCoordinates = value; }
        }
        public Color RegionColor
        {
            get { return regionColor; }
            set { regionColor = value; }
        }
        /*public int CompareNumber
        {
            get { return compareNumber; }
            set { compareNumber = value; }
        }*/
    }
}
