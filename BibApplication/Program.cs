using System;

namespace BibApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var bibliotheek = new CollectieBibliotheek();
            bibliotheek.ItemsInCollectie.Add(new Item(SoortItem.Boek, "1", "The Invited - Jennifer McMahon", "","","", 0));
            string usertype = null;

            while (usertype != "1" && usertype != "2" && usertype != "")
            {
                Console.WriteLine("Typ 1 om als lid in te loggen, typ 2 om als medewerker in te loggen (alleen op ENTER drukken om als bezoeker ingelogd te blijven !)");
                usertype = Console.ReadLine();
                if (usertype == "1")
                {
                    Console.WriteLine("Jij bent lid !");
                }
                else if (usertype == "2")
                {
                    Console.WriteLine("Jij bent medewerker !");
                }
                else if (usertype == "")
                {
                    Console.WriteLine("Jij bent een bezoeker !");
                }
                else
                {
                    Console.WriteLine("WRONG INPUT, ERROR 405");
                }
            }
            if (usertype == "1")
            {
                member(bibliotheek);
            }
            else if (usertype == "2")
            {
                employee(bibliotheek);
            }
            else if (usertype == "")
            {
                visitor(bibliotheek);
            }
            Console.WriteLine("");
        }
        static void member(CollectieBibliotheek bibliotheek)
        {
            var user = memberlogin(bibliotheek);
            while (true)
            {
                ZoekJouwItem(user);
            }
        }
        static void visitor(CollectieBibliotheek bibliotheek)
        {
            var user = connectionvisiteur(bibliotheek);
            while (true)
            {
                ZoekJouwItem(user);
            }
        }
        static void employee(CollectieBibliotheek bibliotheek)
        {
            var user = Medewerker.PromoveerLidNaarMedewerker(memberlogin(bibliotheek));
            while (true)
            {
                ZoekJouwItem(user);
            }
        }
        static Bezoeker connectionvisiteur(CollectieBibliotheek bibliotheek)
        {
            do
            {
                Console.WriteLine("Typ jouw eerste naam in: ");
                string Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Typ jouw familienaam in: ");
                string Familyname = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Familyname))
                {
                    Console.WriteLine("ALLEEN letters invullen");
                    continue;
                }
                Console.WriteLine("Jij bent ingelogd !");
                return new Bezoeker(bibliotheek, Familyname, Firstname);
            } while (true);
        }
        static Lid memberlogin(CollectieBibliotheek bibliotheek)
        {
            do
            {
                Console.WriteLine("Typ jouw eerste naam in: ");
                string Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Typ jouw familienaam in: ");
                string Familyname = Console.ReadLine().Trim();
                Console.WriteLine("Typ jouw geboortedatum in: ");
                string Birthdate = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Familyname))
                {
                    Console.WriteLine("Alleen letter gebruiken !");
                    continue;
                }
                Console.WriteLine("Jij bent ingelogd !");
                return new Lid(bibliotheek, Familyname, Firstname, Birthdate);
            } while (true);
        }
        static void ZoekJouwItem(Bezoeker user)
        {
            Console.WriteLine("Druk op 1 om iets op te zoeken");
            string Choice = Console.ReadLine().Trim();
            if (Choice == "1")
            {
                Console.WriteLine("Typ de ID of naam van item");
                string Search = Console.ReadLine().Trim();
                var items = user.ZoekItem(Search);
                if (items.Count == 0)
                {
                    Console.WriteLine("De item werd niet gevonden");
                }
                else
                {
                    foreach (var item in items)
                    {
                        Console.WriteLine($" {item.ItemId} {item.Titel} {item.SoortItem}");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}