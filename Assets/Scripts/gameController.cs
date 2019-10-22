using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public GameObject obj;
    public Camera mainCamera;
    public int NumberOfPlayers = 6;
    public int CurrentPlayerId = 0;
    int[] players;
    public bool isTurnOver = false;
    public bool timeForWesteros = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // WestorosPhase();
        players = new int[6];
        players[0] = 0;
        players[1] = 1;
        players[2] = 2;
        players[3] = 3;
        players[4] = 4;
        players[5] = 5;

    }

    // Update is called once per frame
    void Update()
    {
        // PlanningPhase();
        // ActionPhase();
        if (timeForWesteros == true) {
            timeForWesteros = false;
            WestorosPhase();
        }
        
    }

    public void WestorosPhase()
    {
        Debug.Log("Westeros Phase INitiateing");
    }

    void PlanningPhase()
    {
        Debug.Log("Planning Phase initiating");
    }
    void ActionPhase()
    {
        Debug.Log("Action Phase Initianting");
    }
}
