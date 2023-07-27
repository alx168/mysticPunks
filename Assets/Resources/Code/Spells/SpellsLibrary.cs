using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using UnityEngine;

public class SpellsLibrary : MonoBehaviour
{
    private static ConcurrentDictionary<int, List<Spell>> allSpells = new ConcurrentDictionary<
        int,
        List<Spell>
    >(
        new List<KeyValuePair<int, List<Spell>>>
        {
            new KeyValuePair<int, List<Spell>>(
                1, new List<Spell>
                {
                    new Spell("Tundra Hands of Yot"),
                    new Spell("King Vley's Roar"),
                    new Spell("Nitar's Fireballs"),
                    new Spell("Halgwet's Healing Meditation"),
                    new Spell("Pognif Explosion")
                }
            )
        }
    );

    public static ConcurrentDictionary<int, List<Spell>> getAllSpells()
    {
        return allSpells;
    }
}
