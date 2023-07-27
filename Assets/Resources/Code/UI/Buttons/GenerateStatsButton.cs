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
        private Text inventoryText;

    public void onClick() {
        initInventory();
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
        player.canCastSpells = player.inte >= 10;
        GameUtils.updateTextBoxAndLogToConsole(prettyStats(player), statsText);
    }
    private void initInventory()
    {
        player.inventory = new List<Item>();
        player.inventory.Add(new Item("Switchblade of Krungt", 1, "fighting"));
        //Need to maybe set up another textbox that displays inventory? Not sure how to do UI for inventory stuff.
        GameUtils.updateTextBoxAndLogToConsole(prettyInventory(player), inventoryText);
    }

    private string prettyStats(Player player) {
        var playerStats = player.getPlayerStats();
        string logStats = "";
        foreach (string key in playerStats.Keys)
        {
            logStats += string.Format("{0}: {1}", key, playerStats[key] + "\n");
        }
        return logStats;
    }    

    private string prettyInventory(Player player) {
        var playerInventory = player.inventory;
        string logStats = "";
        foreach (Item item in playerInventory) {
            logStats += string.Format("{0}: {1} {2}", item.name, item.modVal, item.modModded);
        }
        return logStats;
    }
}
