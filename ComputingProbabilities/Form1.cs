using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingProbabilities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.CenterToScreen();

            lvComputationResults.View = View.Details;
            lvComputationResults.Columns.Add("Reps");
            lvComputationResults.Columns.Add("The Probability");

            lvComputationResults.FullRowSelect = true;

            lvComputationResults.Show();            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void btnComputeTheProbability_Click(object sender, EventArgs e)
        {
            // See if the probability contains a % sign.
            bool percent = txtTheEventProbability.Text.Contains("%");

            // Get the event probability.
            double event_prob =
                double.Parse(txtTheEventProbability.Text.Replace("%", ""));

            // If we're using percents, divide by 100.
            if (percent) event_prob /= 100.0;

            // Get the probability of the event not happening.
            double non_prob = 1.0 - event_prob;

            lvComputationResults.Items.Clear();
            for (int i = 0; i <= 100; i++)
            {
                double prob = 1.0 - Math.Pow(non_prob, i);
                ListViewItem new_item = lvComputationResults.Items.Add(i.ToString());

                if (percent)
                {
                    prob *= 100.0;
                    new_item.SubItems.Add(prob.ToString("0.0000") + "%");
                }
                else
                {
                    new_item.SubItems.Add(prob.ToString("0.000000"));
                }
            }

            lvComputationResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
