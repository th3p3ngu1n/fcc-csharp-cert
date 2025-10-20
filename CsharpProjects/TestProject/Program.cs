string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string customerLetter = $"Dear {customerName},";
customerLetter += "\nAs a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.";
customerLetter += $"\n\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P}.";
customerLetter += $"\n\nOur new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.";

Console.WriteLine(customerLetter);

string comparisonMessage = "\nHere's a quick comparison:\n";

comparisonMessage += $"{currentProduct,-20}{currentReturn,-10:P2}{currentProfit,-20:C}";
comparisonMessage += $"\n{newProduct,-20}{newReturn,-10:P2}{newProfit,-20:C}";

Console.WriteLine(comparisonMessage);