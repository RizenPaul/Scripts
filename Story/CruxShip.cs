/*
name: Crux Ship Story
description: This will finish the Crux Ship story.
tags: story, quest, crux-ship
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
using Skua.Core.Interfaces;

public class CruxShip
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        StoryLine();

        Core.SetOptions(false);
    }

    public void StoryLine()
    {
        if (Core.isCompletedBefore(4616))
            return;

        Story.PreLoad(this);

        Core.EquipClass(ClassType.Farm);

        //By the Power of the Moon 4598
        Story.KillQuest(4598, "CruxShip", "Shadow Locust");

        //Clear the Swarm 4599
        if (!Story.QuestProgression(4599))
        {
            Core.EnsureAccept(4599);
            Core.KillMonster("CruxShip", "r2", "Left", "Shadow Locust", "Locusts Defeated", 5);
            Story.MapItemQuest(4599, "CruxShip", 3901, 2);
        }

        //Act 1 Complete 4600
        Story.ChainQuest(4600);

        //Defend the Ship! 4601
        Story.ChainQuest(4601);

        //Act 2 Complete 4602
        Story.ChainQuest(4602);

        //Treasure Hunters Attack! 4603
        Story.KillQuest(4603, "CruxShip", "Treasure Hunter");

        //Airship Sabotage 4604
        Story.MapItemQuest(4604, "CruxShip", 3902, 3);

        //Act 3 Complete 4605
        Story.ChainQuest(4605);

        //Plague in the Pyramid 4606
        Story.KillQuest(4606, "CruxShip", "Shadow Locust");

        //The Plaguebringer Appears 4607
        if (!Story.QuestProgression(4607))
        {
            Core.EnsureAccept(4607);
            Core.HuntMonster("CruxShip", "Nokris Plaguebringer", "Norkis Plaugebringer Defeated");
            Core.KillMonster("CruxShip", "r2", "Left", "Shadow Locust", "Locusts Defeated", 3);
            Core.EnsureComplete(4607);
        }

        Story.KillQuest(4610, "CruxShip", new[] { "Ancient Mummy", "Treasure Hunter" });

        //Treasure Hunter's Last Stand 4611
        Story.KillQuest(4611, "CruxShip", new[] { "Treasure Hunter", "Treasure Hunter Captain" });

        //Act 4 Complete 4612
        Story.ChainQuest(4612);

        //Apephyrx Rises 4613
        Core.EquipClass(ClassType.Solo);
        Story.KillQuest(4613, "CruxShip", "Apephryx");

        //Act 5 Complete 4614
        Story.ChainQuest(4614);

        //100 Mummy Massacre 4616
        if (!Story.QuestProgression(4616))
        {
            Core.EquipClass(ClassType.Farm);
            Core.EnsureAccept(4616);
            Core.HuntMonster("Mummies", "Mummy", "Mummy Defeated", 100);
            Core.EnsureComplete(4616);
        }

    }
}
