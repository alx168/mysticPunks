using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChooseSpellsButton : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private Text spellsText;


    public void onClick() {
        //Debug.Log("hi");
        spellsText.text = "Spells you can choose:\n";
        List<Spell> spells = SpellsLibrary.getAllSpells()[1];
        foreach (Spell spell in spells)
            {
                spellsText.text += spell.name + "\n";
            }
    }

   
}
