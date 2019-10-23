using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public GameObject obj;
    public Camera mainCamera;
    public int NumberOfPlayers = 6;
    public int CurrPlayer = 0;
    string[] players;
    public bool isTurnOver = false;
    public bool timeForWesteros = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // WestorosPhase();
        players = new string[6];
        players[0] = "Lannisters";
        players[1] = "Baratheons";
        players[2] = "Tyrells";
        players[3] = "Martells";
        players[4] = "Starks";
        players[5] = "Greyjoys";

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

    public void nextTurn() 
    {
        validateTurnFinishReady();
        CurrPlayer = (CurrPlayer + 1) % NumberOfPlayers;
        Debug.Log(players[CurrPlayer] + "finsihing their turn.");
    }

    void validateTurnFinishReady() 
    {
        Debug.Log("validating everything is ready for turn finish.");
    }

    void WestorosPhase()
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
