using Microsoft.VisualBasic.Logging;
using System.Text;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double primeiroValor = 0;
        Double segundoValor = 0;
        Double resultado = 0;
        String operador = "";
        String operadorMemoria = "";
        String logOperacao = "";

        double[] memoria = new double[10];
        bool isMemoriaSelecionada = false;
        int memoriaIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // Função para calcular
        private void Calcular()
        {
            switch (operador)
            {
                case "+":
                    resultado = primeiroValor + segundoValor;
                    break;
                case "-":
                    resultado = primeiroValor - segundoValor;
                    break;
                case "x":
                    resultado = primeiroValor * segundoValor;
                    break;
                case "÷":
                    if (segundoValor != 0)
                        resultado = primeiroValor / segundoValor;
                    else
                        MessageBox.Show("Erro: divisão por zero!");
                    break;
                case "^":
                    resultado = Math.Pow(primeiroValor, segundoValor);
                    break;
                case "y√x":
                    resultado = Math.Pow(primeiroValor, 1 / segundoValor);
                    break;
                case "sin":
                    resultado = Math.Sin(primeiroValor);
                    break;
                case "cos":
                    resultado = Math.Cos(primeiroValor);
                    break;
                case "tan":
                    resultado = Math.Tan(primeiroValor);
                    break;
                case "x²":
                    resultado = Math.Pow(primeiroValor, 2);
                    break;
                case "√":
                    resultado = Math.Sqrt(primeiroValor);
                    break;
                default:
                    break;
            }

            if (operador == "x²" || operador == "√" || operador == "sin" || operador == "cos" || operador == "tan")
            {
                textBox_Display1.Text = resultado.ToString();
                textBox_Display2.Text = primeiroValor.ToString() + operador;
                string log = $"= {resultado}";
                addLogOperacao(valor: log, final: true);
            }
            else
            {
                string log = $"= {resultado}";
                addLogOperacao(valor: log, final: true);
                textBox_Display1.Text = resultado.ToString();
                textBox_Display2.Clear();
            }
        }

        // Eventos de clique de todos os botões numéricos de 0 a 9
        private void Numerico_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isMemoriaSelecionada)
            {
                memoriaIndex = int.Parse(button.Text);
                if (memoriaIndex >= 0 && memoriaIndex <= 9)
                {
                    if (operadorMemoria == "MS")
                    {
                        memoria[memoriaIndex] = double.Parse(textBox_Display1.Text);
                        MessageBox.Show($"Valor armazenado no registrador {memoriaIndex}: {memoria[memoriaIndex]}");
                    }
                    else if (operadorMemoria == "MR")
                    {
                        textBox_Display1.Text = memoria[memoriaIndex].ToString();
                        MessageBox.Show($"Valor recuperado do registrador {memoriaIndex}: {memoria[memoriaIndex]}");
                    }
                }
                isMemoriaSelecionada = false;
                memoriaIndex = -1;
            }
            else
            {
                textBox_Display1.Text += button.Text;
            }
        }

        // Função para adicionar ponto, botão .
        private void btnPonto(object sender, EventArgs e)
        {
            textBox_Display1.Text += ",";
        }

        // Função para adicionar negativo na conta, botão +/-
        private void button10_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Insert(0, "-");
            sb.Append(textBox_Display1.Text);
            textBox_Display1.Text = sb.ToString();
        }

        // Eventos de clique de todos os botões de operações
        private void Operacao_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            operador = button.Text;

            if (operador == "x²" || operador == "√" || operador == "sin" || operador == "cos" || operador == "tan")
            {
                primeiroValor = double.Parse(textBox_Display1.Text);
                Calcular();
            }
            else if (!string.IsNullOrEmpty(textBox_Display1.Text))
            {
                primeiroValor = double.Parse(textBox_Display1.Text);
                textBox_Display2.Text = primeiroValor.ToString() + operador;

                textBox_Display1.Clear();
            }
        }

        // Função de clique do botão de igual
        private void btnIgual(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Display1.Text))
            {
                segundoValor = double.Parse(textBox_Display1.Text);
                Calcular();
            }
        }

        // Função para limpar o TextBox botão CE
        private void btnLimparEntrada(object sender, EventArgs e)
        {
            addLogOperacao(valor: textBox_Display2.Text + textBox_Display1.Text, ce: true);
            textBox_Display1.Clear();
        }

        // Função para resetar a calculadora botão C
        private void btnResetar(object sender, EventArgs e)
        {
            addLogOperacao(valor: textBox_Display2.Text + textBox_Display1.Text, c: true);
            primeiroValor = 0;
            segundoValor = 0;
            operador = "";
            textBox_Display1.Clear();
            textBox_Display2.Clear();
        }

        // Função para adicionar o log da operação
        private void addLogOperacao(string valor = "", bool final = false, bool c = false, bool ce = false)
        {
            if (final)
            {
                // Log 2 valores
                if (!string.IsNullOrEmpty(operador) && segundoValor != 0)
                {
                    string log;

                    if (operador == "x²" || operador == "√" || operador == "sin" || operador == "cos" || operador == "tan")
                    {
                        log = $"{primeiroValor}; {operador}; = ; {resultado}";
                    }
                    else
                    {
                        log = $"{primeiroValor}; {operador}; {segundoValor}; = ; {resultado}";
                    }

                    logOperacao += log + "\r\n";
                }
                // Log 1 valor
                else if (!string.IsNullOrEmpty(operador) && segundoValor == 0)
                {
                    string log = $"{primeiroValor}; {operador}; = ; {resultado}";
                    logOperacao += log + "\r\n";
                }
                else
                {
                    string log = $"{valor};";
                    if (ce)
                    {
                        logOperacao += $"{log} CE; ";
                    }
                    else if (c)
                    {
                        logOperacao += $"{log} C\r\n";
                    }
                }
            }
            else
            {
                string log = $"{valor};";
                if (ce)
                {
                    logOperacao += $"{log} CE; ";
                }
                else if (c)
                {
                    logOperacao += $"{log} C\r\n";
                }
            }
        }

        // Função para ver ou não o log de operação
        private void btnInfoLog_Click(object sender, EventArgs e)
        {
            if (listBox_logOperacao.Items.Count == 0)
            {
                string[] logs = logOperacao.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                listBox_logOperacao.Items.AddRange(logs);
            }
            else
            {
                listBox_logOperacao.Items.Clear();
            }
        }

        // Função para zerar a memória MC
        private void btnLimpaMemoria_Click(object sender, EventArgs e)
        {
            memoria[0] = 0;
            MessageBox.Show("Registrador 0 zerado.");
        }

        // Função para armazenar na memória MS
        private void btnArmazenaMemoria_Click(object sender, EventArgs e)
        {
            operadorMemoria = "MS";
            isMemoriaSelecionada = true;
            MessageBox.Show("Selecione um registrador (0-9) para armazenar o valor.");
        }

        // Função para recuperar da memória MR
        private void btnRecuperaMemoria_Click(object sender, EventArgs e)
        {
            operadorMemoria = "MR";
            isMemoriaSelecionada = true;

            // Mostrar os valores dos registradores
            StringBuilder memoriaDisplay = new StringBuilder("Registradores de Memória:\n");
            for (int i = 0; i < memoria.Length; i++)
            {
                memoriaDisplay.AppendLine($"Registrador {i}: {memoria[i]}");
            }
            memoriaDisplay.AppendLine("\nSelecione um registrador (0-9) para recuperar o valor.");
            MessageBox.Show(memoriaDisplay.ToString());
        }
    }
}
