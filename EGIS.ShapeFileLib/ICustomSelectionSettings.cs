using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIS.ShapeFileLib
{
    public interface ICustomSelectionSettings
    {
        Color GetFillColor(int index);

        Color GetOutlineColor(int index);
    }
}
