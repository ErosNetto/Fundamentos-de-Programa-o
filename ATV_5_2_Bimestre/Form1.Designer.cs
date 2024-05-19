namespace ATV_5_2_Bimestre
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
            btnContador = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBoxRes = new RichTextBox();
            formInput = new TextBox();
            SuspendLayout();
            // 
            // btnContador
            // 
            btnContador.BackColor = Color.DarkGreen;
            btnContador.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnContador.ForeColor = SystemColors.ControlText;
            btnContador.Location = new Point(350, 110);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(129, 60);
            btnContador.TabIndex = 1;
            btnContador.Text = "Contar";
            btnContador.UseVisualStyleBackColor = false;
            btnContador.Click += btnContador_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(244, 19);
            label2.Name = "label2";
            label2.Size = new Size(334, 37);
            label2.TabIndex = 3;
            label2.Text = "Quantidades para contar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 356);
            label3.Name = "label3";
            label3.Size = new Size(265, 37);
            label3.TabIndex = 4;
            label3.Text = "Eros Netto Antunes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(543, 356);
            label4.Name = "label4";
            label4.Size = new Size(228, 37);
            label4.TabIndex = 5;
            label4.Text = "RA: 2023200550";
            // 
            // TextBoxRes
            // 
            TextBoxRes.HideSelection = false;
            TextBoxRes.Location = new Point(314, 188);
            TextBoxRes.Name = "TextBoxRes";
            TextBoxRes.Size = new Size(202, 215);
            TextBoxRes.TabIndex = 6;
            TextBoxRes.Text = "";
            // 
            // formInput
            // 
            formInput.Location = new Point(314, 71);
            formInput.Name = "formInput";
            formInput.Size = new Size(202, 23);
            formInput.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(formInput);
            Controls.Add(TextBoxRes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnContador);
            Name = "Form1";
            Text = "Atividade Avaliativa 5 - 2 Bimestre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnContador;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox TextBoxRes;
        private TextBox formInput;
    }
}
