namespace _your_project_.Helpers;

public static class FormValidation
{
  static FormValidation() { }

  public static bool IsNullOrEmptyFields(string[] fields)
  {
    foreach (var field in fields)
    {
      if (string.IsNullOrEmpty(field))
        return true;
    }

    return false;
  }

  public static bool ValidateEmail(string email)
  {
    string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
    return Regex.IsMatch(email, emailPattern);
  }
}
