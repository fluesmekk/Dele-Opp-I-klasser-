using System;
using System.Collections.Generic;
using System.Text;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class Clothes
    {
        private int _price;
        private int _size;
        private string _color;
        private string _brand;
        private int _inStock;
        private string _category;

        public Clothes(int Price, int Size, string Color, string Brand, int InStock, string Category)
        {
            _price = Price;
            _size = Size;
            _color = Color;
            _brand = Brand;
            _inStock = InStock;
        }
    }
}
