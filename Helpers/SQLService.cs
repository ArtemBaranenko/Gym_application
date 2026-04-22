using SQLite;

// public class SQLService<T>
public class SQLService
{
    SQLiteAsyncConnection _database;
    public SQLService(string databasePath)
    {
        _database = new SQLiteAsyncConnection(databasePath);

    }

    public async Task InitAsync()
    {
        await _database.CreateTableAsync<Notes>();
    }

    public async Task<List<Notes>> GetNotesAsync()
    {
        return await _database.Table<Notes>().ToListAsync();
    }

    public async Task<int> SaveAsync(Notes notes)
    {
        if (notes.Id != 0)
        {
            return await _database.UpdateAsync(notes);
        }
        else
        {
            return await _database.InsertAsync(notes);
        }
    }
    //TODO: Add delete function
    // public async Task<int> DeleteNoteAsync(Journal journal)
    // {

    // }
}
