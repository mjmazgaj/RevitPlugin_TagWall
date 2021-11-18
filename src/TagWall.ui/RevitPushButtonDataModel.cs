using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using TagWall.res;

namespace TagWall.ui
{
    public class RevitPushButtonDataModel
    {
        public string Label { get; set; }
        public RibbonPanel ribbonPanel { get; set; }
        public string ToolTip { get; set; }
        public string ToolTipImageName { get; set; }
        public string ImageName { get; set; }
        public string LargeImageName { get; set; }
        public string AssemblyLocation { get; set; }
        public string ClassName { get; set; }

    }
}
