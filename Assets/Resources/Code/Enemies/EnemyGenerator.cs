using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // delegate is used to ensure we get a new imp instantiated each time.
    public delegate Enemy getEnemyDelegate();

    // key: number on a 1d10 roll
    // val: the enemy to return to the caller.
    private Dictionary<int, getEnemyDelegate> standardEnemyTable = new Dictionary<int, getEnemyDelegate>();
    void Start()
    {
        standardEnemyTable[1] = getImp;
        standardEnemyTable[2] = getGreySlime;
        standardEnemyTable[3] = getVampireFreshman;
        standardEnemyTable[4] = getHag;
        standardEnemyTable[5] = getLich;
        standardEnemyTable[6] = getVampireJunior;
        standardEnemyTable[7] = getSpectre;
        standardEnemyTable[8] = getRedSlime;
        standardEnemyTable[9] = getUttleDemon;
        standardEnemyTable[10] = getVitzHellspawn;
    }

    public Enemy getRandomStandardEnemy()
    {
        Enemy e = standardEnemyTable[ GameUtils.rand1d10() ]();
        return e;
    }

    private Enemy getImp()
    {
        Debug.Log("Imp called");
        return new Enemy(
            "Imp", 
            "Mischeivous to the core, Imps are known for their lethal deviousness. Most stand no higher than 3' foot and are ruddy in complexion with sharply-filed teeth and pointed ears. They attack with whatever is available, strangely preferring ball-peen hammers.", 
            6, 8, 8, 10
        );
    }

    private Enemy getGreySlime()
    {
        Debug.Log("Grey slime called");
        return new Enemy(
            "Grey Slime",
            "Slow moving greyish masses of pus-filled ooze from the universe's bowels. Sluggish in movement but surprisingly agile in their tendril attacks.",
            6, 8, 8, 10
        );
    }

    private Enemy getVampireFreshman()
    {
        Debug.Log("vampire freshman called");
        return new Enemy(
            "Vampire Freshman",
            "Recently turned undead by upperclassmen vamps, Vampire Freshmen are hungry for their first kills.",
            6, 8, 9, 10
        );
    }

    private Enemy getHag()
    {
        Debug.Log("Hag called");
        return new Enemy(
            "Hag",
            "Hags are always looking for supple young teens as necessary spell ingredients. Their attacks consist of debilitating paralysis majick followed by brutish staff blows.",
            7, 10, 10, 15
        );
    }
    private Enemy getLich()
    {
        Debug.Log("Lich called");
        return new Enemy(
            "Lich",
            "Those who foolishly strived for immortality at the cost of their humanity. Dark Majick twisted them into cadaverous monsters that emit poisonous smog from their mouths.",
            8, 11, 11, 25
        );
    }
    private Enemy getVampireJunior()
    {
        Debug.Log("Vampire Junior called");
        return new Enemy(
            "Vampire Junior",
            "Underlings to only Vampire Seniors, these vamps are much stronger than their younger kin.",
            8, 12, 13, 25
        );
    }
    private Enemy getSpectre()
    {
        Debug.Log("Spectre called");
        return new Enemy(
            "Spectre",
            "Evil ethereal beings haunting your school's hallways. They commonly attack with a piercing screech.",
            10, 13, 13, 35
        );
    }
    private Enemy getRedSlime()
    {
        Debug.Log("Red Slime called");
        return new Enemy(
            "Red Slime",
            "Ruby colored oozes that are more intelligent than their grey counterparts. They attack by spraying noxious crimson webs.",
            10, 13, 14, 35
        );
    }
    private Enemy getUttleDemon()
    {
        Debug.Log("Uttle Demon called");
        return new Enemy(
            "Uttle Demon",
            "Demon soldiers from another dimension. One kill rarely quenches their bloodlust. If executed by one you can rest assured your corpse is dragged to their world for necromatic experiments.",
            12, 14, 16, 50
        );
    }
    private Enemy getVitzHellspawn()
    {
        Debug.Log("Vitz Hellspawn called");
        return new Enemy(
            "Vitz Hellspawn",
            "Their humanoid torsos fused with arachnid bottoms make for a horrific sight. These majickal abominations make short work of opponents with their barbed spider appendages. Vitz Hellspawn are the overseers of Uttle Demon battalions.",
            14, 15, 17, 55
        );
    }
}