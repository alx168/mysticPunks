using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshTextBoxes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    Put on the game manager
    Should this class work with the update function and have textboxes as the parameters so that it updates the textboxes once per frame?
    Or should this class work with the buttons such that each time a button is clicked it will update the textboxes? - problem is if you pick up an item, that's not a button click
    Or should this class be on the manager to watch for all events that might be relevant to the textboxes and then update the textboxes if so. How would this event driven system look?
    */
}
