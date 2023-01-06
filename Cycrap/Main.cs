using MelonLoader;
using QuestMod;
using CRXCScarfaceClient;
using CRXCScarfaceClient.QuickMenu;
using CRXCScarfaceClient.Wings;
using ReMod.Core.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;
using UnhollowerRuntimeLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.DataModel;
using VRC.SDKBase;
using VRC.UI.Elements.Menus;
using CRXCui;
using VRC.UI.Elements;
using scarface;
using scarface.menus;

//it is important that you give this a unique name
namespace CRXCScarfaceClient
{

    public class scarfaceMain : MelonMod
    {
        public static GameObject UserInterface; 
        public static UiManager scarfaceui;
        public const string version = "Beta 0.0.0.1"; 
       // private static ReMenuPage targetPageMenu;
       public static ReMenuPage Menu1;
       // private static ReMenuPage itemmodule;

        public override void OnApplicationStart()
        {
            MelonLogger.Msg(ConsoleColor.Red,"[Application Start] ScarfaceClient Quest Only By James reborn");
            startWaitForUI();
        }


        public void OnMenuStart()
        {
            scarfacemenusbuilder.MenuStart();
        }

        public void startWaitForUI()
        {
            ClassInjector.RegisterTypeInIl2Cpp<EnableDisableListener>();
            MelonCoroutines.Start(WaitForUI());
        }


       
         private IEnumerator WaitForUI()
            {
                while (ReferenceEquals(VRCUiManager.field_Private_Static_VRCUiManager_0, null)) yield return null; // wait till VRCUIManger isnt null
                foreach (var GameObjects in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (GameObjects.name.Contains("UserInterface"))
                    {
                        UserInterface = GameObjects;
                    }
                }

                while (ReferenceEquals(MenuEx.Instance, null)) yield return null;
                OnMenuStart();
                yield break;
            }
        }

        


       

    }

