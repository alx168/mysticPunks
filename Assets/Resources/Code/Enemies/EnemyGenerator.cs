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
        getRandomStandardEnemy();
    }

    public Enemy getRandomStandardEnemy()
    {
        Enemy e = standardEnemyTable[ GameUtils.rand1d10() ]();
        return e;
    }

    private Enemy getImp()
    {
        Debug.Log("imp called");
        return new Enemy(
            "Imp", 
            "Mischeivous to the core, Imps are known for their lethal " + 
            "deviousness. Most stand no higher than 3' foot and are ruddy " +
            "in complexion with sharply-filed teeth and pointed ears. " +
            "They attack with whatever is available, strangely preferring " +
            "ball-peen hammers.", 
            6, 8, 8, 10
        );
    }

    //do the other functions, getGreySlime, getVampireFreshman, etc 
    //or else an exception is thrown if the rand1d10() call isn't a 1.
}