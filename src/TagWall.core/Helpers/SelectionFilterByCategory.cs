using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace TagWall.core
{
    public class SelectionFilterByCategory : ISelectionFilter
    {
        private string _category { get; set; }

        public SelectionFilterByCategory(string category)
        {
            _category = category;
        }
        public bool AllowElement(Element elem)
        {
            if (elem?.Category?.Name != null)
                if (elem.Category.Name == _category)
                    return true;
            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            throw new NotImplementedException();
        }
    }
}
