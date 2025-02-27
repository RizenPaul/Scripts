/*
name: Member Farms Kit
description: This kit contains all Member farms that you can profit off after your membership expires
tags: member, kit, expire, legend
*/
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreDailies.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Dailies/0AllDailies.cs
//cs_include Scripts/Dailies/LordOfOrder.cs
//cs_include Scripts/Enhancement/InventoryEnhancer.cs
//cs_include Scripts/Good/ArchPaladin.cs
//cs_include Scripts/Good/BLoD/CoreBLOD.cs
//cs_include Scripts/Good/GearOfAwe/CapeOfAwe.cs
//cs_include Scripts/Good/GearOfAwe/CoreAwe.cs
//cs_include Scripts/Good/Paladin.cs
//cs_include Scripts/Hollowborn/MergeShops/ShadowrealmMerge.cs
//cs_include Scripts/Dailies/MineCrafting.cs
//cs_include Scripts/Enhancement/UnlockForgeEnhancements.cs
//cs_include Scripts/Nation/AssistingCragAndBamboozle[Mem].cs
//cs_include Scripts/Nation/CoreNation.cs
//cs_include Scripts/Nation/VHL/CoreVHL.cs
//cs_include Scripts/Other/Classes/DragonShinobi.cs
//cs_include Scripts/Other/Classes/REP-based/EternalInversionist.cs
//cs_include Scripts/Other/Classes/REP-based/GlacialBerserker.cs
//cs_include Scripts/Other/Classes/REP-based/Shaman.cs
//cs_include Scripts/Other/Classes/REP-based/StoneCrusher.cs
//cs_include Scripts/Other/Classes/ScarletSorceress.cs
//cs_include Scripts/Other/Classes/BloodSorceress.cs
//cs_include Scripts/Other/FreeBoosts/FreeBoostsQuest(10mns)[Rng].cs
//cs_include Scripts/Other/Weapons/BurningBladeOfAbezeth.cs
//cs_include Scripts/Other/Weapons/BurningBlade.cs
//cs_include Scripts/Other/Weapons/DualChainSawKatanas.cs
//cs_include Scripts/Other/Weapons/EnchantedVictoryBladeWeapons.cs
//cs_include Scripts/Story/BattleUnder.cs
//cs_include Scripts/Story/DragonFableOrigins.cs
//cs_include Scripts/Story/Glacera.cs
//cs_include Scripts/Story/LordsofChaos/Core13LoC.cs
//cs_include Scripts/Story/Nation/CitadelRuins.cs
//cs_include Scripts/Story/QueenofMonsters/Extra/BrightOak.cs
//cs_include Scripts/Story/ThroneofDarkness/CoreToD.cs
//cs_include Scripts/Story/Tutorial.cs
//cs_include Scripts/Story/XansLair.cs
//cs_include Scripts/Story/Yokai.cs
//cs_include Scripts/Other/FarmJoeKits/CoreFarmerJoe.cs
//cs_include Scripts/Tools/BankAllItems.cs
//cs_include Scripts/Story/Friendship.cs
//cs_include Scripts/Other/Classes/REP-based/MasterRanger.cs
//cs_include Scripts/Evil/SDKA/CoreSDKA.cs
//cs_include Scripts/Legion/SwordMaster.cs
//cs_include Scripts/Legion/YamiNoRonin/CoreYnR.cs
//cs_include Scripts/Legion/CoreLegion.cs
//cs_include Scripts/Story/ShadowsOfWar/CoreSoW.cs
//cs_include Scripts/Other/MergeShops/SynderesMerge.cs
//cs_include Scripts/Other/Classes/REP-based/DarkbloodStormKing.cs
//cs_include Scripts/Nation/Various/ArchfiendDeathLord.cs
//cs_include Scripts/Story/Nation/Originul.cs
//cs_include Scripts/Story/Nation/Fiendshard.cs
//cs_include Scripts/Nation/AFDL/WillpowerExtraction.cs
//cs_include Scripts/Darkon/CoreDarkon.cs
//cs_include Scripts/Other/Weapons/GoldenBladeOfFate.cs
//cs_include Scripts/Other/Weapons/PinkBladeofDestruction.cs
//cs_include Scripts/Story/Doomwood/CoreDoomwood.cs
//cs_include Scripts/Story/QueenofMonsters/CoreQoM.cs
//cs_include Scripts/Story/7DeadlyDragons/Core7DD.cs
//cs_include Scripts/Other/MysteriousEgg.cs
//cs_include Scripts/Story/Summer2015AdventureMap/CoreSummer.cs
//cs_include Scripts/Story/Borgars.cs
//cs_include Scripts/Story/ElegyofMadness(Darkon)/CoreAstravia.cs
//cs_include Scripts/Other/Classes/DragonOfTime.cs
//cs_include Scripts/Story/AgeofRuin/CoreAOR.cs
//cs_include Scripts/Other/MergeShops/YulgarsUndineMerge.cs
//cs_include Scripts/Hollowborn/MergeShops/DawnFortressMerge.cs
//cs_include Scripts/Story/Hollowborn/CoreHollowbornStory.cs
//cs_include Scripts/Other/MergeShops/CelestialChampMerge.cs
//cs_include Scripts/Story/QueenofMonsters/Extra/CelestialArena.cs
//cs_include Scripts/Other/Classes/Daily-Classes/BlazeBinder.cs
//cs_include Scripts/Nation/Various/Archfiend.cs
//cs_include Scripts/Evil/NSoD/CoreNSOD.cs
//cs_include Scripts/Other/Classes/Necromancer.cs
//cs_include Scripts/Dailies/Cryomancer.cs
//cs_include Scripts/ShadowsOfWar/CoreSoWMats.cs
//cs_include Scripts/Story/SepulchureSaga/CoreSepulchure.cs
//cs_include Scripts/Other/Armor/FireChampionsArmor.cs
//cs_include Scripts/Chaos/EternalDrakathSet.cs
//cs_include Scripts/Evil/SepulchuresOriginalHelm.cs
//cs_include Scripts/Darkon/Various/PrinceDarkonsPoleaxePreReqs.cs
//cs_include Scripts/Legion/HeadOfTheLegionBeast.cs
//cs_include Scripts/Good/GearOfAwe/Awescended.cs
//cs_include Scripts/Nation/AFDL/NulgathDemandsWork.cs
//cs_include Scripts/Story/ThirdSpell.cs
//cs_include Scripts/Story/Legion/SevenCircles(War).cs
//cs_include Scripts/Nation/Various/PrimeFiendShard.cs
//cs_include Scripts/Other/Armor/MalgorsArmorSet.cs
//cs_include Scripts/Good/GearOfAwe/ArmorOfAwe.cs
//cs_include Scripts/Story/StarSinc.cs
//cs_include Scripts/Nation/Various/VoidPaladin.cs
//cs_include Scripts/Good/GearOfAwe/HelmOfAwe.cs
//cs_include Scripts/Seasonal/StaffBirthdays/Nulgath/TempleDelveMerge.cs
//cs_include Scripts/Story/Nation/VoidRefuge.cs
//cs_include Scripts/Nation/MergeShops/VoidRefugeMerge.cs
//cs_include Scripts/Seasonal/StaffBirthdays/Nulgath/TempleDelve.cs
//cs_include Scripts/Seasonal/StaffBirthdays/Nulgath/TempleSiege.cs
//cs_include Scripts/Nation/Various/TheLeeryContract[Member].cs
//cs_include Scripts/Nation/Various/JuggernautItems.cs
//cs_include Scripts/Nation/MergeShops/NulgathDiamondMerge.cs
//cs_include Scripts/Nation/Various/TarosManslayer.cs
//cs_include Scripts/Nation/Various/PurifiedClaymoreOfDestiny.cs
//cs_include Scripts/Nation/Various/VoidSpartan.cs
//cs_include Scripts/Nation/Various/SwirlingTheAbyss.cs
//cs_include Scripts/Hollowborn/TradingandStuff(single).cs
//cs_include Scripts/Nation/EmpoweringItems.cs
//cs_include Scripts/Other/Weapons/VoidAvengerScythe.cs
//cs_include Scripts/Nation/Various/GoldenHanzoVoid.cs
//cs_include Scripts/Nation/MergeShops/DilligasMerge.cs
//cs_include Scripts/Nation/MergeShops/DirtlickersMerge.cs
//cs_include Scripts/Other/Weapons/WrathofNulgath.cs
//cs_include Scripts/Nation/MergeShops/VoidChasmMerge.cs
//cs_include Scripts/Story/Nation/VoidChasm.cs
//cs_include Scripts/Nation/MergeShops/NationMerge.cs
//cs_include Scripts/Nation/NationLoyaltyRewarded.cs
//cs_include Scripts/Story/Legion/DarkWarLegionandNation.cs
//cs_include Scripts/Hollowborn/CoreHollowborn.cs
//cs_include Scripts/Other/Classes/DragonslayerGeneral.cs
//cs_include Scripts/ShadowsOfWar/MergeShops/DeadLinesMerge.cs
//cs_include Scripts/Other/WarFuryEmblem.cs
//cs_include Scripts/ShadowsOfWar/MergeShops/ShadowflameFinaleMerge.cs
//cs_include Scripts/ShadowsOfWar/MergeShops/TimekeepMerge.cs
//cs_include Scripts/Chaos/DrakathsArmor.cs
//cs_include Scripts/ShadowsOfWar/MergeShops/StreamwarMerge.cs
//cs_include Scripts/ShadowsOfWar/MergeShops/WorldsCoreMerge.cs
//cs_include Scripts/ShadowsOfWar/MergeShops/ManaCradleMerge.cs
//cs_include Scripts/Other/ShadowDragonDefender.cs
//cs_include Scripts/Other/Weapons/ShadowReaperOfDoom.cs
//cs_include Scripts/Story/J6Saga.cs
//cs_include Scripts/Evil/ADK.cs
//cs_include Scripts/Good/SilverExaltedPaladin.cs
//cs_include Scripts/Story/7DeadlyDragons/Extra/HatchTheEgg.cs
//cs_include Scripts/Story/Nation/Bamboozle.cs
//cs_include Scripts/Story/DjinnGate.cs
//cs_include Scripts/Other/Weapons/FortitudeAndHubris.cs
//cs_include Scripts/Other/Weapons/ExaltedApotheosisPreReqs.cs
//cs_include Scripts/Seasonal/Friday13th/TrobbolierPet[mem].cs
//cs_include Scripts/Seasonal/Friday13th/Story/CoreFriday13th.cs
//cs_include Scripts/Other/CoinCollectorSet[Member].cs
//cs_include Scripts/Seasonal/Friday13th/TheLostKnightAndBackupBlade[Mem].cs
//cs_include Scripts/Seasonal/Friday13th/SpellRaiser[Mem].cs
//cs_include Scripts/Nation/Various/ArchfiendDragonEgg[Mem].cs
//cs_include Scripts/Nation/Various/DragonBlade[mem].cs
//cs_include Scripts/Other/MergeShops/BonecastleTowerMerge.cs
//cs_include Scripts/Other/Classes/Curio-Classes/LegendaryElementalWarrior[mem].cs
//cs_include Scripts/Other/Classes/Members-CLasses/ChronoAssassin[Mem].cs
//cs_include Scripts/Other/MergeShops/TachyonMerge.cs
//cs_include Scripts/Story/CruxShip.cs
//cs_include Scripts/Nation/Various/TendurrrTheAssistantQuests.cs
//cs_include Scripts/Nation/Various/TarosPrismaticManslayers.cs
//cs_include Scripts/Nation/EvolvedOrb/EvolvedShadowOrb[Mem].cs
using Skua.Core.Interfaces;

