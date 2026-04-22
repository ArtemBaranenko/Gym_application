namespace gym_assistant;

public class NavigationService : INavigationService
{
    public async Task GoToAsync(string route)
    {
        await Shell.Current.GoToAsync(route);
    }
    public async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}