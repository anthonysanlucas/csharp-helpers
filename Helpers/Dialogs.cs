namespace _your_project_.Helpers
{
  public static class Dialogs
  {
    static Dialogs() { }

    public static async Task<bool> DisplayConfirmationAlert(
        string title,
        string message,
        string accept,
        string cancel
    )
    {
      return await Shell.Current.DisplayAlert(title, message, accept, cancel);
    }

    public static async Task<string> DisplayPrompt(
        string title,
        string message,
        string accept,
        string cancel,
        string placeholder,
        int maxLength,
        Keyboard keyboard
    )
    {
      return await Shell
          .Current
          .DisplayPromptAsync(
              title,
              message,
              accept,
              cancel,
              placeholder,
              maxLength,
              keyboard
          );
    }

    public static async Task DisplayAlert(string title, string message, string cancel)
    {
      await Shell.Current.DisplayAlert(title, message, cancel);
    }
  }
}