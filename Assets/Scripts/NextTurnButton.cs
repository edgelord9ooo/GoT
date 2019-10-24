using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        theStateManager = GameObject.FindObjectOfType<gameController>();
    }

    gameController theStateManager;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp() {
        theStateManager.nextTurn();
    }
}
