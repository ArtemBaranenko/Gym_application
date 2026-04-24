namespace gym_assistant;

public partial class JournalPage : ContentPage
{
    private readonly JournalViewModel _viewModel;
    public JournalPage()
    {
        InitializeComponent();

        _viewModel = new JournalViewModel(new NavigationService());
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await App.DatabaseService.InitAsync();
        await _viewModel.UpdateNotes();
    }
};