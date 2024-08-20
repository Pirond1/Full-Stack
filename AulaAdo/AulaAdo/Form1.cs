namespace AulaAdo
{
    public partial class Form1 : Form
    {
        MetodoPagamento Metodo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> lista = new List<int>();
                int Numero = int.Parse(txtNumero.Text);
                lista.Add(Numero);
                for (int i = 0; i < 5; i++)
                {
                    MessageBox.Show(lista[i].ToString());
                }

                if (Numero >= 18)
                    MessageBox.Show("Maior de Idade");
                else
                    MessageBox.Show("Menor de Idade");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Acessou posição inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Efetuar o Calculo: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Metodo = MetodoPagamento.Dinheiro;
                    break;
                case 1:
                    Metodo = MetodoPagamento.Cartao_debito;
                    break;
                case 2:
                    Metodo = MetodoPagamento.Cartao_credito;
                    break;
                case 3:
                    Metodo = MetodoPagamento.PIX;
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (Metodo == MetodoPagamento.PIX)
            {
                //Salvo tabela PIX
                MessageBox.Show("Pagamento no PIX Confirmado!\nValor: " + textBox1.Text);
            }
            else if (Metodo == MetodoPagamento.Cartao_credito)
            {
                //Salvo tabela Cartão de Crédito
                MessageBox.Show("Pagamento no Cartão de Crédito Confirmado!\nValor: " + textBox1.Text);
            }
            else if (Metodo == MetodoPagamento.Cartao_debito)
            {
                //Salvo tabela Cartão de Débito
                MessageBox.Show("Pagamento no Cartão de Débito Confirmado!\nValor: " + textBox1.Text);
            }
            else if (Metodo == MetodoPagamento.Dinheiro)
            {
                //Salvo tabela Cartão de Débito
                MessageBox.Show("Pagamento em Dinheiro Confirmado!\nValor: " + textBox1.Text);
            }
        }
    }


    public enum MetodoPagamento
    {
        Dinheiro = 1,
        Cartao_debito = 2,
        Cartao_credito = 3,
        PIX = 4,
    }
}