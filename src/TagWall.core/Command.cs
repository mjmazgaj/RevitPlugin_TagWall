#region Namespaces
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Windows.Forms;
#endregion

namespace TagWall.core
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            if (!Validation.CanCreateTextNote(doc))
            {
                ShowMessage.Create("Funkcja nie działa na tym widoku", MessageType.Error);
                return Result.Cancelled;
            }

            var userInformation = new FormData();
            using (var tagWallForm = new Form1(uidoc))
            {
                tagWallForm.ShowDialog();
                if (tagWallForm.DialogResult == DialogResult.Cancel)
                    return Result.Cancelled;

                userInformation = tagWallForm.GetInfromation();
            }

            var elementReferance = uidoc.Selection.PickObject(ObjectType.Element, new SelectionFilterByCategory("Walls"), "Select basic wall");
            var wall = (Wall)doc.GetElement(elementReferance);

            if (!Validation.IsWallProper(wall))
                return Result.Cancelled;

            var pt = uidoc.Selection.PickPoint("Pick a point");

            var tagWallTextNote = new TagWallTextNote(userInformation);
            var msg = tagWallTextNote.Create(wall);

            using (var transaction = new Transaction(doc))
            {
                transaction.Start("Tag Wall Annotate");
                TextNote.Create(doc, doc.ActiveView.Id, pt, msg, tagWallTextNote.TextNoteOptions);
                transaction.Commit();
            }

            return Result.Succeeded;
        }

        public static string GetPath()
        {
            return typeof(Command).Namespace + "." + nameof(Command);
        }
    }
}
