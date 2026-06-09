using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace gym_assistant;

public class CreateWorkoutViewModel : INotifyPropertyChanged
{
    private readonly INavigationService _navigation;
    private readonly ExerciseAPIService _apiService;

    public ObservableCollection<ExerciseAPIService.Exercise> ExerciseSuggestion { get; set; } = new();

    public ICommand CreateCommand { get; set; }
    public ICommand FindCommand { get; set; }
    public ICommand SelectExerciseCommand { get; }
    public ICommand AddExerciseCommand { get; }

    private List<string> _exercisesList = new();

    private string? _workoutTitle;
    public string? WorkoutTitle
    {
        get => _workoutTitle;
        set
        {
            _workoutTitle = value;
            OnPropertyChanged();
        }
    }

    private string? _exerciseEntry;
    public string? ExerciseEntry
    {
        get => _exerciseEntry;
        set
        {
            _exerciseEntry = value;
            OnPropertyChanged();
        }
    }
    private bool _isDropDownVisible;
    public bool IsDropDownVisible
    {
        get => _isDropDownVisible;
        set
        {
            _isDropDownVisible = value;
            OnPropertyChanged();
        }
    }

    private ExerciseAPIService.Exercise? _selectedExercise;
    public ExerciseAPIService.Exercise? SelectedExercise
    {
        get => _selectedExercise;
        set
        {
            _selectedExercise = value;
            OnPropertyChanged();
        }
    }

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
    private string? _selectedWeight;
    public string? SelectedWeight
    {
        get => _selectedWeight;
        set
        {
            _selectedWeight = value;
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

    public ObservableCollection<string> WarmUp { get; set; } = new()
    {
        "1 min",
        "2 min",
        "3 min",
        "4 min",
        "5 min",
        "10 min"
    };
    private string? _selectedWarmUp;
    public string? SelectedWarmUp
    {
        get => _selectedWarmUp;
        set
        {
            _selectedWarmUp = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string> CoolDown { get; set; } = new()
    {
        "5 min",
        "10 min",
        "15 min"
    };
    private string? _selectedCoolDown;
    public string? SelectedCoolDown
    {
        get => _selectedCoolDown;
        set
        {
            _selectedCoolDown = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string> WorkoutType { get; set; } = new()
    {
        "Cardio",
        "Weight lifting",
        "Rest"
    };
    private string? _selectedWorkoutType;
    public string? SelectedWorkoutType
    {
        get => _selectedWorkoutType;
        set
        {
            _selectedWorkoutType = value;
            OnPropertyChanged();
        }
    }

    public CreateWorkoutViewModel(INavigationService navigation, ExerciseAPIService apiService)
    {
        _navigation = navigation;
        _apiService = apiService;

        CreateCommand = new Command(async () => await CreateWorkout());
        FindCommand = new Command(async () => await GetExercises());

        SelectExerciseCommand = new Command(() =>
        {
            if (SelectedExercise == null)
                return;
            ExerciseEntry = SelectedExercise.name;

            IsDropDownVisible = false;
        });

        AddExerciseCommand = new Command(async () => await CreateExercise());
    }

    public async Task GetExercises()
    {
        var exercises = await _apiService.GetExerciseAsync(ExerciseEntry);

        ExerciseSuggestion.Clear();
        IsDropDownVisible = true;

        //Shows all the options it got
        for (int i = exercises.Count - 1; i >= 0; i--)
        {
            var exercise = exercises[i];
            ExerciseSuggestion.Add(exercise);
        }
    }
    // public Task SelectExercise(SelectedExercise)
    // {
    //     //Whaits until user chooses needed one
    //     if (SelectedExercise == null)
    //         return;
    //     ExerciseEntry = SelectedExercise.name;

    //     //SelectExercise(SelectedExercise);
    //     //Clears out the search entry & and IsDropDownVisible = False        
    // }

    private async Task CreateExercise()
    {
        WorkoutExercises workoutExercises = new WorkoutExercises
        {
            Name = SelectedExercise.name,
            Type = SelectedExercise.type,
            Difficulty = SelectedExercise.difficulty,
            Instructions = SelectedExercise.instructions,
            Equipments = SelectedExercise.equipments.ToString(),
            Safety_info = SelectedExercise.safety_info
        };

        await App.DatabaseService.SaveWorkoutExercisesAsync(workoutExercises);

        _exercisesList.Add(workoutExercises.Name);
    }

    private async Task CreateWorkout()
    {
        WorkoutPrograms workoutPrograms = new WorkoutPrograms
        {
            WorkoutName = WorkoutTitle,
            WorkoutType = SelectedWorkoutType,
            WarmUp = SelectedWarmUp,
            CoolDown = SelectedCoolDown,
            RestBetweenSets = SelectedRest
        };

        await App.DatabaseService.SaveWorkoutProgramsAsync(workoutPrograms);

        var ids = await App.DatabaseService.GetExercisesIdAsync(_exercisesList);

        for (int i = 0; i < ids.Count(); i++)
        {
            WorkoutSession workoutSession = new WorkoutSession
            {
                WorkoutId = await App.DatabaseService.GetWorkoutIdAsync(WorkoutTitle),
                ExerciseId = ids[i],
                Sets = SelectedNumberOfSets,
                Reps = SelectedNumberOfReps,
                Weight = SelectedWeight,
                Order = i + 1
            };
            await App.DatabaseService.SaveWorkoutSessionAsync(workoutSession);
        }

        WorkoutTitle = string.Empty;
        ExerciseEntry = string.Empty;
        SelectedWorkoutType = string.Empty;
        SelectedNumberOfSets = string.Empty;
        SelectedNumberOfReps = string.Empty;
        SelectedWarmUp = string.Empty;
        SelectedCoolDown = string.Empty;
        SelectedRest = string.Empty;
        SelectedWeight = string.Empty;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? properyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
    }
}