namespace gym_assistant;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}

	private static SQLService databaseService = default!;
	public static SQLService DatabaseService
	{
		get
		{
			if (databaseService == null)
			{
				var path = Path.Combine(FileSystem.AppDataDirectory, "gym.db");
				databaseService = new SQLService(path);
			}
			return databaseService;
		}
	}
}