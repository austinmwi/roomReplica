using UnityEngine;
using System.Collections;

public class dropPoint : MonoBehaviour {
    public GameObject droppedPointPrefab; //This is our dot prefab
    public GameObject controller; //We only need one controller

    public int delay = 20; //Using a simple count up mechanism instead of a coroutine or invokerepeating because I'm lazy and the point is to get this done quickly
    private int delayCounter = 0;

	void Update () {
        if (controller.GetComponent<SteamVR_TrackedController>().triggerPressed) { //If we've pressed the trigger
            if(delayCounter <= 0) { //If our timer is up
                Instantiate(droppedPointPrefab, this.transform.position, this.transform.rotation); //Drop a ball in place
                delayCounter = delay; //Reset our delay counter
            } else {
                delayCounter--;
            }
        } else {
            delayCounter = 0;
        }
    }
}
