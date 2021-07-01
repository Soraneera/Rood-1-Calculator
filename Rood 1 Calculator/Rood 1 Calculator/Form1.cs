using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rood_1_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //Values and Variables
        double Value1, Value2;
        bool HasDecimal = false;
        bool InputStatus = true;
        string CalculatorFunctions;

        //Function buttons

        //Plus button
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text.Length != 0)
            {
                if (CalculatorFunctions == string.Empty)
                {
                    Value1 = System.Double.Parse(Output_TextBox.Text);
                    Output_TextBox.Text = string.Empty;
                }
                else
                {
                    Results();
                }
                CalculatorFunctions = "Add";
                HasDecimal = false;
            }
        }


        //Minus button
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text.Length != 0)
            {
                if (CalculatorFunctions == string.Empty)
                {
                    Value1 = System.Double.Parse(Output_TextBox.Text);
                    Output_TextBox.Text = string.Empty;
                }
                else
                {
                    Results();
                }
                CalculatorFunctions = "Minus";
                HasDecimal = false;
            }
        }
        
        //Multiply button
        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text.Length != 0)
            {
                if (CalculatorFunctions == string.Empty)
                {
                    Value1 = System.Double.Parse(Output_TextBox.Text);
                    Output_TextBox.Text = string.Empty;
                }
                else
                {
                    Results();
                }
                CalculatorFunctions = "Multiply";
                HasDecimal = false;
            }
        }

        //Percent button
        private void btn_Percentile_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text.Length != 0)
            {
                if (CalculatorFunctions == string.Empty)
                {
                    Value1 = System.Double.Parse(Output_TextBox.Text);
                    Output_TextBox.Text = string.Empty;
                }
                else
                {
                    Results();
                }
                CalculatorFunctions = "Percent";
                HasDecimal = false;
            }
        }

        //Division button
        private void btn_Division_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text.Length != 0)
            {
                if (CalculatorFunctions == string.Empty)
                {
                    Value1 = System.Double.Parse(Output_TextBox.Text);
                    Output_TextBox.Text = string.Empty;
                }
                else
                {
                    Results();
                }
                CalculatorFunctions = "Divide";
                HasDecimal = false;
            }
        }

        //Equals button
        private void btn_Equals_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text.Length != 0 && Value1 != 0)
            {
                Results();
                CalculatorFunctions = string.Empty;
                HasDecimal = false;
            }
        }

        //Backspace button
        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            //Local Variables
            string str;
            int loc;

            if (Output_TextBox.Text.Length > 0)
            {
                str = Output_TextBox.Text.Substring(Output_TextBox.Text.Length - 1);
                if (str == ".")
                {
                    HasDecimal = false;
                }
                loc = Output_TextBox.Text.Length;
                Output_TextBox.Text = Output_TextBox.Text.Remove(loc - 1, 1);
            }
        }

        //Clear Entry button
        private void btn_ClearEntry_Click(object sender, EventArgs e)
        {
            Output_TextBox.Text = string.Empty;
            HasDecimal = false;
        }

        //Clear button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Output_TextBox.Text = string.Empty;
            Value1 = 0;
            Value2 = 0;
            CalculatorFunctions = string.Empty;
            HasDecimal = false;
        }

        //Numerical buttons
        //Zero button
        private void btn_Zero_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                if (Output_TextBox.Text.Length >= 1)
                {
                    Output_TextBox.Text += btn_Zero.Text;
                }
            }

        }

        //One button
        private void btn_One_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_One.Text;
            }
            else
            {
                Output_TextBox.Text = btn_One.Text;
                InputStatus = true;                   
            }
        }

        //Two button
        private void btn_Two_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Two.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Two.Text;
                InputStatus = true;
            }
        }

        //Three button
        private void btn_Three_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Three.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Three.Text;
                InputStatus = true;
            }
        }

        //Four button
        private void btn_Four_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Four.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Four.Text;
                InputStatus = true;
            }
        }

        //Five button
        private void btn_Five_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Five.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Five.Text;
                InputStatus = true;
            }
        }

        //Six button
        private void btn_Six_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Six.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Six.Text;
                InputStatus = true;
            }
        }

        //Seven button
        private void btn_Seven_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Seven.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Seven.Text;
                InputStatus = true;
            }
        }

        //Eight button
        private void btn_Eight_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Eight.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Eight.Text;
                InputStatus = true;
            }
        }

        //Nine button
        private void btn_Nine_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                Output_TextBox.Text += btn_Nine.Text;
            }
            else
            {
                Output_TextBox.Text = btn_Nine.Text;
                InputStatus = true;
            }
        }

        //Decimal button
        private void btn_Dot_Click(object sender, EventArgs e)
        {
            if (InputStatus)
            {
                if (!HasDecimal)
                {
                    if (Output_TextBox.Text.Length != 0)
                    {
                        if (Output_TextBox.Text != "0")
                        {
                            Output_TextBox.Text += btn_Dot.Text;
                            HasDecimal = true;
                        }
                    }
                    else
                    {
                        Output_TextBox.Text = "0";
                    }
                }
            }
        }
        //Calculations/Results
        private void Results()
        {
            Value2 = System.Double.Parse(Output_TextBox.Text);
            switch (CalculatorFunctions)
            {
                case "Add":
                    Value1 = Value1 + Value2;
                    break;
                case "Percent":
                    Value2 = Value1 / 100;
                    break;
                case "Minus":
                    Value1 = Value1 - Value2;
                    break;
                case "Multiply":
                    Value1 = Value1 * Value2;
                    break;
                case "Divide":
                    Value1 = Value1 / Value2;
                    break;

            }
            Output_TextBox.Text = Value1.ToString();
            InputStatus = false;
        }
    }
}
