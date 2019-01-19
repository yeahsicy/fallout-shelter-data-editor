
public class Rootobject
{
    public Timemgr timeMgr { get; set; }
    public Localnotificationmgr localNotificationMgr { get; set; }
    public Taskmgr taskMgr { get; set; }
    public Ratingmgr ratingMgr { get; set; }
    public Specialtheme specialTheme { get; set; }
    public Dwellers dwellers { get; set; }
    public Constructmgr constructMgr { get; set; }
    public Vault vault { get; set; }
    public Dwellerspawner dwellerSpawner { get; set; }
    public string deviceName { get; set; }
    public Tutorialmanager tutorialManager { get; set; }
    public Objectivemgr objectiveMgr { get; set; }
    public Unlockablemgr unlockableMgr { get; set; }
    public Survivalw survivalW { get; set; }
    public Shopwindow ShopWindow { get; set; }
    public Happinessmanager happinessManager { get; set; }
    public Refugeespawner refugeeSpawner { get; set; }
    public object LunchBoxCollectWindow { get; set; }
    public Deathclawmanager DeathclawManager { get; set; }
    public object PromoCodesWindow { get; set; }
    public object JunkGiveAwayWindow { get; set; }
    public Mysteriousstranger MysteriousStranger { get; set; }
    public Statswindow StatsWindow { get; set; }
    public string[] PromotionFlags { get; set; }
    public string appVersion { get; set; }
    public Bottleandcappymgrserializekey BottleAndCappyMgrSerializeKey { get; set; }
    public Completedquestdatamanager completedQuestDataManager { get; set; }
    public float[] cameraPosition { get; set; }
    public Questsetup questSetup { get; set; }
    public Questdatamanager questDataManager { get; set; }
    public Questdwellers questDwellers { get; set; }
    public Questdwellerspawner questDwellerSpawner { get; set; }
    public Task1 task { get; set; }
    public Time time { get; set; }
    public Viewmanager viewManager { get; set; }
    public int versionCount { get; set; }
}

public class Timemgr
{
    public float gameTime { get; set; }
    public int questTime { get; set; }
    public float time { get; set; }
    public long timeSaveDate { get; set; }
    public long timeGameBegin { get; set; }
}

public class Localnotificationmgr
{
    public object[] UniqueIDS { get; set; }
}

public class Taskmgr
{
    public int id { get; set; }
    public float time { get; set; }
    public Task[] tasks { get; set; }
    public object[] pausedTasks { get; set; }
}

public class Task
{
    public float startTime { get; set; }
    public float endTime { get; set; }
    public int id { get; set; }
    public bool paused { get; set; }
    public bool rescheduleToOldest { get; set; }
}

public class Ratingmgr
{
    public int sampleId { get; set; }
    public int dayRatingId { get; set; }
    public object[] currentSamples { get; set; }
    public Rating[] ratings { get; set; }
    public object[] ratingsLast { get; set; }
    public bool hasWeekRating { get; set; }
    public bool hasLastWeekRating { get; set; }
    public int weekRating { get; set; }
    public int lastWeekRating { get; set; }
}

public class Rating
{
    public int rating { get; set; }
    public int time { get; set; }
    public bool collected { get; set; }
}

public class Specialtheme
{
    public Themebyroomtype themeByRoomType { get; set; }
    public Eventsthemes eventsThemes { get; set; }
    public string lastOverallTheme { get; set; }
}

public class Themebyroomtype
{
}

public class Eventsthemes
{
    public Cafeteria_Xmas Cafeteria_Xmas { get; set; }
    public Cafeteria_Halloween Cafeteria_Halloween { get; set; }
    public Cafeteria_Thanksgiving Cafeteria_ThanksGiving { get; set; }
    public Livingquarters_Xmas LivingQuarters_Xmas { get; set; }
    public Livingquarters_Halloween LivingQuarters_Halloween { get; set; }
    public Livingquarters_Thanksgiving LivingQuarters_ThanksGiving { get; set; }
}

public class Cafeteria_Xmas
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
    public Extradata extraData { get; set; }
}

public class Extradata
{
    public int partsCollectedCount { get; set; }
    public bool IsCraftingInProgress { get; set; }
    public bool IsCrafted { get; set; }
    public bool IsClaimed { get; set; }
    public bool IsClaimedInCraftingRoom { get; set; }
    public bool IsNew { get; set; }
}

public class Cafeteria_Halloween
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
    public Extradata1 extraData { get; set; }
}

public class Extradata1
{
    public int partsCollectedCount { get; set; }
    public bool IsCraftingInProgress { get; set; }
    public bool IsCrafted { get; set; }
    public bool IsClaimed { get; set; }
    public bool IsClaimedInCraftingRoom { get; set; }
    public bool IsNew { get; set; }
}

public class Cafeteria_Thanksgiving
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
    public Extradata2 extraData { get; set; }
}

