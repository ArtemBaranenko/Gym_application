namespace gym_assistant;

public partial class NoteDetailsPage : ContentPage
{
    public NoteDetailsPage(Notes selectedNote)
    {
        InitializeComponent();
        BindingContext = new NoteDeatailsViewModel(selectedNote);
    }
}