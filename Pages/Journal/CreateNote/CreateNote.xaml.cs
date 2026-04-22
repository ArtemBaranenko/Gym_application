namespace gym_assistant;

public partial class CreateNotePage : ContentPage
{
    public CreateNotePage()
    {
        InitializeComponent();
        BindingContext = new CreateNoteViewModel();
    }
};