public class Extradata2
{
    public int partsCollectedCount { get; set; }
    public bool IsCraftingInProgress { get; set; }
    public bool IsCrafted { get; set; }
    public bool IsClaimed { get; set; }
    public bool IsClaimedInCraftingRoom { get; set; }
    public bool IsNew { get; set; }
}

public class Livingquarters_Xmas
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
    public Extradata3 extraData { get; set; }
}

public class Extradata3
{
    public int partsCollectedCount { get; set; }
    public bool IsCraftingInProgress { get; set; }
    public bool IsCrafted { get; set; }
    public bool IsClaimed { get; set; }
    public bool IsClaimedInCraftingRoom { get; set; }
    public bool IsNew { get; set; }
}

public class Livingquarters_Halloween
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
    public Extradata4 extraData { get; set; }
}

public class Extradata4
{
    public int partsCollectedCount { get; set; }
    public bool IsCraftingInProgress { get; set; }
    public bool IsCrafted { get; set; }
    public bool IsClaimed { get; set; }
    public bool IsClaimedInCraftingRoom { get; set; }
    public bool IsNew { get; set; }
}

public class Livingquarters_Thanksgiving
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
    public Extradata5 extraData { get; set; }
}

public class Extradata5
{
    public int partsCollectedCount { get; set; }
    public bool IsCraftingInProgress { get; set; }
    public bool IsCrafted { get; set; }
    public bool IsClaimed { get; set; }
    public bool IsClaimedInCraftingRoom { get; set; }
    public bool IsNew { get; set; }
}

public class Dwellers
{
    public Dweller[] dwellers { get; set; }
    public object[] actors { get; set; }
    public int id { get; set; }
    public int mrhId { get; set; }
    public float min_happiness { get; set; }
}

public class Dweller
{
    public int serializeId { get; set; }
    public string name { get; set; }
    public string lastName { get; set; }
    public Happiness happiness { get; set; }
    public Health health { get; set; }
    public Experience experience { get; set; }
    public Relations relations { get; set; }
    public int gender { get; set; }
    public Stats stats { get; set; }
    public bool pregnant { get; set; }
    public bool babyReady { get; set; }
    public bool assigned { get; set; }
    public bool sawIncident { get; set; }
    public bool WillGoToWasteland { get; set; }
    public bool WillBeEvicted { get; set; }
    public bool IsEvictedWaitingForFollowers { get; set; }
    public long skinColor { get; set; }
    public long hairColor { get; set; }
    public long outfitColor { get; set; }
    public int pendingExperienceReward { get; set; }
    public string uniqueData { get; set; }
    public string hair { get; set; }
    public Equipedoutfit equipedOutfit { get; set; }
    public Equipedweapon equipedWeapon { get; set; }
    public int savedRoom { get; set; }
    public float lastChildBorn { get; set; }
    public string rarity { get; set; }
    public int deathTime { get; set; }
    public string faceMask { get; set; }
}

public class Happiness
{
    public float happinessValue { get; set; }
}

public class Health
{
    public float healthValue { get; set; }
    public int radiationValue { get; set; }
    public bool permaDeath { get; set; }
    public int lastLevelUpdated { get; set; }
    public float maxHealth { get; set; }
}

public class Experience
{
    public int experienceValue { get; set; }
    public int currentLevel { get; set; }
    public int storage { get; set; }
    public int accum { get; set; }
    public bool needLvUp { get; set; }
    public int wastelandExperience { get; set; }
}

public class Relations
{
    public object[] relations { get; set; }
    public int partner { get; set; }
    public int lastPartner { get; set; }
    public int[] ascendants { get; set; }
}

public class Stats
{
    public Stat[] stats { get; set; }
}

public class Stat
{
    public int value { get; set; }
    public int mod { get; set; }
    public int exp { get; set; }
}

public class Equipedoutfit
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Equipedweapon
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Constructmgr
{
    public int roomDeserializeID { get; set; }
}

public class Vault
{
    public Rock[] rocks { get; set; }
    public Room[] rooms { get; set; }
    public Storage storage { get; set; }
    public Inventory inventory { get; set; }
    public Emergencydata emergencyData { get; set; }
    public Roomconsumption roomConsumption { get; set; }
    public Dwellerwaterconsumption dwellerWaterConsumption { get; set; }
    public Dwellerfoodconsumption dwellerFoodConsumption { get; set; }
    public string lunchboxRandomGenerator { get; set; }
    public object[] LunchBoxesByType { get; set; }
    public int LunchBoxesCount { get; set; }
    public string VaultName { get; set; }
    public string VaultMode { get; set; }
    public int VaultTheme { get; set; }
    public Achievements Achievements { get; set; }
    public Wasteland wasteland { get; set; }
}

public class Storage
{
    public Resources resources { get; set; }
    public Bonus bonus { get; set; }
}

