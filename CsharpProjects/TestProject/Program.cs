int heroHealth = 10;
int monsterHealth = 10;
Random attack = new Random();

do
{
  int attackPoints = attack.Next(1, 11);
  monsterHealth -= attackPoints;
  Console.WriteLine($"Monster was damaged and lost {attackPoints} health and now has {monsterHealth} health.");
  
  if (monsterHealth <= 0) continue;
  
  attackPoints = attack.Next(1, 11);
  heroHealth -= attackPoints;
  Console.WriteLine($"Hero was damaged and lost {attackPoints} health and now has {heroHealth} health.");
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");