using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public static Action Collision;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collision?.Invoke();
        }
    }
}
