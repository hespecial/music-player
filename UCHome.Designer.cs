namespace music_player
{
    partial class UCHome
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lablePlayingState = new System.Windows.Forms.Label();
            this.labelSongName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // lablePlayingState
            // 
            this.lablePlayingState.AutoSize = true;
            this.lablePlayingState.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lablePlayingState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(203)))));
            this.lablePlayingState.Location = new System.Drawing.Point(770, 258);
            this.lablePlayingState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lablePlayingState.Name = "lablePlayingState";
            this.lablePlayingState.Size = new System.Drawing.Size(418, 86);
            this.lablePlayingState.TabIndex = 12;
            this.lablePlayingState.Text = "No Playing ...";
            // 
            // labelSongName
            // 
            this.labelSongName.AutoSize = true;
            this.labelSongName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelSongName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSongName.Location = new System.Drawing.Point(940, 440);
            this.labelSongName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(0, 59);
            this.labelSongName.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::music_player.Properties.Resources.音乐3;
            this.pictureBox2.Location = new System.Drawing.Point(786, 410);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::music_player.Properties.Resources.音乐2;
            this.pictureBox1.Location = new System.Drawing.Point(140, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picNext
            // 
            this.picNext.Image = global::music_player.Properties.Resources.下一首1;
            this.picNext.Location = new System.Drawing.Point(722, 814);
            this.picNext.Margin = new System.Windows.Forms.Padding(6);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(120, 120);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 10;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            this.picNext.MouseEnter += new System.EventHandler(this.picNext_MouseEnter);
            this.picNext.MouseLeave += new System.EventHandler(this.picNext_MouseLeave);
            // 
            // picPrevious
            // 
            this.picPrevious.Image = global::music_player.Properties.Resources.上一首1;
            this.picPrevious.Location = new System.Drawing.Point(374, 814);
            this.picPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(120, 120);
            this.picPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrevious.TabIndex = 9;
            this.picPrevious.TabStop = false;
            this.picPrevious.Click += new System.EventHandler(this.picPrevious_Click);
            this.picPrevious.MouseEnter += new System.EventHandler(this.picPrevious_MouseEnter);
            this.picPrevious.MouseLeave += new System.EventHandler(this.picPrevious_MouseLeave);
            // 
            // picStop
            // 
            this.picStop.Image = global::music_player.Properties.Resources.停止3;
            this.picStop.Location = new System.Drawing.Point(896, 810);
            this.picStop.Margin = new System.Windows.Forms.Padding(6);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(130, 130);
            this.picStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStop.TabIndex = 8;
            this.picStop.TabStop = false;
            this.picStop.Click += new System.EventHandler(this.picStop_Click);
            this.picStop.MouseEnter += new System.EventHandler(this.picStop_MouseEnter);
            this.picStop.MouseLeave += new System.EventHandler(this.picStop_MouseLeave);
            // 
            // picPause
            // 
            this.picPause.Image = global::music_player.Properties.Resources.播放1;
            this.picPause.Location = new System.Drawing.Point(550, 814);
            this.picPause.Margin = new System.Windows.Forms.Padding(6);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(120, 120);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPause.TabIndex = 7;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            this.picPause.MouseEnter += new System.EventHandler(this.picPause_MouseEnter);
            this.picPause.MouseLeave += new System.EventHandler(this.picPause_MouseLeave);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::music_player.Properties.Resources.播放;
            this.picPlay.Location = new System.Drawing.Point(550, 814);
            this.picPlay.Margin = new System.Windows.Forms.Padding(6);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(120, 120);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 6;
            this.picPlay.TabStop = false;
            this.picPlay.Visible = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            this.picPlay.MouseEnter += new System.EventHandler(this.picPlay_MouseEnter);
            this.picPlay.MouseLeave += new System.EventHandler(this.picPlay_MouseLeave);
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.labelSongName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lablePlayingState);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPrevious);
            this.Controls.Add(this.picStop);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.picPlay);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1432, 1056);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.PictureBox picStop;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lablePlayingState;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSongName;
    }
}
