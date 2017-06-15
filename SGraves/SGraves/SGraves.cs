using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;

using static SGraves.Combo;
using static SGraves.Lane;
using static SGraves.Menus;
using static SGraves.Harass;
using static SGraves.Drawings;

namespace SGraves
{
    public class SGraves : IScript
    {
        public string Author => "Ouija";
        public string Name => "SGraves";
        public string Version => "7.12";

        public static Spell Q, W, E, R, R1;
        public static AIHeroClient Graves => ObjectManager.Player;
        public static Orbwalker.OrbwalkerInstance MyOrb => Core.Orbwalker;

        public void OnInitialize()
        {
            Game.OnGameLoaded += LoadComplete;
        }

        private void LoadComplete()
        {
            if (ObjectManager.Player.Hero != Champion.Graves) return;
            Chat.Print("SGraves: Loaded");

            CreateMenu();

            CreateSpells();
            CreateDraw();

            Game.OnUpdate += GameUpdate;
        }

        private void GameUpdate()
        {
            switch (MyOrb.ActiveMode)
            {
                case Orbwalker.OrbwalkingMode.Combo:
                    ComboExec();
                    break;
                case Orbwalker.OrbwalkingMode.LaneClear:
                    LaneExec();
                    break;
                case Orbwalker.OrbwalkingMode.Harass:
                    HarassExec();
                    break;
            }
        }

        private void CreateSpells()
        {
            Q = new Spell(SpellSlot.Q, 900,TargetSelector.DamageType.Physical);
            W = new Spell(SpellSlot.W, 950, TargetSelector.DamageType.Physical);
            E = new Spell(SpellSlot.E, 450, TargetSelector.DamageType.Physical);
            R = new Spell(SpellSlot.R, 1000, TargetSelector.DamageType.Physical);

            Q.SetSkillshot(0.26f, 50f, 1950f, false, SkillshotType.SkillshotLine);
            W.SetSkillshot(0.35f, 250f, 1650f, false, SkillshotType.SkillshotCircle);
            R.SetSkillshot(0.25f, 120f, 2100f, false, SkillshotType.SkillshotLine);
        }
    }
}
