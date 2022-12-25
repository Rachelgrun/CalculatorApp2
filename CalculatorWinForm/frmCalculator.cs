using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorApp;

namespace CalculatorWinForm
{
    public partial class frmCalculator : Form
    {
        Calculator activecalc;
        Calculator calc1 = new Calculator();
        Calculator calc2 = new Calculator();
        Calculator calc3 = new Calculator();
        public frmCalculator()
        {
            InitializeComponent();
            btn0.Click += BtnEquation_Click;
            btn1.Click += BtnEquation_Click;
            btn2.Click += BtnEquation_Click;
            btn3.Click += BtnEquation_Click;
            btn4.Click += BtnEquation_Click;
            btn5.Click += BtnEquation_Click;
            btn6.Click += BtnEquation_Click;
            btn7.Click += BtnEquation_Click;
            btn8.Click += BtnEquation_Click;
            btn9.Click += BtnEquation_Click;
            btnDivide.Click += BtnEquation_Click;
            btnMultiply.Click += BtnEquation_Click;
            btnSubtraction.Click += BtnEquation_Click;
            btnAddition.Click += BtnEquation_Click;
            btnClear.Click += BtnClear_Click;
            btnEquals.Click += BtnEquals_Click;

            SwitchCalculator(1);
            optCalc1.Click += OptCalc1_Click;
            optCalc2.Click += OptCalc2_Click;
            optCalc3.Click += OptCalc3_Click;
         //test
       
        }

        private void DisplayEquation(Label l,Calculator c)
        {
           if (c.Result == null)
            {
                l.Text = c.EquationDescription;
            }
           else
            {
                l.Text = c.EquationDescription + "=" + c.Result.ToString();
              
            }
            
        }
     
        private void DisplayCalculatorValues()
        {
            lblFirstFactor.Text = activecalc.Factor1.ToString();
            lblSecondFactor .Text = activecalc.Factor2.ToString();
            lblOperationSymbol.Text = activecalc.OperatorDisplay.ToString();
            lblProduct.Text = activecalc.Result.ToString();

            DisplayEquation(lblEquation1, calc1);
            DisplayEquation(lblEquation2, calc2);
            DisplayEquation(lblEquation3, calc3);

        }

        private void InputFactor(string value)
        {
            //activecalc.Factor1 = 
            activecalc.AddInput(value);
            DisplayCalculatorValues();
            
        }



        private void Calculate()
        {
            activecalc.Calculate();
            DisplayCalculatorValues();
        }

        private void ClearCalculator()
        {
            activecalc.Clear();
            DisplayCalculatorValues();
        }

        private void SwitchCalculator(int value)
        {
            switch (value)
            {
                case 1:
                    activecalc = calc1;
                    break;
                case 2:
                    activecalc = calc2;
                    break;
                case 3:
                    activecalc = calc3;
                    break;
            }
            DisplayCalculatorValues();
        }

        private void BtnEquation_Click(object? sender, EventArgs e)
        {
           InputFactor(((Button)sender).Text);
        }



        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            Calculate();
          
           

        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ClearCalculator();

            
        }


        private void OptCalc3_Click(object? sender, EventArgs e)
        {
            SwitchCalculator(3);
            
        }

        private void OptCalc2_Click(object? sender, EventArgs e)
        {
            SwitchCalculator(2);
            
        }

        private void OptCalc1_Click(object? sender, EventArgs e)
        {
            SwitchCalculator(1);
          
        }


    }
}
