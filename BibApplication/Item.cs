namespace BibApplication
{
    public class Item
    {
        public SoortItem SoortItem { get; private set; }
        public string ItemId { get; private set; }
        public string Titel { get; private set; }
        public string Auteur { get; private set;}
        public string Regisseur { get; private set; }
        public string Uitvoerder { get; private set; }
        public int Jaar { get; private set; }
        public bool UitGeleend { get; set; }
        public bool Afgevoerd { get; set; }

        public Item(
         SoortItem soortItem,
         string itemId,
         string titel,
         string auteur,
         string regisseur,
         string uitvoerder,
         int jaar)
        {
            SoortItem = soortItem;
            ItemId = itemId;
            Titel = titel;
            Auteur = auteur;
            Regisseur = regisseur;
            Uitvoerder = uitvoerder;
            Jaar = jaar;
            UitGeleend = false;
            Afgevoerd = false;
        }
    }
}
