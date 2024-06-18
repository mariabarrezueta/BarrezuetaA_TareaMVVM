namespace RebeBA_ApuntesApp.Views;

public partial class RebeBA_AllNotesPage : ContentPage
{
	public RebeBA_AllNotesPage()
	{
		InitializeComponent();
        
    
    
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}