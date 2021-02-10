namespace FFmpegWrapper
{
    partial class frmConvertToMP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvertToMP3));
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblInputDirectory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.gbConvert = new System.Windows.Forms.GroupBox();
            this.lblInputExtension = new System.Windows.Forms.Label();
            this.txtInputExtension = new System.Windows.Forms.TextBox();
            this.chkResolveSameName = new System.Windows.Forms.CheckBox();
            this.chkCopyFolderStructure = new System.Windows.Forms.CheckBox();
            this.chkIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.gbFileFolder = new System.Windows.Forms.GroupBox();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.rbSingleFile = new System.Windows.Forms.RadioButton();
            this.gbConvert.SuspendLayout();
            this.gbFileFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(293, 89);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblInputDirectory
            // 
            this.lblInputDirectory.AutoSize = true;
            this.lblInputDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDirectory.Location = new System.Drawing.Point(6, 16);
            this.lblInputDirectory.Name = "lblInputDirectory";
            this.lblInputDirectory.Size = new System.Drawing.Size(72, 13);
            this.lblInputDirectory.TabIndex = 1;
            this.lblInputDirectory.Text = "Input folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output folder";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(93, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(489, 20);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(93, 37);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(489, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(588, 11);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(587, 34);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // gbConvert
            // 
            this.gbConvert.Controls.Add(this.lblInputExtension);
            this.gbConvert.Controls.Add(this.txtInputExtension);
            this.gbConvert.Controls.Add(this.chkResolveSameName);
            this.gbConvert.Controls.Add(this.chkCopyFolderStructure);
            this.gbConvert.Controls.Add(this.chkIncludeSubFolders);
            this.gbConvert.Controls.Add(this.btnOutput);
            this.gbConvert.Controls.Add(this.btnConvert);
            this.gbConvert.Controls.Add(this.lblInputDirectory);
            this.gbConvert.Controls.Add(this.btnInput);
            this.gbConvert.Controls.Add(this.label2);
            this.gbConvert.Controls.Add(this.txtOutput);
            this.gbConvert.Controls.Add(this.txtInput);
            this.gbConvert.Controls.Add(this.gbFileFolder);
            this.gbConvert.Location = new System.Drawing.Point(8, 4);
            this.gbConvert.Name = "gbConvert";
            this.gbConvert.Size = new System.Drawing.Size(676, 120);
            this.gbConvert.TabIndex = 7;
            this.gbConvert.TabStop = false;
            // 
            // lblInputExtension
            // 
            this.lblInputExtension.AutoSize = true;
            this.lblInputExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputExtension.Location = new System.Drawing.Point(9, 66);
            this.lblInputExtension.Name = "lblInputExtension";
            this.lblInputExtension.Size = new System.Drawing.Size(62, 13);
            this.lblInputExtension.TabIndex = 13;
            this.lblInputExtension.Text = "Input Ext.";
            // 
            // txtInputExtension
            // 
            this.txtInputExtension.Location = new System.Drawing.Point(93, 63);
            this.txtInputExtension.Name = "txtInputExtension";
            this.txtInputExtension.Size = new System.Drawing.Size(35, 20);
            this.txtInputExtension.TabIndex = 12;
            this.txtInputExtension.Text = "rsd";
            this.txtInputExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkResolveSameName
            // 
            this.chkResolveSameName.AutoSize = true;
            this.chkResolveSameName.Location = new System.Drawing.Point(507, 66);
            this.chkResolveSameName.Name = "chkResolveSameName";
            this.chkResolveSameName.Size = new System.Drawing.Size(155, 17);
            this.chkResolveSameName.TabIndex = 11;
            this.chkResolveSameName.Text = "Auto-resolve same filename";
            this.chkResolveSameName.UseVisualStyleBackColor = true;
            // 
            // chkCopyFolderStructure
            // 
            this.chkCopyFolderStructure.AutoSize = true;
            this.chkCopyFolderStructure.Location = new System.Drawing.Point(378, 66);
            this.chkCopyFolderStructure.Name = "chkCopyFolderStructure";
            this.chkCopyFolderStructure.Size = new System.Drawing.Size(123, 17);
            this.chkCopyFolderStructure.TabIndex = 10;
            this.chkCopyFolderStructure.Text = "Copy folder structure";
            this.chkCopyFolderStructure.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSubFolders
            // 
            this.chkIncludeSubFolders.AutoSize = true;
            this.chkIncludeSubFolders.Location = new System.Drawing.Point(257, 66);
            this.chkIncludeSubFolders.Name = "chkIncludeSubFolders";
            this.chkIncludeSubFolders.Size = new System.Drawing.Size(115, 17);
            this.chkIncludeSubFolders.TabIndex = 8;
            this.chkIncludeSubFolders.Text = "Include sub-folders";
            this.chkIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // gbFileFolder
            // 
            this.gbFileFolder.Controls.Add(this.rbFolder);
            this.gbFileFolder.Controls.Add(this.rbSingleFile);
            this.gbFileFolder.Location = new System.Drawing.Point(134, 56);
            this.gbFileFolder.Name = "gbFileFolder";
            this.gbFileFolder.Size = new System.Drawing.Size(117, 31);
            this.gbFileFolder.TabIndex = 9;
            this.gbFileFolder.TabStop = false;
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Location = new System.Drawing.Point(53, 10);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(54, 17);
            this.rbFolder.TabIndex = 1;
            this.rbFolder.Text = "Folder";
            this.rbFolder.UseVisualStyleBackColor = true;
            // 
            // rbSingleFile
            // 
            this.rbSingleFile.AutoSize = true;
            this.rbSingleFile.Checked = true;
            this.rbSingleFile.Location = new System.Drawing.Point(6, 10);
            this.rbSingleFile.Name = "rbSingleFile";
            this.rbSingleFile.Size = new System.Drawing.Size(41, 17);
            this.rbSingleFile.TabIndex = 0;
            this.rbSingleFile.TabStop = true;
            this.rbSingleFile.Text = "File";
            this.rbSingleFile.UseVisualStyleBackColor = true;
            // 
            // frmConvertToMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(694, 128);
            this.Controls.Add(this.gbConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConvertToMP3";
            this.Text = "Convert to MP3";
            this.gbConvert.ResumeLayout(false);
            this.gbConvert.PerformLayout();
            this.gbFileFolder.ResumeLayout(false);
            this.gbFileFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblInputDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.GroupBox gbConvert;
        private System.Windows.Forms.CheckBox chkCopyFolderStructure;
        private System.Windows.Forms.GroupBox gbFileFolder;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.RadioButton rbSingleFile;
        private System.Windows.Forms.CheckBox chkIncludeSubFolders;
        private System.Windows.Forms.CheckBox chkResolveSameName;
        private System.Windows.Forms.Label lblInputExtension;
        private System.Windows.Forms.TextBox txtInputExtension;
    }
}

