/*
name: Mouring Flower
description: Mouring Flower
tags: darkon, mouring flower
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Darkon/CoreDarkon.cs
//cs_include Scripts/Story/ElegyofMadness(Darkon)/CoreAstravia.cs
using Skua.Core.Interfaces;

public class MourningFlower
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreDarkon Darkon => new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        Darkon.MourningFlower();

        Core.SetOptions(false);
    }
}
