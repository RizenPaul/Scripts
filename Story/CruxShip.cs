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

    public void StoryLine(bool badge = false)
    {
        if (Core.isCompletedBefore(4614))
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
        if (!Story.QuestProgression(4600))
        {
            Core.Join("cruxship", "Enter", "Spawn");
            //jumping here just autocompletes the quest..
            Core.Jump("Cut1", "Left");
            Bot.Wait.ForQuestComplete(4600);
            Core.Jump("Enter", "Spawn");
        }

        //Defend the Ship! 4601 && Act 2 Complete 4602
        if (!Bot.Quests.IsUnlocked(4603))
        {
            Core.EnsureAcceptmultiple(false, new[] { 4601, 4602 });
            Core.Join("cruxship", "Enter", "Spawn");
            Core.Jump("r5", "Left");
            Core.Sleep(1500);
            Core.SendPackets($"%xt%zm%tryQuestComplete%{Bot.Map.RoomID}%4601%-1%false%1%wvz%");
            Core.Sleep(1500);
            Bot.Wait.ForQuestComplete(4601);
            Core.SendPackets($"%xt%zm%moveToCell%{Bot.Map.RoomID}%Cut2%Left%");
            Core.Sleep(1500);
            Core.SendPackets($"%xt%zm%tryQuestComplete%{Bot.Map.RoomID}%4602%1%false%1%wvz%");
            Bot.Wait.ForQuestComplete(4602);
            Core.Sleep(1500);
            Core.Jump("r6", "Left");
        }

        //Treasure Hunters Attack! 4603
        Story.KillQuest(4603, "CruxShip", "Treasure Hunter");

        //Airship Sabotage 4604
        Story.MapItemQuest(4604, "CruxShip", 3902, 3);

        //Act 3 Complete 4605
        if (!Story.QuestProgression(4605))
        {
            Core.Join("cruxship", "Enter", "Spawn");
            //jumping here just autocompletes the quest..
            Core.Jump("Cut3", "Left");
            Bot.Wait.ForQuestComplete(4605);
        }

        //Plague in the Pyramid 4606
        Story.KillQuest(4606, "CruxShip", "Shadow Locust");

        //The Plaguebringer Appears 4607
        if (!Story.QuestProgression(4607))
        {
            Core.EnsureAccept(4607);
            Core.HuntMonster("CruxShip", "Nokris Plaguebringer", "Nokris Plaguebringer Defeated");
            Core.KillMonster("CruxShip", "r2", "Left", "Shadow Locust", "Locusts Defeated", 3);
            Core.EnsureComplete(4607);
        }

        // Battle to the Temple
        if (!Story.QuestProgression(4610))
        {
            Core.EnsureAccept(4610);
            Core.HuntMonster("CruxShip", "Ancient Mummy", "Mummy Defeated", 12);
            Core.HuntMonster("CruxShip", "Treasure Hunter", "Treasure Hunter Defeated", 8);
            Core.EnsureComplete(4610);
        }

        //Treasure Hunter's Last Stand 4611
        if (!Story.QuestProgression(4611))
        {
            Core.EnsureAccept(4611);
            Core.HuntMonster("CruxShip", "Treasure Hunter Captain", "Captain Defeated");
            Core.HuntMonster("CruxShip", "Treasure Hunter", "Treasure Hunter Defeated", 8);
            Core.EnsureComplete(4611);
        }

        //Act 4 Complete 4612
        if (!Story.QuestProgression(4612))
        {
            Core.Join("cruxship", "Enter", "Spawn");
            //jumping here just autocompletes the quest..
            Core.Jump("Cut4", "Left");
            Bot.Wait.ForQuestComplete(4612);
        }

        //Apephyrx Rises 4613
        if (!Story.QuestProgression(4613))
        {
            Core.EquipClass(ClassType.Solo);
            Core.EnsureAccept(4613);
            Core.HuntMonster("CruxShip", "Apephryx", "Apephryx Defeated");
            Core.EnsureComplete(4613);
        }

        //Act 5 Complete 4614
        if (!Story.QuestProgression(4614))
        {
            //jumping here just autocompletes the quest..
            Core.Jump("Cut5", "Left");
            Bot.Wait.ForQuestComplete(4612);
        }

        if (!badge)
            return;

        //100 Mummy Massacre 4616
        if (!Story.QuestProgression(4616))
        {
            Core.EquipClass(ClassType.Farm);
            Core.EnsureAccept(4616);
            Core.HuntMonster("Mummies", "Mummy", "Mummy Defeated", 100);
            Bot.Wait.ForQuestComplete(4616);
            Core.Sleep(2500);
            if (Core.HasWebBadge("Mummy Slayer"))
                return;
            else Core.EnsureComplete(4616);
        }

    }
}
