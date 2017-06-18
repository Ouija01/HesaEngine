using System.Collections.Generic;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using SharpDX;
using static SGraves.SGraves;

namespace SGraves
{
    public class Combo
    {
        public static void ComboExec()
        {
            var targetQ = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Physical);
            var targetW = TargetSelector.GetTarget(W.Range, TargetSelector.DamageType.Physical);
            var targetE = TargetSelector.GetTarget(E.Range, TargetSelector.DamageType.Physical);
            var targetR = TargetSelector.GetTarget(R.Range, TargetSelector.DamageType.Physical);

            if (targetR == null || Graves.IsDead) return;

            if (!Menus.RootMenu.Get<MenuKeybind>("burstKey").Active)
            {
                if (Menus.RootMenu.Get<MenuCheckbox>("CQ").Checked && Q.IsReady())
                {
                    var prediction = Q.GetPrediction(targetQ);
                    if (prediction.Hitchance >= HitChance.VeryHigh)
                    {
                        Q.Cast(prediction.CastPosition);
                    }
                }

                if (Menus.RootMenu.Get<MenuCheckbox>("CW").Checked && W.IsReady())
                {
                    var prediction = W.GetPrediction(targetW);
                    if (prediction.Hitchance >= HitChance.High)
                    {
                        W.Cast(prediction.CastPosition);
                    }
                }

                if (Menus.RootMenu.Get<MenuCheckbox>("CR").Checked && R.IsReady()
                    && R.GetDamage(targetR) > targetR.Health
                    && targetR.IsInRange(Graves.Position, R.Range - 50))
                {
                    var prediction = Q.GetPrediction(targetQ);
                    if (prediction.Hitchance >= HitChance.VeryHigh)
                    {
                        Q.Cast(prediction.CastPosition);
                    }
                }

                if (Menus.RootMenu.Get<MenuCheckbox>("CE").Checked)
                {
                    switch (Menus.RootMenu.Get<MenuCombo>("eMode").CurrentValue)
                    {
                        case 0:
                            if (E.IsReady(0) && targetE != null && (double)Graves.Mana > 120.0 && IsSafePosition(targetQ.Position))
                            {
                                E.Cast(Game.CursorPosition);
                            }
                            break;
                        case 1:
                            if (E.IsReady(0) && targetE != null && (double)Graves.Mana > 120.0 && IsSafePosition(targetQ.Position))
                            {
                                E.Cast(targetQ);
                            }
                            break;
                        case 2:
                            return;
                            break;
                    }
                }
            }

            if (Menus.RootMenu.Get<MenuKeybind>("burstKey").Active)
            {
                var Qpred = Q.GetPrediction(targetQ);
                var Wpred = W.GetPrediction(targetW);
                var Rpred = R.GetPrediction(targetR);

                if (targetR != null)
                {
                    if (Orbwalker.CanAttack() && targetQ.IsInRange(Graves.Position, Q.Range))
                    {
                        if (FlatBurstDmg(targetQ) >= targetQ.Health)
                        {
                            if (Q.IsReady())
                            {
                                if (Qpred.Hitchance >= HitChance.High) Q.Cast(targetQ);
                            }
                            if (IsOnCooldown(Q) && W.IsReady())
                            {
                                if (Wpred.Hitchance >= HitChance.Medium) W.Cast(targetW);
                            }
                            if (IsOnCooldown(Q) && IsOnCooldown(W) && R.IsReady())
                            {
                                if (Rpred.Hitchance >= HitChance.High) R.Cast(targetR);

                            }
                        }
                    }
                }
                if (!Q.IsInRange(targetQ) && E.IsReady())
                {
                    E.Cast(targetQ);
                }
            }
        }

        public static bool IsOnCooldown(Spell spell)
        {
            if (!spell.IsReady())
            {
                return true;
            }
            return false;
        }

        public static float FlatBurstDmg(AIHeroClient target)
        {
            var damage = 0;

            if (Q.IsReady())
            {
                damage += (int)Q.GetDamage(target);
            }

            if (W.IsReady())
            {
                damage += (int)W.GetDamage(target);
            }

            if (R.IsReady())
            {
                damage += (int)R.GetDamage(target);
            }

            return damage;
        }

        public static bool UnderAllyTurret(Vector3 pos)
        {
            return ObjectManager.Get<Obj_AI_Turret>().Any(t => t.IsAlly && !t.IsDead && pos.Distance(t) <= 900);
        }

        public static bool UnderEnemyTurret(Vector3 pos)
        {
            return ObjectManager.Get<Obj_AI_Turret>().Any(t => t.IsEnemy && !t.IsDead && pos.Distance(t) <= 900);
        }

        public static bool InSpawnPoint(Vector3 pos)
        {
            return ObjectManager.Get<Obj_SpawnPoint>().Any(x => pos.Distance(x) < 800 && x.IsEnemy);
        }

        public static int CountAlliesInRange(Vector3 pos)
        {
            var allies = ObjectManager.Heroes.Allies.Count(
                allied => !allied.IsDead && allied.Distance(pos) <= 800);
            return allies;
        }

        public static bool IsSafePosition(Vector3 position)
        {
            var enemies = position.CountEnemiesInRange(800);
            var allies = CountAlliesInRange(position);
            var turrets = ObjectManager.Turrets.Ally.Count(x => Graves.Distance(x) < 800 && !x.IsDead && x.IsValid());
            var lowEnemies = GetLowaiAiHeroClients(position, 800).Count;

            if (UnderEnemyTurret(position)) return false;

            if (enemies == 1)
            {
                return true;
            }
            return allies + turrets > enemies - lowEnemies;
        }

        public static List<AIHeroClient> GetLowaiAiHeroClients(Vector3 position, float range)
        {
            return
                ObjectManager.Heroes.Enemies.Where(
                    hero => hero.IsValidTarget() && (hero.Distance(position) <= range) && hero.HealthPercent <= 15)
                    .ToList();
        }
    }
}