namespace backend_solution
{
    partial class Start
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
            this.txbInputFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectInputFile = new System.Windows.Forms.Button();
            this.btnGenerateOutput = new System.Windows.Forms.Button();
            this.tabLevelResolution = new System.Windows.Forms.TabControl();
            this.tabPageResolution = new System.Windows.Forms.TabPage();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbExpectedOutputPath = new System.Windows.Forms.TextBox();
            this.txbTestDataFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectExpectedOutput = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSelectTestDataFile = new System.Windows.Forms.Button();
            this.cbbLevelSelection = new System.Windows.Forms.ComboBox();
            this.lblSelectLevel = new System.Windows.Forms.Label();
            this.tabLevelResolution.SuspendLayout();
            this.tabPageResolution.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbInputFilePath
            // 
            this.txbInputFilePath.Enabled = false;
            this.txbInputFilePath.Location = new System.Drawing.Point(8, 16);
            this.txbInputFilePath.Name = "txbInputFilePath";
            this.txbInputFilePath.Size = new System.Drawing.Size(343, 20);
            this.txbInputFilePath.TabIndex = 1;
            // 
            // btnSelectInputFile
            // 
            this.btnSelectInputFile.Location = new System.Drawing.Point(357, 14);
            this.btnSelectInputFile.Name = "btnSelectInputFile";
            this.btnSelectInputFile.Size = new System.Drawing.Size(101, 23);
            this.btnSelectInputFile.TabIndex = 2;
            this.btnSelectInputFile.Text = "Select Data File";
            this.btnSelectInputFile.UseVisualStyleBackColor = true;
            this.btnSelectInputFile.Click += new System.EventHandler(this.btnSelectInputFile_Click);
            // 
            // btnGenerateOutput
            // 
            this.btnGenerateOutput.Location = new System.Drawing.Point(142, 52);
            this.btnGenerateOutput.Name = "btnGenerateOutput";
            this.btnGenerateOutput.Size = new System.Drawing.Size(98, 23);
            this.btnGenerateOutput.TabIndex = 3;
            this.btnGenerateOutput.Text = "Generate Output";
            this.btnGenerateOutput.UseVisualStyleBackColor = true;
            this.btnGenerateOutput.Click += new System.EventHandler(this.btnGenerateOutput_Click);
            // 
            // tabLevelResolution
            // 
            this.tabLevelResolution.Controls.Add(this.tabPageResolution);
            this.tabLevelResolution.Controls.Add(this.tabPageTest);
            this.tabLevelResolution.Location = new System.Drawing.Point(0, 31);
            this.tabLevelResolution.Name = "tabLevelResolution";
            this.tabLevelResolution.SelectedIndex = 0;
            this.tabLevelResolution.Size = new System.Drawing.Size(571, 135);
            this.tabLevelResolution.TabIndex = 4;
            // 
            // tabPageResolution
            // 
            this.tabPageResolution.Controls.Add(this.txbInputFilePath);
            this.tabPageResolution.Controls.Add(this.btnGenerateOutput);
            this.tabPageResolution.Controls.Add(this.btnSelectInputFile);
            this.tabPageResolution.Location = new System.Drawing.Point(4, 22);
            this.tabPageResolution.Name = "tabPageResolution";
            this.tabPageResolution.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResolution.Size = new System.Drawing.Size(563, 109);
            this.tabPageResolution.TabIndex = 0;
            this.tabPageResolution.Text = "Level1-Resolution";
            this.tabPageResolution.UseVisualStyleBackColor = true;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.lblResult);
            this.tabPageTest.Controls.Add(this.txbExpectedOutputPath);
            this.tabPageTest.Controls.Add(this.txbTestDataFilePath);
            this.tabPageTest.Controls.Add(this.btnSelectExpectedOutput);
            this.tabPageTest.Controls.Add(this.btnTest);
            this.tabPageTest.Controls.Add(this.btnSelectTestDataFile);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(563, 109);
            this.tabPageTest.TabIndex = 1;
            this.tabPageTest.Text = "Level1-Tests";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(190, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // txbExpectedOutputPath
            // 
            this.txbExpectedOutputPath.Enabled = false;
            this.txbExpectedOutputPath.Location = new System.Drawing.Point(6, 44);
            this.txbExpectedOutputPath.Name = "txbExpectedOutputPath";
            this.txbExpectedOutputPath.Size = new System.Drawing.Size(347, 20);
            this.txbExpectedOutputPath.TabIndex = 4;
            // 
            // txbTestDataFilePath
            // 
            this.txbTestDataFilePath.Enabled = false;
            this.txbTestDataFilePath.Location = new System.Drawing.Point(6, 18);
            this.txbTestDataFilePath.Name = "txbTestDataFilePath";
            this.txbTestDataFilePath.Size = new System.Drawing.Size(347, 20);
            this.txbTestDataFilePath.TabIndex = 3;
            // 
            // btnSelectExpectedOutput
            // 
            this.btnSelectExpectedOutput.Location = new System.Drawing.Point(359, 45);
            this.btnSelectExpectedOutput.Name = "btnSelectExpectedOutput";
            this.btnSelectExpectedOutput.Size = new System.Drawing.Size(132, 23);
            this.btnSelectExpectedOutput.TabIndex = 2;
            this.btnSelectExpectedOutput.Text = "Select Expected Output";
            this.btnSelectExpectedOutput.UseVisualStyleBackColor = true;
            this.btnSelectExpectedOutput.Click += new System.EventHandler(this.btnSelectExpectedOutput_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(98, 76);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSelectTestDataFile
            // 
            this.btnSelectTestDataFile.Location = new System.Drawing.Point(359, 16);
            this.btnSelectTestDataFile.Name = "btnSelectTestDataFile";
            this.btnSelectTestDataFile.Size = new System.Drawing.Size(132, 23);
            this.btnSelectTestDataFile.TabIndex = 0;
            this.btnSelectTestDataFile.Text = "Select Test Data File";
            this.btnSelectTestDataFile.UseVisualStyleBackColor = true;
            this.btnSelectTestDataFile.Click += new System.EventHandler(this.btnSelectTestDataFile_Click);
            // 
            // cbbLevelSelection
            // 
            this.cbbLevelSelection.FormattingEnabled = true;
            this.cbbLevelSelection.Location = new System.Drawing.Point(103, 4);
            this.cbbLevelSelection.Name = "cbbLevelSelection";
            this.cbbLevelSelection.Size = new System.Drawing.Size(121, 21);
            this.cbbLevelSelection.TabIndex = 5;
            this.cbbLevelSelection.SelectedIndexChanged += new System.EventHandler(this.cbbLevelSelection_SelectedIndexChanged);
            // 
            // lblSelectLevel
            // 
            this.lblSelectLevel.AutoSize = true;
            this.lblSelectLevel.Location = new System.Drawing.Point(12, 9);
            this.lblSelectLevel.Name = "lblSelectLevel";
            this.lblSelectLevel.Size = new System.Drawing.Size(86, 13);
            this.lblSelectLevel.TabIndex = 6;
            this.lblSelectLevel.Text = "Select the level: ";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 168);
            this.Controls.Add(this.lblSelectLevel);
            this.Controls.Add(this.cbbLevelSelection);
            this.Controls.Add(this.tabLevelResolution);
            this.Name = "Start";
            this.Text = "Backend Solution";
            this.tabLevelResolution.ResumeLayout(false);
            this.tabPageResolution.ResumeLayout(false);
            this.tabPageResolution.PerformLayout();
            this.tabPageTest.ResumeLayout(false);
            this.tabPageTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbInputFilePath;
        private System.Windows.Forms.Button btnSelectInputFile;
        private System.Windows.Forms.Button btnGenerateOutput;
        private System.Windows.Forms.TabControl tabLevelResolution;
        private System.Windows.Forms.TabPage tabPageResolution;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.TextBox txbExpectedOutputPath;
        private System.Windows.Forms.TextBox txbTestDataFilePath;
        private System.Windows.Forms.Button btnSelectExpectedOutput;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSelectTestDataFile;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cbbLevelSelection;
        private System.Windows.Forms.Label lblSelectLevel;
    }    
}