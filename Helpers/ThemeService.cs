public static class ThemeService
{
    public static void SetTheme(AppTheme theme)
    {
        Preferences.Set("Theme", theme.ToString());
        Application.Current.UserAppTheme = theme;
    }
    public static void LoadTheme()
    {
        string theme = Preferences.Get("Theme", "Light");
    }
}