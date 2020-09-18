using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("InterObject"))
        {
            //check if simple reward
            //check if inventory item (visual only or requirement)
            //check if quest
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObj.SendMessage("DoInteraction");
        }
    }


    // Only if interaction button is needed to interact
    /*private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            if ( other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }*/
}
