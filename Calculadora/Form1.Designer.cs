namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            textBox_Display1 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button8 = new Button();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            button0 = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonSubtract = new Button();
            buttonAdd = new Button();
            buttonPower = new Button();
            buttonSqrt = new Button();
            buttonSquare = new Button();
            button18 = new Button();
            buttonEquals = new Button();
            buttonClearEntry = new Button();
            buttonClear = new Button();
            buttonMS = new Button();
            buttonMR = new Button();
            buttonMC = new Button();
            buttonRoot = new Button();
            buttonSin = new Button();
            buttonCos = new Button();
            buttonTan = new Button();
            textBox_Display2 = new TextBox();
            button10 = new Button();
            btnInfoLog = new Button();
            listBox_logOperacao = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 404);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Eros Netto Antunes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(560, 404);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 1;
            label2.Text = "RA: 2023200550";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button7.Location = new Point(381, 143);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Numerico_Click;
            // 
            // textBox_Display1
            // 
            textBox_Display1.Location = new Point(381, 58);
            textBox_Display1.Name = "textBox_Display1";
            textBox_Display1.Size = new Size(386, 23);
            textBox_Display1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button4.Location = new Point(381, 199);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Numerico_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(381, 255);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Numerico_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.Location = new Point(437, 255);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Numerico_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button5.Location = new Point(437, 199);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 14;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Numerico_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button8.Location = new Point(437, 143);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 15;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Numerico_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button9.Location = new Point(493, 143);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 16;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Numerico_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button6.Location = new Point(493, 199);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 17;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Numerico_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button3.Location = new Point(493, 255);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 18;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Numerico_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button0.Location = new Point(381, 311);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 19;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Numerico_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonDivide.Location = new Point(605, 143);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(50, 50);
            buttonDivide.TabIndex = 20;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += Operacao_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonMultiply.Location = new Point(549, 143);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(50, 50);
            buttonMultiply.TabIndex = 21;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += Operacao_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSubtract.Location = new Point(549, 199);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(50, 50);
            buttonSubtract.TabIndex = 22;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += Operacao_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonAdd.Location = new Point(549, 255);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 23;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += Operacao_Click;
            // 
            // buttonPower
            // 
            buttonPower.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonPower.Location = new Point(605, 199);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(50, 50);
            buttonPower.TabIndex = 24;
            buttonPower.Text = "^";
            buttonPower.UseVisualStyleBackColor = true;
            buttonPower.Click += Operacao_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSqrt.Location = new Point(493, 312);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(50, 50);
            buttonSqrt.TabIndex = 25;
            buttonSqrt.Text = "√";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += Operacao_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSquare.Location = new Point(605, 255);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(50, 50);
            buttonSquare.TabIndex = 26;
            buttonSquare.Text = "x²";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += Operacao_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button18.Location = new Point(437, 311);
            button18.Name = "button18";
            button18.Size = new Size(50, 50);
            button18.TabIndex = 27;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += btnPonto;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEquals.Location = new Point(549, 312);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(106, 50);
            buttonEquals.TabIndex = 28;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += btnIgual;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonClearEntry.Location = new Point(381, 87);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(50, 50);
            buttonClearEntry.TabIndex = 29;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = true;
            buttonClearEntry.Click += btnLimparEntrada;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonClear.Location = new Point(437, 87);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 50);
            buttonClear.TabIndex = 30;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += btnResetar;
            // 
            // buttonMS
            // 
            buttonMS.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMS.Location = new Point(549, 88);
            buttonMS.Name = "buttonMS";
            buttonMS.Size = new Size(50, 50);
            buttonMS.TabIndex = 31;
            buttonMS.Text = "MS";
            buttonMS.UseVisualStyleBackColor = true;
            buttonMS.Click += btnArmazenaMemoria_Click;
            // 
            // buttonMR
            // 
            buttonMR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMR.Location = new Point(605, 88);
            buttonMR.Name = "buttonMR";
            buttonMR.Size = new Size(50, 50);
            buttonMR.TabIndex = 32;
            buttonMR.Text = "MR";
            buttonMR.UseVisualStyleBackColor = true;
            buttonMR.Click += btnRecuperaMemoria_Click;
            // 
            // buttonMC
            // 
            buttonMC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMC.Location = new Point(493, 87);
            buttonMC.Name = "buttonMC";
            buttonMC.Size = new Size(50, 50);
            buttonMC.TabIndex = 33;
            buttonMC.Text = "MC";
            buttonMC.UseVisualStyleBackColor = true;
            buttonMC.Click += btnLimpaMemoria_Click;
            // 
            // buttonRoot
            // 
            buttonRoot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonRoot.Location = new Point(661, 144);
            buttonRoot.Name = "buttonRoot";
            buttonRoot.Size = new Size(106, 50);
            buttonRoot.TabIndex = 34;
            buttonRoot.Text = "y√x";
            buttonRoot.UseVisualStyleBackColor = true;
            buttonRoot.Click += Operacao_Click;
            // 
            // buttonSin
            // 
            buttonSin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonSin.Location = new Point(661, 87);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(106, 50);
            buttonSin.TabIndex = 35;
            buttonSin.Text = "sin";
            buttonSin.UseVisualStyleBackColor = true;
            buttonSin.Click += Operacao_Click;
            // 
            // buttonCos
            // 
            buttonCos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonCos.Location = new Point(661, 199);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(106, 50);
            buttonCos.TabIndex = 36;
            buttonCos.Text = "cos";
            buttonCos.UseVisualStyleBackColor = true;
            buttonCos.Click += Operacao_Click;
            // 
            // buttonTan
            // 
            buttonTan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonTan.Location = new Point(661, 255);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(106, 50);
            buttonTan.TabIndex = 37;
            buttonTan.Text = "tan";
            buttonTan.UseVisualStyleBackColor = true;
            buttonTan.Click += Operacao_Click;
            // 
            // textBox_Display2
            // 
            textBox_Display2.BackColor = Color.DarkGray;
            textBox_Display2.Location = new Point(381, 29);
            textBox_Display2.Name = "textBox_Display2";
            textBox_Display2.Size = new Size(386, 23);
            textBox_Display2.TabIndex = 38;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button10.Location = new Point(661, 312);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 39;
            button10.Text = "+/-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // btnInfoLog
            // 
            btnInfoLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnInfoLog.Location = new Point(717, 312);
            btnInfoLog.Name = "btnInfoLog";
            btnInfoLog.Size = new Size(50, 50);
            btnInfoLog.TabIndex = 40;
            btnInfoLog.Text = "inf";
            btnInfoLog.UseVisualStyleBackColor = true;
            btnInfoLog.Click += btnInfoLog_Click;
            // 
            // listBox_logOperacao
            // 
            listBox_logOperacao.FormattingEnabled = true;
            listBox_logOperacao.ItemHeight = 15;
            listBox_logOperacao.Location = new Point(24, 88);
            listBox_logOperacao.Name = "listBox_logOperacao";
            listBox_logOperacao.Size = new Size(200, 274);
            listBox_logOperacao.TabIndex = 41;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_logOperacao);
            Controls.Add(btnInfoLog);
            Controls.Add(button10);
            Controls.Add(textBox_Display2);
            Controls.Add(buttonTan);
            Controls.Add(buttonCos);
            Controls.Add(buttonSin);
            Controls.Add(buttonRoot);
            Controls.Add(buttonMC);
            Controls.Add(buttonMR);
            Controls.Add(buttonMS);
            Controls.Add(buttonClear);
            Controls.Add(buttonClearEntry);
            Controls.Add(buttonEquals);
            Controls.Add(button18);
            Controls.Add(buttonSquare);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonPower);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonDivide);
            Controls.Add(button0);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(textBox_Display1);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Atividade Avaliativa 6 - 2 Bimestre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button7;
        private TextBox textBox_Display1;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button8;
        private Button button9;
        private Button button6;
        private Button button3;
        private Button button0;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonSubtract;
        private Button buttonAdd;
        private Button buttonPower;
        private Button buttonSqrt;
        private Button buttonSquare;
        private Button button18;
        private Button buttonEquals;
        private Button buttonClearEntry;
        private Button buttonClear;
        private Button buttonMS;
        private Button buttonMR;
        private Button buttonMC;
        private Button buttonRoot;
        private Button buttonSin;
        private Button buttonCos;
        private Button buttonTan;
        private TextBox textBox_Display2;
        private Button button10;
        private Button btnInfoLog;
        private ListBox listBox_logOperacao;
    }
}
