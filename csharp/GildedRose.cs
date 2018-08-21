using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public void UpdateQuality()
        {
            foreach (Item item in _items)
            {
                UpdteItemQuality(item);
            }
        }

        private static void UpdteItemQuality(Item item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.DecreaseQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.IncreaseQuality();

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.IncreaseQuality();
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.IncreaseQuality();
                            }
                        }
                    }
                }
            }

            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.DecreaseQuality();
                            }
                        }
                    }
                    else
                    {
                        item.ZeroQuality();
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
        }
    }
}
