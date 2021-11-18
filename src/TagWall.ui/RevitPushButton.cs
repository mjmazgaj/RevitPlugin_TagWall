using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagWall.core;
using TagWall.res;

namespace TagWall.ui
{
    public static class RevitPushButton
    {
        public static PushButton Create(RevitPushButtonDataModel data)
        {
            var guid = Guid.NewGuid().ToString();
            var pushButtonDataModel = new PushButtonData(guid, data.Label, data.AssemblyLocation, data.ClassName)
            {
                Image = ResourceImage.GetImage(data.ImageName),
                ToolTipImage = ResourceImage.GetImage(data.ToolTipImageName),
                LargeImage = ResourceImage.GetImage(data.LargeImageName)
            };

            return (PushButton)data.ribbonPanel.AddItem(pushButtonDataModel);
        }
    }
}
