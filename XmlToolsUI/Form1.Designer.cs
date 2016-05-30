namespace XmlToolsUI
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonBrowseSource = new System.Windows.Forms.Button();
            this.buttonBrowseDestination = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonRebuild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNoOverwrite = new System.Windows.Forms.CheckBox();
            this.checkBoxStrictOpenXml = new System.Windows.Forms.CheckBox();
            this.checkBoxSortXml = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentXml = new System.Windows.Forms.CheckBox();
            this.checkBoxTraverseSubdirectories = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.Location = new System.Drawing.Point(78, 21);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(360, 20);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestination.Location = new System.Drawing.Point(78, 47);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(360, 20);
            this.textBoxDestination.TabIndex = 2;
            this.textBoxDestination.TextChanged += new System.EventHandler(this.textBoxDestination_TextChanged);
            // 
            // buttonBrowseSource
            // 
            this.buttonBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseSource.Location = new System.Drawing.Point(445, 17);
            this.buttonBrowseSource.Name = "buttonBrowseSource";
            this.buttonBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSource.TabIndex = 4;
            this.buttonBrowseSource.Text = "Browse";
            this.buttonBrowseSource.UseVisualStyleBackColor = true;
            this.buttonBrowseSource.Click += new System.EventHandler(this.buttonBrowseSource_Click);
            // 
            // buttonBrowseDestination
            // 
            this.buttonBrowseDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDestination.Location = new System.Drawing.Point(444, 44);
            this.buttonBrowseDestination.Name = "buttonBrowseDestination";
            this.buttonBrowseDestination.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDestination.TabIndex = 5;
            this.buttonBrowseDestination.Text = "Browse";
            this.buttonBrowseDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseDestination.Click += new System.EventHandler(this.buttonBrowseDestination_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtract.Enabled = false;
            this.buttonExtract.Location = new System.Drawing.Point(282, 74);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(75, 23);
            this.buttonExtract.TabIndex = 10;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // buttonRebuild
            // 
            this.buttonRebuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRebuild.Enabled = false;
            this.buttonRebuild.Location = new System.Drawing.Point(363, 74);
            this.buttonRebuild.Name = "buttonRebuild";
            this.buttonRebuild.Size = new System.Drawing.Size(75, 23);
            this.buttonRebuild.TabIndex = 11;
            this.buttonRebuild.Text = "Rebuild";
            this.buttonRebuild.UseVisualStyleBackColor = true;
            this.buttonRebuild.Click += new System.EventHandler(this.buttonRebuild_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Destination";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxNoOverwrite);
            this.groupBox1.Controls.Add(this.checkBoxStrictOpenXml);
            this.groupBox1.Controls.Add(this.checkBoxSortXml);
            this.groupBox1.Controls.Add(this.checkBoxIndentXml);
            this.groupBox1.Controls.Add(this.checkBoxTraverseSubdirectories);
            this.groupBox1.Location = new System.Drawing.Point(15, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 154);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBoxNoOverwrite
            // 
            this.checkBoxNoOverwrite.AutoSize = true;
            this.checkBoxNoOverwrite.Location = new System.Drawing.Point(6, 111);
            this.checkBoxNoOverwrite.Name = "checkBoxNoOverwrite";
            this.checkBoxNoOverwrite.Size = new System.Drawing.Size(203, 17);
            this.checkBoxNoOverwrite.TabIndex = 17;
            this.checkBoxNoOverwrite.Text = "Don\'t overwrite original file on Rebuild";
            this.checkBoxNoOverwrite.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrictOpenXml
            // 
            this.checkBoxStrictOpenXml.AutoSize = true;
            this.checkBoxStrictOpenXml.Location = new System.Drawing.Point(6, 88);
            this.checkBoxStrictOpenXml.Name = "checkBoxStrictOpenXml";
            this.checkBoxStrictOpenXml.Size = new System.Drawing.Size(101, 17);
            this.checkBoxStrictOpenXml.TabIndex = 16;
            this.checkBoxStrictOpenXml.Text = "Strict OpenXML";
            this.checkBoxStrictOpenXml.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortXml
            // 
            this.checkBoxSortXml.AutoSize = true;
            this.checkBoxSortXml.Location = new System.Drawing.Point(6, 65);
            this.checkBoxSortXml.Name = "checkBoxSortXml";
            this.checkBoxSortXml.Size = new System.Drawing.Size(159, 17);
            this.checkBoxSortXml.TabIndex = 15;
            this.checkBoxSortXml.Text = "Sort Elements and Attributes";
            this.checkBoxSortXml.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentXml
            // 
            this.checkBoxIndentXml.AutoSize = true;
            this.checkBoxIndentXml.Checked = true;
            this.checkBoxIndentXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIndentXml.Location = new System.Drawing.Point(6, 42);
            this.checkBoxIndentXml.Name = "checkBoxIndentXml";
            this.checkBoxIndentXml.Size = new System.Drawing.Size(81, 17);
            this.checkBoxIndentXml.TabIndex = 14;
            this.checkBoxIndentXml.Text = "Indent XML";
            this.checkBoxIndentXml.UseVisualStyleBackColor = true;
            // 
            // checkBoxTraverseSubdirectories
            // 
            this.checkBoxTraverseSubdirectories.AutoSize = true;
            this.checkBoxTraverseSubdirectories.Checked = true;
            this.checkBoxTraverseSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTraverseSubdirectories.Location = new System.Drawing.Point(6, 19);
            this.checkBoxTraverseSubdirectories.Name = "checkBoxTraverseSubdirectories";
            this.checkBoxTraverseSubdirectories.Size = new System.Drawing.Size(138, 17);
            this.checkBoxTraverseSubdirectories.TabIndex = 13;
            this.checkBoxTraverseSubdirectories.Text = "Traverse Subdirectories";
            this.checkBoxTraverseSubdirectories.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRebuild);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonBrowseDestination);
            this.Controls.Add(this.buttonBrowseSource);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSource);
            this.Name = "Form1";
            this.Text = "XmlTools UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonBrowseSource;
        private System.Windows.Forms.Button buttonBrowseDestination;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button buttonRebuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxNoOverwrite;
        private System.Windows.Forms.CheckBox checkBoxStrictOpenXml;
        private System.Windows.Forms.CheckBox checkBoxSortXml;
        private System.Windows.Forms.CheckBox checkBoxIndentXml;
        private System.Windows.Forms.CheckBox checkBoxTraverseSubdirectories;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

