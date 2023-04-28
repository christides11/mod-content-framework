using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
#if MCF_UMOD_SUPPORT
using UMod;
#endif

namespace mcf
{
    [System.Serializable]
    public class ModLoader : MonoBehaviour
    {
        public delegate void ModActionDelegate(ModLoader modLoader, string modNamespace);
        public static event ModActionDelegate OnModLoaded;
        public static event ModActionDelegate OnModLoadUnsuccessful;

        public static string modsLoadedFileName = "loadedmods.json";
        public static readonly string bepinModsLoadedFileName = "enabled.txt";

        /// <summary>
        /// A list of all mods in the Mods folder.
        /// </summary>
        public List<ModInfo> modList = new List<ModInfo>();
        public Dictionary<string, ModInfo> modListByNamespace = new Dictionary<string, ModInfo>();
        /// <summary>
        /// A list of all currently enabled mods.
        /// </summary>
        public Dictionary<uint, LoadedModDefinition> loadedModsByID = new Dictionary<uint, LoadedModDefinition>();
        /// <summary>
        /// The path where mods are installed.
        /// </summary>
        public string modInstallPath = "";
#if MCF_UMOD_SUPPORT
        public ModDirectory modDirectory = null;
#endif

        public Dictionary<uint, string> modIDToNamespace = new Dictionary<uint, string>();
        public Dictionary<string, uint> modNamespaceToID = new Dictionary<string, uint>();

        public virtual async UniTask Initialize()
        {
            // Initialize paths.
            modInstallPath = Path.Combine(Application.persistentDataPath, "Mods");

            Directory.CreateDirectory(modInstallPath);
#if MCF_UMOD_SUPPORT
            modDirectory = new ModDirectory(modInstallPath, true, false);
            Mod.DefaultDirectory = modDirectory;
#endif
            await RefreshModList();
        }

        public virtual async UniTask RefreshModList()
        {

        }

        #region Loading
        public virtual async UniTask LoadAllMods()
        {
            foreach (ModInfo mi in modList)
            {
                await LoadMod(mi);
            }
        }

        public virtual async UniTask<List<string>> LoadMods(List<string> identifiers)
        {
            List<string> notLoaded = new List<string>();
            for (int i = 0; i < identifiers.Count; i++)
            {
                if (!(await LoadMod(identifiers[i])))
                {
                    notLoaded.Add(identifiers[i]);
                }
            }
            return notLoaded;
        }

        public virtual async UniTask<bool> LoadMod(string modNamespace)
        {
            return false;
        }

        public virtual async UniTask<bool> LoadMod(ModInfo modInfo)
        {
            return false;
        }
        #endregion

        #region Unloading
        public virtual void UnloadMod(string modNamespace)
        {
            if (!modNamespaceToID.ContainsKey(modNamespace)) return;
            UnloadMod(modNamespaceToID[modNamespace]);
        }

        public virtual void UnloadMod(uint modID)
        {
            if (!loadedModsByID.ContainsKey(modID)) return;
            loadedModsByID[modID].Unload();
            loadedModsByID.Remove(modID);
        }
        #endregion

        public virtual bool TryGetLoadedMod(string modID, out LoadedModDefinition loadedMod)
        {
            loadedMod = null;
            if (!modNamespaceToID.ContainsKey(modID)) return false;
            if (!TryGetLoadedMod(modNamespaceToID[modID], out loadedMod)) return false;
            return true;
        }

        public virtual bool TryGetLoadedMod(uint modID, out LoadedModDefinition loadedMod)
        {
            if (!loadedModsByID.TryGetValue(modID, out loadedMod)) return false;
            return true;
        }

        public virtual bool IsLoaded(uint modID)
        {
            return loadedModsByID.ContainsKey(modID);
        }

        public virtual ModInfo GetModInfo(uint modID)
        {
            if (!modIDToNamespace.ContainsKey(modID)) return null;
            return GetModInfo(modIDToNamespace[modID]);
        }

        public virtual ModInfo GetModInfo(string modNamespace)
        {
            if (!modListByNamespace.ContainsKey(modNamespace)) return null;
            return modListByNamespace[modNamespace];
        }
    }
}