public class Resources
{
    public int Nuka { get; set; }
    public float Food { get; set; }
    public float Energy { get; set; }
    public float Water { get; set; }
    public int StimPack { get; set; }
    public int RadAway { get; set; }
    public int Lunchbox { get; set; }
    public int MrHandy { get; set; }
    public int PetCarrier { get; set; }
    public int CraftedOutfit { get; set; }
    public int CraftedWeapon { get; set; }
    public int NukaColaQuantum { get; set; }
    public int CraftedTheme { get; set; }
}

public class Bonus
{
    public int Nuka { get; set; }
    public int Food { get; set; }
    public int Energy { get; set; }
    public int Water { get; set; }
    public int StimPack { get; set; }
    public int RadAway { get; set; }
    public int Lunchbox { get; set; }
    public int MrHandy { get; set; }
    public int PetCarrier { get; set; }
    public int CraftedOutfit { get; set; }
    public int CraftedWeapon { get; set; }
    public int NukaColaQuantum { get; set; }
    public int CraftedTheme { get; set; }
}

public class Inventory
{
    public Item[] items { get; set; }
}

public class Item
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Emergencydata
{
    public bool active { get; set; }
    public int randomEventTaskId { get; set; }
}

public class Roomconsumption
{
    public int taskIdOnline { get; set; }
    public int taskIDShutDown { get; set; }
}

public class Dwellerwaterconsumption
{
    public int taskIdOnline { get; set; }
}

public class Dwellerfoodconsumption
{
    public int taskIdOnline { get; set; }
}

public class Achievements
{
    public Objectivesinprogress[] objectivesInProgress { get; set; }
    public object[] completed { get; set; }
}

public class Objectivesinprogress
{
    public string objectiveID { get; set; }
    public Requirement[] requirements { get; set; }
    public bool completed { get; set; }
    public int incrementLevel { get; set; }
}

public class Requirement
{
    public string requirementID { get; set; }
    public bool satisfied { get; set; }
    public int rushCount { get; set; }
    public int higherMergeLevelFound { get; set; }
    public int currentCreatures { get; set; }
    public int currentBabies { get; set; }
    public int acceptedRoom { get; set; }
    public int dweller { get; set; }
    public int currentInvasions { get; set; }
    public int numberOfObjectivesCompleted { get; set; }
    public int currentLegendaryDwellers { get; set; }
    public int currentLegendaryOutfits { get; set; }
    public int currentLegendaryWeapons { get; set; }
    public int nukaCount { get; set; }
    public bool isAchievement { get; set; }
    public int currentNumberQuestsCompleted { get; set; }
    public int currentNumberItems { get; set; }
    public int currentAllThemeParts { get; set; }
    public int currentNumberQuestDialogChoicesMade { get; set; }
    public int currentNumberQuestEnemiesToKill { get; set; }
    public int currentNumberLoot { get; set; }
}

public class Wasteland
{
    public State state { get; set; }
    public object[] teams { get; set; }
    public Cycle[] cycles { get; set; }
    public Mrhandycycle[] mrHandyCycles { get; set; }
    public object[] questCycles { get; set; }
    public int allTimeTeamsCounter { get; set; }
    public string lastSurpriseQuest { get; set; }
    public float lastSurprisePopupTime { get; set; }
}

public class State
{
    public string name { get; set; }
}

public class Cycle
{
    public string cycleType { get; set; }
    public int taskId { get; set; }
    public object[] pendingCycles { get; set; }
    public object[] teamEncounters { get; set; }
    public object[] inProgress { get; set; }
}

public class Mrhandycycle
{
    public string cycleType { get; set; }
    public int taskId { get; set; }
}

public class Rock
{
    public int r { get; set; }
    public int c { get; set; }
}

public class Room
{
    public bool emergencyDone { get; set; }
    public string type { get; set; }
    public string _class { get; set; }
    public int mergeLevel { get; set; }
    public int row { get; set; }
    public int col { get; set; }
    public bool power { get; set; }
    public Roomhealth roomHealth { get; set; }
    public object[] mrHandyList { get; set; }
    public int rushTask { get; set; }
    public int level { get; set; }
    public int?[] dwellers { get; set; }
    public object[] deadDwellers { get; set; }
    public string currentStateName { get; set; }
    public Currentstate currentState { get; set; }
    public int deserializeID { get; set; }
    public string assignedDecoration { get; set; }
    public bool roomVisibility { get; set; }
    public bool roomOutline { get; set; }
    public bool broken { get; set; }
    public bool withHole { get; set; }
    public Storage1 storage { get; set; }
    public int numberOfProductionCycle { get; set; }
    public bool ExperienceRewardIsDirty { get; set; }
    public string[] IngredientItemIds { get; set; }
    public string CraftingItemId { get; set; }
    public float CompletedTime { get; set; }
    public Child[] children { get; set; }
    public object[] partners { get; set; }
    public bool newDwellerReady { get; set; }
    public bool onlyIncreaseHappiness { get; set; }
}

