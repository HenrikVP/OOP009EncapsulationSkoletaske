using OOP009Encapsulation;

Skoletaske AlexandersTaske = new();
Madkasse AMadkasse = new Madkasse();
AlexandersTaske.FoodBox = AMadkasse;
Madder Spegepølsemad = new Madder();
Spegepølsemad.Name = "Sigurd Spegepølse";
AMadkasse.MadderList.Add(Spegepølsemad);
AlexandersTaske.Penalhus = new Penalhus();
AlexandersTaske.Penalhus.Viskelæderlist = new();
AlexandersTaske.Penalhus.Viskelæderlist.Add(new Viskelæder() { Name = "Jordbær"});


foreach (Viskelæder viskelæder in AlexandersTaske.Penalhus.Viskelæderlist)
{
    Console.WriteLine("Viskelæder: " + viskelæder.Name);
}

foreach (Madder madder in AlexandersTaske.FoodBox.MadderList)
{
    Console.WriteLine("Madder: " + madder.Name);
}