namespace MovieOrganizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.sourcePathBrowse = new System.Windows.Forms.Button();
            this.destinationPathBrowse = new System.Windows.Forms.Button();
            this.sourceTitle = new System.Windows.Forms.Label();
            this.destinationTitle = new System.Windows.Forms.Label();
            this.sourceBox = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destinationBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.omdbApiKey = new System.Windows.Forms.TextBox();
            this.omdbapiLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.testOMDB = new System.Windows.Forms.Button();
            this.optCleanFile = new System.Windows.Forms.CheckBox();
            this.optYearinFile = new System.Windows.Forms.CheckBox();
            this.optOrganize = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(16, 34);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(252, 20);
            this.sourcePath.TabIndex = 0;
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(347, 34);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(258, 20);
            this.destinationPath.TabIndex = 1;
            // 
            // sourcePathBrowse
            // 
            this.sourcePathBrowse.Location = new System.Drawing.Point(274, 34);
            this.sourcePathBrowse.Name = "sourcePathBrowse";
            this.sourcePathBrowse.Size = new System.Drawing.Size(28, 20);
            this.sourcePathBrowse.TabIndex = 2;
            this.sourcePathBrowse.Text = "...";
            this.sourcePathBrowse.UseVisualStyleBackColor = true;
            this.sourcePathBrowse.Click += new System.EventHandler(this.sourcePathBrowse_Click);
            // 
            // destinationPathBrowse
            // 
            this.destinationPathBrowse.Location = new System.Drawing.Point(605, 34);
            this.destinationPathBrowse.Name = "destinationPathBrowse";
            this.destinationPathBrowse.Size = new System.Drawing.Size(34, 20);
            this.destinationPathBrowse.TabIndex = 3;
            this.destinationPathBrowse.Text = "...";
            this.destinationPathBrowse.UseVisualStyleBackColor = true;
            this.destinationPathBrowse.Click += new System.EventHandler(this.destinationPathBrowse_Click);
            // 
            // sourceTitle
            // 
            this.sourceTitle.AutoSize = true;
            this.sourceTitle.Location = new System.Drawing.Point(16, 15);
            this.sourceTitle.Name = "sourceTitle";
            this.sourceTitle.Size = new System.Drawing.Size(69, 13);
            this.sourceTitle.TabIndex = 4;
            this.sourceTitle.Text = "Source Path:";
            // 
            // destinationTitle
            // 
            this.destinationTitle.AutoSize = true;
            this.destinationTitle.Location = new System.Drawing.Point(350, 15);
            this.destinationTitle.Name = "destinationTitle";
            this.destinationTitle.Size = new System.Drawing.Size(88, 13);
            this.destinationTitle.TabIndex = 5;
            this.destinationTitle.Text = "Destination Path:";
            // 
            // sourceBox
            // 
            this.sourceBox.FormattingEnabled = true;
            this.sourceBox.HorizontalScrollbar = true;
            this.sourceBox.Location = new System.Drawing.Point(16, 61);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(286, 290);
            this.sourceBox.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 494);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(526, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(560, 494);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 10);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(347, 61);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(291, 290);
            this.destinationBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(16, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 10);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // omdbApiKey
            // 
            this.omdbApiKey.Location = new System.Drawing.Point(19, 411);
            this.omdbApiKey.Name = "omdbApiKey";
            this.omdbApiKey.Size = new System.Drawing.Size(109, 20);
            this.omdbApiKey.TabIndex = 11;
            this.omdbApiKey.Text = "a1901879";
            // 
            // omdbapiLink
            // 
            this.omdbapiLink.AutoSize = true;
            this.omdbapiLink.Location = new System.Drawing.Point(106, 392);
            this.omdbapiLink.Name = "omdbapiLink";
            this.omdbapiLink.Size = new System.Drawing.Size(133, 13);
            this.omdbapiLink.TabIndex = 12;
            this.omdbapiLink.TabStop = true;
            this.omdbapiLink.Text = "http://www.omdbapi.com/";
            this.omdbapiLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.omdbapiLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "OMDb API Key:";
            // 
            // testOMDB
            // 
            this.testOMDB.Location = new System.Drawing.Point(134, 411);
            this.testOMDB.Name = "testOMDB";
            this.testOMDB.Size = new System.Drawing.Size(69, 20);
            this.testOMDB.TabIndex = 14;
            this.testOMDB.Text = "Test Key";
            this.testOMDB.UseVisualStyleBackColor = true;
            this.testOMDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // optCleanFile
            // 
            this.optCleanFile.AutoSize = true;
            this.optCleanFile.Location = new System.Drawing.Point(347, 392);
            this.optCleanFile.Name = "optCleanFile";
            this.optCleanFile.Size = new System.Drawing.Size(120, 17);
            this.optCleanFile.TabIndex = 15;
            this.optCleanFile.Text = "Clean Up File Name";
            this.optCleanFile.UseVisualStyleBackColor = true;
            // 
            // optYearinFile
            // 
            this.optYearinFile.AutoSize = true;
            this.optYearinFile.Location = new System.Drawing.Point(347, 416);
            this.optYearinFile.Name = "optYearinFile";
            this.optYearinFile.Size = new System.Drawing.Size(137, 17);
            this.optYearinFile.TabIndex = 16;
            this.optYearinFile.Text = "Keep Year in File Name";
            this.optYearinFile.UseVisualStyleBackColor = true;
            // 
            // optOrganize
            // 
            this.optOrganize.AutoSize = true;
            this.optOrganize.Enabled = false;
            this.optOrganize.Location = new System.Drawing.Point(347, 439);
            this.optOrganize.Name = "optOrganize";
            this.optOrganize.Size = new System.Drawing.Size(188, 17);
            this.optOrganize.TabIndex = 17;
            this.optOrganize.Text = "Organize by Genre & Create Folders";
            this.optOrganize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 542);
            this.Controls.Add(this.optOrganize);
            this.Controls.Add(this.optYearinFile);
            this.Controls.Add(this.optCleanFile);
            this.Controls.Add(this.testOMDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.omdbapiLink);
            this.Controls.Add(this.omdbApiKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.destinationTitle);
            this.Controls.Add(this.sourceTitle);
            this.Controls.Add(this.destinationPathBrowse);
            this.Controls.Add(this.sourcePathBrowse);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.sourcePath);
            this.Name = "Form1";
            this.Text = "MovieOrganizer v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.Button sourcePathBrowse;
        private System.Windows.Forms.Button destinationPathBrowse;
        private System.Windows.Forms.Label sourceTitle;
        private System.Windows.Forms.Label destinationTitle;
        private System.Windows.Forms.ListBox sourceBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox destinationBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox omdbApiKey;
        private System.Windows.Forms.LinkLabel omdbapiLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testOMDB;
        private System.Windows.Forms.CheckBox optCleanFile;
        private System.Windows.Forms.CheckBox optYearinFile;
        private System.Windows.Forms.CheckBox optOrganize;
    }
}

