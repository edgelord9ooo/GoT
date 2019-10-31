using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() 
    {
        theStateManager = GameObject.FindObjectOfType<gameController>();
        textButton = this.gameObject.GetComponentInChildren<Text>().text;
    }

    public gameController theStateManager;
    public string textButton;
    public void assignOrderClicked() 
    {
        theStateManager.assignOrder(textButton);
    }
    
}
