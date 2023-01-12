using SimpleJeuDeDes;
#region Create Dice
Dice Dice1 = new Dice();
Dice Dice2 = new Dice();
#endregion
#region Shot
int Shot = 0;
do
{
    Dice1.Launch();
    Dice2.Launch();
    Shot++;
} while (!((Dice1.Value == 6) && (Dice2.Value == 6)));
Console.WriteLine($"Il il aura fallu {Shot} coup! ");
Dice1.Print();
Dice2.Print();
Console.WriteLine($"Il y a {Dice.DiceNb} dés");
#endregion



