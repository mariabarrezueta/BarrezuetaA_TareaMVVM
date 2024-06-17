namespace RebeBA_ApuntesApp.Views;

public partial class RebeBA_AboutPage : ContentPage
{
	public RebeBA_AboutPage()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.RebeBA_About about)
        {
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
        
}
