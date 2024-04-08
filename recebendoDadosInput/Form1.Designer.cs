namespace recebendoDadosInput
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
            input1 = new TextBox();
            btn1 = new Button();
            input2 = new TextBox();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(265, 101);
            input1.Name = "input1";
            input1.Size = new Size(100, 23);
            input1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(415, 125);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "Clique aqui";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // input2
            // 
            input2.Location = new Point(265, 165);
            input2.Name = "input2";
            input2.Size = new Size(100, 23);
            input2.TabIndex = 3;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(546, 133);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 4;
            lbl1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Controls.Add(input2);
            Controls.Add(btn1);
            Controls.Add(input1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1;
        private Button btn1;
        private TextBox input2;
        private Label lbl1;
    }
}