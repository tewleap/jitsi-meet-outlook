﻿using Microsoft.Office.Tools.Ribbon;
using System.Threading.Tasks;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonGroup
    {

        private void AppointmentRibbonGroup_Load(object sender, RibbonUIEventArgs e)
        {
            if (Properties.Settings.Default.disableCustomRoomId)
            {
                fieldRoomID.Visible = false;
                buttonRandomRoomID.Visible = false;
            }

            initialise();
        }

        private void buttonDialogLauncher_Click(object sender, RibbonControlEventArgs e)
        {

            FormSettings settingsWindow = new FormSettings();
            settingsWindow.Show();
        }

        private void buttonCustomiseJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            randomiseRoomId();
        }

        private void buttonStartWithAudioMuted_Click(object sender, RibbonControlEventArgs e)
        {
            toggleMuteOnStart();
        }

        private void RoomID_TextChanged(object sender, RibbonControlEventArgs e)
        {
            _ = setRoomId(fieldRoomID.Text);
        }

        private void buttonStartWithVideoMuted_Click(object sender, RibbonControlEventArgs e)
        {
            toggleVideoOnStart();
        }

        private void buttonNewJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            addJitsiMeeting();
        }
    }
}
