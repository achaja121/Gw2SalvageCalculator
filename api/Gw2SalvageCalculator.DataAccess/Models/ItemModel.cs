namespace Gw2SalvageCalculator.DataAccess.Models
{
    internal class ItemModel
    {
        public bool Binding { get; set; }

        public int Id { get; set; }
        
        public int ItemId { get; set; }

        public int Level { get; set; }

        public string Name { get; set; }

        public RarityModel Rarity { get; set; }

        public bool Salvage { get; set; }

        public TypeModel Type { get; set; }
    }
}
