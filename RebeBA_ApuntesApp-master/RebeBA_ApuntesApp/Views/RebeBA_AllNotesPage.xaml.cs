namespace RebeBA_ApuntesApp.Views;

public partial class RebeBA_AllNotesPage : ContentPage
{
	public RebeBA_AllNotesPage()
	{
		InitializeComponent();
        BindingContext = new Models.RebeBA_AllNotes();
    }
    protected override void OnAppearing()
    {
        ((Models.RebeBA_AllNotes)BindingContext).LoadNotes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RebeBA_NotePage));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (Models.RebeBA_Note)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(RebeBA_NotePage)}?{nameof(RebeBA_NotePage.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }

}