﻿using Tibia.Objects;

namespace Tibia.Constants
{
    public static class Spells
    {
        public static Spell AnimateDead = new Spell("Animate Dead", "adana mort", 600, SpellCategory.Summon, SpellType.ItemTransformation);
        public static Spell Annihilation = new Spell("Annihilation", "exori gran ico", 300, SpellCategory.Attack, SpellType.Instant);
        public static Spell Antidote = new Spell("Antidote", "exana pox", 30, SpellCategory.Healing, SpellType.Instant);
        public static Spell AntidoteRune = new Spell("Antidote Rune", "adana pox", 200, SpellCategory.Healing, SpellType.ItemTransformation);
        public static Spell Avalanche = new Spell("Avalanche Rune", "adori mas frigo", 530, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell Berserk = new Spell("Berserk", "exori", 115, SpellCategory.Attack, SpellType.Instant);
        public static Spell BloodRage = new Spell("Blood Rage", "utito tempo", 290, SpellCategory.Support, SpellType.Instant);
        public static Spell BrutalStrike = new Spell("Brutal Strike", "exori ico", 30, SpellCategory.Attack, SpellType.Instant);
        public static Spell CancelInvisibility = new Spell("Cancel Invisibility", "exana ina", 200, SpellCategory.Support, SpellType.Instant);
        public static Spell Challenge = new Spell("Challenge", "exeta res", 30, SpellCategory.Support, SpellType.Instant);
        public static Spell Chameleon = new Spell("Chameleon", "adevo ina", 600, SpellCategory.Support, SpellType.ItemTransformation);
        public static Spell Charge = new Spell("Charge", "utani tempo hur", 100, SpellCategory.Support, SpellType.Instant);
        public static Spell ConjureArrow = new Spell("Conjure Arrow", "exevo con", 100, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConjureBolt = new Spell("Conjure Bolt", "exevo con mort", 140, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConjureExplosiveArrow = new Spell("Conjure Explosive Arrow", "exevo con flam", 290, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConjurePiercingBolt = new Spell("Conjure Piercing Bolt", "exevo con grav", 180, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConjurePoisonedArrow = new Spell("Conjure Poisoned Arrow", "exevo con pox", 130, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConjurePowerBolt = new Spell("Conjure Power Bolt", "exevo con vis", 700, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConjureSniperArrow = new Spell("Conjure Sniper Arrow", "exevo con hur", 160, SpellCategory.Supply, SpellType.Instant);
        public static Spell ConvinceCreature = new Spell("Convince Creature", "adeta sio", 200, SpellCategory.Summon, SpellType.ItemTransformation);
        public static Spell CreatureIllusion = new Spell("Creature Illusion", "utevo res ina \"{creatureName}\"", 100, SpellCategory.Support, SpellType.Instant);
        public static Spell CureBleeding = new Spell("Cure Bleeding", "exana kor", 30, SpellCategory.Healing, SpellType.Instant);
        public static Spell CureBurning = new Spell("Cure Burning", "exana flam", 30, SpellCategory.Healing, SpellType.Instant);
        public static Spell CureCurse = new Spell("Cure Curse", "exana mort", 40, SpellCategory.Healing, SpellType.Instant);
        public static Spell CureElectrification = new Spell("Cure Electrification", "exana vis", 30, SpellCategory.Healing, SpellType.Instant);
        public static Spell Curse = new Spell("Curse", "utori mort", 30, SpellCategory.Attack, SpellType.Instant);
        public static Spell DeathStrike = new Spell("Death Strike", "exori mort", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell Desintegrate = new Spell("Desintegrate", "adito tera", 200, SpellCategory.Support, SpellType.ItemTransformation);
        public static Spell DestroyField = new Spell("Destroy Field", "adito grav", 120, SpellCategory.Support, SpellType.ItemTransformation);
        public static Spell DivineCaldera = new Spell("Divine Caldera", "exevo mas san", 160, SpellCategory.Attack, SpellType.Instant);
        public static Spell DivineHealing = new Spell("Divine Healing", "exura san", 210, SpellCategory.Healing, SpellType.Instant);
        public static Spell DivineMissile = new Spell("Divine Missile", "exori san", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell Electrify = new Spell("Electrify", "utori vis", 30, SpellCategory.Attack, SpellType.Instant);
        public static Spell EnchantParty = new Spell("Enchant Party", "utori mas sio", 0, SpellCategory.Support, SpellType.Instant);
        public static Spell EnchantSpear = new Spell("Enchant Spear", "exeta con", 350, SpellCategory.Supply, SpellType.ItemTransformation);
        public static Spell EnchantStaff = new Spell("Enchant Staff", "exeta vis", 80, SpellCategory.Supply, SpellType.Instant);
        public static Spell EnergyBeam = new Spell("Energy Beam", "exevo vis lux", 40, SpellCategory.Attack, SpellType.Instant);
        public static Spell EnergyBomb = new Spell("Energy Bomb", "adevo mas vis", 880, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell EnergyField = new Spell("Energy Field", "adevo grav vis", 320, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell EnergyStrike = new Spell("Energy Strike", "exori vis", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell EnergyWall = new Spell("Energy Wall", "adevo mas grav vis", 1000, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell EnergyWave = new Spell("Energy Wave", "exevo vis hur", 170, SpellCategory.Attack, SpellType.Instant);
        public static Spell Envenom = new Spell("Envenom", "utori pox", 30, SpellCategory.Attack, SpellType.Instant);
        public static Spell EternalWinter = new Spell("Eternal Winter", "exevo gran mas frigo", 1200, SpellCategory.Attack, SpellType.Instant);
        public static Spell EtherealSpear = new Spell("Ethereal Spear", "exori con", 25, SpellCategory.Attack, SpellType.Instant);
        public static Spell Explosion = new Spell("Explosion", "adevo mas hur", 570, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell FierceBerserk = new Spell("Fierce Berserk", "exori gran", 340, SpellCategory.Attack, SpellType.Instant);
        public static Spell FindPerson = new Spell("Find Person", "exiva \"{name}\"", 20, SpellCategory.Support, SpellType.Instant);
        public static Spell FireBomb = new Spell("Fire Bomb", "adevo mas flam", 600, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell FireField = new Spell("Fire Field", "adevo grav flam", 240, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell FireWall = new Spell("Fire Wall", "adevo mas grav flam", 780, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell FireWave = new Spell("Fire Wave", "exevo flam hur", 25, SpellCategory.Attack, SpellType.Instant);
        public static Spell Fireball = new Spell("Fireball", "adori flam", 460, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell FlameStrike = new Spell("Flame Strike", "exori flam", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell Food = new Spell("Food", "exevo pan", 120, SpellCategory.Supply, SpellType.Instant);
        public static Spell FrontSweep = new Spell("Front Sweep", "exori min", 200, SpellCategory.Attack, SpellType.Instant);
        public static Spell GreatEnergyBeam = new Spell("Great Energy Beam", "exevo gran vis lux", 110, SpellCategory.Attack, SpellType.Instant);
        public static Spell GreatFireball = new Spell("Great Fireball", "adori mas flam", 530, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell GreatLight = new Spell("Great Light", "utevo gran lux", 60, SpellCategory.Support, SpellType.Instant);
        public static Spell Groundshaker = new Spell("Groundshaker", "exori mas", 160, SpellCategory.Attack, SpellType.Instant);
        public static Spell Haste = new Spell("Haste", "utani hur", 60, SpellCategory.Support, SpellType.Instant);
        public static Spell HealFriend = new Spell("Heal Friend", "exura sio \"{name}\"", 140, SpellCategory.Healing, SpellType.Instant);
        public static Spell HeavyMagicMissile = new Spell("Heavy Magic Missile", "adori vis", 350, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell HellsCore = new Spell("Hell's Core", "exevo gran mas flam", 1200, SpellCategory.Attack, SpellType.Instant);
        public static Spell HolyFlash = new Spell("Holy Flash", "utori san", 50, SpellCategory.Attack, SpellType.Instant);
        public static Spell HolyMissile = new Spell("Holy Missile", "adori san", 300, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell IceStrike = new Spell("Ice Strike", "exori frigo", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell IceWave = new Spell("Ice Wave", "exevo frigo hur", 25, SpellCategory.Attack, SpellType.Instant);
        public static Spell Icicle = new Spell("Icicle", "adori frigo", 460, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell Ignite = new Spell("Ignite", "utori flam", 30, SpellCategory.Attack, SpellType.Instant);
        public static Spell InflictWound = new Spell("Inflict Wound", "utori kor", 30, SpellCategory.Attack, SpellType.Instant);
        public static Spell IntenseHealing = new Spell("Intense Healing", "exura gran", 70, SpellCategory.Healing, SpellType.Instant);
        public static Spell IntenseHealingRune = new Spell("Intense Healing Rune", "adura gran", 120, SpellCategory.Healing, SpellType.ItemTransformation);
        public static Spell IntenseRecovery = new Spell("Intense Recovery", "utura gran", 165, SpellCategory.Healing, SpellType.Instant);
        public static Spell IntenseWoundCleansing = new Spell("Intense Wound Cleansing", "exura gran ico", 200, SpellCategory.Healing, SpellType.Instant);
        public static Spell Invisible = new Spell("Invisible", "utana vid", 440, SpellCategory.Support, SpellType.Instant);
        public static Spell Levitate = new Spell("Levitate", "exani hur \"{up|down}\"", 50, SpellCategory.Support, SpellType.Instant);
        public static Spell Light = new Spell("Light", "utevo lux", 20, SpellCategory.Support, SpellType.Instant);
        public static Spell LightHealing = new Spell("Light Healing", "exura", 20, SpellCategory.Healing, SpellType.Instant);
        public static Spell LightMagicMissile = new Spell("Light Magic Missile", "adori min vis", 120, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell Lightning = new Spell("Lightning", "exori amp vis", 60, SpellCategory.Attack, SpellType.Instant);
        public static Spell MagicRope = new Spell("Magic Rope", "exani tera", 20, SpellCategory.Support, SpellType.Instant);
        public static Spell MagicShield = new Spell("Magic Shield", "utamo vita", 50, SpellCategory.Support, SpellType.Instant);
        public static Spell MagicWall = new Spell("Magic Wall", "adevo grav tera", 750, SpellCategory.Support, SpellType.ItemTransformation);
        public static Spell MassHealing = new Spell("Mass Healing", "exura gran mas res", 150, SpellCategory.Healing, SpellType.Instant);
        public static Spell Paralyze = new Spell("Paralyze", "adana ani", 1400, SpellCategory.Support, SpellType.ItemTransformation);
        public static Spell PhysicalStrike = new Spell("Physical Strike", "exori moe ico", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell PoisonBomb = new Spell("Poison Bomb", "adevo mas pox", 520, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell PoisonField = new Spell("Poison Field", "adevo grav pox", 200, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell PoisonWall = new Spell("Poison Wall", "adevo mas grav pox", 640, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell ProtectParty = new Spell("Protect Party", "utamo mas sio", 0, SpellCategory.Support, SpellType.Instant);
        public static Spell Protector = new Spell("Protector", "utamo tempo", 200, SpellCategory.Support, SpellType.Instant);
        public static Spell RageOfTheSkies = new Spell("Rage of the Skies", "exevo gran mas vis", 650, SpellCategory.Attack, SpellType.Instant);
        public static Spell Recovery = new Spell("Recovery", "utura", 75, SpellCategory.Healing, SpellType.Instant);
        public static Spell Salvation = new Spell("salvation", "exura gran san", 210, SpellCategory.Healing, SpellType.Instant);
        public static Spell Sharpshooter = new Spell("Sharpshooter", "utito tempo san", 450, SpellCategory.Support, SpellType.Instant);
        public static Spell Soulfire = new Spell("Soulfire", "adevo res flam", 420, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell Stalagmite = new Spell("Stalagmite", "adori tera", 350, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell StoneShower = new Spell("Stone Shower", "adori mas tera", 430, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell StrongEnergyStrike = new Spell("Strong Energy Strike", "exori gran vis", 60, SpellCategory.Attack, SpellType.Instant);
        public static Spell StrongEtherealSpear = new Spell("Strong Ethereal Spear", "exori gran con", 55, SpellCategory.Attack, SpellType.Instant);
        public static Spell StrongFlameStrike = new Spell("Strong Flame Strike", "exori gran flam", 60, SpellCategory.Attack, SpellType.Instant);
        public static Spell StrongHaste = new Spell("Strong Haste", "utani gran hur", 100, SpellCategory.Support, SpellType.Instant);
        public static Spell StrongIceStrike = new Spell("Strong Ice Strike", "exori gran frigo", 60, SpellCategory.Attack, SpellType.Instant);
        public static Spell StrongIceWave = new Spell("Strong Ice Wave", "exevo gran frigo hur", 170, SpellCategory.Attack, SpellType.Instant);
        public static Spell StrongTerraStrike = new Spell("Strong Terra Strike", "exori gran tera", 60, SpellCategory.Attack, SpellType.Instant);
        public static Spell SuddenDeath = new Spell("Sudden Death", "adori gran mort", 985, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell SummonCreature = new Spell("Summon Creature", "utevo res \"{creatureName}\"", 0, SpellCategory.Summon, SpellType.Instant);
        public static Spell SwiftFoot = new Spell("Swift Foot", "utamo tempo san", 400, SpellCategory.Support, SpellType.Instant);
        public static Spell TerraStrike = new Spell("Terra Strike", "exori tera", 20, SpellCategory.Attack, SpellType.Instant);
        public static Spell TerraWave = new Spell("Terra Wave", "exevo tera hur", 210, SpellCategory.Attack, SpellType.Instant);
        public static Spell Thunderstorm = new Spell("Thunderstorm", "adori mas vis", 430, SpellCategory.Attack, SpellType.ItemTransformation);
        public static Spell TrainParty = new Spell("Train Party", "utito mas sio", 0, SpellCategory.Support, SpellType.Instant);
        public static Spell UltimateEnergyStrike = new Spell("Ultimate Energy Strike", "exori max vis", 100, SpellCategory.Attack, SpellType.Instant);
        public static Spell UltimateFlameStrike = new Spell("Ultimate Flame Strike", "exori max flam", 100, SpellCategory.Attack, SpellType.Instant);
        public static Spell UltimateHealing = new Spell("Ultimate Healing", "exura vita", 160, SpellCategory.Healing, SpellType.Instant);
        public static Spell UltimateHealingRune = new Spell("Ultimate Healing Rune", "adura vita", 400, SpellCategory.Healing, SpellType.ItemTransformation);
        public static Spell UltimateIceStrike = new Spell("Ultimate Ice Strike", "exori max frigo", 100, SpellCategory.Attack, SpellType.Instant);
        public static Spell UltimateLight = new Spell("Ultimate Light", "utevo vis lux", 140, SpellCategory.Support, SpellType.Instant);
        public static Spell UltimateTerraStrike = new Spell("Ultimate Terra Strike", "exori max tera", 100, SpellCategory.Attack, SpellType.Instant);
        public static Spell UndeadLegion = new Spell("Undead Legion", "exana mas mort", 500, SpellCategory.Summon, SpellType.Instant);
        public static Spell WhirlwindThrow = new Spell("Whirlwind Throw", "exori hur", 40, SpellCategory.Attack, SpellType.Instant);
        public static Spell WildGrowth = new Spell("Wild Growth", "exevo grav vita", 220, SpellCategory.Support, SpellType.Instant);
        public static Spell WoundCleansing = new Spell("Wound Cleansing", "exana mort", 65, SpellCategory.Healing, SpellType.Instant);
        public static Spell WrathOfNature = new Spell("Wrath of Nature", "exevo gran mas tera", 770, SpellCategory.Attack, SpellType.Instant);
    }
}