public class Roomhealth
{
    public float damageValue { get; set; }
    public float initialValue { get; set; }
}

public class Currentstate
{
    public int taskId { get; set; }
    public string notificationId { get; set; }
    public float remainingTime { get; set; }
    public int estimatedTime { get; set; }
}

public class Storage1
{
    public Resources1 resources { get; set; }
    public Bonus1 bonus { get; set; }
}

public class Resources1
{
    public float Nuka { get; set; }
    public float Food { get; set; }
    public float Energy { get; set; }
    public float Water { get; set; }
    public float StimPack { get; set; }
    public int RadAway { get; set; }
    public int Lunchbox { get; set; }
    public int MrHandy { get; set; }
    public int PetCarrier { get; set; }
    public int CraftedOutfit { get; set; }
    public int CraftedWeapon { get; set; }
    public int NukaColaQuantum { get; set; }
    public int CraftedTheme { get; set; }
}

public class Bonus1
{
    public int Nuka { get; set; }
    public int Food { get; set; }
    public int Energy { get; set; }
    public int Water { get; set; }
    public int StimPack { get; set; }
    public int RadAway { get; set; }
    public int Lunchbox { get; set; }
    public int MrHandy { get; set; }
    public int PetCarrier { get; set; }
    public int CraftedOutfit { get; set; }
    public int CraftedWeapon { get; set; }
    public int NukaColaQuantum { get; set; }
    public int CraftedTheme { get; set; }
}

public class Child
{
    public int taskID { get; set; }
    public int dwellerID { get; set; }
    public int notificationID { get; set; }
}

public class Dwellerspawner
{
    public object[] dwellersWaiting { get; set; }
}

public class Tutorialmanager
{
    public string phase { get; set; }
    public int taskNumber { get; set; }
    public bool objectivesTutorialMessage { get; set; }
    public bool lunchboxTutorialMessage { get; set; }
    public bool showingObjectiveTutorialMessage { get; set; }
    public bool showingLunchboxTutorialMessage { get; set; }
    public int showWastelandMessageTime { get; set; }
    public int showExploreWastelandMessageTime { get; set; }
    public bool exploreWastelandMessageShown { get; set; }
    public int skippedTutorial { get; set; }
    public int questTutorialCompleted { get; set; }
    public object[] intialTimerTasks { get; set; }
    public bool ContextualVaultTecObjectives { get; set; }
    public bool ContextualAddFriends { get; set; }
    public bool ContextualWasteland { get; set; }
    public bool ContextualRadioRoom { get; set; }
    public bool ContextualWeaponsAndOutfits { get; set; }
    public bool ContextualTrainDweller { get; set; }
    public bool ContextualBabies { get; set; }
    public bool ContextualDestroyRocks { get; set; }
    public bool ContextualStorage { get; set; }
    public bool ContextualNoRoomForDwellers { get; set; }
    public bool ContextualUnequipedDweller { get; set; }
    public bool ContextualBuildAnElevator { get; set; }
    public bool ContextualDestroyRockToBuild { get; set; }
    public bool ContextualNoBuildZonesAvailableByRock { get; set; }
    public bool ContextualDestroyRockToAccessNextFloor { get; set; }
    public bool ContextualResourcesAlert { get; set; }
    public bool ContextualIncidentOcurs { get; set; }
    public bool ContextualLowPowerAlert { get; set; }
    public bool ContextualStorageFull { get; set; }
    public bool ContextualMergeOrUpgradeRoom { get; set; }
    public bool ContextualWastelandMessage { get; set; }
    public bool ContextualObjectivesCompleted { get; set; }
    public bool ContextualBabiesTutorial { get; set; }
    public bool ContextualStimpackMessage { get; set; }
    public bool ContextualLunchboxTutorial { get; set; }
    public bool ContextualRadwayMessage { get; set; }
    public bool ContextualRoomMerge2 { get; set; }
    public bool ContextualRoomMerge3 { get; set; }
    public bool ContextualStorage2 { get; set; }
    public bool ContextualEquippingItemsWeapon { get; set; }
    public bool ContextualLuck { get; set; }
    public bool ContextualEquppingItemsPet { get; set; }
    public bool ContextualCrafting { get; set; }
    public bool ContextualDecorations { get; set; }
    public bool ContextualRequestJunk { get; set; }
    public bool ContextualJunk { get; set; }
    public bool ContextualTriggeredBirth { get; set; }
    public bool ContextualInventoryFull { get; set; }
    public bool ContextualInventoryFullWindow { get; set; }
    public bool ContextualJunkGiveAway { get; set; }
    public bool ContextualScrapping { get; set; }
    public bool ContextualAssignWith3DTouch { get; set; }
    public bool ContextualNukaQuantum { get; set; }
    public bool ContextualSurpriseQuests { get; set; }
    public bool ContextualReturningFromQuests { get; set; }
    public bool ContextualRadioRoomToggle { get; set; }
    public bool ContextualCraftTheme { get; set; }
    public bool ContextualJoystickNavigationInVault { get; set; }
    public int MaleTasksQuant { get; set; }
    public int FemaleTasksQuant { get; set; }
}

