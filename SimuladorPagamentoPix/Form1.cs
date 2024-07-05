using System.Text;
using System.Text.Json;

namespace SimuladorPagamentoPix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtQrCodePix_TextChanged(object sender, EventArgs e)
        {
            btnPagar.Enabled = !String.IsNullOrEmpty(txtQrCodePix.Text);
        }

        private async void btnPagar_Click(object sender, EventArgs e)
        {
            txtResultado.ResetText();

            txtQrCodePix.Enabled = btnPagar.Enabled = false;

            await SendPaymentAsync(txtQrCodePix.Text);

            txtQrCodePix.ResetText();
            txtQrCodePix.Enabled = true;
        }

        private async Task SendPaymentAsync(string qrcode)
        {
            using HttpClient client = new();
            string url = "https://api.hm.bb.com.br/testes-portal-desenvolvedor/v1/boletos-pix/pagar?gw-app-key=95cad3f03fd9013a9d15005056825665";

            var data = new
            {
                pix = qrcode,
            };

            string json = JsonSerializer.Serialize(data);
            StringContent content = new(json, Encoding.UTF8, "application/json");

            try
            {
                txtResultado.Text = $"Aguarde! Efetuando o pagamento...{Environment.NewLine}";
                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                txtResultado.Text = responseBody;
                txtResultado.AppendText(Environment.NewLine);
                txtResultado.AppendText("Pagamento efatuado com sucesso.");
            }
            catch (HttpRequestException e)
            {
                txtResultado.AppendText($"Erro na requisição: {e.Message}");
            }
        }
    }
}
