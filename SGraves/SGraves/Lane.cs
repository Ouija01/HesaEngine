using System.Linq;
using HesaEngine.SDK;
using static SGraves.SGraves;
using static SGraves.Menus;

namespace SGraves
{
    public class Lane
    {
        public static void LaneExec()
        {
            var lanemonster = MinionManager.GetMinions(Q.Range, MinionTypes.All, MinionTeam.Enemy);

            if (lanemonster == null) return;

            if (Menus.Menu.Get<MenuSlider>("LMana").CurrentValue <= Graves.ManaPercent) return;

            if (Q.IsReady() && Menus.Menu.Get<MenuCheckbox>("LQ").Checked)
            {
                if (Q.WillHit(lanemonster.FirstOrDefault(), Graves.Position, 0, HitChance.High))
                {
                    Q.CastIfWillHit(lanemonster.FirstOrDefault(),2);
                }
            }
        }
    }
}