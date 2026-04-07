using BepInEx;
using Mod_template;
using UnityEngine;
using Utilla;
using Utilla.Attributes;

namespace MyNewMod
{
    [BepInPlugin("com.mythmodtempalte.mythmodtemplate", "Mod Name", "1.0.0")]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [ModdedGamemode]
    public class MyNewMod : BaseUnityPlugin
    {
        public static bool inRoom = false;

        private void Awake()
        {
            Debug.Log("MY NEW MOD LOADED");
            gameObject.AddComponent<Mod>();
        }

        [ModdedGamemodeJoin]
        private void OnJoin(string gamemode) => inRoom = true;

        [ModdedGamemodeLeave]
        private void OnLeave(string gamemode) => inRoom = false;
    }
}