public class Objectivemgr
{
    public int taskID { get; set; }
    public bool canDiscard { get; set; }
    public int nukaQuantumIncrement { get; set; }
    public string[][] shuffleBags { get; set; }
    public Slotarray[] slotArray { get; set; }
}

public class Slotarray
{
    public Objective objective { get; set; }
    public int incLevel { get; set; }
    public bool[] lottery { get; set; }
}

public class Objective
{
    public string objectiveID { get; set; }
    public Requirement1[] requirements { get; set; }
    public bool completed { get; set; }
    public int incrementLevel { get; set; }
}

public class Requirement1
{
    public string requirementID { get; set; }
    public bool satisfied { get; set; }
    public int currentFires { get; set; }
    public int nukaCount { get; set; }
    public bool isAchievement { get; set; }
    public int lastOutfits { get; set; }
    public int lastWeapons { get; set; }
    public object[] allDwellers { get; set; }
}

public class Unlockablemgr
{
    public Objectivesinprogress1[] objectivesInProgress { get; set; }
    public object[] completed { get; set; }
    public string[] claimed { get; set; }
}

public class Objectivesinprogress1
{
    public string objectiveID { get; set; }
    public Requirement2[] requirements { get; set; }
    public bool completed { get; set; }
    public int incrementLevel { get; set; }
}

public class Requirement2
{
    public string requirementID { get; set; }
    public bool satisfied { get; set; }
    public int currentCount { get; set; }
}

public class Survivalw
{
    public string[] weapons { get; set; }
    public string[] outfits { get; set; }
    public object[] dwellers { get; set; }
    public object[] pets { get; set; }
    public object[] breeds { get; set; }
    public object[] decorations { get; set; }
    public string[] junk { get; set; }
    public string[] recipes { get; set; }
    public string[] claimedRecipes { get; set; }
    public Collectedthemes collectedThemes { get; set; }
}

public class Collectedthemes
{
    public object[] themeList { get; set; }
}

public class Shopwindow
{
    public bool isStarterPackPurchased { get; set; }
    public bool hasStarterPackPopupShown { get; set; }
}

public class Happinessmanager
{
    public Room185[] room185 { get; set; }
    public Room105[] room105 { get; set; }
    public Room203[] room203 { get; set; }
    public Room62[] room62 { get; set; }
    public Room333[] room333 { get; set; }
    public Room354[] room354 { get; set; }
    public int[] rooms { get; set; }
    public Dweller1[] dweller1 { get; set; }
    public Dweller3[] dweller3 { get; set; }
    public Dweller10[] dweller10 { get; set; }
    public Dweller14[] dweller14 { get; set; }
    public Dweller15[] dweller15 { get; set; }
    public Dweller13[] dweller13 { get; set; }
    public Dweller6[] dweller6 { get; set; }
    public Dweller17[] dweller17 { get; set; }
    public Dweller7[] dweller7 { get; set; }
    public Dweller9[] dweller9 { get; set; }
    public Dweller23[] dweller23 { get; set; }
    public Dweller16[] dweller16 { get; set; }
    public Dweller27[] dweller27 { get; set; }
    public Dweller24[] dweller24 { get; set; }
    public Dweller18[] dweller18 { get; set; }
    public Dweller26[] dweller26 { get; set; }
    public Dweller20[] dweller20 { get; set; }
    public Dweller19[] dweller19 { get; set; }
    public int[] dwellers { get; set; }
}

public class Room185
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
    public int dc { get; set; }
}

public class Room105
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
    public int dc { get; set; }
}

public class Room203
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
    public int dc { get; set; }
}

public class Room62
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
    public int dc { get; set; }
}

public class Room333
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
    public int dc { get; set; }
}

public class Room354
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
    public int dc { get; set; }
}

public class Dweller1
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller3
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller10
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller14
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller15
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller13
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller6
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller17
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller7
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller9
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller23
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller16
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller27
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller24
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller18
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller26
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller20
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Dweller19
{
    public int type { get; set; }
    public int rh { get; set; }
    public bool _in { get; set; }
}

public class Refugeespawner
{
    public int newGameTask { get; set; }
    public int succeed { get; set; }
    public string currentPool { get; set; }
    public bool collectedAllRefugees { get; set; }
}

public class Deathclawmanager
{
    public int deathclawTotalExtraChance { get; set; }
    public bool canDeathclawEmergencyOccurs { get; set; }
    public int deathclawCooldownID { get; set; }
}

public class Mysteriousstranger
{
    public string currentState { get; set; }
    public bool canAppear { get; set; }
    public float timeToAppear { get; set; }
    public int remainingTimeToAppear { get; set; }
}

