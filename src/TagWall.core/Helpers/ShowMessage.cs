using Autodesk.Revit.UI;

namespace TagWall.core
{
    public static class ShowMessage
    {
        /// <summary>
        /// shows taksDialog with specified message and type
        /// </summary>
        /// <param name="message">text of message</param>
        /// <param name="type">type of message</param>
        public static void Create(string message, MessageType type)
        {
            string title = "";
            TaskDialogIcon icon = TaskDialogIcon.TaskDialogIconNone;

            switch (type)
            {
                case MessageType.Information:
                    title = "Information";
                    icon = TaskDialogIcon.TaskDialogIconInformation;
                    break;
                case MessageType.Warning:
                    title = "Warning";
                    icon = TaskDialogIcon.TaskDialogIconWarning;
                    break;
                case MessageType.Error:
                    title = "Error";
                    icon = TaskDialogIcon.TaskDialogIconError;
                    break;
                default:
                    break;
            }

            TaskDialog taskDialog = new TaskDialog(title)
            {
                MainContent = message,
                MainIcon = icon,
            };

            taskDialog.Show();
        }
    }
}
