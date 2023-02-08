﻿namespace NeoServer.Game.Common.Item;

public enum ItemAttribute : byte
{
    None = 0,
    None2 = 254,
    AnotherDescription = 1,
    ExtensionFile = 2,
    TileFlags = 3,
    ActionId = 4,
    UniqueId = 5,
    Text = 6,
    Description = 7, // ATTR_DESC = 7,
    TeleportDestination = 8, // ATTR_TELE_DEST = 8,
    Item, // ATTR_ITEM = 9,
    DepotId = 10, // ATTR_DEPOT_ID = 10,
    ExtensionFileForSpawns, // //ATTR_EXT_SPAWN_FILE = 11,
    RuneCharges = 12, // ATTR_RUNE_CHARGES = 12,
    ExtensionFileForHouses, // //ATTR_EXT_HOUSE_FILE = 13,
    HouseDoorId = 14, // ATTR_HOUSEDOORID = 14,
    Count = 15, // ATTR_COUNT = 15,
    Duration = 16, // ATTR_DURATION = 16,
    DecayingState = 17, // ATTR_DECAYING_STATE = 17,
    WrittenDate = 18, // ATTR_WRITTENDATE = 18,
    WrittenBy = 19, // ATTR_WRITTENBY = 19,
    SleeperGuid = 20, // ATTR_SLEEPERGUID = 20,
    SleepStart = 21, // ATTR_SLEEPSTART = 21,
    Charges = 22, // ATTR_CHARGES = 22,
    ContainerItems = 23, // ATTR_CONTAINER_ITEMS = 23,
    Name = 24, // ATTR_NAME = 24,
    Article = 25, // ATTR_ARTICLE = 25,
    PluralName = 26, // ATTR_PLURALNAME = 26,
    Weight = 27, // ATTR_WEIGHT = 27,
    Attack = 28, // ATTR_ATTACK = 28,
    Defense = 29, // ATTR_DEFENSE = 29,
    ExtraDefense = 30, // ATTR_EXTRADEFENSE = 30,
    Armor = 31, // ATTR_ARMOR = 31,
    HitChance = 32, // ATTR_HITCHANCE = 32,
    ShootRange = 33, // ATTR_SHOOTRANGE = 33,
    CustomAttributes = 34, // ATTR_CUSTOM_ATTRIBUTES = 34
    DecayTo = 35,
    Capacity,
    Waypoints,
    AvoidDamageTypes,
    ExpireTarget,
    StopDecaying,
    SourceLiquidType,
    DisguiseTarget,
    Brightness,
    LightColor,
    Elevation,
    KeydoorTarget,
    ChangeTarget,
    NamedoorTarget,
    FontSize,
    QuestdoorTarget,
    LeveldoorTarget,
    ThrowRange,
    ThrowAttackValue,
    ThrowDefendValue,
    ThrowMissile,
    ThrowSpecialEffect,
    ThrowEffectStrength,
    ThrowFragility,
    RotateTarget,
    DestroyTarget,
    Meaning,
    InformationType,
    MaxLength,
    MaxLengthOnce,
    BodyPosition,
    ShieldDefendValue,
    ProtectionDamageTypes,
    DamageReduction,
    WearoutTarget,
    TotalUses,
    MinimumLevel,
    Professions,
    WandRange,
    WandAttackStrength,
    WandAttackVariation,
    WandDamageType,
    WandMissile,
    SkillNumber,
    SkillModification,
    WeaponType,
    WeaponAttackValue,
    WeaponDefendValue,
    Nutrition,
    BowRange,
    BowAmmoType,
    AmmoType,
    AmmoAttackValue,
    AmmoMissile,
    AmmoSpecialEffect,
    AmmoEffectStrength,
    CorpseType,
    AbsTeleportEffect,
    RelTeleportEffect,
    RelTeleportDisplacement,
    Amount,
    ContainerLiquidType,
    PoolLiquidType,
    String,
    SavedExpireTime,
    Type,
    RuneSpellName,
    ShowCount,
    Moveable,
    BlockProjectTile,
    Pickupable,
    ForceSerialize,
    FloorChange,
    Readable,
    Writeable,
    WriteOnceItemId,
    ShootType,
    Effect,
    Range,
    TransformEquipTo,
    TransformDequipTo,
    ShowDuration,
    ShowCharges,
    ShowAttributes,
    MaxHitChance,
    Invisible,
    Speed,
    HealthGain,
    HealTicks,
    ManaGain,
    ManaTicks,
    ManaShield,
    SkillSword,
    SkillAxe,
    SkillDistance,
    SkillFishing,
    SkillShield,
    SkillClub,
    SkillFist,
    MaxHitpoints,
    MaxHitpointsPercent,
    MaxManapoints,
    MagicPoints,
    MagicPointsPercent,
    CriticalHitChance,
    CriticalHitAmount,
    LifeLeechChance,
    LifeLeechAmount,
    ManaLeechAmout,
    ManaLeechChange,
    MaxManaPointsPercent,
    FieldAbsorbPercentEnergy,
    FieldAbsorbEercentFire,
    AbsorbPercentAll,
    FieldAbsorbPercentPoison,
    AbsorbPercentElements,
    AbsorbPercentMagic,
    AbsorbPercentEnergy,
    AbsorbPercentFire,
    AbsorbPercentPoison,
    Field,
    AllowDistRead,
    Blocking,
    WalkStack,
    ElementEnergy,
    ElementFire,
    ElementEarth,
    ElementIce,
    DestroyTo,
    TransformTo,
    FemaleTransformTo,
    MaleTransformTo,
    LevelDoor,
    PartnerDirection,
    Replaceable,
    SuppressCurse,
    SuppressDazzle,
    SuppressFreeze,
    SuppressPhysical,
    SuppressDrown,
    SuppressPoison,
    SuppressFire,
    SuppressEnergy,
    SuppressDrunk,
    AbsorbPercenUndefined,
    AbsorbPercentHealing,
    AbsorbPercentPhysical,
    AbsorbPercentDrown,
    AbsorbPercentManaDrain,
    AbsorbPercentLifeDrain,
    AbsorbPercentDeath,
    AbsorbPercentHoly,
    AbsorbPercentIce,
    Healing,
    Min,
    Max,
    Sentence,
    Vocation,
    Regeneration,
    NeedTarget,
    Formula,
    Damage,
    Area,
    Ticks,
    Script,
    Worth,
    ManaUse,
    CooldownTime,
    UseOn
}