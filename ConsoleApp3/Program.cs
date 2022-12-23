namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boerderij aan maken met drie verschillende dieren
            Boerderij boerderij = new Boerderij();
            Kip kip = new Kip();
            Koe koe = new Koe();
            Varken varken = new Varken();

            // De dieren toevoegen aan de boerderij
            boerderij.Dieren.Add(koe);
            boerderij.Dieren.Add(varken);
            boerderij.Dieren.Add(kip);

            // Laat ieder dier een geluid maken. De MaakGeluid()-functie doet voor ieder dier iets anders. 
            // Dier is namelijk een abstracte klasse. Koe, Kip en Varken geven ieder hun eigen invulling hieraan.
            foreach (Dier dier in boerderij.Dieren)
            {
                dier.MaakGeluid();
            }
        }

        class Boerderij
        {
            public List<Dier> Dieren { get; set; } = new List<Dier>();
        }

        abstract class Dier
        {
            public abstract void MaakGeluid();
        }

        class Koe : Dier
        {
            override public void MaakGeluid()
            {
                Console.WriteLine("Moe!");
            }
        }

        class Varken : Dier
        {
            override public void MaakGeluid()
            {
                Console.WriteLine("Knor!");
            }
        }

        class Kip : Dier
        {
            override public void MaakGeluid()
            {
                Console.WriteLine("Tok!");
            }
        }

    }
}