using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var bibliotheek = new CollectieBibliotheek();
            bibliotheek.ItemsInCollectie.Add(new Item(SoortItem.Boek, "1", "The Invited", "","","", 0));
            string usertype = null;

            while (usertype != "1" && usertype != "2" && usertype != "")
            {
                Console.WriteLine("Tapez 1 pour entrer en tant que membre, tapez 2 pour employées (appuyer seulement sur ENTER pour rester en tant que visiteur)");
                usertype = Console.ReadLine();
                if (usertype == "1")
                {
                    Console.WriteLine("Vous etes membre !");
                }
                else if (usertype == "2")
                {
                    Console.WriteLine("Vous etes un employé !");
                }
                else if (usertype == "")
                {
                    Console.WriteLine("Vous restez visiteur");
                }
                else
                {
                    Console.WriteLine("WRONG INPUT, ERROR 666");
                }
            }

            if (usertype == "1")
            {
                member(bibliotheek);
            }
            else if (usertype == "2")
            {
                employé(bibliotheek);
            }
            else if (usertype == "")
            {
                visitor(bibliotheek);
            }
            Console.WriteLine("");
        }
        static void member(CollectieBibliotheek bibliotheek)
        {
            var user = connectionmembre(bibliotheek);
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
        static void employé(CollectieBibliotheek bibliotheek)
        {
            var user = Medewerker.PromoveerLidNaarMedewerker(connectionmembre(bibliotheek));
            while (true)
            {
                ZoekJouwItem(user);
            }
        }
        static Bezoeker connectionvisiteur(CollectieBibliotheek bibliotheek)
        {
            do
            {
                Console.WriteLine("Type your first name");
                string Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Type your family name");
                string Familyname = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Familyname))
                {
                    Console.WriteLine("Please enter ONLY LETTERS");
                    continue;
                }
                Console.WriteLine("Vous etes connecté");
                return new Bezoeker(bibliotheek, Familyname, Firstname);
            } while (true);
        }
        static Lid connectionmembre(CollectieBibliotheek bibliotheek)
        {
            do
            {
                Console.WriteLine("Type your first name");
                string Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Type your family name");
                string Familyname = Console.ReadLine().Trim();
                Console.WriteLine("Type your birthdate");
                string Birthdate = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Familyname))
                {
                    Console.WriteLine("Please enter ONLY LETTERS");
                    continue;
                }
                Console.WriteLine("Vous etes connecté");
                return new Lid(bibliotheek, Familyname, Firstname, Birthdate);
            } while (true);
        }
        static void ZoekJouwItem(Bezoeker user)
        {
            Console.WriteLine("Type 1 to search an item");
            string Choice = Console.ReadLine().Trim();
            if (Choice == "1")
            {
                Console.WriteLine("Type the ID or the title");
                string Search = Console.ReadLine().Trim();
                var items = user.ZoekItem(Search);
                if (items.Count == 0)
                {
                    Console.WriteLine("The item was not found");
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
