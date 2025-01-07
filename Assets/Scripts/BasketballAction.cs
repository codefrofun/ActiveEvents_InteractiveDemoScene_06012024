using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Actionsmanager;

public class BasketballAction : MonoBehaviour
{
    public float throwBall = 10f; // Force ball to throw
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
        // add force... Vector3
        rb.AddForce(Vector3.up * throwBall, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Basket"))
        {
            ActionsManager.OnBasketScoredEvent?.Invoke();
        }
    }
}