using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JitsiMeetOutlook.Entities
{
    public class ToolBarSettings
    {
        public static Dictionary<string, string> Values { get; set; } = new Dictionary<string, string>
        {
            {
                "Microphone", "microphone"
            },
            {
                "Camera", "camera"
            },
            {
                "Screenshare", "desktop"
            },
            {
                "Chat", "chat"
            },
            {
                "Raise Hand", "raisehand"
            },
            {
                "Participants Pane", "participants-pane"
            },
            {
                "Toggle Tile View", "tileview"
            },
            {
                "Toggle Camera", "toggle-camera"
            },
            {
                "Leave Meeting", "hangup"
            },
            {
                "Profile", "profile"
            },
            {
                "Invite people", "invite"
            },
            {
                "Performance settings", "videoquality"
            },
            {
                "View Full Screen", "fullscreen"
            },
            {
                "Security Options", "security"
            },
            {
                "Closed Caption", "closedcaptions"
            },
            {
                "Recording", "recording"
            },
            {
                "Highlight Moments (when Recording)", "highlight"
            },
            {
                "Live Streaming", "livestreaming"
            },
            {
                "Share Video", "sharedvideo"
            },
            {
                "Share Audio", "sharedaudio"
            },
            {
                "Toggle Noise Suppression", "noisesuppression"
            },
            {
                "Etherpad", "etherpad"
            },
            {
                "Select Background", "select-background"
            },
            {
                "Undock IFrame", "undock-iframe"
            },
            {
                "Dock IFrame", "dock-iframe"
            },
            {
                "Settings", "settings"
            },
            {
                "Speaker Stats", "stats"
            },
            {
                "View Shortcuts", "shortcuts"
            },
            {
                "Embed Meeting", "embedmeeting"
            },
            {
                "Leave Feedback", "feedback"
            },
            {
                "Download App", "download"
            },
            {
                "Help", "help"
            },
            {
                "Filmstrip", "filmstrip"
            },
        };
    }
}
