namespace ATV_3_1_Bimentre
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
            btnRemove = new Button();
            btnReset = new Button();
            label3 = new Label();
            labelCliques = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(135, 322);
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
            label2.Location = new Point(453, 322);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 1;
            label2.Text = "RA: 2023200550";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(211, 170);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(70, 70);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "-";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CornflowerBlue;
            btnReset.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(367, 170);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 70);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(135, 62);
            label3.Name = "label3";
            label3.Size = new Size(264, 37);
            label3.TabIndex = 5;
            label3.Text = "Número de cliques:";
            // 
            // labelCliques
            // 
            labelCliques.AutoSize = true;
            labelCliques.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCliques.ForeColor = SystemColors.Control;
            labelCliques.Location = new Point(405, 62);
            labelCliques.Name = "labelCliques";
            labelCliques.Size = new Size(33, 37);
            labelCliques.TabIndex = 6;
            labelCliques.Text = "0";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(554, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(labelCliques);
            Controls.Add(label3);
            Controls.Add(btnReset);
            Controls.Add(btnRemove);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Atividade Avaliativa 3 - 1 Bimestre";
            Load += btnReset_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRemove;
        private Button btnReset;
        private Label label3;
        private Label labelCliques;
        private Button btnAdd;
    }
}
