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
using backend_solution.Model;
using Newtonsoft.Json;
using backend_solution.Model.level1;
using backend_solution.Model.level2;

namespace backend_solution
{
    public partial class Start : Form
    {
        #region Start
        public Start()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        public void InitializeComboBox()
        {
            cbbLevelSelection.Items.Insert(0, "Level1");
            cbbLevelSelection.Items.Insert(1, "Level2");
            cbbLevelSelection.SelectedIndex = 0;
        }
        #endregion
        
        #region Level Resolution

        private void btnSelectInputFile_Click(object sender, EventArgs e)
        {            
                txbInputFilePath.Text = SelectFile();                            
        }        

        private void btnGenerateOutput_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputFilePath.Text))
            {
                MessageBox.Show("Please, select a data file.");
                return;
            }            

            Output output = ObtainOutput(txbInputFilePath.Text);       
            
            string outputText = JsonConvert.SerializeObject(output);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "json";
            saveFile.Filter = "JSON files (*.json)|*.json";
            saveFile.FileName = "output";
            saveFile.InitialDirectory = txbInputFilePath.Text;
            saveFile.Title = "Select the place where the result will be saved";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFile.FileName))
                {
                    outputFile.Write(outputText);
                    MessageBox.Show("Output file created.");
                }
            }

        }

        #endregion

        #region Testing

        private void btnSelectTestDataFile_Click(object sender, EventArgs e)
        {
            txbTestDataFilePath.Text = SelectFile();
        }

        private void btnSelectExpectedOutput_Click(object sender, EventArgs e)
        {
            txbExpectedOutputPath.Text = SelectFile();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTestDataFilePath.Text) || string.IsNullOrEmpty(txbExpectedOutputPath.Text))
            {
                MessageBox.Show("Please, select both files before pressing the test button.");
                return;
            }
                     
            Output actualOutput = ObtainOutput(txbTestDataFilePath.Text);             
            Output expectedOutput = Output.ReadJsonFile(txbExpectedOutputPath.Text);
            
            if (actualOutput.Compare(expectedOutput))
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "It works!";
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Something went wrong!";
            }                        
        }

        #endregion       

        private string SelectFile()
        {
            string path = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json";
            dialog.Title = "Select a JSON file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
            }

            return path;
        }

        private void cbbLevelSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbLevelSelection.SelectedIndex)
            {
                case 0:
                    tabPageResolution.Text = "Level1-Resolution";
                    tabPageTest.Text = "Level1-Test";
                    break;
                case 1:
                    tabPageResolution.Text = "Level2-Resolution";
                    tabPageTest.Text = "Level2-Test";
                    break;
            }
        }

        private Output ObtainOutput(string filePath)
        {
            int levelSelected = cbbLevelSelection.SelectedIndex;
            Output output = new Output();

            switch (levelSelected)
            {
                case 0:
                    Level1Input level1Input = Level1Input.ReadJsonFile(filePath);
                    output = new Output(level1Input);
                    break;
                case 1:
                    Level2Input level2Input = Level2Input.ReadJsonFile(filePath);
                    output = new Output(level2Input);
                    break;                                    
            }
            return output;
        }
    }
}
