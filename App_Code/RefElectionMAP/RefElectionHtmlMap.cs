using System;
using System.Web.UI;
using System.Text;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Web.UI.WebControls;

namespace RefElectionHTMLMap
{
	public class HtmlMap : System.Web.UI.WebControls.WebControl
	{
		private List<MapArea> _areas = new List<MapArea>();

        /// <summary>
        /// Gets or sets Name and ID attributes fo map tag. 
        /// </summary>
		public string NAME
		{
			get { return this.ID; }
            set { this.ID = value; }
		}

        /// <summary>
        /// Gets or sets the list of areas of this RefElectionHtmlMap object.
        /// </summary>
		public List<MapArea> AREAS
		{
			get { return _areas; }
			set { _areas = value; }
		}

		protected override void Render(HtmlTextWriter writer)
		{
			writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ID);
			writer.AddAttribute(HtmlTextWriterAttribute.Name, this.NAME);
			writer.RenderBeginTag(HtmlTextWriterTag.Map);
            foreach (MapArea area in _areas)
			{
				writer.AddAttribute("shape", area.Shape.ToString());
				StringBuilder sbCoords = new StringBuilder();
				foreach (Point i in area.Coords)
				{
					sbCoords.Append(i.X + "," + i.Y);
					sbCoords.Append(",");
				}
				sbCoords.Remove(sbCoords.Length - 1, 1);
				writer.AddAttribute("coords", sbCoords.ToString());
				//writer.AddAttribute(HtmlTextWriterAttribute.Href, area.Href.ToString());
                writer.AddAttribute(HtmlTextWriterAttribute.Alt, area.Alt);
                foreach (string key in area.Attributes.Keys)
                {
                    writer.AddAttribute(key, area.Attributes[key]);
                }

				writer.RenderBeginTag(HtmlTextWriterTag.Area);
				writer.RenderEndTag();
			}
			writer.RenderEndTag();
		}
	}
}