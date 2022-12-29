using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
            buttonPlayOrStop.Text = "Pause";
            trackBar1.Maximum = MaxMusicLengthSeconds;
            labelSongName.Text = "(None Playing)";
            timer1 = new System.Windows.Forms.Timer();
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

        private void TimeFormat(ref string time)
        {
            time = String.Format("{0:00}:{1:00}"); //minutes seconds
        }

        private void buttonPlayOrStop_Click(object sender, EventArgs e)
        {
            if(player.playState == WMPPlayState.wmppsPaused/*WMPPlayState.wmppsStopped*/)
            {
                player.controls.play();
                buttonPlayOrStop.Text = "Pause";
            }
            else
            {
                player.controls.pause();
                buttonPlayOrStop.Text = "Play";
            }
        }
        //https://learn.microsoft.com/en-us/previous-versions/windows/embedded/ms910018(v=msdn.10)
        //https://learn.microsoft.com/en-us/previous-versions/windows/embedded/ms930699(v=msdn.10)

        private void buttonReset_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
        }

        private void saveCurrentTrackToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if music length is greater than max time...
            using (openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader r = new StreamReader(openFileDialog1.FileName))
                    {
                        string filename = openFileDialog1.FileName;
                        player.URL = filename;
                        //if(player.)
                        labelSongName.Text = Path.GetFileName(filename);
                        //player.controls.pause();

                        r.Close();
                    }
                }
            }
        }

        private void buttonSetLoopPoints_Click(object sender, EventArgs e)
        {
            //if(Validator.IsNotEmpty(textStartLoop) && Validator.IsNotEmpty(textEndLoop))
            //{

            //}
            ShowOrHideTimestamps(true);
            textStartLoop.Text = textEndLoop.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = (int)player.controls.currentPosition;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = trackBar1.Value;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            

        }

        private void buttonGoToTimeStamp_Click(object sender, EventArgs e)
        {
            if(Validator.IsNotEmpty(textGoToTimeStamp))
                if(Validator.IsInteger(textGoToTimeStamp))
                {
                    //code here that

                }
            
        }

        //private void player_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        //{
        //    if (player.openState == WMPLib.WMPOpenState.wmposMediaOpen)
        //    {
        //        trackBar1.Maximum = (int)player.currentMedia.duration;
        //        timer1.Start();
        //    }
        //}
    }

}