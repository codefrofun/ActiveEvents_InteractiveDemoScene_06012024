using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Actionsmanager;

public class BasketballAction : MonoBehaviour
{
    public float throwBall = 12f; // Force of basketball, changes in inspector
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Throw ball when you press space
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        // Throw forward
        Vector3 forwardForce = transform.forward * throwBall;
        // Throw upward
        Vector3 upwardForce = Vector3.up * throwBall;

        rb.AddForce(forwardForce + upwardForce, ForceMode.Impulse); // Adding forces for ball to move forward to net, and up to sky
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket"))
        {
            ActionsManager.OnBasketScoredEvent?.Invoke();
        }
    }
}