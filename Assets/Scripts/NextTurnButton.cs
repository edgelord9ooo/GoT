using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        theStateManager = GameObject.FindObjectOfType<gameController>();
        DataController = GameObject.FindObjectOfType<DataController>();
        Debug.Log(theStateManager);
    }

    gameController theStateManager;
    DataController DataController;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp() {
        SkipTurn();
    }

    void SkipTurn() {

        if (!theStateManager.isTurnOver) {
            theStateManager.CurrentPlayerId = (theStateManager.CurrentPlayerId + 1) % 6;
            Debug.Log("current turn is " + theStateManager.CurrentPlayerId);
        }
        if (theStateManager.CurrentPlayerId == 5) {
            theStateManager.timeForWesteros = true;
        }
    }
}
