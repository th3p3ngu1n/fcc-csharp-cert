string pangram = "The quick brown fox jumps over the lazy dog";
string output = "";
foreach (var word in pangram.Split(" "))
{
  char[] characters = word.ToCharArray();
  Array.Reverse(characters);
  output += new string(characters);
  output += " ";
}
Console.WriteLine(output.Trim());