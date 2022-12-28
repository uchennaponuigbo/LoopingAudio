using System.Windows.Forms;

namespace LoopingAudio
{
    partial class formLoopAudio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlayOrStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentTrackToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSongName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textGoToTimeStamp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlayOrStop
            // 
            this.buttonPlayOrStop.Location = new System.Drawing.Point(299, 115);
            this.buttonPlayOrStop.Name = "buttonPlayOrStop";
            this.buttonPlayOrStop.Size = new System.Drawing.Size(70, 40);
            this.buttonPlayOrStop.TabIndex = 0;
            this.buttonPlayOrStop.Text = "Play";
            this.buttonPlayOrStop.UseVisualStyleBackColor = true;
            this.buttonPlayOrStop.Click += new System.EventHandler(this.buttonPlayOrStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 44);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(744, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelEndTime);
            this.groupBox1.Controls.Add(this.labelStartTime);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.buttonPlayOrStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(375, 115);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 40);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartTime.Location = new System.Drawing.Point(6, 80);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(46, 25);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "0:00";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndTime.Location = new System.Drawing.Point(676, 76);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(80, 25);
            this.labelEndTime.TabIndex = 4;
            this.labelEndTime.Text = "59:59:99";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTrackToolStripMenuItem,
            this.openFromDatabaseToolStripMenuItem,
            this.saveCurrentTrackToDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTrackToolStripMenuItem
            // 
            this.openTrackToolStripMenuItem.Name = "openTrackToolStripMenuItem";
            this.openTrackToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.openTrackToolStripMenuItem.Text = "Open Track...";
            this.openTrackToolStripMenuItem.Click += new System.EventHandler(this.openTrackToolStripMenuItem_Click);
            // 
            // openFromDatabaseToolStripMenuItem
            // 
            this.openFromDatabaseToolStripMenuItem.Name = "openFromDatabaseToolStripMenuItem";
            this.openFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.openFromDatabaseToolStripMenuItem.Text = "Open From Database...";
            // 
            // saveCurrentTrackToDatabaseToolStripMenuItem
            // 
            this.saveCurrentTrackToDatabaseToolStripMenuItem.Name = "saveCurrentTrackToDatabaseToolStripMenuItem";
            this.saveCurrentTrackToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.saveCurrentTrackToDatabaseToolStripMenuItem.Text = "Save Current Track to Database...";
            this.saveCurrentTrackToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentTrackToDatabaseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Now Playing";
            // 
            // labelSongName
            // 
            this.labelSongName.AutoSize = true;
            this.labelSongName.Location = new System.Drawing.Point(295, 66);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(116, 20);
            this.labelSongName.TabIndex = 5;
            this.labelSongName.Text = "SongName.mp3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mp3";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Open mp3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go To Timestamp";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textGoToTimeStamp
            // 
            this.textGoToTimeStamp.Location = new System.Drawing.Point(280, 333);
            this.textGoToTimeStamp.MaxLength = 8;
            this.textGoToTimeStamp.Name = "textGoToTimeStamp";
            this.textGoToTimeStamp.Size = new System.Drawing.Size(101, 27);
            this.textGoToTimeStamp.TabIndex = 7;
            // 
            // formLoopAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.textGoToTimeStamp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSongName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formLoopAudio";
            this.Text = "Looping Audio";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPlayOrStop;
        private TrackBar trackBar1;
        private GroupBox groupBox1;
        private Button buttonReset;
        private Label labelEndTime;
        private Label labelStartTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openTrackToolStripMenuItem;
        private ToolStripMenuItem openFromDatabaseToolStripMenuItem;
        private ToolStripMenuItem saveCurrentTrackToDatabaseToolStripMenuItem;
        private Label label1;
        private Label labelSongName;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private TextBox textGoToTimeStamp;
    }
}