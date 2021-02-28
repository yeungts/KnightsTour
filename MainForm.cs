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

namespace Assignment1
{
    public partial class MainForm : Form
    {

        private int[] trialPlay;
        private bool end;
        private double SD, avgPlay;
        private int method, targetTrial, startX, startY, trial, count, sumPlay;
        private string trialOutput;
        private string chestBoardOutput;

        private StreamWriter file;
        private Coordinate[,] coordinates;
        private Random r = new Random();
        private ControlMethods control = new ControlMethods();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnHeuristic.Enabled = true;
            btnNonIntel.Enabled = true;
            txtTrial.Enabled = true;
            txtXcoor.Enabled = true;
            txtYCoor.Enabled = true;
            txtTrial.Clear();
            txtXcoor.Clear();
            txtYCoor.Clear();
            rtbTrialOutput.Clear();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            rtbTrialOutput.ReadOnly = true;
            btnNextTrial.Enabled = false;
        }

        private void btnHeuristic_Click(object sender, EventArgs e)
        {
            trial = 0;
            method = 1;
            getInput();
        }
        private void btnNonIntel_Click(object sender, EventArgs e)
        {
            trial = 0;
            method = 2;
            getInput();
        }

        private void btnNextTrial_Click(object sender, EventArgs e)
        {
            if (trial < targetTrial)
            {
                count = 0;

                coordinates = InitiatingCoordinates(startX, startY);

                do {
                    Coordinate currCoordinate;

                    // Getting the current location of the knight
                    currCoordinate = GetCurrCoordinate(coordinates);

                    // Setting when did the knight landed at this location
                    currCoordinate.LandedTime = (count + 1);
                    if (method == 1)
                    { end = control.HeuristicsPlay(currCoordinate, coordinates, r); }

                    if (method == 2)
                    { end = control.NonIntelligentPlay(currCoordinate, coordinates, r); }

                    count++;
                } while (!end);

                lblPlayOutputTitle.Text = String.Format("Knight's movement for trial {0}:", 
                    (trial + 1));

                trialOutput += String.Format("Trial {0}: The knight was able to " +
                        "successfully land on {1} squares.\n", (trial + 1), count);

                chestBoardOutput = PrintPlay(coordinates);

                trialPlay[trial] = count;
                trial++;
            }
            
            if (trial == targetTrial)
            {

                // Getting the average plays
                sumPlay = 0;

                for (int i = 0; i < trialPlay.Length; i++)
                { sumPlay += trialPlay[i]; }

                avgPlay = Convert.ToDouble(sumPlay) / Convert.ToDouble(trialPlay.Length);


                // Getting the standard deviation 
                SD = 0;

                for (int i = 0; i < trialPlay.Length; i++)
                { SD += Math.Pow((Convert.ToDouble(trialPlay[i]) - avgPlay), 2); }

                SD /= trialPlay.Length;
                SD = Math.Sqrt(SD);

                trialOutput += String.Format("\nThe average landing times is: {0}\n" +
                    "Standard deviation is: {1}\n",
                    Math.Floor(avgPlay), SD);

                btnNextTrial.Enabled = false;

                if (method == 1)
                {
                    if (!File.Exists("TszKinYeung_HeuristicsMethod.txt"))
                    { file = File.CreateText("TszKinYeung_HeuristicsMethod.txt"); }
                    else
                    { file = File.AppendText("TszKinYeung_HeuristicsMethod.txt"); }
                }
                if (method == 2)
                {
                    if (!File.Exists("TszKinYeung_NonIntelligentMethod.txt"))
                    {  file = File.CreateText("TszKinYeung_NonIntelligentMethod.txt"); }
                    else
                    { file = File.AppendText("TszKinYeung_NonIntelligentMethod.txt"); }
                }

                file.WriteLine(trialOutput);
                file.WriteLine("------------------------------------------------------------------\n");
                file.Close();
            }


            lblPlayOutput.Text = chestBoardOutput;
            rtbTrialOutput.Text = trialOutput;
            rtbTrialOutput.SelectionStart = rtbTrialOutput.Text.Length;
            rtbTrialOutput.ScrollToCaret();
        }

