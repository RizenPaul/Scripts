/*
name: Shadow War
description: This is the first part of the Shadow War story arc. It will take you to the Shadow War area and start the quest.
tags: story, quest, shadow-war
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/Story/ShadowsOfWar/CoreSoW.cs
using Skua.Core.Interfaces;

public class ShadowWar1
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreSoW SoW = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        SoW.ShadowWar();

        Core.SetOptions(false);
    }
}
