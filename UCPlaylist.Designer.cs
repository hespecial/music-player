namespace music_player
{
    partial class UCPlaylist
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
            this.musicList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddMusic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // musicList
            // 
            this.musicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.musicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.musicList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.musicList.ForeColor = System.Drawing.Color.SteelBlue;
            this.musicList.FullRowSelect = true;
            this.musicList.HideSelection = false;
            this.musicList.Location = new System.Drawing.Point(116, 176);
            this.musicList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicList.MultiSelect = false;
            this.musicList.Name = "musicList";
            this.musicList.OwnerDraw = true;
            this.musicList.Size = new System.Drawing.Size(1232, 722);
            this.musicList.TabIndex = 5;
            this.musicList.UseCompatibleStateImageBehavior = false;
            this.musicList.View = System.Windows.Forms.View.Details;
            this.musicList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.musicList_DrawColumnHeader);
            this.musicList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.musicList_DrawItem);
            this.musicList.SelectedIndexChanged += new System.EventHandler(this.musicList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Song";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 393;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ext";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddMusic
            // 
            this.buttonAddMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(186)))), ((int)(((byte)(240)))));
            this.buttonAddMusic.FlatAppearance.BorderSize = 3;
            this.buttonAddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMusic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddMusic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddMusic.Location = new System.Drawing.Point(230, 38);
            this.buttonAddMusic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAddMusic.Name = "buttonAddMusic";
            this.buttonAddMusic.Size = new System.Drawing.Size(280, 80);
            this.buttonAddMusic.TabIndex = 6;
            this.buttonAddMusic.Text = "Import Music";
            this.buttonAddMusic.UseVisualStyleBackColor = true;
            this.buttonAddMusic.Click += new System.EventHandler(this.buttonAddMusic_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::music_player.Properties.Resources.import;
            this.pictureBox1.Location = new System.Drawing.Point(116, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UCPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAddMusic);
            this.Controls.Add(this.musicList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UCPlaylist";
            this.Size = new System.Drawing.Size(1432, 1056);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView musicList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonAddMusic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
