﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackLeft4Dead2.Hack.Models
{
    public enum ClassID : sbyte
    {
        SurvivorPlayer = 67,
        SurvivorBot = 97,

        Hunter = -70,
        Tank = -91,
        Witch = -98,
        Spitter = -57,
        Smoker = -77,
        Boomer = -84,
        Jockey = -50,
        Charger = -63,
        Infected = -108,

        WeaponSpawn = 2,
        WeaponAmmoSpawn = 6,
    }
}
