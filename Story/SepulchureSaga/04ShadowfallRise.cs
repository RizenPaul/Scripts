/*
name: Shadowfall Rise
description: This will finish the Shadowfall Rise quest.
tags: story, quest, sepulchure-saga, shadowfall-rise
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/SepulchureSaga/CoreSepulchure.cs
using Skua.Core.Interfaces;

public class ShadowfallRise
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new();
    public CoreSepulchure CoreSS = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        CoreSS.ShadowfallRise();

        Core.SetOptions(false);
    }

}
