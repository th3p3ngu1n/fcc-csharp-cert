string[] validRoles = { "administrator", "manager", "user" };
string rolePrompt = "Enter your role name (Administrator, Manager, or User)";
Console.WriteLine(rolePrompt);

string? input = "";
bool valid = false;
do
{
  input = Console.ReadLine();
  if (!validRoles.Contains(input?.Trim()?.ToLower()))
  {
    Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. {rolePrompt}");
  }
  else
  {
    valid = true;
    Console.WriteLine($"Your input value ({input}) has been accepted.");
  }

} while (!valid);
