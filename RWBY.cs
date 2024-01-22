using Terraria.ModLoader;

namespace RWBY
{
	public class RWBY : Mod
	{

        private static ModKeybind TransformHotKey;

        public override void Load()
        {
            TransformHotKey = KeybindLoader.RegisterKeybind(this, "Transform Weapon", "Q");

            base.Load();
        }

        public static ModKeybind GetTransformHotKey() { return TransformHotKey; }

        public override void Unload()
        {
            TransformHotKey = null;

            base.Unload();
        }
    }
}