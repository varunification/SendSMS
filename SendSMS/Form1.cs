using Vonage;
using Vonage.Request;

namespace SendSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private async void submit_Click(object sender, EventArgs e)
        {
            string key = Program.Configuration["Keys:api_key"];
            string secret = Program.Configuration["Keys:api_secret"];

            var credentials = Credentials.FromApiKeyAndSecret(key, secret);

            var VonageClient = new VonageClient(credentials);
            string countryCode = CountryCode.Text;
            string phone = textTo.Text;
            string fullnum = string.Concat(countryCode, phone);
            var response = VonageClient.SmsClient.SendAnSmsAsync(new Vonage.Messaging.SendSmsRequest()
            {
                To = fullnum,
                From = Program.Configuration["Keys:from"],
                Text = richTextMessage.Text
            });
            MessageBox.Show("sms send successfully");
        }
    }
}