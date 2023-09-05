using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletContorller : MonoBehaviour
{
    public Vector3 BulletRotation;
    public Vector3 BulletPositon;
    public GameObject Bullet1;

    public void Spawn()
    {
        GameObject Bullet = Instantiate(Bullet1, BulletPositon, Quaternion.identity);
        Bullet.transform.Rotate(BulletRotation);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Spawn();
        }
    }
}
