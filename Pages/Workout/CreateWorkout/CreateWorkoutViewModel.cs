using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;

public class CreateWorkoutViewModel : INotifyPropertyChanged
{
    private readonly INavigationService _navigation;
    public ObservableCollection<string> NumberOfSets { get; set; } = new()
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6"
    };

    public string? SelectedNumberOfSets { get; set; }

    public CreateWorkoutViewModel(INavigationService navigation)
    {
        _navigation = navigation;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? properyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
    }
}