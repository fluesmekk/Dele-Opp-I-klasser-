using System;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class Program
    {
        static void Main(string[] args)
        {
            Pants BrownPants = new Pants(500, 34, "Brown", "Gant", 5);
            Tshirt BlueTshirt = new Tshirt(400, 30, "Blue", "Ralph Lauren", 3);
            Shoes BlackShoes = new Shoes(500, 44, "Black", "Vans", 10);

            AllClothes StoreSelection = new AllClothes(BrownPants, BlueTshirt, BlackShoes);
            Wallet wallet = new Wallet(1200);
            Store store = new Store(StoreSelection, wallet);
            store.ShowAvailableStock();
        }
    }
}
