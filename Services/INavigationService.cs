namespace gym_assistant;

public interface INavigationService
{
    Task GoToAsync(string route);
    Task GoBackAsync();
}