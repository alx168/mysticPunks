using UnityEngine;
using UnityEngine.UI;

public class GameUtils : MonoBehaviour
{
    public static int rand1d20()
    {
        return Random.Range(1, 21);
    }

    public static void updateTextBoxAndLogToConsole(string logline, Text textbox) {
        Debug.Log("updating: " + textbox.name);
        Debug.Log(logline);
        textbox.text = logline;
    }

    public static int rand1d10()
    {
        return Random.Range(1,11);
    }
}
