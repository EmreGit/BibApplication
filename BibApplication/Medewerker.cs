using System.Collections.Generic;

namespace BibApplication
{
    public class Medewerker : Lid
    {
        private Medewerker(
            CollectieBibliotheek collectieBibliotheek,
            string familieNaam,
            string voorNaam,
            string geboorteDatum,
            List<Item> uitleenHistoriek, 
            List<Item> uitleenItems,
            List<Item> collectieReservatie) 
            : base(collectieBibliotheek,
                  familieNaam,
                  voorNaam,
                  geboorteDatum,
                  uitleenHistoriek,
                  uitleenItems,
                  collectieReservatie){}
        public static Medewerker PromoveerLidNaarMedewerker (Lid lid)
        {
            return new Medewerker(
                lid.CollectieBibliotheek,
                lid.FamilieNaam,
                lid.VoorNaam,
                lid.GeboorteDatum,
                lid.UitleenHistoriek,
                lid.UitleenItems,
                lid.CollectieReservatie);
        }
        public void VoerItemAf(Item item, int index)
        {
            CollectieBibliotheek.ItemsInCollectie.Insert(index, item);
        }
        public void VoegItemToe(Item item)
        {
            CollectieBibliotheek.ItemsInCollectie.Add(item);
        }
        public void Terugbrengen(Item item)
        {
            item.UitGeleend = false;
        }
        public void Reserveren(Item item)
        {
            item.UitGeleend = true;
        }
    }
}
