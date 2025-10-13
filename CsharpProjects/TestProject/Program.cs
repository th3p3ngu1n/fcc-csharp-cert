// pre-defined array of strings for project
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
  string myString = myStrings[i];
  int periodLocation = myString.IndexOf('.');

  while (periodLocation != -1)
  {
    string currentSentence = myString.Remove(periodLocation).Trim();
    Console.WriteLine(currentSentence);

    myString = myString.Substring(periodLocation + 1).TrimStart();
    periodLocation = myString.IndexOf('.');
  }
  Console.WriteLine(myString.Trim());
}