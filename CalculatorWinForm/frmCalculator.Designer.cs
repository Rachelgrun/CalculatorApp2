namespace CalculatorWinForm
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tblCalculatorMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstFactor = new System.Windows.Forms.Label();
            this.lblOperationSymbol = new System.Windows.Forms.Label();
            this.lblSecondFactor = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnPlusSlashMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.optCalc1 = new System.Windows.Forms.RadioButton();
            this.optCalc2 = new System.Windows.Forms.RadioButton();
            this.optCalc3 = new System.Windows.Forms.RadioButton();
            this.lblEquation1 = new System.Windows.Forms.Label();
            this.lblEquation2 = new System.Windows.Forms.Label();
            this.lblEquation3 = new System.Windows.Forms.Label();
            this.tblCalculatorMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCalculatorMain
            // 
            this.tblCalculatorMain.AutoSize = true;
            this.tblCalculatorMain.BackColor = System.Drawing.Color.Fuchsia;
            this.tblCalculatorMain.ColumnCount = 6;
            this.tblCalculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tblCalculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tblCalculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tblCalculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tblCalculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCalculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tblCalculatorMain.Controls.Add(this.lblFirstFactor, 0, 1);
            this.tblCalculatorMain.Controls.Add(this.lblOperationSymbol, 1, 1);
            this.tblCalculatorMain.Controls.Add(this.lblSecondFactor, 2, 1);
            this.tblCalculatorMain.Controls.Add(this.lblProduct, 3, 1);
            this.tblCalculatorMain.Controls.Add(this.btn1, 0, 3);
            this.tblCalculatorMain.Controls.Add(this.btn2, 1, 3);
            this.tblCalculatorMain.Controls.Add(this.btn3, 2, 3);
            this.tblCalculatorMain.Controls.Add(this.btn4, 0, 4);
            this.tblCalculatorMain.Controls.Add(this.btn5, 1, 4);
            this.tblCalculatorMain.Controls.Add(this.btn6, 2, 4);
            this.tblCalculatorMain.Controls.Add(this.btnMultiply, 3, 3);
            this.tblCalculatorMain.Controls.Add(this.btnSubtraction, 3, 4);
            this.tblCalculatorMain.Controls.Add(this.btn7, 0, 5);
            this.tblCalculatorMain.Controls.Add(this.btn8, 1, 5);
            this.tblCalculatorMain.Controls.Add(this.btn9, 2, 5);
            this.tblCalculatorMain.Controls.Add(this.btnAddition, 3, 5);
            this.tblCalculatorMain.Controls.Add(this.btnPlusSlashMinus, 0, 6);
            this.tblCalculatorMain.Controls.Add(this.btn0, 1, 6);
            this.tblCalculatorMain.Controls.Add(this.btnDecimal, 2, 6);
            this.tblCalculatorMain.Controls.Add(this.btnEquals, 3, 6);
            this.tblCalculatorMain.Controls.Add(this.btnDivide, 3, 2);
            this.tblCalculatorMain.Controls.Add(this.btnClear, 2, 2);
            this.tblCalculatorMain.Controls.Add(this.lblMessageBox, 0, 0);
            this.tblCalculatorMain.Controls.Add(this.optCalc1, 4, 2);
            this.tblCalculatorMain.Controls.Add(this.optCalc2, 4, 3);
            this.tblCalculatorMain.Controls.Add(this.optCalc3, 4, 4);
            this.tblCalculatorMain.Controls.Add(this.lblEquation1, 5, 2);
            this.tblCalculatorMain.Controls.Add(this.lblEquation2, 5, 3);
            this.tblCalculatorMain.Controls.Add(this.lblEquation3, 5, 4);
            this.tblCalculatorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCalculatorMain.Location = new System.Drawing.Point(0, 0);
            this.tblCalculatorMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblCalculatorMain.Name = "tblCalculatorMain";
            this.tblCalculatorMain.RowCount = 7;
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68421F));
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68421F));
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68421F));
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68421F));
            this.tblCalculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68421F));
            this.tblCalculatorMain.Size = new System.Drawing.Size(1766, 1160);
            this.tblCalculatorMain.TabIndex = 3;
            // 
            // lblFirstFactor
            // 
            this.lblFirstFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFirstFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstFactor.Location = new System.Drawing.Point(4, 183);
            this.lblFirstFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstFactor.Name = "lblFirstFactor";
            this.lblFirstFactor.Size = new System.Drawing.Size(238, 183);
            this.lblFirstFactor.TabIndex = 0;
            this.lblFirstFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperationSymbol
            // 
            this.lblOperationSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOperationSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperationSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperationSymbol.Location = new System.Drawing.Point(250, 183);
            this.lblOperationSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperationSymbol.Name = "lblOperationSymbol";
            this.lblOperationSymbol.Size = new System.Drawing.Size(238, 183);
            this.lblOperationSymbol.TabIndex = 1;
            this.lblOperationSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondFactor
            // 
            this.lblSecondFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSecondFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecondFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondFactor.Location = new System.Drawing.Point(496, 183);
            this.lblSecondFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondFactor.Name = "lblSecondFactor";
            this.lblSecondFactor.Size = new System.Drawing.Size(238, 183);
            this.lblSecondFactor.TabIndex = 2;
            this.lblSecondFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.Location = new System.Drawing.Point(742, 183);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(238, 183);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Fuchsia;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(4, 528);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(238, 150);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Fuchsia;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(250, 528);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(238, 150);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Fuchsia;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(496, 528);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(238, 150);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(4, 686);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(238, 150);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(250, 686);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(238, 150);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(496, 686);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(238, 150);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Fuchsia;
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(742, 528);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(238, 150);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubtraction.Location = new System.Drawing.Point(742, 686);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(238, 150);
            this.btnSubtraction.TabIndex = 15;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(4, 844);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(238, 150);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(250, 844);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(238, 150);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(496, 844);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(238, 150);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddition.Location = new System.Drawing.Point(742, 844);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(238, 150);
            this.btnAddition.TabIndex = 19;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            // 
            // btnPlusSlashMinus
            // 
            this.btnPlusSlashMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlusSlashMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlusSlashMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlusSlashMinus.Location = new System.Drawing.Point(4, 1002);
            this.btnPlusSlashMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlusSlashMinus.Name = "btnPlusSlashMinus";
            this.btnPlusSlashMinus.Size = new System.Drawing.Size(238, 154);
            this.btnPlusSlashMinus.TabIndex = 20;
            this.btnPlusSlashMinus.Text = "+/-";
            this.btnPlusSlashMinus.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(250, 1002);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(238, 154);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(496, 1002);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(238, 154);
            this.btnDecimal.TabIndex = 4;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(742, 1002);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(238, 154);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(742, 370);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(238, 150);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Fuchsia;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(496, 370);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(238, 150);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.tblCalculatorMain.SetColumnSpan(this.lblMessageBox, 4);
            this.lblMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessageBox.Location = new System.Drawing.Point(4, 0);
            this.lblMessageBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(976, 183);
            this.lblMessageBox.TabIndex = 22;
            this.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optCalc1
            // 
            this.optCalc1.AutoSize = true;
            this.optCalc1.Checked = true;
            this.optCalc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optCalc1.Location = new System.Drawing.Point(988, 370);
            this.optCalc1.Margin = new System.Windows.Forms.Padding(4);
            this.optCalc1.Name = "optCalc1";
            this.optCalc1.Size = new System.Drawing.Size(240, 150);
            this.optCalc1.TabIndex = 23;
            this.optCalc1.TabStop = true;
            this.optCalc1.Text = "Equation 1:";
            this.optCalc1.UseVisualStyleBackColor = true;
            // 
            // optCalc2
            // 
            this.optCalc2.AutoSize = true;
            this.optCalc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optCalc2.Location = new System.Drawing.Point(988, 528);
            this.optCalc2.Margin = new System.Windows.Forms.Padding(4);
            this.optCalc2.Name = "optCalc2";
            this.optCalc2.Size = new System.Drawing.Size(240, 150);
            this.optCalc2.TabIndex = 24;
            this.optCalc2.Text = "Equation 2:";
            this.optCalc2.UseVisualStyleBackColor = true;
            // 
            // optCalc3
            // 
            this.optCalc3.AutoSize = true;
            this.optCalc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optCalc3.Location = new System.Drawing.Point(988, 686);
            this.optCalc3.Margin = new System.Windows.Forms.Padding(4);
            this.optCalc3.Name = "optCalc3";
            this.optCalc3.Size = new System.Drawing.Size(240, 150);
            this.optCalc3.TabIndex = 25;
            this.optCalc3.Text = "Equation 3:";
            this.optCalc3.UseVisualStyleBackColor = true;
            // 
            // lblEquation1
            // 
            this.lblEquation1.AutoSize = true;
            this.lblEquation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquation1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquation1.Location = new System.Drawing.Point(1236, 366);
            this.lblEquation1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquation1.Name = "lblEquation1";
            this.lblEquation1.Size = new System.Drawing.Size(526, 158);
            this.lblEquation1.TabIndex = 26;
            this.lblEquation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquation2
            // 
            this.lblEquation2.AutoSize = true;
            this.lblEquation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquation2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquation2.Location = new System.Drawing.Point(1236, 524);
            this.lblEquation2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquation2.Name = "lblEquation2";
            this.lblEquation2.Size = new System.Drawing.Size(526, 158);
            this.lblEquation2.TabIndex = 27;
            this.lblEquation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquation3
            // 
            this.lblEquation3.AutoSize = true;
            this.lblEquation3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquation3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquation3.Location = new System.Drawing.Point(1236, 682);
            this.lblEquation3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquation3.Name = "lblEquation3";
            this.lblEquation3.Size = new System.Drawing.Size(526, 158);
            this.lblEquation3.TabIndex = 28;
            this.lblEquation3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 1160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblCalculatorMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.tblCalculatorMain.ResumeLayout(false);
            this.tblCalculatorMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TableLayoutPanel tblCalculatorMain;
        private Label lblFirstFactor;
        private Label lblOperationSymbol;
        private Label lblSecondFactor;
        private Label lblProduct;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btnSubtraction;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAddition;
        private Button btnPlusSlashMinus;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;
        private Button btnDivide;
        private Button btnClear;
        private Label lblMessageBox;
        private RadioButton optCalc1;
        private RadioButton optCalc2;
        private RadioButton optCalc3;
        private Label lblEquation1;
        private Label lblEquation2;
        private Label lblEquation3;
    }
}