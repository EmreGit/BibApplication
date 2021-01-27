using System.Collections.Generic;

namespace BibApplication
{
    public class Lid:Bezoeker
    {
        public string GeboorteDatum { get; private set; }
        public List<Item> UitleenHistoriek { get; private set; }
        public List<Item> UitleenItems { get; private set; }
        public List<Item> CollectieReservatie { get; private set; }

        public Lid(
            CollectieBibliotheek collectieBibliotheek,
            string familieNaam,
            string voorNaam,
            string geboorteDatum) 
            : base(collectieBibliotheek,
                  familieNaam, 
                  voorNaam)
        {
            GeboorteDatum = geboorteDatum;
            UitleenHistoriek = new List<Item>();
            UitleenItems = new List<Item>();
            CollectieReservatie = new List<Item>();
        }
        public Lid(
            CollectieBibliotheek collectieBibliotheek,
            string familieNaam,
            string voorNaam,
            string geboorteDatum,
            List<Item> uitleenHistoriek,
            List<Item> uitleenItems,
            List<Item> collectieReservatie ) 
            : base(collectieBibliotheek,
                  familieNaam,
                  voorNaam)
        {
            GeboorteDatum = geboorteDatum;
            UitleenHistoriek = uitleenHistoriek;
            UitleenItems = uitleenItems;
            CollectieReservatie = collectieReservatie;
        }
    }
}
