using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace TagWall.core
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private UIDocument _uidoc;
        private ElementId _TextTypeId = null;
        private UnitsType _UnitTypeId = UnitsType.mm;
        private int _Decimal = 0;
        public Form1(UIDocument uIDocument)
        {
            InitializeComponent();
            _uidoc = uIDocument;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupTextTypes();
            SetupDecimals();
            SetupUnitsType();
        }

        private void cbTextType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _TextTypeId = ((KeyValuePair<string, ElementId>)cbTextType.SelectedItem).Value;
        }

        private void cbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UnitTypeId = (UnitsType)cbUnits.SelectedValue;
        }

        private void cbDecimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Decimal = (int)cbDecimals.SelectedValue;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        public FormData GetInfromation()
        {
            var formData = new FormData();

            formData.Function = chbFunction.Checked;
            formData.Name = chbName.Checked;
            formData.Thickness = chbThickness.Checked;
            formData.TextTypeId = _TextTypeId;
            formData.Decimal = _Decimal;
            formData.UnitTypeId = _UnitTypeId;

            return formData;
        }
        private void SetupTextTypes()
        {
            var doc = _uidoc.Document;
            var allTextElementType = new FilteredElementCollector(doc).OfClass(typeof(TextElementType));

            var list = new List<KeyValuePair<string, ElementId>>();

            foreach (var item in allTextElementType)
                list.Add(new KeyValuePair<string, ElementId>(item.Name, item.Id));

            cbTextType.DataSource = new BindingSource(list, null);
            cbTextType.DisplayMember = "Key";
            cbTextType.ValueMember = "Value";
        }

        private void SetupUnitsType()
        {
            var list = Enum.GetValues(typeof(UnitsType));
            cbUnits.DataSource = list;
        }

        private void SetupDecimals()
        {
            var list = new List<int> { 0, 1, 2, 3, 4 };
            cbDecimals.DataSource = list;
        }

    }
}
