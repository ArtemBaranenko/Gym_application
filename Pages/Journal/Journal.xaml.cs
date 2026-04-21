namespace gym_assistant;

public partial class JournalPage : ContentPage
{
    public JournalPage()
    {
        InitializeComponent();
        BindingContext = new Notes();
    }
    SQLService databaseSerice = App.DatabaseService;

    private async void OnCreateWorkoutClicked(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CreateNotePage());
    }

};