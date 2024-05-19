using System.Numerics;

namespace ATV_5_2_Bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            int contador = 0;
            String res = "";

            res = "O contador está em 1\r\n";
            int numInput = int.Parse(formInput.Text);

            while (contador < numInput) { 
                contador += 10;
                res += "O contador está em: " + contador + "\r\n";
            }

            contador += 1;
            res += "Total contado: " + contador;
            TextBoxRes.Text = res;
        }
    }
}
