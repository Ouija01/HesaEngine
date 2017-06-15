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

namespace SGraves
{
    public class SGraves : IScript
    {
        public string Author => "Ouija";
        public string Name => "SGraves";
        public string Version => "7.12";

        public static Menu Menu;

        public static Spell Q, W, E, R, R1;
        public static AIHeroClient Graves;
        public static Orbwalker.OrbwalkerInstance MyOrb => Core.Orbwalker;

        public void OnInitialize()
        {
            Game.OnGameLoaded += Loading_Onload;
        }

        private void Loading_Onload()
        {
            if (Graves.Hero != Champion.Graves)
            {
                Chat.Print("SGraves: Failed to Load");
                return;
            }

            Game.OnUpdate += GameUpdate;

            CreateMenu();
            CreateSpells();
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
            Q = new Spell(SpellSlot.Q, 900f,TargetSelector.DamageType.Physical);
            W = new Spell(SpellSlot.W, 950f, TargetSelector.DamageType.Physical);
            E = new Spell(SpellSlot.E, 450f, TargetSelector.DamageType.Physical);
            R = new Spell(SpellSlot.R, 1000f, TargetSelector.DamageType.Physical);
            R1 = new Spell(SpellSlot.R, 1500f, TargetSelector.DamageType.Physical);

            Q.SetSkillshot(0.26f, 50f, 1950f, false, SkillshotType.SkillshotLine);
            W.SetSkillshot(0.35f, 250f, 1650f, false, SkillshotType.SkillshotCircle);
            R.SetSkillshot(0.25f, 120f, 2100f, false, SkillshotType.SkillshotLine);
            R1.SetSkillshot(0.26f, 120f, 2100f, false, SkillshotType.SkillshotLine);
        }
    }
}
