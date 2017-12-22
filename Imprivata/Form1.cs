using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprivata
{
    public partial class Form1 : Form, IOutputLogger
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearLog();

            MergeArraysTask mergeArraysTask = new MergeArraysTask(this);
            mergeArraysTask.RunMergeArraysTask_Random();
            mergeArraysTask.RunMergeArraysTask_RandomSortedTwo();
            mergeArraysTask.RunMergeArraysTask_AlreadySorted();
            mergeArraysTask.RunMergeArraysTask_WorstCase();
        }

        public void WriteMessage(string message)
        {
            this.outputWindow.AppendText(message + "\n");
        }

        public void ClearLog()
        {
            this.outputWindow.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PangramTest pangramTest = new PangramTest(this);
            bool result = pangramTest.IsPangram(pangramTestInput.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PangramTest pangramTest = new PangramTest(this);

            if(lstTestStrings.SelectedItem == null)
            {
                lstTestStrings.SelectedIndex = 0;
            }

            bool result = pangramTest.IsPangram(lstTestStrings.SelectedItem.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TopmostStepTest stepTest = new TopmostStepTest(this);

            int topmostStep = stepTest.FindTopmostStep(2, 2);
            topmostStep = stepTest.FindTopmostStep(2, 1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CityClinicsTest cityClinicsTest = new CityClinicsTest(this);
            int[] cityPopulations = { 200000, 500000 };
            cityClinicsTest.DaterminMaxVaccinationsInLargestClinic(2, 7, cityPopulations);
        }
    }
}
