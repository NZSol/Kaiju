using UnityEngine;
using System;

namespace Combat.AttackTypes{
    enum AttackElement
    {
        Kinetic,
        Energy,
        Plasma,
        Fire,
        Explosion
    };

    enum AttackDistribution
    {
        Target,
        Splash
    }

    enum AttackProximity
    {
        Short,
        Medium,
        Far
    }
}