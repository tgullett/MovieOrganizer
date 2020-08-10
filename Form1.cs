using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace MovieOrganizer
{
    public partial class Form1 : Form
    {
        //private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void sourcePathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdSource = new FolderBrowserDialog();
            fbdSource.Description = "Select the source path to move movies from.";
            if (sourcePath.Text != "") { fbdSource.SelectedPath = sourcePath.Text; }
            if (fbdSource.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourcePath.Text = fbdSource.SelectedPath;
                sourceBox.Items.Clear();
                try
                {

                    string[] extensions = { ".avi", ".mp4", ".mkv" };
                    foreach (string fileName in Directory.EnumerateFiles(fbdSource.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
                    {
                        sourceBox.Items.Add(fileName);
                    }

                    /*
                    var txtFiles = Directory.EnumerateFiles(fbdSource.SelectedPath, "*.avi", SearchOption.AllDirectories);
                    foreach (string currentFile in txtFiles)
                    {
                        string fileName = currentFile.Substring(fbdSource.SelectedPath.Length + 1);
                        sourceBox.Items.Add(fileName);
                        //Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                    }
                    */
                }
                catch (Exception errorE)
                {
                    MessageBox.Show("Error Message: " + errorE.Message, "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void destinationPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdDestination = new FolderBrowserDialog();
            fbdDestination.Description = "Select the destination folder to movie and organize movies.";
            if (destinationPath.Text != "") { fbdDestination.SelectedPath = destinationPath.Text; }
            if (fbdDestination.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destinationPath.Text = fbdDestination.SelectedPath;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string oAPIKey = omdbApiKey.Text;
            var oAPIKeyTest = ProcessRepositories(oAPIKey);

        }

        public static async Task ProcessRepositories(string oAPIKey)
        {
            HttpClient client = new HttpClient();
            
            client.DefaultRequestHeaders.Accept.Clear();
            /* client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")); */
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            var response = await client.GetAsync("http://www.omdbapi.com/?apikey=" + oAPIKey + "&type=movie&s=The%20Day%20After%20Tomorrow");
            if (response.IsSuccessStatusCode)
            {
                var getResponsestring = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Message: " + getResponsestring, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //JObject o = JObject.Parse(getResponsestring);

            }
            else
            {
                MessageBox.Show("Wrong API Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void omdbapiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.omdbapi.com/");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int totalFiles = sourceBox.Items.Count;
            

            if (totalFiles > 0)
            {
                progressBar1.Maximum = totalFiles;
                
                //MessageBox.Show(progressIncrement.ToString());
                sourceBox.BeginUpdate();
                try
                {
                    int fileCount = 0;
                    destinationBox.Items.Clear();
                    foreach (var sourceFile in sourceBox.Items )
                    {
                        fileCount++;
                        progressBar1.Value = fileCount;
                        progressBar1.Refresh();
                        //MessageBox.Show(sourceFile.ToString());
                        destinationBox.Items.Add(fileCount.ToString() + " - " + sourceFile.ToString());

                    }
                }
                finally
                {
                    sourceBox.EndUpdate();
                }
                

            }
            



        }
    }
}
