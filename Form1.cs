using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using cs_ffmpeg_mp3_converter;

namespace FFmpegWrapper
{
    public partial class frmConvertToMP3 : Form
    {
        const string MP3 = ".mp3";
        public frmConvertToMP3()
        {
            InitializeComponent();
        }

        private bool ProcessSingleFile(string inputFilePath, string outputFolder)
        {
            //Create directory path if doesn't exist
            if (!Directory.Exists(outputFolder)) Directory.CreateDirectory(outputFolder);

            //Check destination file exists
            string outputFullPath;
            string outputFileNameNoExtension;
            if(!('\\' == outputFolder[outputFolder.Length - 1]))
            {
                outputFolder += @"\";
            }
            outputFileNameNoExtension = Path.GetFileNameWithoutExtension(inputFilePath);
            
            byte number = 0;
            if (File.Exists(outputFolder + outputFileNameNoExtension + MP3))
            {
                if(!chkResolveSameName.Checked)
                {
                    MessageBox.Show("File already exists");
                    return false;
                }
                for (; File.Exists(outputFolder + outputFileNameNoExtension + number + MP3); number++);                
                outputFullPath = outputFolder + outputFileNameNoExtension + number + MP3;
            }
            else
            {
                outputFullPath = outputFolder + outputFileNameNoExtension + MP3;
            }
                
            FFMpeg.Convert2Mp3(inputFilePath, outputFullPath);
            return true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(rbSingleFile.Checked)
            {
                ProcessSingleFile(txtInput.Text, txtOutput.Text);
                return;
            }
            if(!Directory.Exists(txtInput.Text))
            {
                MessageBox.Show("Input directory, doesn't exist!");
                return;
            }
            SearchOption so;
            if (chkIncludeSubFolders.Checked)
                so = SearchOption.AllDirectories;
            else
                so = SearchOption.TopDirectoryOnly;
            ProcessDirectory(txtInput.Text, txtOutput.Text, so);
        }

        private bool ProcessDirectory(string inputDirectory, string outputDirectory, SearchOption seachOption)
        {            
            var txtFiles = Directory.EnumerateFiles(txtInput.Text, "*." + txtInputExtension.Text,seachOption);
            for(int i = 0; i < txtFiles.Count(); i++)
            {
                string inputFullFilePath = txtFiles.ElementAt(i);

                string outputDIR;
                if (chkCopyFolderStructure.Checked)
                {
                    string t = inputFullFilePath.Substring(txtInput.Text.Length);
                    t = t.Substring(0, t.LastIndexOf('\\'));
                    outputDIR = outputDirectory + t; //inputFullFilePath.Substring(0, inputFullFilePath.LastIndexOf('\\'));
                }
                else
                {
                    outputDIR = outputDirectory;
                }
                ProcessSingleFile(inputFullFilePath, outputDIR );
            }
            return true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (rbSingleFile.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Audio format|*.*";
                ofd.Title = "Please select file to convert";
                ofd.ShowDialog();
                if (File.Exists(ofd.FileName))
                    txtInput.Text = ofd.FileName;
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (Directory.Exists(fbd.SelectedPath))
                    txtInput.Text = fbd.SelectedPath;
            }
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (Directory.Exists(fbd.SelectedPath))
                txtOutput.Text = fbd.SelectedPath;
        }

    }
}