public class MemberFarm
{
    private IScriptInterface Bot => IScriptInterface.Instance;
    private CoreBots Core => CoreBots.Instance;
    private CoreAdvanced Adv = new();
    private CoreNation Nation = new();
    private CoreSDKA SDKA = new();
    private TrobbolierPet Trobbolier = new();
    private CoinCollectorSet CoinCollector = new();
    private TheLostKnightAndBackupBlade LostKnight = new();
    private SpellRaiser SpellRaiser = new();
    private ArchfiendDragonEgg ArchfiendDragonPet = new();
    private DragonBladeofNulgath DBoN = new();
    private BonecastleTowerMerge BonecastleTowerMerge = new();
    private LegendaryElementalWarrior LegendaryElementalWarrior = new();
    private ChronoAssassin ChronoAssassin = new();
    private TachyonMerge Tachyon = new();
    private CoreQOM QOM = new();
    private DragonFableOrigins DFO = new();
    private CruxShip Crux = new();
    private TendurrrTheAssistantQuests Tendurr = new();
    private TarosPrismaticManslayers TarosItems = new();
    private EvolvedShadowOrb ShadowOrb = new();

    public void ScriptMain(IScriptInterface Bot)
    {
        Core.SetOptions();

        DoAll();

        Core.SetOptions(false);
    }