        // This method will initiate all coordinates' accessibility, then set the knight's location
        private Coordinate[,] InitiatingCoordinates(int X, int Y)
        {
            Coordinate[,] coordinates = new Coordinate[8, 8];

            int accessibility;
            for (int x = 0; x < coordinates.GetLength(0); x++)
            {
                for (int y = 0; y < coordinates.GetLength(1); y++)
                {
                    if ((x == 0 || x == 7) && (y == 0 || y == 7))
                    { accessibility = 2; }
                    else if (((x == 1 || x == 6) && (y == 0 || y == 7))
                        || ((x == 0 || x == 7) && (y == 1 || y == 6)))
                    { accessibility = 3; }
                    else if (((x > 1 && x < 6) && (y == 0 || y == 7))
                        || ((x == 0 || x == 7) && (y > 1 && y < 6))
                        || ((x == 1 || x == 6) && (y == 1 || y == 6)))
                    { accessibility = 4; }
                    else if (((x > 1 && x < 6) && (y == 1 || y == 6))
                        || ((x == 1 || x == 6) && (y > 1 && y < 6)))
                    { accessibility = 6; }
                    else { accessibility = 8; }
                    coordinates[x, y] = new Coordinate(x, y, accessibility);
                }
            }
            coordinates[X, Y].Land();
            return coordinates;
        }

        // This method will return the current coordinate of the knight
        private Coordinate GetCurrCoordinate(Coordinate[,] coordinates)
        {
            Coordinate currCoordinate = null;
            for (int y = 0; y < coordinates.GetLength(0); y++)
            {
                for (int x = 0; x < coordinates.GetLength(1); x++)
                { if (coordinates[x, y].isCurrCoor) { currCoordinate = coordinates[x, y]; } }
            }

            return currCoordinate;
        }

        // This method will print out the chestboard and when did the knight land at each square
        private string PrintPlay(Coordinate[,] coordinates)
        {
            String output = "";
            for (int y = 0; y < coordinates.GetLength(0); y++)
            {
                for (int x = 0; x < coordinates.GetLength(1); x++)
                {
                    if (coordinates[x, y].LandedTime == 0)
                    {
                        output += String.Format("{0, 2} ", " X");
                    }
                    else
                    {
                        output += String.Format("{0, 2} ", coordinates[x, y].LandedTime);
                    }

                    if (x == (coordinates.GetLength(1) - 1))
                    {
                        output += "\n";
                    }
                }
            }
            return output;
        }

        private void getInput()
        {
            try
            {
                targetTrial = Convert.ToInt32(txtTrial.Text);
                if (targetTrial < 1)
                { throw new ArgumentOutOfRangeException("Trial(s)", "Trials should be bigger than 0"); }

                trialPlay = new int[targetTrial];
                startX = Convert.ToInt32(txtXcoor.Text);
                if (startX < 0 || startX > 7)
                { throw new ArgumentOutOfRangeException("X", "X should be within 0 to 7"); }

                startY = Convert.ToInt32(txtYCoor.Text);
                if (startY < 0 || startY > 7)
                { throw new ArgumentOutOfRangeException("Y", "Y should be within 0 to 7"); }

                MessageBox.Show("Input values accepted! Start your trials " +
                    "with the 'Next Trial' button at the bottom.", "Success");

                btnHeuristic.Enabled = false;
                btnNonIntel.Enabled = false;
                txtTrial.Enabled = false;
                txtXcoor.Enabled = false;
                txtYCoor.Enabled = false;
                btnNextTrial.Enabled = true;
                trialOutput = "Trials ran on: " + DateTime.Now.ToString("G") + "\nX: " 
                    + startX + "\tY: " + startY + "\n";

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid value", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter positive number", "Invalid value", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
