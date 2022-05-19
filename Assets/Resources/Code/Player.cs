using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public bool canCastSpells;
    public int hp = 0;
    public int vig = 0;
    public int agil = 0;
    public int inte = 0;
    public int soc = 0; 
    public int cun = 0;
    public int joints = 5;
    public List<Spell> spells;
    public List<Item> inventory;

    public Hashtable getPlayerStats() {
        return new Hashtable() {
            { "hp", hp },
            { "vig", vig },
            { "agil", agil },
            { "inte", inte },
            { "soc", soc },
            { "cun", cun },
            { "socMod", getSocMod() },
            { "intMod", getIntMod() },
            { "agilMod", getAgilMod() },
            { "fighting", getFightingMod() },
            { "joints", joints },
        };
    }

    private int getFightingMod(){
        int fightMod = 0;
        inventory.FindAll(item => item.modModded.Equals("fighting")).ToList<Item>().ForEach(item => fightMod += item.modVal);
        Debug.Log("val: " + inventory[0].modVal + " mod: " +inventory[0].modModded);
        return fightMod;
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
