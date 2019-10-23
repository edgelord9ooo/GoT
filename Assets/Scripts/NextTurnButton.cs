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
        theStateManager.nextTurn();
        Debug.Log(theStateManager.CurrPlayer + " is finishing their turn.");
    }
}
