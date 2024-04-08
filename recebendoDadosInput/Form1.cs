namespace recebendoDadosInput
{
    public partial class Form1 : Form
    {
        double nota1, nota2, media = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            nota1 = double.Parse(input1.Text);
            nota2 = double.Parse(input2.Text);
            media = (nota1 + nota2) / 2;

            lbl1.Text = media.ToString();
        }
    }
}