    public void DoAll()
    {
        if (!Core.IsMember)
        {
            Core.Logger("This script is Member-Only", messageBox: true);
            return;
        }

        //Core Farm
        SDKA.DoAll();
        Core.ToBank(SDKA.SDKAItems);

        DragonBlade();
        Core.ToBank("DragonBlade of Nulgath", "Legion DragonBlade of Nulgath", "Ebony DragonBlade of Nulgath", "Dual DragonBlades of Nulgath");

        LegendaryElementalWarrior.GetLEW();
        Core.ToBank("Legendary Elemental Warrior");

        //Nation Item
        // TarosItems.TemptationTest();
        Core.ToBank("Taro's Prismatic Manslayer", "Taro's Dual Prismatic Manslayers", "Taro's BattleBlade");

        ArchfiendDragonPet.GetAFDE();
        Core.ToBank("ArchFiend Baby Dragon Pet");

        ShadowOrb.GetEvolvedShadowOrb();
        Core.ToBank("Evolved Shadow Orb");

        Tendurr.TendurrItems();
        Core.ToBank(Tendurr.Rewards);

        //Evolved Orb Item Quest (Need ACs for this quest)

        Core.ToBank(Nation.bagDrops);

        //Free AC Items on Member quest/shop
        CoinCollector.GetItems();
        BabyDragonOfAwe();
        FireWar();
        CruxVIPWeapon();
        DeepForestItems();
        DualWield();

        //Free AC Items on Member Area
        HuntingMonster();
        SpellRaiser.GetAll();
        LostKnight.GetAll();
        Trobbolier.GetAll();

        //MergeShops - not working until find efficient method
        TachyonMerge();
        BoneTowerMerge();

        //Class
        ChronoAssassin.GetChronoAss();
        Core.ToBank("Chrono Assassin");

        //Deadfly.BuyAllMerge();
        //GonnaGetcha.BuyAllMerge();
        //Oddities.BuyAllMerge();
    }


