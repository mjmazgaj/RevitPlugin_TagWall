#region Namespace
using Autodesk.Revit.UI;
using TagWall.ui;
using TagWall.core;
#endregion

namespace TagWall
{
    public class SetupInterface
    {
        private UIControlledApplication _application;
        private string _tabName;
        
        /// <summary>
        /// Constructor sets private application and RibbonTab name.
        /// </summary>
        /// <param name="application">Name of current application.</param>
        /// <param name="tabName">Name of RibbonTab to create.</param>
        public SetupInterface(UIControlledApplication application, string tabName)
        {
            _application = application;
            _tabName = tabName;
        }

        /// <summary>
        /// Creating new RibbonTab, RibbonPanel and PushButton.
        /// </summary>
        /// <param name="panelTab">Name of RibbonPanel to create.</param>
        public void Initialize(string panelTab)
        {
            _application.CreateRibbonTab(_tabName);
            RibbonPanel ribPanel = _application.CreateRibbonPanel(_tabName, panelTab);
            
            var revitPushButtonDataModel = new RevitPushButtonDataModel()
            {
                Label = "Tag Wall",
                ToolTip = "Some Tool Tip",
                ImageName = "icon3.jpg",
                LargeImageName = "icon1.png",
                ToolTipImageName = "icon2.png",
                ribbonPanel = ribPanel,
                AssemblyLocation = AssemblyCore.GetAssemblyLocation(),
                ClassName = Command.GetPath()
            };

            var pushButton = RevitPushButton.Create(revitPushButtonDataModel);
        }
    }
}
