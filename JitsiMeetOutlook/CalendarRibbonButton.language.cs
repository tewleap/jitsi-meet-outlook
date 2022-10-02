using System.Text.Json;

namespace JitsiMeetOutlook
{
    public partial class CalendarRibbonButton
    {
        private void setLanguage()
        {
            this.buttonNewJitsiMeeting.Label = Globals.ThisAddIn.getElementTranslation("calendarRibbonButton", "buttonNewJitsiMeeting");
            this.JitsiMeet.Label = Globals.ThisAddIn.getElementTranslation("calendarRibbonButton", "label");
        }
    }
}
