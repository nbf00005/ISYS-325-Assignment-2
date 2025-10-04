using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainForm : Form
    {
        enum Colors { RED, BLUE, GREEN, BLACK, WHITE };

        private Colors color = Colors.RED;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblSummary.Text = "";
            lblSummary.ForeColor = Color.Black;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            lblSummary.ForeColor = Color.Black;

            if (lstModel.SelectedItem == null)
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please select a make and model.";
                return;
            }

            if (!int.TryParse(txtYear.Text.Trim(), out int year))
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please enter a valid year.";
                return;
            }

            string makeModel = lstModel.SelectedItem.ToString();

            string colorString = GetColorString1();

            List<string> features = new List<string>();

            if (chkWindows.Checked)
            {
                features.Add("Power Windows");
            }
            if (chkAC.Checked)
            {
                features.Add("AC");
            }
            if (chkSyrius.Checked)
            {
                features.Add("Syrius radio");
            }
            if (chkLane.Checked)
            {
                features.Add("Lane Assistance");
            }

            string featureList = features.Count > 0 ? string.Join(", ", features) : "none";

            lblSummary.Text = $"You have purchased a {colorString} {year} {makeModel} with the following features: {featureList}.";
        }

        private string GetColorString1()
        {
            switch (color)
            {
                case Colors.RED:
                    return "red";
                case Colors.BLUE:
                    return "blue";
                case Colors.GREEN:
                    return "green";
                case Colors.BLACK:
                    return "black";
                case Colors.WHITE:
                    return "white";
                default:
                    return "No color";
            }
        }


        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                color = Colors.RED;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                color = Colors.BLUE;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                color = Colors.GREEN;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                color = Colors.BLACK;
            }
        }

        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (radWhite.Checked)
            {
                color = Colors.WHITE;
            }
        }
    }
}