public class Statswindow
{
    public Vaultdata vaultData { get; set; }
}

public class Vaultdata
{
    public Collectedres collectedRes { get; set; }
    public int collectedOutfits { get; set; }
    public int collectedWeapons { get; set; }
    public int collectedDecorations { get; set; }
    public int collectedPets { get; set; }
    public int raidersKilled { get; set; }
    public int elevatorRides { get; set; }
    public int lunchBoxesOpened { get; set; }
    public int petCarriersOpened { get; set; }
    public int totalLifetimeDwellers { get; set; }
    public int babiesBorn { get; set; }
    public int dwellersRevived { get; set; }
    public int levelsGained { get; set; }
    public int specialStatTrained { get; set; }
    public int takenStimpack { get; set; }
    public int takenRadaway { get; set; }
    public int deadDwellers { get; set; }
    public int evictedDwellers { get; set; }
    public int soldWeapons { get; set; }
    public int soldOutfits { get; set; }
    public int soldDecorations { get; set; }
    public int soldPets { get; set; }
    public int scrappedOutfits { get; set; }
    public int scrappedWeapons { get; set; }
    public int craftedWeapons { get; set; }
    public int craftedOutfits { get; set; }
    public int craftedDecorations { get; set; }
    public int craftedThemes { get; set; }
    public int collectedJunk { get; set; }
    public int soldJunk { get; set; }
    public int successfulRushes { get; set; }
    public int failRushes { get; set; }
    public int firesExtinguised { get; set; }
    public int emergencyStopRaider { get; set; }
    public int emergencyStopDeathClaw { get; set; }
    public int emergencyStopGhoul { get; set; }
    public int emergencyStopRadroach { get; set; }
    public int emergencyStopRadscorpion { get; set; }
    public int emergencyStopMolerat { get; set; }
    public int dwellersSentWasteland { get; set; }
    public int wastelandTotalTime { get; set; }
    public int wastelandCreaturesKilled { get; set; }
    public bool vaultCreatedBeforeUpdate { get; set; }
    public int dwellersCustomized { get; set; }
    public long measuringSince { get; set; }
    public Previousvresources previousVResources { get; set; }
    public bool weaponFactoryBuilt { get; set; }
    public bool outfitFactoryBuilt { get; set; }
}

public class Collectedres
{
    public int Nuka { get; set; }
    public float Food { get; set; }
    public float Energy { get; set; }
    public float Water { get; set; }
    public int StimPack { get; set; }
    public int RadAway { get; set; }
    public int Lunchbox { get; set; }
    public int MrHandy { get; set; }
    public int PetCarrier { get; set; }
    public int CraftedOutfit { get; set; }
    public int CraftedWeapon { get; set; }
    public int NukaColaQuantum { get; set; }
    public int CraftedTheme { get; set; }
}

public class Previousvresources
{
    public int Nuka { get; set; }
    public float Food { get; set; }
    public float Energy { get; set; }
    public float Water { get; set; }
    public int StimPack { get; set; }
    public int RadAway { get; set; }
    public int Lunchbox { get; set; }
    public int MrHandy { get; set; }
    public int PetCarrier { get; set; }
    public int CraftedOutfit { get; set; }
    public int CraftedWeapon { get; set; }
    public int NukaColaQuantum { get; set; }
    public int CraftedTheme { get; set; }
}

public class Bottleandcappymgrserializekey
{
    public int SerializeAccumulatedTriggerChance { get; set; }
    public bool SerializeLocked { get; set; }
}

public class Completedquestdatamanager
{
    public int taskID { get; set; }
    public string[] completedQuests { get; set; }
    public object[] foundClues { get; set; }
    public Standalonequestpicker standaloneQuestPicker { get; set; }
    public Dailyquestpicker dailyQuestPicker { get; set; }
    public Weeklyquestpicker weeklyQuestPicker { get; set; }
    public int nukaQuantumIncrement { get; set; }
    public Standalonequestskipper standaloneQuestSkipper { get; set; }
    public Dailyquestskipper dailyQuestSkipper { get; set; }
    public Weeklyquestskipper weeklyQuestSkipper { get; set; }
}

public class Standalonequestpicker
{
    public string currentStandalone { get; set; }
}

public class Dailyquestpicker
{
    public Currentdaily[] currentDailies { get; set; }
    public Historydaily[] historyDailies { get; set; }
}

public class Currentdaily
{
    public string startDate { get; set; }
    public string endDate { get; set; }
    public string officialStartDate { get; set; }
    public string questName { get; set; }
}

public class Historydaily
{
    public string startDate { get; set; }
    public string endDate { get; set; }
    public string officialStartDate { get; set; }
    public string questName { get; set; }
}

public class Weeklyquestpicker
{
    public object[] currentWeeklies { get; set; }
    public Historyweekly[] historyWeeklies { get; set; }
}

