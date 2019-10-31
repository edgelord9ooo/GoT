using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string family;
    public int influencePoints;
    public List<string> tokensHeld;
    public int supply;
    public int victoryPoints;

    public Player(string fam, int influence, List<string> tokens, int supp, int vicPoints)
    {
        family = fam;
        influencePoints = influence; 
        tokensHeld = tokens;
        supply = supp;
        victoryPoints = vicPoints;
    }
}