    public void DragonBlade()
    {
        if (!Core.CheckInventory("DragonBlade of Nulgath", toInv: false) &&
            Core.CheckInventory(new[] { "Ebony DragonBlade of Nulgath", "Legion DragonBlade of Nulgath", "Dual DragonBlades of Nulgath" }, 1, true, false))
        {
            Core.Logger("You already have DBoN but it's not in your inventory/bank, please check your buyback menu");
            return;
        }

        DBoN.GetDragonBlade();
    }

    public void CruxVIPWeapon()
    {
        if (Core.CheckInventory("Darkwave Khopesh", toInv: false))
        {
            Core.ToBank("Darkwave Khopesh");
            return;
        }

        Crux.StoryLine();

        Core.AddDrop("Darkwave Khopesh");
        Core.EquipClass(ClassType.Solo);
        Core.FarmingLogger("Darkwave Khopesh", 1);

        Core.RegisterQuests(4618);
        while (!Bot.ShouldExit && (!Core.CheckInventory("Darkwave Khopesh")))
        {
            Core.HuntMonster("cruxship", "Apephryx", "Khopesh Shard", 1, isTemp: false);
            Bot.Wait.ForPickup("Darkwave Khopesh");
        }
        Core.CancelRegisteredQuests();

        Core.ToBank("Darkwave Khopesh");
    }


