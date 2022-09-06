using OOP009Encapsulation;

Skoletaske AlexandersTaske = new();
Madkasse AMadkasse = new Madkasse();
AlexandersTaske.FoodBox = AMadkasse;
Madder Spegepølsemad = new Madder();
Spegepølsemad.Name = "Sigurd Spegepølse";
AMadkasse.MadderList.Add(Spegepølsemad);
AlexandersTaske.Penalhus = new Penalhus();
AlexandersTaske.Penalhus.Viskelæderlist = new();
AlexandersTaske.Penalhus.Viskelæderlist.Add(new Viskelæder() { Name = "Jordbær" });

AlexandersTaske.Booklist = new List<Bog>() {
    new Bog() { Name = "Ringenes Herre",Author = "Tolkien"},
    new Bog() { Name = "Dune", Author = "Frank Herbert"} };

foreach (Bog bog in AlexandersTaske.Booklist)
{
    Console.WriteLine($"{bog.Name} {bog.Author}");
}

foreach (Viskelæder viskelæder in AlexandersTaske.Penalhus.Viskelæderlist)
{
    Console.WriteLine("Viskelæder: " + viskelæder.Name);
}

foreach (Madder madder in AlexandersTaske.FoodBox.MadderList)
{
    Console.WriteLine("Madder: " + madder.Name);
}