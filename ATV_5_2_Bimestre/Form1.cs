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

            res = "O contador est� em 1\r\n";
            int numInput = int.Parse(formInput.Text);

            while (contador < numInput) {
                contador += 10;
                if (contador <= numInput) {
                    res += "O contador est� em: " + contador + "\r\n";
                }
            }

            if (numInput % 10 != 0) {
                res += "O contador est� em: " + numInput + "\r\n";
            }

            res += "Total contado: " + numInput;
            TextBoxRes.Text = res;
        }
    }
}
