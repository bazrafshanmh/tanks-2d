using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TailController : MonoBehaviour
{
    public int Rotation;
    private bool _up = false;
    private bool _down = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _up = true;
        }else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            _up = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _down = true;
        }else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            _down = false;
        }
        if (_up)
        {
            transform.Rotate(Vector3.forward*Rotation);
        }
        if (_down)
        {
            transform.Rotate(Vector3.back*Rotation);

        }
    }
}
