namespace gym_assistant;

public class CreateNoteViewModel
{
    SQLService databaseSerice = App.DatabaseService;

    private async Task UpdateNotes()
    {
        notesListView.ItemsSource = null;
        notesListView.ItemsSource = await databaseSerice.GetNotesAsync();
    }

    private async void onRefreshClicked(object sender, EventArgs e)
    {
        await UpdateNotes();
    }

    private async Task SaveNote()
    {
        Notes newNotes = new Notes()
        {
            Note = noteEditor.Text,
            NoteDate = DateTime.Now,
        };

        int result = await databaseSerice.SaveNoteAsync(newNotes);

        if (result == 1)
        {
            await UpdateNotes();
            noteEditor.IsEnabled = false;
            noteEditor.IsEnabled = true;
        }
    }

    private async void onSaveClicked(object sender, EventArgs e)
    {
        await SaveNote();
    }
}