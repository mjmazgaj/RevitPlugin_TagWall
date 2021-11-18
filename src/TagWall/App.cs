#region Namespaces
using Autodesk.Revit.UI;
#endregion

namespace TagWall
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            var UI = new SetupInterface(app, "My plugin");
            UI.Initialize("Tag Wall");

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            return Result.Succeeded;
        }
    }
}
