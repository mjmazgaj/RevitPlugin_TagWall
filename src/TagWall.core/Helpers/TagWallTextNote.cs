using Autodesk.Revit.DB;
using System.Text;

namespace TagWall.core
{
    public class TagWallTextNote
    {
        private FormData _userInformation;
        public TextNoteOptions TextNoteOptions;

        public TagWallTextNote(FormData userInformation)
        {
            _userInformation = userInformation;
            SetupTextNoteOption();
        }
        /// <summary>
        /// Create string message with wall's layer information
        /// </summary>
        /// <param name="wall">name of wall</param>
        /// <returns></returns>
        public string Create(Wall wall)
        {
            var layers = wall.WallType.GetCompoundStructure().GetLayers();
            StringBuilder msg = new StringBuilder();

            foreach (var layer in layers)
            {
                var material = "undefined";
                var materialFromRevit = (Material)wall.Document.GetElement(layer.MaterialId);

                if (materialFromRevit?.Name != null)
                    material = materialFromRevit.Name;

                var width = UnitConverter.Convert(layer.Width, _userInformation.Decimal, _userInformation.UnitTypeId);

                if (_userInformation.Thickness == true)
                    msg.Append($"{width}\t");
                if (_userInformation.Function == true && layer?.Function != null)
                    msg.Append(layer.Function);
                if (_userInformation.Name == true)
                    msg.Append($" {material}");
                msg.AppendLine();
            }

            return msg.ToString();
        }

        private void SetupTextNoteOption()
        {
            TextNoteOptions = new TextNoteOptions()
            {
                HorizontalAlignment = HorizontalTextAlignment.Left,
                VerticalAlignment = VerticalTextAlignment.Top,
                TypeId = _userInformation.TextTypeId
            };
        }
    }
}
