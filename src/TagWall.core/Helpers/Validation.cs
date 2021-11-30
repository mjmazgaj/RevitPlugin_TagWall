using Autodesk.Revit.DB;

namespace TagWall.core
{
    public static class Validation
    {
        /// <summary>
        /// Check if function can be used in current view
        /// </summary>
        /// <param name="doc">name of current document</param>
        /// <returns>true or false</returns>
        public static bool CanCreateTextNote(Document doc)
        {
            var activeView = doc.ActiveView;

            switch (activeView.ViewType)
            {
                case ViewType.FloorPlan:
                    return true;
                case ViewType.CeilingPlan:
                    return true;
                case ViewType.Elevation:
                    return true;
                case ViewType.Section:
                    return true;
                case ViewType.Detail:
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Check if function can be used on chosen wall
        /// </summary>
        /// <param name="wall">Name of chosen wall</param>
        /// <returns>true or false</returns>
        public static bool IsWallProper(Wall wall)
        {
            if (wall.IsStackedWall)
            {
                ShowMessage.Create("Wybierz Basic Wall", MessageType.Error);
                return false;
            }
            if (wall?.WallType?.GetCompoundStructure()?.GetLayers() == null)
            {
                ShowMessage.Create("Wybierz Basic Wall", MessageType.Error);
                return false;
            }
            return true;
        }
    }
}
