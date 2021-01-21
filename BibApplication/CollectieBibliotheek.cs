using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
