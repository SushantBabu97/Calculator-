using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class TempertureConverter : Form

    {
        double Temp1;
        //C Button
        private void CButton_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Display2.Clear();
        }

        //Numeric Buttons 
        //Numeric Buttons 
             

        

       
        public TempertureConverter()
        {
            InitializeComponent();
        }

        private void Kelvin_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void TempertureConverter_Load(object sender, EventArgs e)
        {
            this.Width = 358;
        }

        

        private void CEButton_Click(object sender, EventArgs e)
        {
            Display.Clear();
        }

        private void CButton_Click_1(object sender, EventArgs e)
        {
            Display.Clear();
            Display2.Clear();
        }

        private void BackspButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if ((String.Compare(Display.Text, " ") < 0))
                {
                    Display.Text = Display.Text.Substring(0, Display.Text.Length);

                }
                if ((String.Compare(Display.Text, " ") <= 0) || (String.Compare(Display2.Text, " ") > 0))
                {
                    Display2.Text = Display2.Text.Substring(0, Display2.Text.Length - 1);
                }
                else
                {
                    Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);

                }
            }

        }

        private void SevenButton_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
                Display.Text = Display.Text + "7";
            }
            else
            {
                Display.Text = Display.Text + "7";
            }

        }

        private void EightButton_Click_1(object sender, EventArgs e)
        {

            if (Display.Text == "0")
            {
                Display.Clear();
                Display.Text = Display.Text + "8";
            }
            else
            {
                Display.Text = Display.Text + "8";
            }

        }

        private void NineButton_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
                Display.Text = Display.Text + "9";
            }
            else
            {
                Display.Text = Display.Text + "9";
            }
        }

        private void SixButton_Click_1(object sender, EventArgs e)
        {
            
                if (Display.Text == "0")
                {
                    Display.Clear();
                    Display.Text = Display.Text + "6";
                }
                else
                {
                    Display.Text = Display.Text + "6";
                }
            

               
        }

        private void FiveButton_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
                Display.Text = Display.Text + "5";
            }
            else
            {
                Display.Text = Display.Text + "5";
            }
        }

        private void FourButton_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
                Display.Text = Display.Text + "4";
            }
            else
            {
                Display.Text = Display.Text + "4";
            }
        }

        private void ThreeButton_Click_1(object sender, EventArgs e)
        {
           
                if (Display.Text == "0")
                {
                    Display.Clear();
                    Display.Text = Display.Text + "3";
                }
                else
                {
                    Display.Text = Display.Text + "3";
                }
            
                          
            
        }

        private void TwoButton_Click_1(object sender, EventArgs e)
        {
                if (Display.Text == "0")
                {
                    Display.Clear();
                    Display.Text = Display.Text + "2";
                }
                else
                {
                    Display.Text = Display.Text + "2";
                }
            

        }

        private void OneButton_Click_1(object sender, EventArgs e)
        {
                if (Display.Text == "0")
                {
                    Display.Clear();
                    Display.Text = Display.Text + "1";
                }
                else
                {
                    Display.Text = Display.Text + "1";
                }
               
        }

        private void ZeroButton_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
                Display.Text = Display.Text + "0";
            }
            else
            {
                Display.Text = Display.Text + "0";
            }
        }

        private void DotButton_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text = "0.";
            }
            else
            {
                Display.Text = Display.Text + ".";
            }
        }

        private void InvertButton_Click(object sender, EventArgs e)
        {

            if (Display.Text == "") { }
            else
            {
                int output = Convert.ToInt32(Display.Text) * (-1);

                string Final = "", reverse = "";
                int Length = 0;
                Final = Convert.ToString(output);
                Length = Final.Length - 1;
                while (Length >= 0)
                {
                    reverse = reverse + Final[Length];
                    Length--;
                    Display.Text = reverse;
                }


            }
        }

        private void K_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Kelvin.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Kelvin " + Display.Text;
                    Display.Clear();
                    Result = Temp1;
                    Display.Text = Convert.ToString(Result)+"K";
                    
                }
                else if (Farenheit.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Kelvin " + Display.Text;
                    Display.Clear();
                    Result = (((Temp1 -32)*5)/9 )+ 273;
                    Display.Text = Convert.ToString(Result) + "K";
                    
                }
                else if (Celsius.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Kelvin " + Display.Text;
                    Display.Clear();
                    Result = Temp1 + 273;
                    Display.Text = Convert.ToString(Result)+"K";

                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Kelvin.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Celsius " + Display.Text;
                    Display.Clear();
                    Result = Temp1 -273;
                    Display.Text = Convert.ToString(Result) + "C";

                }
                else if (Farenheit.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Celsius " + Display.Text;
                    Display.Clear();
                    Result = (((Temp1 - 32) * 5) / 9);
                    Display.Text = Convert.ToString(Result) + "C";

                }
                else if (Celsius.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Celsius " + Display.Text;
                    Display.Clear();
                    Result = Temp1;
                    Display.Text = Convert.ToString(Result) + "C";
                }
            }
        }
        private void F_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Kelvin.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Farenheit " + Display.Text;
                    Display.Clear();
                    Result = ((Temp1-273)*9)/ 5 + 32;
                    Display.Text = Convert.ToString(Result) + "F";

                }
                else if (Farenheit.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Farenheit " + Display.Text;
                    Display.Clear();
                    Result = Temp1;
                    Display.Text = Convert.ToString(Result) + "F";

                }
                else if (Celsius.Checked == true)
                {
                    double Result;
                    Temp1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "In Farenheit " + Display.Text;
                    Display.Clear();
                    Result = (Temp1*9)/5+32;
                    Display.Text = Convert.ToString(Result)+"F";
                }
            }
        }

        private void Menuback_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.Show();
            this.Close();
            

        }
    }
}
