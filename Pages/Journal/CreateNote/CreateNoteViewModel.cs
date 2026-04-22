using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;

public class CreateNoteViewModel : INotifyPropertyChanged
{
    private string? _noteText;
    public string? NoteText
    {
        get => _noteText;
        set
        {
            _noteText = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<Notes> Notes { get; set; } = new();
    public ICommand SaveCommand { get; }

    public CreateNoteViewModel()
    {
        SaveCommand = new Command(async () => await SaveNoteAsync());
    }

    private async Task SaveNoteAsync()
    {
        Notes note = new Notes
        {
            Note = NoteText
        };

        await App.DatabaseService.SaveAsync(note);

        Notes.Add(note);

        NoteText = string.Empty;
        OnPropertyChanged(nameof(NoteText));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }



    // private async Task UpdateNotes()
    // {
    //     notesListView.ItemsSource = null;
    //     notesListView.ItemsSource = await databaseSerice.GetNotesAsync();
    // }

    // private async void onRefreshClicked(object sender, EventArgs e)
    // {
    //     await UpdateNotes();
    // }


    // private void onSave()
    // {
    //     await SaveNote();
    // }



}