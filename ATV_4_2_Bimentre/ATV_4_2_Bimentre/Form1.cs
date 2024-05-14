namespace ATV_4_2_Bimentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cliques = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cliques != 10)
            {
                cliques++;
                labelCliques.Text = cliques.ToString();

                switch (cliques) {
                    case 7:
                        labelMensagem.Text = "Faltam apenas mais 3\r\n";
                        labelCliques.ForeColor = Color.Yellow;
                        labelMensagem.ForeColor = Color.Yellow;
                        break;
                    case 8:
                        labelMensagem.Text = "Faltam apenas mais 2\r\n";
                        labelCliques.ForeColor = Color.DarkOrange;
                        labelMensagem.ForeColor = Color.DarkOrange;
                        break;
                    case 9:
                        labelMensagem.Text = "Faltam apenas mais 1\r\n";
                        labelCliques.ForeColor = Color.Red;
                        labelMensagem.ForeColor = Color.Red;
                        break;
                    case 10:
                        labelMensagem.Text = "Acabou!\r\n";
                        labelCliques.ForeColor = Color.Green;
                        labelMensagem.ForeColor = Color.Green;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliques = 0;
            labelCliques.Text = cliques.ToString();
            labelCliques.ForeColor = Color.White;
            labelMensagem.Text = "Clique no botão para começar a contagem!";
            labelMensagem.ForeColor = Color.White;
        }
    }
}
