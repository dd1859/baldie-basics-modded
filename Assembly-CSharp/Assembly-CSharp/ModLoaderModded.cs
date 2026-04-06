// ModLoaderModded.cs - A mod loader system for Baldi Basics

using System;
using System.Collections.Generic;

namespace BaldiBasicsModLoader
{
    public class ModLoader
    {
        private List<IMod> mods;

        public ModLoader()
        {
            mods = new List<IMod>();
        }

        public void LoadMods()
        {
            // Load mods from the mods directory
            foreach (var mod in mods)
            {
                mod.Initialize();
            }
        }

        public void RegisterMod(IMod mod)
        {
            mods.Add(mod);
        }
    }

    public interface IMod
    {
        void Initialize();
    }
}
