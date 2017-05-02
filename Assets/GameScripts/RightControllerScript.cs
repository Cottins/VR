using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControllerScript : MonoBehaviour {

    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private GameObject pickup;

    public GameObject shield;

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }
    // Use this for initialization
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("controller not installed");
            return;
        }

        if (controller.GetPress(triggerButton) && pickup != null)
        {
            pickup.GetComponent<Rigidbody>().isKinematic = true;
            pickup.transform.parent = this.transform;
            Debug.Log("trigger down");
        }
        if (controller.GetPressUp(triggerButton) && pickup != null)
        {
            pickup.GetComponent<Rigidbody>().isKinematic = false;
            pickup.GetComponent<Rigidbody>().velocity = controller.velocity;
            pickup.GetComponent<Rigidbody>().angularVelocity = controller.angularVelocity;
            pickup.transform.parent = null;
            
            Debug.Log("trigger up");
        }

        if (controller.GetPressDown(gripButton))
        {
            pickup = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Baloon" && pickup == null)
        {
            pickup = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        pickup = null;
    }
}
