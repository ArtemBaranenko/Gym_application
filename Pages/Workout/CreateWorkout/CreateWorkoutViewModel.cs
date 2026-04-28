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
        "1 set",
        "2 sets",
        "3 sets",
        "4 sets",
        "5 sets",
        "6 sets"
    };
    private string? _selectedNumberOfSets;
    public string? SelectedNumberOfSets
    {
        get => _selectedNumberOfSets;
        set
        {
            _selectedNumberOfSets = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string> NumberOfReps { get; set; } = new()
    {
        "1 rep", "2 reps", "3 reps", "4 reps", "5 reps", "6 reps", "7 reps", "8 reps", "9 reps", "10 reps",
        "11 reps", "12 reps", "13 reps", "14 reps", "15 reps", "16 reps", "17 reps", "18 reps", "19 reps", "20 reps",
        "21 reps", "22 reps", "23 reps", "24 reps", "25 reps", "26 reps", "27 reps", "28 reps", "29 reps", "30 reps"
    };
    private string? _selectedNumberOfReps;
    public string? SelectedNumberOfReps
    {
        get => _selectedNumberOfReps;
        set
        {
            _selectedNumberOfReps = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string> Weight { get; set; } = new()
    {
        "2.5 kg", "5 kg",
        "7.5 kg", "10 kg",
        "12.5 kg","15 kg",
        "17.5 kg", "20 kg",
        "22.5 kg", "25 kg",
        "27.5 kg", "30 kg"
    };
    private string? _selectedNumber;
    public string? SelectedNumber
    {
        get => _selectedNumber;
        set
        {
            _selectedNumber = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string> RestBetween { get; set; } = new()
    {
        "15 sec",
        "30 sec",
        "45 sec",
        "60 sec",
        "1 min",
        "2 min",
        "3 min",
        "4 min",
        "5 min",
        "10 min"
    };
    private string? _selectedRest;
    public string? SelectedRest
    {
        get => _selectedRest;
        set
        {
            _selectedRest = value;
            OnPropertyChanged();
        }
    }

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