using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;

namespace A1Calculator
{
   public partial class Main : Form
   {
      #region Fields

      private const int MAX_COLUMNS = 256;
      private const string INVALID_OUTPUT_MESSAGE = "NA";
      private const int NUM_COLUMNS = 5;

      private Color GOOD_INPUT_COLOR = Color.FromArgb(198, 239, 206);
      private Color BAD_INPUT_COLOR = Color.FromArgb(255, 199, 206);

      private Regex regA1Format = new Regex(@"^[a-zA-Z][a-zA-Z]?$");

      private string _output = string.Empty;

      #endregion

      public Main()
      {
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         txtListing.Text = GenerateListing();
      }

      private void OnMenuHelpAbout(object sender, EventArgs e)
      {
         var aboutBox = new AboutBox();
         aboutBox.ShowDialog();
      }

      private void OnExit(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void OnConvert(object sender, EventArgs e)
      {
         if (_output != string.Empty)
            txtOutput.Text = _output;
         else
            txtOutput.Text = INVALID_OUTPUT_MESSAGE;
      }

      private void OnInputTextChanged(object sender, EventArgs e)
      {
         string input = txtInput.Text.Trim();
         int index;
         string a1;

         if (input.Length == 0)
         {
            _output = string.Empty;
            txtOutput.Text = string.Empty;
            btnConvert.Enabled = false;
            txtInput.BackColor = Color.White;
         }
         else if (A1ToIndex(input, out index))
         {
            _output = index.ToString();
            txtOutput.Text = string.Empty;
            btnConvert.Enabled = true;
            txtInput.BackColor = GOOD_INPUT_COLOR;
         }
         else if (IndexToA1(input, out a1))
         {
            _output = a1;
            txtOutput.Text = string.Empty;
            btnConvert.Enabled = true;
            txtInput.BackColor = GOOD_INPUT_COLOR;
         }
         else
         {
            _output = string.Empty;
            txtOutput.Text = INVALID_OUTPUT_MESSAGE;
            btnConvert.Enabled = false;
            txtInput.BackColor = BAD_INPUT_COLOR;
         }
      }

      private bool A1ToIndex(string input, out int output)
      {
         output = int.MaxValue;

         if (!regA1Format.IsMatch(input))
            return false;

         if (input.Length == 1)
         {
            char c = input.ToUpper()[0];
            output = c - 'A';
            return true;
         }
         else
         {
            char c1 = input.ToUpper()[0];
            char c2 = input.ToUpper()[1];
            int x = c1 - 'A' + 1;
            int y = c2 - 'A';
            int index = x * 26 + y;
            if (index < MAX_COLUMNS)
            {
               output = index;
               return true;
            }
           return false;
         }
      }

      private bool IndexToA1(string input, out string output)
      {
         output = string.Empty;

         int index;
         if (!int.TryParse(input, out index) || index >= MAX_COLUMNS)
            return false;

         int x = index / 26;
         int y = index % 26;
         if (x == 0)
            output = Convert.ToString((char)('A' + y));
         else
         {
            char c1 = (char)('A' + x - 1);
            char c2 = (char)('A' + y);
            output = string.Format("{0}{1}", c1, c2);
         }
         return true;
      }

      private string GenerateListing()
      {
         var builder = new StringBuilder();
         int currIndex;
         int numRows = (int)Math.Ceiling((double)MAX_COLUMNS / NUM_COLUMNS);
         for (int i = 0; i < (numRows - 1) * NUM_COLUMNS; i += NUM_COLUMNS)
         {
            for (int j = 0; j < NUM_COLUMNS; ++j)
            {
               currIndex = i + j;
               PrintEntry(builder, currIndex);
            }
            builder.AppendLine();
         }
         // Make sure we print the right number of columns in the last row.
         // It's simpler to simply check every row to make sure the index 
         // doesn't exceed MAX_COLUMNS, but not as efficient.
         for (int j = 0; j < NUM_COLUMNS; ++j)
         {
            currIndex = j + (numRows - 1) * NUM_COLUMNS;
            if (currIndex < MAX_COLUMNS)
               PrintEntry(builder, currIndex);
         }

         return builder.ToString();
      }

      private void PrintEntry(StringBuilder builder, int index)
      {
         string output;
         builder.AppendFormat("{0,3} ", index);
         IndexToA1(index.ToString(), out output);
         builder.AppendFormat("{0,2}", output);
         builder.Append("\t");
      }

   }  // class
}  // ns
