using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        theStateManager = GameObject.FindObjectOfType<gameController>();

    }
    public string name;
    public gameController theStateManager;

    // Update is called once per frame
    void Update()
    {
        
    }
    private string OnMouseUp() {
        theStateManager.processRegionClick(name);
        return name;
    }
}
