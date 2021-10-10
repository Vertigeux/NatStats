﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NatStats.Database
{
    public partial class Ability
    {
        public uint Id { get; set; }
        public uint CharacterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasHitCheck { get; set; }
        public string HitCheckBase { get; set; }
        public int HitCheckBonus { get; set; }
        public int HitCheckCrit { get; set; }
        public bool HasEffect { get; set; }
        public int EffectDiceCount { get; set; }
        public int EffectDiceSides { get; set; }
        public string EffectBase { get; set; }
        public int EffectBonus { get; set; }
        public uint EffectDamageTypeId { get; set; }
        public bool EffectCanCrit { get; set; }
        public int EffectCritDiceCount { get; set; }
        public int EffectCritDiceSides { get; set; }
        public int EffectCritBonus { get; set; }
        public uint ConditionId { get; set; }
        public bool HasSavingThrow { get; set; }
        public double PassDamageMod { get; set; }
        public bool PassApplyCondition { get; set; }
        public double FailDamageMod { get; set; }
        public bool FailApplyCondition { get; set; }
    }
}
