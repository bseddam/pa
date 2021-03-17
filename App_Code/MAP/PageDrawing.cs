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
using System.Drawing;
using System.Drawing.Imaging;


namespace HTMLMap
{
    public class PageDrawing
    {
        public static string filePath = string.Empty;
        public PageDrawing()
        { }

        #region DrawHtmlPicture
        public static HtmlMap DrawHtmlPicture(int ParameterID, int Year)
        {
            List<Regions> regions = DrawPicture(ParameterID, Year);
            
            HtmlMap map = new HtmlMap();
            map.NAME = "RegionsMap";

            foreach (Regions region in regions)
            {
                MapArea area = new MapArea();
                area.Alt = region.RegionName + ": " + region.RegionParametr;
                area.Coords = region.RegionCoordinates;
                area.Shape = AreaShapesEnum.POLY;
                map.AREAS.Add(area);
            }
            return map;
        }
        #endregion 

        #region DrawPicture
        public static List<Regions> DrawPicture(int ParameterID, int Year)
        {
            int compareNumber = 0;
            RegionslistInfo regionListInfo = new RegionslistInfo();
            regionListInfo.GetRegionsList(ParameterID, Year);
            compareNumber = regionListInfo.RegionsList[0].CompareNumber;

            Point[] allPoints = new Point[]{
            new Point(0,0),
            new Point(0,800),
            new Point(800,800),
            new Point(800,0)  };

            Bitmap objForMap = new Bitmap(800, 600);             
            Graphics g = Graphics.FromImage(objForMap);
            Brush b = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Black);
            g.FillPolygon(new SolidBrush(Color.WhiteSmoke), allPoints);

            Point[] point;
            for (int i = 1; i < regionListInfo.RegionsList.Count + 1; i++)
            {
                try
                {
                    int k = regionListInfo.RegionsList[i-1].RegionCoordinates.Count;
                    point = new Point[k];
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw ex;
                }
                regionListInfo.RegionsList[i-1].RegionCoordinates.CopyTo(point);
                
                g.FillPolygon(new SolidBrush(regionListInfo.RegionsList[i-1].RegionColor), point);
                g.DrawPolygon(p, point);
                
            }
            //Draw rectangles
            Font font = new Font(new FontFamily("Arial"), 14, FontStyle.Bold);
           
            g.DrawRectangle(p, 670, 380, 20, 20);
            g.FillRectangle(new SolidBrush(Color.White), 670, 380, 20, 20);
            g.DrawString(" = 0", font, new SolidBrush(Color.Blue), new PointF(700, 380));

            g.DrawRectangle(p, 670, 420, 20, 20);
            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 180, 0)), 670, 420, 20, 20);
            g.DrawString(" < " + Convert.ToString(((compareNumber*20)/100)), font, new SolidBrush(Color.Blue), new PointF(700, 420));

            g.DrawRectangle(p, 670, 460, 20, 20);
            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 130, 2)), 670, 460, 20, 20);
            g.DrawString(Convert.ToString(((compareNumber*20)/100)) + " < " + Convert.ToString(((compareNumber * 50) / 100)), font, new SolidBrush(Color.Blue), new PointF(700, 460));

            g.DrawRectangle(p, 670, 500, 20, 20);
            g.FillRectangle(new SolidBrush(Color.FromArgb(254, 0, 0)), 670, 500, 20, 20);
            g.DrawString(Convert.ToString(((compareNumber*50)/100)) + " < " + Convert.ToString(((compareNumber * 80) / 100)), font, new SolidBrush(Color.Blue), new PointF(700, 500));
           
            g.DrawRectangle(p, 670, 540, 20, 20);
            g.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 0)), 670, 540, 20, 20);
            g.DrawString(" > " + Convert.ToString(((compareNumber * 80) / 100)), font, new SolidBrush(Color.Blue), new PointF(700, 540));
            //  Saving 
            objForMap.Save(filePath, ImageFormat.Png);
            g.Dispose();
            return regionListInfo.RegionsList;
        }
        #endregion
    }
}