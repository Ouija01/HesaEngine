using HesaEngine.SDK;
using SharpDX.DirectInput;
using static SGraves.SGraves;

namespace SGraves
{
    public class Menus
    {
        public static Menu RootMenu;

        public static void CreateMenu()
        {
            RootMenu = Menu.AddMenu("SGraves");

            var comboMenu = RootMenu.AddSubMenu("Combo");
            comboMenu.Add(new MenuCheckbox("CQ", "Q Usage", true));
            comboMenu.Add(new MenuCheckbox("CW", "W Usage", true));
            comboMenu.Add(new MenuCheckbox("CE", "E Usage", true));
            comboMenu.Add(new MenuCheckbox("CR", "R Usage", true));

            var laneClearMenu = RootMenu.AddSubMenu("Laneclear");
            laneClearMenu.Add(new MenuSlider("LMana", "If mana is under [{0}%] do not use Skills", 0, 100, 30));
            laneClearMenu.Add(new MenuCheckbox("LQ", "Q Usage", true));

            var harassMenu = RootMenu.AddSubMenu("Harass");
            harassMenu.Add(new MenuCheckbox("HQ", "Q Usage", true));
            harassMenu.Add(new MenuCheckbox("HW", "W Usage", true));

            var eSettings = RootMenu.AddSubMenu("E Settings");
            eSettings.AddSeparator("Combo only!");
            eSettings.Add(new MenuCombo("eMode", "E Mode", new string[] {"Cursors", "ToSafeTarget", "None"}, 0));

            var burstCombo = RootMenu.AddSubMenu("Burst");
            burstCombo.AddSeparator("Combo Only");
            burstCombo.Add(new MenuKeybind("burstKey", "Burst Key Hold", Key.T, MenuKeybindType.Hold));

            var drawingsMenu = RootMenu.AddSubMenu("Drawings");
            drawingsMenu.Add(new MenuCheckbox("disableDraw", "Disable all Drawings", false));
            drawingsMenu.AddSeparator("Only if the Spell is Ready");
            drawingsMenu.Add(new MenuCheckbox("qDraw", "Draw Q", true));
            drawingsMenu.Add(new MenuCheckbox("wDraw", "Draw W", true));
            drawingsMenu.Add(new MenuCheckbox("eDraw", "Draw E", false));
            drawingsMenu.Add(new MenuCheckbox("rDraw", "Draw R", true));
            //drawingsMenu.AddSeparator("");
            //drawingsMenu.Add(new MenuCheckbox("targetCircle","Draw Circle around current target",true));
            //drawingsMenu.Add(new MenuCheckbox("burstDmgText", "Draw BurstCombo Damage", false));
        }
    }
}