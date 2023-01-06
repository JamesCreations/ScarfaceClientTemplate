using CRXCScarfaceClient;
using CRXCScarfaceClient.QuickMenu;
using UnityEngine;

namespace ReMod.Core.Managers
{
    public class UiManager
    {
        public IButtonPage MainMenu { get; }
        public IButtonPage TargetMenu { get; }
        public IButtonPage LaunchPad { get; }

        public UiManager(string menuName, Sprite menuSprite, bool createTargetMenu = true, bool createMainMenu = true)
        {
            this.MainMenu = new ReMenuPage(menuName, true);
            ReTabButton.Create(menuName, "Open the " + menuName + " menu.", menuName, menuSprite);
            if (createTargetMenu)
            {
                ReCategoryPage reCategoryPage = new ReCategoryPage(MenuEx.SelectedUserLocal.transform);
                this.TargetMenu = reCategoryPage.AddCategory(menuName ?? "");
            }
            if (createMainMenu)
            {
                ReCategoryPage reCategoryPage2 = new ReCategoryPage(MenuEx.DashboardMenu.transform);
                this.LaunchPad = reCategoryPage2.AddCategory(menuName ?? "");
            }
        }
    }
}
//Thanks Kami