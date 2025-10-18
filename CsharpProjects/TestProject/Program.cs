string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";
foreach (var value in values)
{
  if (decimal.TryParse(value, out decimal numericValue))
  {
    total += numericValue;
  }
  else
  {
    message += value;
  }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");