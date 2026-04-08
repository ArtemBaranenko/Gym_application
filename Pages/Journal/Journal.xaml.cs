namespace gym_assistant;

public partial class JournalPage : ContentPage
{
    public JournalPage()
    {
        InitializeComponent();
        // BindingContext = new Model();
    }

    private async void OnCreateWorkoutClicked(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CreateNotePage());
    }
};