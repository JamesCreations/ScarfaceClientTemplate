using CRXCScarfaceClient;
using CRXCui;
using MelonLoader;
using ReMod.Core.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace scarface.menus
{
    public class scarfacemenusbuilder : scarfaceMain
    {

        public static void MenuStart()
        {
            MelonLogger.Msg("Initializing UI...");
            Transform menuParent = MenuEx.MenuParent;

            //The below is code for the image placeholder, use it
            var norm = CyResource.LoadSpriteFromDisk("UserData/CRXC/Resources/normalized.png");
            scarfaceMain.scarfaceui = new UiManager("ScarfaceClient", null, true, true);
            //dont touch this, this allows the module system to work as intended
            scarfaceMain.Menu1 = scarfaceui.MainMenu.AddMenuPage("Module 1", null, norm);

            Menu1.AddButton("Test", null, () =>
            {

            }, norm);



        }

    }
}
