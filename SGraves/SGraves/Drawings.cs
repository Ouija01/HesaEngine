using System;
using HesaEngine.SDK;
using SharpDX;
using static SGraves.SGraves;
using static SGraves.Menus;
using static SGraves.Combo;

namespace SGraves
{
    public class Drawings
    {
        public static void CreateDraw()
        {
            Drawing.OnDraw += Ondrawing;
        }

        private static void Ondrawing(EventArgs args)
        {
            if (Menus.Menu.Get<MenuCheckbox>("disableDraw").Checked) return;

            if (Menus.Menu.Get<MenuCheckbox>("qDraw").Checked && Q.IsReady())
            {
                Drawing.DrawCircle(Graves.Position,Q.Range);
            }

            if (Menus.Menu.Get<MenuCheckbox>("wDraw").Checked && W.IsReady())
            {
                Drawing.DrawCircle(Graves.Position, W.Range);
            }

            if (Menus.Menu.Get<MenuCheckbox>("eDraw").Checked && E.IsReady())
            {
                Drawing.DrawCircle(Graves.Position, E.Range);
            }

            if (Menus.Menu.Get<MenuCheckbox>("rDraw").Checked && R.IsReady())
            {
                Drawing.DrawCircle(Graves.Position, R.Range);
            }

            if (Menus.Menu.Get<MenuCheckbox>("burstDmgText").Checked)
            {
                var targetQ = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Physical);
                var damages = Q.GetDamage(targetQ) + W.GetDamage(targetQ) + R.GetDamage(targetQ);
                if (targetQ != null && targetQ.IsInRange(Graves.Position,Q.Range))
                {
                    Drawing.DrawText(Graves.Position.X, Graves.Position.Y - 40, Color.Aqua,"Burst Damage: " + Convert.ToString(damages));
                }
            }
        }
    }
}