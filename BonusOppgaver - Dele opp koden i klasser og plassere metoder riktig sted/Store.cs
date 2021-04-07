using System;
using System.Collections.Generic;
using System.Text;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class Store
    {
        AllClothes _allClothes;

        private Wallet _wallet;
        private List<Clothes> Cart;

        public Store(AllClothes AllClothes, Wallet wallet)
        {
            _allClothes = AllClothes;
            Cart = new List<Clothes>();
            _wallet = new Wallet(wallet.Money, wallet.Currency);
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
            var split = word.Split(" ");
            foreach (var item in _allClothes.clothes)
            {
                if (split[0] == item.Color && split[1] == item.Brand && split[2] == item.Category)
                {
                    Cart.Add(item);
                    Console.WriteLine($"Added {item.Category} to cart");
                    item.InStock--;
                }
            }
        }

        public void DeleteFromCart(string word)
        {
            var split = word.Split(" ");
            Cart.RemoveAll(dc => dc.Color == split[0] && split[1] == dc.Brand && split[2] == dc.Category);
            Console.WriteLine("Deleted Item");
        }

        public void BuyCart()
        {
            int price = CalculatePrice();
            _wallet.Money -= price;
            Console.WriteLine($"You bougth {Cart.Count} items");
            Cart.Clear();
            ShowMoney();
        }

        private void ShowMoney()
        {
            Console.WriteLine($"Du har {_wallet.Money} {_wallet.Currency} igjen");
        }

        private int CalculatePrice()
        {
            var totalPrice = 0;
            foreach (var item in Cart)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }

        public void ShowCart()
        {
            foreach (var item in Cart)
            {
                Console.WriteLine($"{item.Color} {item.Brand} {item.Category} size: {item.Size} price: {item.Price} instock: {item.InStock}");
            }
        }
    }
}
