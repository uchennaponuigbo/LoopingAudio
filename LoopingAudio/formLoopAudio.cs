using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopingAudio
{
    //https://learn.microsoft.com/en-us/previous-versions/windows/embedded/ms930695(v=msdn.10)?redirectedfrom=MSDN
    public partial class formLoopAudio : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private const int MaxMusicLengthSeconds = 3600;
        public formLoopAudio()
        {
            InitializeComponent();
            //player.controls.(properties and methods can be called here)
            buttonPlayOrStop.Text = "Play";
            trackBar1.Maximum = MaxMusicLengthSeconds;
            //EnableOrDisableControls();
            //ShowOrHideTimestamps();
        }

        public void EnableOrDisableControls(bool allowEdits = false)
        {
            trackBar1.Enabled = allowEdits;

            buttonReset.Enabled = allowEdits;
            buttonPlayOrStop.Enabled = allowEdits;
            buttonGoToTimeStamp.Enabled = allowEdits;

            textStartLoop.Enabled = allowEdits;
            textEndLoop.Enabled = allowEdits;
            textGoToTimeStamp.Enabled = allowEdits;
        }

        private void ShowOrHideTimestamps(bool showLabels = false)
            => labelStartLoop.Visible = labelEndLoop.Visible = showLabels;

        private void buttonPlayOrStop_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
        }

        private void saveCurrentTrackToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetLoopPoints_Click(object sender, EventArgs e)
        {
            //if(Validator.IsNotEmpty(textStartLoop) && Validator.IsNotEmpty(textEndLoop))
            //{

            //}
            ShowOrHideTimestamps(true);
            textStartLoop.Text = textEndLoop.Text = "";
        }
    }

}