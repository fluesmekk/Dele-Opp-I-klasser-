using System;
using System.Collections.Generic;
using System.Text;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class Store
    {
        AllClothes _allClothes;

        Wallet wallet;

        public Store(AllClothes AllClothes, Wallet wallet)
        {
            _allClothes = AllClothes;
            wallet = wallet;
        }

        ShowAvailableStock();
        AddToCart();
        DeleteFromCart();
        BuyCart();
    }
}
