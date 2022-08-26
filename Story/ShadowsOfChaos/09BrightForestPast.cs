//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/ShadowsOfChaos/CoreSoC.cs

using Skua.Core.Interfaces;

public class BrightForestPast
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new();
    public SoC SoC = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();
        SoC.BrightForestPast();
        Core.SetOptions(false);
    }
}
