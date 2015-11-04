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

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        string inputFileExtension;
        string selectedPath;
        string result = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Please wait! The Menu is being generated based on your selection!";
            textBox1.Text = string.Empty;

            string restaurantCountry = string.Empty;
            string restaurantCategory = string.Empty;
            string outputFormat = string.Empty;
            string inputReader = string.Empty;

            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedPath = FD.FileName;
                inputFileExtension = Path.GetExtension(FD.FileName);
            }

            if (britishRadioBtn.Checked)
            {
                restaurantCountry = "British";
                inputReader = inputFileExtension.Replace('.',' ').Trim(); // "xml";
            }
            else if (americanRadioBtn.Checked)
            {
                restaurantCountry = "American";
                inputReader = inputFileExtension.Replace('.', ' ').Trim(); //"json";
            }

            if(dinerRadioBtn.Checked)
            {
                restaurantCategory = "Diner";
            }
            else if (eveningRadioBtn.Checked)
            {
                restaurantCategory = "Evening";
            }
            else if(allDayRadioBtn.Checked)
            {
                restaurantCategory = "All";
            }

            if(plainTextRadioBtn.Checked)
            {
                outputFormat = "txt";
            }
            else if(htmlRadioBtn.Checked)
            {
                outputFormat = "html";
            }
            else if(xmlRadioBtn.Checked)
            {
                outputFormat = "xml";
            }

            Decider objDecider = new Decider(inputReader, outputFormat);
            string fileExtension = Path.GetExtension(selectedPath);
            result = objDecider.getMenuDetail(restaurantCountry, restaurantCategory, selectedPath, fileExtension);

            if (!string.IsNullOrEmpty(result))
            {
                var savePath = Path.Combine(Application.StartupPath, "Menu." + outputFormat);
                File.WriteAllText(savePath, result);

                label1.Text = string.Format(@"Menu generated and saved. The path is displayed below in the text box. If you want to save the output to another location click the 'Save File' button.");
                textBox1.Text = savePath;
            }
            else
            {
                label1.Text = "No File generated";
            }
        }

        public class Decider
        {
            string InputReader = string.Empty;
            string OutputFormat = string.Empty;

            public Decider(string inputReader, string outputFormat)
            {
                InputReader = inputReader;
                OutputFormat = outputFormat;
            }

            public string getMenuDetail(string factoryType, string restaurantType, string relativePath, string fileExtension)
            {
                if (factoryType == "British")
                {
                    IRestaurantFactory factory = new BritishRestaurant();
                    var readMenu = factory.Reader(InputReader);
                    var menugen = factory.MenuGenerator();
                    var menuFormatter = factory.MenuOutputFormatter(OutputFormat);

                    var inputFile = File.ReadAllText(relativePath);
                    var data = readMenu.readFile2(inputFile, factoryType);
                    var genData = menugen.generateMenu(data, restaurantType);
                    var formattedData = menuFormatter.formatText(genData);

                    return formattedData.ToString();
                    
                }
                else if (factoryType == "American")
                {
                    IRestaurantFactory factory = new AmericanRestaurant();
                    var readMenu = factory.Reader(InputReader);
                    var menugen = factory.MenuGenerator();
                    var menuFormatter = factory.MenuOutputFormatter(OutputFormat);

                    var inputFile = File.ReadAllText(relativePath);
                    var data = readMenu.readFile2(inputFile, factoryType);
                    var genData = menugen.generateMenu(data, restaurantType);
                    var formattedData = menuFormatter.formatText(genData);

                    return formattedData.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name, result);
        } 
    }
}

