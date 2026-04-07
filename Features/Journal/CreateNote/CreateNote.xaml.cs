namespace gym_assistant;

public partial class CreateNotePage : ContentPage
{
    public CreateNotePage()
    {
        InitializeComponent();
        // BindingContext = new Model();
    }
    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//JournalPage");
    }
};