    public void FireWar()
    {
        if (Core.CheckInventory("Ignited Guardian's Accoutrements", toInv: false))
        {
            Core.ToBank("Ignited Guardian's Accoutrements");
            return;
        }

        DFO.GreatFireWar();
        Core.BuyItem("firewar", 1586, "Flame Guardian's Accoutrements");

        Core.EquipClass(ClassType.Solo);
        Core.HuntMonster("firewar", "Uriax", "Dragon Eye", 2, isTemp: false);

        Core.AddDrop("Dragon Flame");
        Core.FarmingLogger("Dragon Flame", 1);
        Core.EquipClass(ClassType.Farm);
        Core.RegisterQuests(6300);

        while (!Bot.ShouldExit && (!Core.CheckInventory("Dragon Flame", 25)))
        {
            Core.HuntMonster("firewar", "Fire Dragon", "Fire Dragon Slain", 3);
            Core.KillMonster("firewar", "r8", "Left", "Inferno Dragon", "Inferno Dragon Slain", 2);
            Bot.Wait.ForPickup("Dragon Flame");
        }
        Core.BuyItem("firewar", 1587, "Ignited Guardian's Accoutrements");
        Core.ToBank("Ignited Guardian's Accoutrements");
    }


    public void DeepForestItems()
    {
        QOM.TheBook();

        if (!Core.CheckInventory("Polished Necrotic Blade of Chaos", toInv: false))
        {
            Core.BuyItem("castleundead", 45, "Necrotic Blade of Chaos");
            Adv.BuyItem("deepforest", 1999, "Gold Voucher 500k", 4);
            Core.BuyItem("deepforest", 1999, "Polished Necrotic Blade of Chaos");
        }
        Core.ToBank("Polished Necrotic Blade of Chaos");

        if (!Core.CheckInventory("Polished Dragon Sword of Chaos", toInv: false))
        {
            Core.BuyItem("castleundead", 45, "Dragon Sword of Chaos");
            Adv.BuyItem("deepforest", 1999, "Gold Voucher 500k", 4);
            Core.BuyItem("deepforest", 1999, "Polished Dragon Sword of Chaos");
        }
        Core.ToBank("Polished Dragon Sword of Chaos");
    }


