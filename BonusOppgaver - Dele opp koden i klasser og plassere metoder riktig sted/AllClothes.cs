using System;
using System.Collections.Generic;
using System.Text;

namespace BonusOppgaver___Dele_opp_koden_i_klasser_og_plassere_metoder_riktig_sted
{
    class AllClothes
    {
        public List<Clothes> clothes;

        public AllClothes(params Clothes[] Clothes)
        {
            clothes = new List<Clothes>();
            foreach (var item in Clothes)
            {
                clothes.Add(item);
            }
        }
    }
}
