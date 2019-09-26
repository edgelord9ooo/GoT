using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject obj;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        WestorosPhase();
    }

    // Update is called once per frame
    void Update()
    {
        PlanningPhase();
        ActionPhase();
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
