using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace EGIS.ShapeFileLib
{
	/// <summary>Interface to allow external by object colouring of selected objects in the shapefile</summary>
	public interface ICustomSelectionSettings
	{
		Color GetFillColor(int index);

		Color GetOutlineColor(int index);
	}
}
