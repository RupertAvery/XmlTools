﻿using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using XmlTools;
using XmlToolsUI.Properties;

namespace XmlToolsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonBrowseSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSource.Text = openFileDialog1.FileName;
                textBoxDestination.Text = Path.Combine(Path.GetDirectoryName(openFileDialog1.FileName), Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
            }
        }

        private void buttonBrowseDestination_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "All Files|*.*";
            //openFileDialog1.ShowDialog();
            //textBoxSource.Text = openFileDialog1.FileName;
        }
        private void buttonExtract_Click(object sender, EventArgs e)
        {
            DoExtract();
        }

        private void buttonRebuild_Click(object sender, EventArgs e)
        {
            DoRebuild();
        }

        private void DoRebuild()
        {
            var target = textBoxSource.Text;
            var extension = Path.GetExtension(target);
            if (checkBoxNoOverwrite.Checked)
            {
                var count = 0;
                target = textBoxDestination.Text + extension;
                var fileExists = File.Exists(target);
                while (fileExists)
                {
                    count++;
                    target = $"{textBoxDestination.Text} ({count}){extension}";
                    fileExists = File.Exists(target);
                }
            }
            try
            {
                using (var newzip = new ZipFile())
                {
                    newzip.AddDirectory(textBoxDestination.Text, "");
                    newzip.Save(target);
                }
                MessageBox.Show($"Saved to '{target}'", Resources.Form1_DoExtract_XmlTools_UI, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"The file '{target}' already exists", Resources.Form1_DoExtract_XmlTools_UI, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void DoExtract()
        {

            var processor = new Processor
            {
                OnStartProcessFile = (filename) => { Console.WriteLine(filename); }
            };

            if (checkBoxSortXml.Checked)
            {
                processor.AddFilter(new Sortify());
            }

            if (checkBoxIndentXml.Checked)
            {
                processor.Indented = true;
            }

            if (checkBoxStrictOpenXml.Checked)
            {
                processor.AddFilter(new Strictify());
            }

            if (checkBoxTraverseSubdirectories.Checked)
            {
                processor.SubFolders = true;
            }

            try
            {
                using (var zip = ZipFile.Read(textBoxSource.Text))
                {
                    zip.ExtractAll(textBoxDestination.Text, ExtractExistingFileAction.OverwriteSilently);
                }

                processor.ProcessFolder(textBoxDestination.Text, "*.xml");
                MessageBox.Show($"Extracted to '{textBoxDestination.Text}'", Resources.Form1_DoExtract_XmlTools_UI, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message, Resources.Form1_DoExtract_XmlTools_UI, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            ToggleButtons();
        }

        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {
            ToggleButtons();
        }

        private void ToggleButtons()
        {
            var enabled = textBoxSource.Text.Length > 1 && textBoxDestination.Text.Length > 1;
            buttonExtract.Enabled = enabled;
            buttonRebuild.Enabled = enabled;
        }
    }
}
