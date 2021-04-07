using System;
using System.Collections.Generic;
using System.Text;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class Clothes
    {
        

        public int Price { get; }
        public int Size { get; }
        public string Color { get; }
        public string Brand { get; }
        public int InStock { get; }
        public string Category { get; }

        public Clothes(int price, int size, string color, string brand, int inStock, string category)
        {
            Price = price;
            Size = size;
            Color = color;
            Brand = brand;
            InStock = inStock;
            Category = category;
        }
    }
}
