using System;
using System.Collections.Generic;
using System.Text;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class Store
    {
        AllClothes _allClothes;

        Wallet wallet;
        private Clothes[] Cart = new Clothes[10];

        public Store(AllClothes AllClothes, Wallet wallet)
        {
            _allClothes = AllClothes;
            wallet = wallet;
        }

        public void ShowAvailableStock()
        {
            foreach (var item in _allClothes.clothes)
            {
                Console.WriteLine($"{item.Color} {item.Brand} {item.Category} size: {item.Size} price: {item.Price} instock: {item.InStock}");
            }
        }

        public void AddToCart(string word)
        {
            var index = 0;
            var split = word.Split(" ");
            foreach (var item in _allClothes.clothes)
            {
                if (split[0] == item.Color && split[1] == item.Brand && split[2] == item.Category)
                {
                    Cart[index] = item;
                    index++;
                    Console.WriteLine();
                }
            }
        }

        void DeleteFromCart()
        {
            
        }

        void BuyCart()
        {
            
        }
    }
}
