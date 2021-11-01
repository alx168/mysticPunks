using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public int hp = 0;
    [SerializeField]
    public int vig = 0;
    [SerializeField]
    public int agil = 0;
    [SerializeField]
    public int inte = 0;
    [SerializeField]
    public int soc = 0; 
    [SerializeField]
    public int cun = 0;
    [SerializeField]
    public int joints = 5;
    public List<Spell> spells;

    public Hashtable getPlayerStats() {
        return new Hashtable() {
            { "hp", hp },
            { "vig", vig },
            { "agil", agil },
            { "inte", inte },
            { "soc", soc },
            { "cun", cun},
            { "socMod", getSocMod() },
            { "intMod", getIntMod() },
            { "agilMod", getAgilMod() },
            { "joints", joints},
        };
    }

    public string prettyStats() {
        var playerStats = getPlayerStats();
        string logStats = "";
        foreach (string key in playerStats.Keys)
        {
            logStats += string.Format("{0}: {1} ", key, playerStats[key] + "\n");
        }
        return logStats;
    }

    public int getSocMod() {
        if (soc - 16 < 0) { return 0; }
        return soc - 16;
    }

    public int getIntMod() {
        switch (inte) {
            case 15:
                return -2;
            case 16:
                return -4;
            case 17:
                return -6;
            case 18:
                return -8;
            case 19:
                return -10;
            case 20:
                return -12;
            default:
                return 0;
        }
    }

    public int getAgilMod() {
        if (agil - 14 < 0) { return 0; }
        return agil - 14;
    }
}
