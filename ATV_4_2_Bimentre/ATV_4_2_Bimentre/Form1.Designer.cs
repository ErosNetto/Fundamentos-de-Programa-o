namespace ATV_4_2_Bimentre
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
            button1 = new Button();
            labelCliques = new Label();
            labelMensagem = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(97, 325);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Eros Netto Antunes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(483, 325);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 1;
            label2.Text = "RA: 2023200550";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button1.Location = new Point(483, 232);
            button1.Name = "button1";
            button1.Size = new Size(100, 60);
            button1.TabIndex = 2;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelCliques
            // 
            labelCliques.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            labelCliques.ForeColor = Color.White;
            labelCliques.Location = new Point(401, 149);
            labelCliques.Name = "labelCliques";
            labelCliques.Size = new Size(50, 38);
            labelCliques.TabIndex = 3;
            labelCliques.Text = "0";
            labelCliques.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMensagem
            // 
            labelMensagem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            labelMensagem.ForeColor = SystemColors.Control;
            labelMensagem.Location = new Point(140, 63);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(571, 37);
            labelMensagem.TabIndex = 4;
            labelMensagem.Text = "Clique no botão para começar a contagem!";
            labelMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(262, 232);
            button2.Name = "button2";
            button2.Size = new Size(100, 60);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(labelMensagem);
            Controls.Add(labelCliques);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Atividade Avaliativa - 2 Bimestre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label labelCliques;
        private Label labelMensagem;
        private Button button2;
    }
}
