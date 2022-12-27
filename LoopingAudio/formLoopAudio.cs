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
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public formLoopAudio()
        {
            InitializeComponent();
        }
    }

}