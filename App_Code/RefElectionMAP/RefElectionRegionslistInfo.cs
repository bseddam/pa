using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Collections.Generic;
using RefElectionHTMLMap.DAL;
/// <summary>
/// Summary description for RegionslistInfo
namespace RefElectionHTMLMap
{
    public class RegionslistInfo
    {
        private List<Regions> regionsListInfo = new List<Regions>();
        //properties
        public List<Regions> RegionsList
        {
            get { return regionsListInfo; }
            set { regionsListInfo = value; }
        }
        public RegionslistInfo()
        {  }

        public List<Regions> GetRegionsList(int year)
        {
            List<Regions> tempRegionsListInfo = new List<Regions>();
            tempRegionsListInfo = RegionInfoDAL.GetRegionListDAL();
            foreach (Regions region in tempRegionsListInfo)
            {
                region.RegionCoordinates = RegionInfoDAL.GetRegionCoordinates(region.RegionID);
                if (region.RegionCoordinates.Count > 0)
                {
                    Regions currentRegion = new Regions();
                    currentRegion = RegionInfoDAL.GetRegionColor(region.RegionID, year);
                    region.RegionColor = currentRegion.RegionColor;
                    region.RegionParametr = currentRegion.RegionParametr;
                    /*region.CompareNumber = currentRegion.CompareNumber;*/

                    regionsListInfo.Add(region);
                }
            }
            return regionsListInfo;
        }
    }
}