    public void DualWield()
    {
        if (!Core.CheckInventory("Golden 8th Birthday Candle"))
            Core.BuyItem(Bot.Map.Name, 1317, "Golden 8th Birthday Candle");
        Core.Sleep(1500);
        if (!Core.CheckInventory("Golden 8th Birthday Candle"))
        {
            Core.Logger("Golden Candle not found - skip dual wield script.");
            return;
        }

        while (!Bot.ShouldExit && (!Core.CheckInventory("Weapon Reflection", 12)))
        {
            Core.EnsureAccept(5518);
            Core.HuntMonster("nostalgiaquest", "Skeletal Viking", "Reflected Glory", 5);
            Core.HuntMonster("nostalgiaquest", "Skeletal Warrior", "Divided Light", 5);
            Core.EnsureComplete(5518);
            Bot.Wait.ForPickup("Weapon Reflection");
        }

        //Boom Went The Dynamite
        if (!Core.CheckInventory("Dual Boom Went The Dynamite", toInv: false))
        {
            if (!Core.CheckInventory("Boom Went The Dynamite"))
            {
                Core.EquipClass(ClassType.Solo);
                Core.HuntMonster("banished", "Desterrat Moya", "Boom Went The Dynamite", isTemp: false);
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Boom Went The Dynamite");
        }
        Core.ToBank("Dual Boom Went The Dynamite");

        //Unarmed
        if (!Core.CheckInventory("Dual Unarmed", toInv: false))
        {
            if (!Core.CheckInventory("Unarmed"))
            {
                Adv.BuyItem(Bot.Map.Name, 1536, "Unarmed");
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Unarmed");
        }
        Core.ToBank("Dual Unarmed");

        //Leviasea Sword
        if (!Core.CheckInventory("Dual Leviasea Sword", toInv: false))
        {
            if (!Core.CheckInventory("Leviasea Sword"))
            {
                Adv.BuyItem("yulgar", 69, "Leviasea Sword");
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Leviasea Sword");
        }
        Core.ToBank("Dual Leviasea Sword");

        //Ddog Sea Serpent Sword
        if (!Core.CheckInventory("Dual Ddog Sea Serpent Sword", toInv: false))
        {
            if (!Core.CheckInventory("Ddog Sea Serpent Sword"))
            {
                Core.EnsureAccept(554);
                Nation.FarmUni13(1);
                Core.HuntMonster("underworld", "Undead Legend", "Undead Legend Rune", log: false);
                Core.EnsureCompleteChoose(554, new[] { "Ddog Sea Serpent Sword" });
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Leviasea Sword");
        }
        Core.ToBank("Dual Ddog Sea Serpent Sword");

        //Soulreaper of Nulgath
        if (!Core.CheckInventory("Dual Soulreaper of Nulgath", toInv: false))
        {
            if (!Core.CheckInventory("Soulreaper of Nulgath"))
            {
                Core.AddDrop("Soulreaper of Nulgath");
                Core.EnsureAccept(571);
                if (!Core.CheckInventory("Godly Golden Dragon Axe"))
                {
                    Core.EnsureAccept(554);
                    Nation.FarmUni13(1);
                    Core.HuntMonster("underworld", "Undead Legend", "Undead Legend Rune", log: false);
                    Core.EnsureCompleteChoose(554, new[] { "Godly Golden Dragon Axe" });
                }
                Nation.FarmDiamondofNulgath(10);
                Nation.FarmDarkCrystalShard(5);
                Nation.SwindleBulk(5);
                Nation.FarmUni13(1);
                Core.EquipClass(ClassType.Solo);
                if (!Core.CheckInventory("Abaddon's Terror"))
                    Core.HuntMonster("twilight", "Abaddon", "Abaddon's Terror", isTemp: false);
                Core.EnsureComplete(571);
                Bot.Wait.ForPickup("Soulreaper of Nulgath");
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Soulreaper of Nulgath");
        }
        Core.ToBank("Dual Soulreaper of Nulgath");

        //Godly Mace of the Ancients
        if (!Core.CheckInventory("Dual Godly Mace of the Ancients", toInv: false))
        {
            if (!Core.CheckInventory("Godly Mace of the Ancients"))
            {
                Adv.BuyItem("citadel", 44, "Godly Mace of the Ancients");
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Godly Mace of the Ancients");
        }
        Core.ToBank("Dual Godly Mace of the Ancients");

        //Balor's Cruelty
        if (!Core.CheckInventory("Dual Balor's Cruelty", toInv: false))
        {
            if (!Core.CheckInventory("Balor's Cruelty"))
            {
                Core.EquipClass(ClassType.Solo);
                Core.HuntMonster("twilight", "Abaddon", "Balor's Cruelty", isTemp: false);
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Balor's Cruelty");
        }
        Core.ToBank("Dual Balor's Cruelty");

        //Abaddon's Terror
        if (!Core.CheckInventory("Dual Abaddon's Terrors", toInv: false))
        {
            if (!Core.CheckInventory("Abaddon's Terror"))
            {
                Core.EquipClass(ClassType.Solo);
                Core.HuntMonster("twilight", "Abaddon", "Abaddon's Terror", isTemp: false);
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Abaddon's Terrors");
        }
        Core.ToBank("Dual Abaddon's Terrors");

        //Mighty Sword Of The Dragons
        if (!Core.CheckInventory("Dual Mighty Sword Of The Dragons", toInv: false))
        {
            if (!Core.CheckInventory("Mighty Sword Of The Dragons"))
            {
                Core.EquipClass(ClassType.Solo);
                Core.AddDrop("Zellare's Death Scale", "Moganth's Death Scale", "Udaroth's Death Scale", "Cellot's Death Scale", "Mighty Sword Of The Dragons");
                Core.RegisterQuests(3343);
                Bot.Quests.UpdateQuest(1416);
                while (!Bot.ShouldExit && !Core.CheckInventory("Mighty Sword Of The Dragons"))
                {
                    Core.HuntMonster("wind", "Cellot", "Cellot's Death Scale", isTemp: false);
                    Core.HuntMonster("fire", "Zellare", "Zellare's Death Scale", isTemp: false);
                    Core.HuntMonster("water", "Udaroth", "Udaroth's Death Scale", isTemp: false);
                    Core.HuntMonster("dragonplane", "Moganth", "Moganth's Death Scale", isTemp: false);
                }
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Mighty Sword Of The Dragons");
        }
        Core.ToBank("Dual Mighty Sword Of The Dragons");

        //Frostbite
        if (!Core.CheckInventory("Dual Frostbite", toInv: false))
        {
            if (!Core.CheckInventory("Frostbite"))
            {
                Adv.BuyItem("blindingsnow", 236, "Frosted Falchion");
                Adv.BuyItem("underworld", 238, "Frostbite");
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual Frostbite");
        }
        Core.ToBank("Dual Frostbite");

        //DragonBlade of Nulgath
        if (!Core.CheckInventory("Dual DragonBlades of Nulgath", toInv: false))
        {
            if (!Core.CheckInventory("DragonBlade of Nulgath"))
            {
                Core.Logger("You don't have DBoN on your inventory/bank, please check your buyback menu");
                return;
            }
            Adv.BuyItem("nostalgiaquest", 1311, "Dual DragonBlades of Nulgath");
        }
        Core.ToBank("Dual DragonBlades of Nulgath");

        //Phoenix Blade of Nulgath (Pseudo-Rare Item)
    }

    public void BabyDragonOfAwe()
    {
        if (Core.CheckInventory("Baby Dragon of Awe", toInv: false))
        {
            Core.ToBank("Baby Dragon of Awe");
            return;
        }

        if (!Core.CheckInventory("Guardian Patent"))
            Core.BuyItem("museum", 53, "Guardian Patent");
        Core.Sleep(1500);
        if (!Core.CheckInventory("Guardian Patent"))
        {
            Core.Logger("Guardian Patent not found - skip Baby Dragon of Awe script");
            return;
        }

        Core.BuyItem("battleon", 10, "Baby Red Dragon");
        Core.BuyItem("museum", 632, "Baby Dragon of Awe");
    }

    public void HuntingMonster()
    {
        GetItems("rotfinger", "rotfinger", "Horned Meat Horror Helm", "Macabre Horror Hammer", "Macabre Meat Horror", "Macabre Meat Ripper", "Macabre Meat Slicer", "Rotfinger's ArmBlades", "Rotfinger's Bow", "Rotfinger's Scythe", "Rotfinger's Staff", "Scream of Agony");
        GetItems("bonebreak", "Killek BoneBreaker", "Axe of Boneshearing", "Dark BonePiercer Spikes", "Killek BoneBreaker");
        GetItems("bonebreak", "Unbroken Minion", "Berserker Minion Mace");
        GetItems("bonebreak", "Undead Berserker", "Berserker Minion Skull Mace");
        GetItems("bonebreak", "Bonebreaker", "Undead Berserker Guard", "Undead Berserker Guard Helm");
        GetItems("deadfly", "Deadfly", "BlackSkulls Knuckle", "Deadfly Morph", "Deadfly's Armor", "Dual BlackSkulls Knuckles");
        GetItems("oddities", "Cursed Spirit", "Cursed Spirit Hunter", "Reaver of Wrath", "Scary Machete", "Scary Machetes", "Spirit Scythe of Wrath", "Spooky Spirit Hunter", "Spooky Spirit Hunter Hat", "Spooky Spirit Hunter Hat + Locks", "Spooky Spirit Hunter Hood", "Unlucky Farmer", "Unlucky Farmer's Hood", "Unlucky Portal Cape");
        GetItems("wormhole", "Trobbolegion", "Blue Trobbolier Morph", "Gold Trobbolier Morph", "Mutated Pink Trobbolier Morph", "Silver Trobbolier Morph");
        GetItems("gonnagetcha", "Shrade Cultist", "Cultist Knife", "Dual Cultist Knife", "Missing Keys Plaque");
        GetItems("gonnagetcha", "Murkonian", "GonnaGetcha Trident");
        GetItems("gonnagetcha", "Shrade", "DeathHunter Hair", "DeathHunter Hood", "DeathHunter Locks", "Fanged Cultist Mask", "Feral Cultist Mask", "Malevolent Cultist Mask", "Shadow Cultist Armor");
        GetItems("splatterwardage", "Shrade", "Celtic Hunter Blade", "Underworld Shrade", "Underworld Shrade Axe", "Underworld Shrade Helm", "Underworld Shrade Minion", "Well-wet Hair");
        GetItems("greymoor", "Shrade", "Necrotic Caster", "Necrotic Caster Cross Back", "Necrotic Caster Grave Spade", "Necrotic Caster Hair", "Necrotic Caster Locks", "Necrotic Caster Locks Morph", "Necrotic Caster Mask", "Necrotic Caster Mask Morph", "Necrotic Caster Masked Locks", "Necrotic Caster Scroll");
        GetItems("greymoor", "Ultra Shrade", "Shrade Armor", "Shrade Helm");
        GetItems("battledoom", "13th Doom Lord", "Doom Lord Vaal and Vayle", "Dual Skull Half-Axes", "Skulled Half-Axe", "SkullBorne Dagger", "Vaal's Doom Visage", "Vayle's Doom Hood", "Weeping Axe of DOOM");
        GetItems("crownsreachfxiii", "Shub-Hathrys", "Tentacled Tophat and Beard", "Tentacled Tophat and Locks");
    }

    private void GetItems(string map, string monster, params string[] items)
    {
        if (Core.CheckInventory(items, toInv: false))
            return;

        Bot.Drops.Add(items);
        foreach (string item in items)
        {
            Core.HuntMonster(map, monster, item, 1, false, log: false);
            Core.ToBank(item);
        }
    }

    public void TachyonMerge()
    {
        if (Core.CheckInventory(TachyonShop, toInv: false))
            return;

        Bot.Drops.Add(TachyonShop);
        foreach (string TachyonItem in TachyonShop)
        {
            Tachyon.BuyAllMerge(TachyonItem);
            Core.ToBank(TachyonItem);
        }
    }

    public void BoneTowerMerge()
    {
        if (Core.CheckInventory(BoneTowerShop, toInv: false))
            return;

        // Required for quest:         
        BonecastleTowerMerge.BuyAllMerge("Silver DeathKnight Lord");
        BonecastleTowerMerge.BuyAllMerge("Golden DeathKnight Lord");

        Bot.Drops.Add(BoneTowerShop);
        foreach (string BoneTowerItem in BoneTowerShop)
        {
            BonecastleTowerMerge.BuyAllMerge(BoneTowerItem);
            Core.ToBank(BoneTowerItem);
        }
    }

    private string[] TachyonShop =
    {
        "Orange Tachyon Blade",
        "Blue Tachyon Blade",
        "Chrono Assassin Armor",
        "Dual Tachyon Blades",
    };

    private string[] BoneTowerShop =
    {
        "DeathKnight Lord",
        "DeathKnight's Blade",
        "DeathKnight Helm",
        "Silver DeathKnight Lord",
        "Silver DeathKnight's Blade",
        "Silver DeathKnight Helm",
        "Golden DeathKnight Lord",
        "Golden DeathKnight's Blade",
        "Golden DeathKnight Helm",
        "DeathKnight Lord Cape"
    };
}
