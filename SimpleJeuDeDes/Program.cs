using SimpleJeuDeDes;
#region Create Dice
Dice De1 = new Dice();
Dice De2 = new Dice();
#endregion
#region Shot
int Shot = 0;
do
{
    De1.Launch();
    De2.Launch();
    Shot++;
} while (!(De1.GetValue() + De2.GetValue() == 6));
Console.WriteLine($"Il il aura fallu {Shot} coup! "); 
#endregion



