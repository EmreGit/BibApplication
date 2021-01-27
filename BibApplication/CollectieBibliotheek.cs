using System.Collections.Generic;

namespace BibApplication
{
    public class CollectieBibliotheek
    {
        public List<Item> ItemsInCollectie { get; private set;}
        public List<Item> AfgevoerdeItems{ get; private set;}
        public List<Lid> Leden { get; private set;}

        public CollectieBibliotheek()
        {
            ItemsInCollectie = new List<Item>();
            AfgevoerdeItems = new List<Item>();
            Leden = new List<Lid>();
        }
    }
}
