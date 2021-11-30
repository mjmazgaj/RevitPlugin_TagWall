using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace TagWall.core
{
    public class SelectionFilterByCategory : ISelectionFilter
    {
        private string _category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category">Name of revit object category</param>
        public SelectionFilterByCategory(string category)
        {
            _category = category;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elem">name of element</param>
        /// <returns>True if element category is searched category</returns>
        public bool AllowElement(Element elem)
        {
            if (elem?.Category?.Name != null)
                if (elem.Category.Name == _category)
                    return true;
            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }
}
