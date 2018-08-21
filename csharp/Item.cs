namespace csharp
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public void IncreaseQuality()
        {
            Quality++;
        }

        public void DecreaseQuality()
        {
            Quality--;
        }

        public void ZeroQuality()
        {
            Quality = 0;
        }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }  
    }
}
