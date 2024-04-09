namespace ATV_3_1_Bimentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cliques = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cliques += 1;
            labelCliques.Text = cliques.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cliques > 0)
            {
                cliques -= 1;
                labelCliques.Text = cliques.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cliques = 0;
            labelCliques.Text = cliques.ToString();
        }
    }
}
