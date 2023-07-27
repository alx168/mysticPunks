using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Spell {
    public string name;
    int magnitude;
    int level;
    bool targetSelf;
    int combatRounds;
    int combatRoundsRemaining;
    int usage;

    public Spell(string newName="defaultName", int newMagnitude = -100,
     int newLevel = -100, bool newTargetSelf = false, int newCombatRounds = -100,
     int newCombatRoundsRemaining = -100, int newUsage = -100) {
        name = newName;
        magnitude = newMagnitude;
        level = newLevel;
        targetSelf = newTargetSelf;
        combatRounds = newCombatRounds;
        combatRoundsRemaining = newCombatRoundsRemaining;
        usage = newUsage;
     }

}

