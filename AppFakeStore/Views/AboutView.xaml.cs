namespace AppFakeStore.Views;

public partial class AboutView : ContentPage
{
	public AboutView()
	{
		InitializeComponent();
	}

    private void btnPrincipal_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void btnLlamar_Clicked(object sender, EventArgs e)
    {
        string phoneNumber = "+5491145678923"; 
        PhoneDialer.Default.Open(phoneNumber);
    }

    private async void btnEnviarMail_Clicked(object sender, EventArgs e)
    {
        var message = new EmailMessage
        {
            Subject = "Asunto del correo",
            Body = "Probando: ",
            To = new List<string> { "lucaberisso1@gmail.com" } 
        };

        await Email.ComposeAsync(message);
    }
}