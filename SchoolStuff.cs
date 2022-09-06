namespace OOP009Encapsulation
{
    internal class SchoolStuff
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Condition { get; set; }
    }

    internal class Skoletaske : SchoolStuff
    {
        public Penalhus Penalhus { get; set; }
        public List<Bog> Booklist { get; set; }
        public Madkasse FoodBox { get; set; }
    }
    internal class Bog : SchoolStuff
    {
        public string Author { get; set; }
    }
    internal class Penalhus : SchoolStuff
    {
        public List<Blyanter> Blyantlist { get; set; }
        public List<Viskelæder> Viskelæderlist { get; set; }
    }
    internal class Viskelæder : SchoolStuff
    {
        public string Smell { get; set; }
    }
    internal class Blyanter : SchoolStuff
    {
        public string Color { get; set; }
    }
    internal class Madkasse : SchoolStuff
    {
        public List<Madder> MadderList { get; set; } = new();
    }
    internal class Madder : SchoolStuff
    {
        public string Smag { get; set; }
    }
}
