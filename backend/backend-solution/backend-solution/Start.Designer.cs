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
            this.tabLevel1 = new System.Windows.Forms.TabControl();
            this.tabPageLevel1 = new System.Windows.Forms.TabPage();
            this.tabPageLevel1Test = new System.Windows.Forms.TabPage();
            this.btnSelectTestDataFile = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSelectExpectedOutput = new System.Windows.Forms.Button();
            this.txbTestDataFilePath = new System.Windows.Forms.TextBox();
            this.txbExpectedOutputPath = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabLevel1.SuspendLayout();
            this.tabPageLevel1.SuspendLayout();
            this.tabPageLevel1Test.SuspendLayout();
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
            // tabLevel1
            // 
            this.tabLevel1.Controls.Add(this.tabPageLevel1);
            this.tabLevel1.Controls.Add(this.tabPageLevel1Test);
            this.tabLevel1.Location = new System.Drawing.Point(0, 13);
            this.tabLevel1.Name = "tabLevel1";
            this.tabLevel1.SelectedIndex = 0;
            this.tabLevel1.Size = new System.Drawing.Size(571, 135);
            this.tabLevel1.TabIndex = 4;
            // 
            // tabPageLevel1
            // 
            this.tabPageLevel1.Controls.Add(this.txbInputFilePath);
            this.tabPageLevel1.Controls.Add(this.btnGenerateOutput);
            this.tabPageLevel1.Controls.Add(this.btnSelectInputFile);
            this.tabPageLevel1.Location = new System.Drawing.Point(4, 22);
            this.tabPageLevel1.Name = "tabPageLevel1";
            this.tabPageLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLevel1.Size = new System.Drawing.Size(563, 109);
            this.tabPageLevel1.TabIndex = 0;
            this.tabPageLevel1.Text = "Level1";
            this.tabPageLevel1.UseVisualStyleBackColor = true;
            // 
            // tabPageLevel1Test
            // 
            this.tabPageLevel1Test.Controls.Add(this.lblResult);
            this.tabPageLevel1Test.Controls.Add(this.txbExpectedOutputPath);
            this.tabPageLevel1Test.Controls.Add(this.txbTestDataFilePath);
            this.tabPageLevel1Test.Controls.Add(this.btnSelectExpectedOutput);
            this.tabPageLevel1Test.Controls.Add(this.btnTest);
            this.tabPageLevel1Test.Controls.Add(this.btnSelectTestDataFile);
            this.tabPageLevel1Test.Location = new System.Drawing.Point(4, 22);
            this.tabPageLevel1Test.Name = "tabPageLevel1Test";
            this.tabPageLevel1Test.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLevel1Test.Size = new System.Drawing.Size(563, 109);
            this.tabPageLevel1Test.TabIndex = 1;
            this.tabPageLevel1Test.Text = "Level1-Tests";
            this.tabPageLevel1Test.UseVisualStyleBackColor = true;
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
            // txbTestDataFilePath
            // 
            this.txbTestDataFilePath.Enabled = false;
            this.txbTestDataFilePath.Location = new System.Drawing.Point(6, 18);
            this.txbTestDataFilePath.Name = "txbTestDataFilePath";
            this.txbTestDataFilePath.Size = new System.Drawing.Size(347, 20);
            this.txbTestDataFilePath.TabIndex = 3;
            // 
            // txbExpectedOutputPath
            // 
            this.txbExpectedOutputPath.Enabled = false;
            this.txbExpectedOutputPath.Location = new System.Drawing.Point(8, 44);
            this.txbExpectedOutputPath.Name = "txbExpectedOutputPath";
            this.txbExpectedOutputPath.Size = new System.Drawing.Size(345, 20);
            this.txbExpectedOutputPath.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(190, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 147);
            this.Controls.Add(this.tabLevel1);
            this.Name = "Start";
            this.Text = "Backend Solution";
            this.tabLevel1.ResumeLayout(false);
            this.tabPageLevel1.ResumeLayout(false);
            this.tabPageLevel1.PerformLayout();
            this.tabPageLevel1Test.ResumeLayout(false);
            this.tabPageLevel1Test.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbInputFilePath;
        private System.Windows.Forms.Button btnSelectInputFile;
        private System.Windows.Forms.Button btnGenerateOutput;
        private System.Windows.Forms.TabControl tabLevel1;
        private System.Windows.Forms.TabPage tabPageLevel1;
        private System.Windows.Forms.TabPage tabPageLevel1Test;
        private System.Windows.Forms.TextBox txbExpectedOutputPath;
        private System.Windows.Forms.TextBox txbTestDataFilePath;
        private System.Windows.Forms.Button btnSelectExpectedOutput;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSelectTestDataFile;
        private System.Windows.Forms.Label lblResult;
    }
}