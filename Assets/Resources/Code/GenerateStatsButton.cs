using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GenerateStatsButton : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private Text statsText;
    [SerializeField]

    public void onClick() {
        populateStats();
    }
    public void populateStats()
    {
        player.vig = GameUtils.rand1d20();
        player.hp = player.vig + 5;
        player.agil = GameUtils.rand1d20();
        player.inte = GameUtils.rand1d20();
        player.soc = GameUtils.rand1d20();
        player.cun = GameUtils.rand1d20();
        GameUtils.updateTextBoxAndLogToConsole(player.prettyStats(), statsText);
    }
}
