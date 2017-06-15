using HesaEngine.SDK;
using static SGraves.SGraves;
using static SGraves.Menus;

namespace SGraves
{
    public class Harass
    {
        public static void HarassExec()
        {
            var targetQ = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Physical);
            var targetW = TargetSelector.GetTarget(W.Range, TargetSelector.DamageType.Physical);
            var targetE = TargetSelector.GetTarget(E.Range, TargetSelector.DamageType.Physical);
            var targetR = TargetSelector.GetTarget(R.Range, TargetSelector.DamageType.Physical);

            if (targetR == null) return;

            if (Menus.RootMenu.Get<MenuCheckbox>("HQ").Checked && Q.IsReady())
            {
                var prediction = Q.GetPrediction(targetQ);
                if (prediction.Hitchance >= HitChance.VeryHigh)
                {
                    Q.Cast(prediction.CastPosition);
                }
            }

            if (Menus.RootMenu.Get<MenuCheckbox>("HW").Checked && W.IsReady())
            {
                var prediction = W.GetPrediction(targetW);
                if (prediction.Hitchance >= HitChance.High)
                {
                    W.Cast(prediction.CastPosition);
                }
            }
        }
    }
}