public class Historyweekly
{
    public string startDate { get; set; }
    public string endDate { get; set; }
    public string officialStartDate { get; set; }
    public string questName { get; set; }
}

public class Standalonequestskipper
{
    public object[] skippedQuests { get; set; }
}

public class Dailyquestskipper
{
    public object[] skippedQuests { get; set; }
}

public class Weeklyquestskipper
{
    public Skippedquest[] skippedQuests { get; set; }
}

public class Skippedquest
{
    public string questName { get; set; }
    public bool isCurrentDay { get; set; }
}

public class Questsetup
{
    public int buildingLenght { get; set; }
    public int buildingHeight { get; set; }
    public int buildingUnderground { get; set; }
    public int seed { get; set; }
    public int entry { get; set; }
    public Questconstructionmgr questConstructionMgr { get; set; }
    public Roomlist[] roomList { get; set; }
    public Wasteland1 wasteland { get; set; }
    public int entranceId { get; set; }
}

public class Questconstructionmgr
{
    public int roomDeserializeID { get; set; }
}

public class Wasteland1
{
    public bool emergencyDone { get; set; }
    public string type { get; set; }
    public string _class { get; set; }
    public int mergeLevel { get; set; }
    public int row { get; set; }
    public int col { get; set; }
    public bool power { get; set; }
    public Roomhealth1 roomHealth { get; set; }
    public object[] mrHandyList { get; set; }
    public int rushTask { get; set; }
    public int level { get; set; }
    public object[] dwellers { get; set; }
    public object[] deadDwellers { get; set; }
    public string currentStateName { get; set; }
    public Currentstate1 currentState { get; set; }
    public int deserializeID { get; set; }
    public string assignedDecoration { get; set; }
    public bool roomVisibility { get; set; }
    public bool roomOutline { get; set; }
}

public class Roomhealth1
{
    public int damageValue { get; set; }
    public int initialValue { get; set; }
}

public class Currentstate1
{
}

public class Roomlist
{
    public bool emergencyDone { get; set; }
    public string type { get; set; }
    public string _class { get; set; }
    public int mergeLevel { get; set; }
    public int row { get; set; }
    public int col { get; set; }
    public bool power { get; set; }
    public Roomhealth2 roomHealth { get; set; }
    public object[] mrHandyList { get; set; }
    public int rushTask { get; set; }
    public int level { get; set; }
    public object[] dwellers { get; set; }
    public object[] deadDwellers { get; set; }
    public string currentStateName { get; set; }
    public Currentstate2 currentState { get; set; }
    public int deserializeID { get; set; }
    public string assignedDecoration { get; set; }
    public bool roomVisibility { get; set; }
    public bool roomOutline { get; set; }
    public string questRoomType { get; set; }
    public string roomClearOutResult { get; set; }
    public string roomPickUpResult { get; set; }
    public string roomName { get; set; }
    public bool enteringLeft { get; set; }
    public string primaryObjective { get; set; }
    public string secondaryObjective { get; set; }
    public string thirdObjective { get; set; }
    public string objectiveTextOverride { get; set; }
    public Combatparameters combatParameters { get; set; }
    public Completionloot completionLoot { get; set; }
    public string debugRoomId { get; set; }
    public int xp { get; set; }
    public bool mainPath { get; set; }
}

public class Roomhealth2
{
    public int damageValue { get; set; }
    public int initialValue { get; set; }
}

public class Currentstate2
{
}

public class Combatparameters
{
    public int difficulty { get; set; }
    public string enemyType { get; set; }
    public int enemyCount { get; set; }
    public bool boss { get; set; }
    public Loot loot { get; set; }
    public string dialogue { get; set; }
}

public class Loot
{
    public int LootType { get; set; }
    public string LootID { get; set; }
    public int LootQuantity { get; set; }
    public int FromVaultQuantity { get; set; }
    public int InitialEquippedQuantity { get; set; }
    public int CurrentlyEquippedQuantity { get; set; }
}

public class Completionloot
{
    public int LootType { get; set; }
    public string LootID { get; set; }
    public int LootQuantity { get; set; }
    public int FromVaultQuantity { get; set; }
    public int InitialEquippedQuantity { get; set; }
    public int CurrentlyEquippedQuantity { get; set; }
}

public class Questdatamanager
{
    public bool questDone { get; set; }
    public bool cancelled { get; set; }
    public bool questSucceeded { get; set; }
    public bool entranceFlow { get; set; }
    public int questDifficulty { get; set; }
    public Questteam questTeam { get; set; }
    public int accumulatedRetryCost { get; set; }
    public int retryCount { get; set; }
    public int incrementedRetryCount { get; set; }
    public int vaultCaps { get; set; }
    public int vaultQuantum { get; set; }
    public int uniqueID { get; set; }
}

