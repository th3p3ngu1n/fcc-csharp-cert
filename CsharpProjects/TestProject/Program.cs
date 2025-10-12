Console.WriteLine("Please enter a number between 5 and 10");
int input = 0;
do
{
  if (!int.TryParse(Console.ReadLine(), out input))
  {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
    continue;
  }
  if (input < 5 || input > 10)
  {
    Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
  }
  else
  {
    Console.WriteLine($"Your input value ({input}) has been accepted.");
  }
} while (input < 5 || input > 10);
