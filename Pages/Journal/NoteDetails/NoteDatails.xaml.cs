namespace gym_assistant;

public partial class NoteDetailsPage : ContentPage
{
    public NoteDetailsPage(Notes note)
    {
        InitializeComponent();
        BindingContext = note;
    }
}