public class Questteam
{
    public string CurrentQuestID { get; set; }
    public int randomIdentifier { get; set; }
    public int[] DwellersDictionary { get; set; }
    public Questlootobtained QuestLootObtained { get; set; }
    public Initialequipment[] InitialEquipment { get; set; }
    public int initialStimpakCount { get; set; }
    public int initialRadawayCount { get; set; }
    public int currentStimpakCount { get; set; }
    public int currentRadawayCount { get; set; }
    public int estimatedDwellerReviveCost { get; set; }
    public Questcurrentperfomance questCurrentPerfomance { get; set; }
    public float questSpentTime { get; set; }
}

public class Questlootobtained
{
    public Loot1[] Loots { get; set; }
}

public class Loot1
{
    public int LootType { get; set; }
    public string LootID { get; set; }
    public int LootQuantity { get; set; }
    public int FromVaultQuantity { get; set; }
    public int InitialEquippedQuantity { get; set; }
    public int CurrentlyEquippedQuantity { get; set; }
}

public class Questcurrentperfomance
{
    public int numberCombatsWon { get; set; }
    public int numberCriticalHitsPerformed { get; set; }
    public int numberPerfectCriticalHitsPerformed { get; set; }
    public int numberContainersCollected { get; set; }
    public int numberCapsCollected { get; set; }
    public int numberLevelsGained { get; set; }
    public int numberLevelsGainedWithBonus { get; set; }
}

public class Initialequipment
{
    public int dweller { get; set; }
    public Weapon weapon { get; set; }
    public Outfit outfit { get; set; }
}

public class Weapon
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Outfit
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Questdwellers
{
    public Dweller2[] dwellers { get; set; }
    public object[] actors { get; set; }
    public int id { get; set; }
    public int mrhId { get; set; }
    public int min_happiness { get; set; }
}

public class Dweller2
{
    public int serializeId { get; set; }
    public string name { get; set; }
    public string lastName { get; set; }
    public Happiness1 happiness { get; set; }
    public Health1 health { get; set; }
    public Experience1 experience { get; set; }
    public Relations1 relations { get; set; }
    public int gender { get; set; }
    public Stats1 stats { get; set; }
    public bool pregnant { get; set; }
    public bool babyReady { get; set; }
    public bool assigned { get; set; }
    public bool sawIncident { get; set; }
    public bool WillGoToWasteland { get; set; }
    public bool WillBeEvicted { get; set; }
    public bool IsEvictedWaitingForFollowers { get; set; }
    public long skinColor { get; set; }
    public long hairColor { get; set; }
    public long outfitColor { get; set; }
    public int pendingExperienceReward { get; set; }
    public string hair { get; set; }
    public Equipedoutfit1 equipedOutfit { get; set; }
    public Equipedweapon1 equipedWeapon { get; set; }
    public int savedRoom { get; set; }
    public int lastChildBorn { get; set; }
    public string rarity { get; set; }
    public int deathTime { get; set; }
    public float[] dwellerPosition { get; set; }
    public int dwellerRoom { get; set; }
    public int dwellerCriticalMeter { get; set; }
    public float dwellerCriticalFactor { get; set; }
}

public class Happiness1
{
    public int happinessValue { get; set; }
}

public class Health1
{
    public int healthValue { get; set; }
    public int radiationValue { get; set; }
    public bool permaDeath { get; set; }
    public int lastLevelUpdated { get; set; }
    public int maxHealth { get; set; }
}

public class Experience1
{
    public int experienceValue { get; set; }
    public int currentLevel { get; set; }
    public int storage { get; set; }
    public int accum { get; set; }
    public bool needLvUp { get; set; }
    public int wastelandExperience { get; set; }
}

public class Relations1
{
    public object[] relations { get; set; }
    public int partner { get; set; }
    public int lastPartner { get; set; }
    public int[] ascendants { get; set; }
}

public class Stats1
{
    public Stat1[] stats { get; set; }
}

public class Stat1
{
    public int value { get; set; }
    public int mod { get; set; }
    public int exp { get; set; }
}

public class Equipedoutfit1
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Equipedweapon1
{
    public string id { get; set; }
    public string type { get; set; }
    public bool hasBeenAssigned { get; set; }
    public bool hasRandonWeaponBeenAssigned { get; set; }
}

public class Questdwellerspawner
{
    public object[] dwellersWaiting { get; set; }
}

public class Task1
{
    public int id { get; set; }
    public float time { get; set; }
    public Task2[] tasks { get; set; }
    public object[] pausedTasks { get; set; }
}

public class Task2
{
    public float startTime { get; set; }
    public float endTime { get; set; }
    public int id { get; set; }
    public bool paused { get; set; }
    public bool rescheduleToOldest { get; set; }
}

public class Time
{
    public float gameTime { get; set; }
    public int questTime { get; set; }
    public float time { get; set; }
    public long timeSaveDate { get; set; }
    public long timeGameBegin { get; set; }
}

public class Viewmanager
{
    public int currentRoom { get; set; }
}
