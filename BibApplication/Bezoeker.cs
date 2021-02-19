using System.Collections.Generic;
using System.Linq;

namespace BibApplication
{
    public class Bezoeker
    {
        public string FamilieNaam { get; private set; }
        public string VoorNaam { get; private set; }

        public CollectieBibliotheek CollectieBibliotheek { get; private set; }

        public Bezoeker(
            CollectieBibliotheek collectieBibliotheek,
            string familieNaam,
            string voorNaam)
        {
            CollectieBibliotheek = collectieBibliotheek;
            FamilieNaam = familieNaam;
            VoorNaam = voorNaam;
        }
        public Lid RegistreerLid(string geboorteDatum)
        {
            return new Lid(CollectieBibliotheek,
                           FamilieNaam,
                           VoorNaam,
                           geboorteDatum);
        }
        public List <Item> ZoekItem(string data)
        {
            return CollectieBibliotheek.ItemsInCollectie
                .Where(x => x.ItemId == data || x.Titel.ToLower().Contains(data.ToLower())).ToList();
        }
    }
}