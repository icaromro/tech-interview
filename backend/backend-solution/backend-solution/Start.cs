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

namespace backend_solution
{
    public partial class Start : Form
    {
        #region Start
        public Start()
        {
            InitializeComponent();
        }
        #endregion

        #region level1

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
            Input input = Input.ReadJsonFile(txbInputFilePath.Text);

            Output output = new Output(input);
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

        #region Level1 Testing

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

            Input inputTest = Input.ReadJsonFile(txbTestDataFilePath.Text);
            Output expectedOutput = Output.ReadJsonFile(txbExpectedOutputPath.Text);
            Output actualOutput = new Output(inputTest);
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
    }
}
