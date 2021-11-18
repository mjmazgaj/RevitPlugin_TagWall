using Autodesk.Revit.DB;

namespace TagWall.core
{
    public class FormData
    {
        public bool Function { get; set; }
        public bool Name { get; set; }
        public bool Thickness { get; set; }
        public ElementId TextTypeId { get; set; }
        public int Decimal { get; set; }
        public UnitsType UnitTypeId { get; set; }
    }
}
