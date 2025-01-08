using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Actionsmanager;

public class FireworksListener : MonoBehaviour
{
    public GameObject FireworkAnimation;
    public float fireworkShow = 10f; // Giving the fireworks force
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Giving the fireworks the ability to move
    }

    void OnEnable()
    {
        // Subscribe to the basket scored event
        ActionsManager.OnBasketScoredEvent += FireworkShow;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        ActionsManager.OnBasketScoredEvent -= FireworkShow;
    }


    private void FireworkShow()
    {
        Vector3 upwardForce = Vector3.up * fireworkShow; // Calculate throwing fireworks upwards
        rb.AddForce(upwardForce, ForceMode.Impulse); // Giving them force
    }
}
