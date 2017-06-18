using System.Linq;
using System.Security.Cryptography.X509Certificates;
using HesaEngine.SDK;
using static SGraves.SGraves;
using static SGraves.Menus;

namespace SGraves
{
    public class Lane
    {
        public static void LaneExec()
        {
            var lanemonster = ObjectManager.MinionsAndMonsters.Enemy.Where(z => z.IsValidTarget() && z.IsInRange(Graves, Q.Range));

            if (Graves.IsDead) return;

            if (Menus.RootMenu.Get<MenuSlider>("LMana").CurrentValue >= Graves.ManaPercent) return;

            if (Q.IsReady() && Menus.RootMenu.Get<MenuCheckbox>("LQ").Checked)
            {
                foreach (var minions in lanemonster)
                {
                    if (Q.WillHit(minions, Graves.Position))
                    {
                        Q.Cast(Q.CastIfWillHit(minions, 2));
                    }
                }
            }
        }
    }
}
