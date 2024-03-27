using StardewModdingAPI;

namespace TestMod
{
    public class TestMod : StardewModdingAPI.Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log("Meow!", LogLevel.Info);
        }
    }
}
