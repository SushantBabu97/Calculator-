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
    public partial class Calculator : Form
    {
        
        double Num1;
        string Operation;
        public Calculator()
        {
            InitializeComponent();
        }
        //Choices
        //Choices
        private void Standard_Click(object sender, EventArgs e)
        {
            this.Width = 358;
            Display.Width = 336;
            Display2.Width = 336;
            Display.MaxLength = 15;
            Display2.MaxLength = 15;
            StandardLabel.Visible = true;
            Scientificbutton.Visible = true;
           
        }
        private void Scientific_Click(object sender, EventArgs e)
        {
            this.Width = 720;
            Display.Width = 688;
            Display2.Width = 688;
            Display.MaxLength = 30;
            Display2.MaxLength = 30;
            StandardLabel.Visible = false;
            Scientificlabel.Visible = true;
            Scientificbutton.Visible = false;
            

        }
        
        //Display Boxes
        //Display Boxes
        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Display2_TextChanged(object sender, EventArgs e)
        {

        }

    //C Button
        private void CButton_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Display2.Clear();
        }

        //Numeric Buttons 
        //Numeric Buttons 
        private void ZeroButton_Click(object sender, EventArgs e)
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

        private void OneButton_Click(object sender, EventArgs e)
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

        private void TwoButton_Click(object sender, EventArgs e)
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

        private void ThreeButton_Click(object sender, EventArgs e)
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

        private void FourButton_Click(object sender, EventArgs e)
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

        private void FiveButton_Click(object sender, EventArgs e)
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

        private void SixButton_Click(object sender, EventArgs e)
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

        private void SevenButton_Click(object sender, EventArgs e)
        {
            //if (Display2.Text != null)
            //{
              //  Display2.Text = Display2.Text + "7";
            //}
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

        private void EightButton_Click(object sender, EventArgs e)
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

        private void NineButton_Click(object sender, EventArgs e)
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
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text = "0.";
            }
            else
            {
                Display.Text = Display.Text+".";                
            }
        }

        //Arithmetic Buttons
        //Arithmetic Buttons 
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "+" + Display.Text;
                Display.Clear();
                Operation = "+";
            }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "-" + Display.Text;
                Display.Clear();
                Operation = "-";
            }
        }
        private void MulButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "*" + Display.Text;
                Display.Clear();
                Operation = "*";
            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {

                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "/" + Display.Text;
                Display.Clear();
                Operation = "/";
            }
        }
        

        private void InvertButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                int output =Convert.ToInt32( Display.Text) * (-1);
                 
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
        private void DownButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
            Num1 = Convert.ToDouble(Display.Text);
            Display2.Text = "1/" + Display.Text;
            Display.Clear();
            Operation = "1/";
                if (Operation == "1/")
                {
                    if (Num1 == 0)
                    {
                        Display2.Text = "MATH ERROR: Cannot divide by zero";
                    }
                    else
                    {
                        Result = (1 / Num1);
                        Display.Text = Convert.ToString(Result);
                        Num1 = Result;
                        Display2.Clear();
                    }
                }
            }
        }
        private void SqrButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "^2" + Display.Text;
                Display.Clear();
                Result = (Num1 * Num1);
                Display.Text = Convert.ToString(Result);
                Num1 = Result;
                Display2.Clear();
            }
        }
        private void SqrtButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "sqrt" + Display.Text;
                Display.Clear();
                Result = Math.Sqrt(Num1);
                Display.Text = Convert.ToString(Result);
                Num1 = Result;
                Display2.Clear();
            }
        }
        private void ModButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "=Percentage";
                Display.Clear();
                Operation = "%";
            }
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

        //EQUAL BUTTON
        //EQUAL BUTTON
        private void EqualButton_Click(object sender, EventArgs e)
        {
            double Num2;
            double Result;

            if (Display.Text == "") { }
            else
            {

                if (Operation == "+")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    Result = (Num1 + Num2);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                    Display2.Clear();
                }
                if (Operation == "-")
                {
                    if (Display.Text == "") { }
                    else
                    {
                        Num2 = Convert.ToDouble(Display.Text);
                        Result = (Num1 - Num2);
                        if (Convert.ToInt32(Result) < 0)
                        {
                            Result = Result * (-1);
                            Display.Text = Result + "-";
                        }
                        else
                        {
                            Display.Text =Convert.ToString(Result);
                        }
                        Num1 = Result;
                        Display2.Clear();
                    }
                }
                if (Operation == "*")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    Result = (Num1 * Num2);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                    Display2.Clear();
                }
                if (Operation == "/")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    if (Num2 == 0)
                    {
                        Display2.Text = "MATH ERROR: Cannot divide by zero";
                    }
                    else
                    {
                        Result = (Num1 / Num2);
                        Display.Text = Convert.ToString(Result);
                        Num1 = Result;
                        Display2.Clear();
                    }
                }

                if (Operation == "+/-")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    Result = Num1 * (-1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                    Display2.Clear();
                }
                if (Operation == "%")
                {
                    Result = Num1 * 100;
                    Display.Text = Convert.ToString(Result) + "%";
                    Num1 = Result;
                    Display2.Clear();
                }

                if (Operation == "Mod")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    if (Num2 == 0)
                    {
                        Display2.Text = "MATH ERROR: Cannot divide by zero";
                    }
                    else
                    {
                        Result = (Num1 % Num2);
                        Display.Text = Convert.ToString(Result);
                        Num1 = Result;
                        Display2.Clear();
                    }
                }
                if (Operation == "^")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    Result = Math.Pow(Num1, Num2);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                    Display2.Clear();
                }
                if (Operation == "Tenx")
                {
                    Num2 = Convert.ToDouble(Display.Text);
                    Result = Num1 * Math.Pow(10, Num2);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                    Display2.Clear();
                }
                if (Operation == "Root")
                {
                    int Num = Convert.ToInt32(Display.Text);

                    double _Num = (double)Num;
                    double[] x = new double[2];
                    x[0] = Num1;
                    x[1] = Num1 / _Num;
                    while (Math.Abs(x[0] - x[1]) > .001)
                    {
                        x[1] = x[0];
                        x[0] = (1 / _Num) * (((_Num - 1) * x[1]) + (Num1 / Math.Pow(x[1], _Num - 1)));

                    }

                    Display2.Text = Display.Text + Display2.Text;
                    Display.Text = Convert.ToString(string.Format("{0:F3}", x[0]));
                                     
                }
            }

        }
        
        private void Modular_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = Display.Text + "%";
                Display.Clear();
                Operation = "Mod";
            }
        }

        private void Sin_Click(object sender, EventArgs e)
        {
           
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Sin(" + Display.Text;
                    Display.Clear();
                    Result = Math.Sin(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Num1 = (Math.PI * Num1) / 180;
                    Display2.Text = "Sin(" + Display.Text;
                    Display.Clear();
                    Result = Math.Sin(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Cos(" + Display.Text;
                    Display.Clear();
                    Result = Math.Cos(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Num1 = (Math.PI * Num1) / 180;
                    Display2.Text = "Cos(" + Display.Text;
                    Display.Clear();
                    Result = Math.Cos(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Tan(" + Display.Text;
                    Display.Clear();
                    Result = Math.Tan(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Num1 = (Math.PI * Num1) / 180;
                    Display2.Text = "Tan(" + Display.Text;
                    Display.Clear();
                    Result = Math.Tan(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }

        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Sinh(" + Display.Text;
                    Display.Clear();
                    Result = Math.Sinh(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Num1 = (Math.PI * Num1) / 180;
                    Display2.Text = "Sinh(" + Display.Text;
                    Display.Clear();
                    Result = Math.Sinh(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }

        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Cosh(" + Display.Text;
                    Display.Clear();
                    Result = Math.Cosh(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Num1 = (Math.PI * Num1) / 180;
                    Display2.Text = "Cosh(" + Display.Text;
                    Display.Clear();
                    Result = Math.Cosh(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }

        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Tanh(" + Display.Text;
                    Display.Clear();
                    Result = Math.Tanh(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Num1 = (Math.PI * Num1) / 180;
                    Display2.Text = "Tanh(" + Display.Text;
                    Display.Clear();
                    Result = Math.Tanh(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }
        }

        private void ln_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "ln" + Display.Text;
                Display.Clear();
                Result = Math.Log10(Num1);
                Display.Text = Convert.ToString(Result);
                Num1 = Result;
            }
            
        }

        private void Logarithm_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "log" + Display.Text;
                Display.Clear();
                Result = Math.Log(Num1);
                Display.Text = Convert.ToString(Result);
                Num1 = Result;
            }
            
        }

        private void Exponential_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "exp" + Display.Text;
                Display.Clear();
                Result = Math.Exp(Num1);
                Display.Text = Convert.ToString(Result);
                Num1 = Result;
            }
            
        }

        private void Sinin_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Sin-1(" + Display.Text;
                    Display.Clear();
                    Result = Math.Asin(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Sin-1(" + Display.Text;
                    Display.Clear();
                    Result = Math.Asin(Num1);
                    Result=(Result*180)/ Math.PI;
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }
        }
        private void Cosin_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Cos-1(" + Display.Text;
                    Display.Clear();
                    Result = Math.Acos(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }

                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Cos-1(" + Display.Text;
                    Display.Clear();
                    Result = Math.Acos(Num1);
                    Result = (Result * 180) / Math.PI;
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }
        }

        private void Tanin_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                if (Radian.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Tan-1(" + Display.Text;
                    Display.Clear();
                    Result = Math.Atan(Num1);
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
                else if (Degree.Checked == true)
                {
                    double Result;
                    Num1 = Convert.ToDouble(Display.Text);
                    Display2.Text = "Tan-1(" + Display.Text;
                    Display.Clear();
                    Result = Math.Atan(Num1);
                    Result = (Result * 180) / Math.PI;
                    Display.Text = Convert.ToString(Result);
                    Num1 = Result;
                }
            }
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Display2.Text = "Pi";
                Display.Text = Convert.ToString(Math.PI);
            }
            
        }

        private void Power_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "^" + Display.Text;
                Display.Clear();
                Operation = "^";
            }
        }

        private void Tenx_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Display2.Text = Display.Text + "*10x";
                Num1 = Convert.ToDouble(Display.Text);
                Display.Clear();
                Operation = "Tenx";
            }
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "!" + Display.Text;
                Display.Clear();
                double n = 1;
                for (double i = Num1; i >= 1; i--)
                {
                    n = n * i;
                    Result = n;
                    Display.Text = Convert.ToString(Result);
                }

            }
            
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                int Num = Convert.ToInt32(Display.Text);
                Display2.Text = "Binary of-> " + Display.Text;
                Display.Clear();
                Display.Text = System.Convert.ToString(Num, 2);
            }
           
        }

        private void Octal_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                int Num = Convert.ToInt32(Display.Text);
                Display2.Text = "Octal of-> " + Display.Text;
                Display.Clear();
                Display.Text = System.Convert.ToString(Num, 8);
            }
        }

        private void Hexa_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                int Num = Convert.ToInt32(Display.Text);
                Display2.Text = "HexaDecimal of-> " + Display.Text;
                Display.Clear();
                Display.Text = System.Convert.ToString(Num, 16);
            }
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                int Num = Convert.ToInt32(Display.Text);
                Display2.Text = "Decimal of-> " + Display.Text;
                Display.Clear();
                Display.Text = System.Convert.ToString(Num);
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "Root of " + Display.Text;
                Display.Clear();
                Operation = "Root";
            }
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            Display.Clear();
        }

        private void Absolute_Click(object sender, EventArgs e)
        {
            int Value =  Convert.ToInt32(Display2.Text);
            if (Display.Text == ""|| Value==0) { }
            else if(Value  <= 0)
            {
                Value = Value * (-1);
                Display.Text = Convert.ToString(Value);
            }
            else
            {
                Display.Text = Display.Text;
            }
                
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            if (Display.Text == "") { }
            else
            {
                double Result;
                Num1 = Convert.ToDouble(Display.Text);
                Display2.Text = "^3" + Display.Text;
                Display.Clear();
                Result = (Num1 * Num1*Num1);
                Display.Text = Convert.ToString(Result);
                Num1 = Result;
                Display2.Clear();
            }
        }

        private void StandardLabel_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Scientificlabel_Click(object sender, EventArgs e)
        {

        }

        private void Radian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Degree_CheckedChanged(object sender, EventArgs e)
        {

        }



      
        
        private void Menu_Click(object sender, EventArgs e)
        {
            TempertureConverter obj = new TempertureConverter();
            obj.Show();
            Hide();          
                                 
        }
        
    }
}
