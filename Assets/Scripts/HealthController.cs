using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int Health;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Bullet"))
        {
            // Health -= other.transform.GetComponent<BulletController.Force>();
            Debug.Log("Decrease Force");
        }
    }
}
