using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HTMLMap
{
	public class MapArea
	{
        private AreaShapesEnum _shape;
		private List<Point> _coords;
		private Uri _href;
        private string _alt;
        private Dictionary<string, string> _attributes;


        /// <summary>
        /// Gets or sets given MapArea's shape
        /// </summary>
		public AreaShapesEnum Shape
		{
			get { return _shape; }
			set { _shape = value;  }
		}

        /// <summary>
        /// Gets or sets <see cref="System.Collections.Generic.List"/> of coordinates for this MapArea object.
        /// </summary>
		public List<Point> Coords
		{
			get { return _coords; }
			set { _coords = value; }
		}

        /// <summary>
        /// Gets or sets <see cref="System.Uri"/> for this MapArea object.
        /// </summary>
		public Uri Href
		{
			get { return _href; }
			set { _href = value; }
		}

        /// <summary>
        /// Gets or sets the alternate text for this area object.
        /// </summary>
        public string Alt
        {
            get { return _alt; }
            set { _alt = value; }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Collections.Generic.Dictionary"/> array of additional attributes of this MapArea object.
        /// </summary>
        /// <remarks>
        /// It can be used for instance to define client-side onmouseover event handler as folows:
        /// <code>
        /// MapArea map = new MapArea();
        /// map.Attributes.Add("onmouseover", "javascript:alert('mouseover');");
        /// </code>
        /// </remarks>
        public Dictionary<string, string> Attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }

        /// <summary>
        /// Initializes a new <b>MapArea</b> object.
        /// </summary>
		public MapArea()
		{
			_coords = new List<Point>();
            _attributes = new Dictionary<string, string>();
		}

	}
}

// @Copyright by Bashir Magomedov 2007 
// bashir.magomedov@gmail.com
