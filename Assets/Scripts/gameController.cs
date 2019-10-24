using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public Camera mainCamera;
    public int NumberOfPlayers = 6;
    public int CurrPlayer = 0;
    string[] players;
    public bool isTurnOver = false;
    public bool timeForWesteros = false;
    DataController DataController;
    WesterosCardsIContainer GameData;
    private int GameRoundNumber;
    
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
        DataController = GameObject.FindObjectOfType<DataController>();
        GameData = DataController.LoadGameData();
        ShuffleDeck(GameData);
        GameRoundNumber = 0;
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

    private void ShuffleDeck(WesterosCardsIContainer Deck)
    {
        Debug.Log("shuffling deck WesterosCardsI");
        for (int i=0; i< Deck.WesterosCardsI.Count; i++) {
            WesterosCard temp = Deck.WesterosCardsI[i];
            int randomIndex = Random.Range(0, Deck.WesterosCardsI.Count);
            Deck.WesterosCardsI[i] = Deck.WesterosCardsI[randomIndex];
            Deck.WesterosCardsI[randomIndex] = temp;
        }

        Debug.Log("shuffling deck WesterosCardsII");
        for (int i=0; i< Deck.WesterosCardsII.Count; i++) {
            WesterosCard temp = Deck.WesterosCardsII[i];
            int randomIndex = Random.Range(0, Deck.WesterosCardsII.Count);
            Deck.WesterosCardsII[i] = Deck.WesterosCardsII[randomIndex];
            Deck.WesterosCardsII[randomIndex] = temp;
        }
    }

    public void nextTurn() 
    {
        validateTurnFinishReady();
        CurrPlayer = (CurrPlayer + 1) % NumberOfPlayers;
        int WesterosPhaseChecker = CurrPlayer;
        Debug.Log(players[CurrPlayer] + " finsihing their turn.");
        if (WesterosPhaseChecker == 5) 
        {
            WestorosPhase();
        }
    }

    void validateTurnFinishReady() 
    {
        Debug.Log("validating everything is ready for turn finish.");
    }

    void WestorosPhase()
    {
        Debug.Log("Westeros Phase INitiateing");
        Debug.Log("Westeros card I picked: " + GameData.WesterosCardsI[GameRoundNumber].Name);
        Debug.Log("Westeros card II picked: " + GameData.WesterosCardsII[GameRoundNumber].Name);
        GameRoundNumber += 1;
        if (GameRoundNumber == 10) {
            EndGameProtocol();
        }
    }

    void EndGameProtocol() {
        Debug.Log("game is ended. Time to determine winner");
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
