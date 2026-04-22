namespace gym_assistant;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CreateNotePage), typeof(CreateNotePage));
	}
}
