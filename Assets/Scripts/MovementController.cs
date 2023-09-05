using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int Speed;
    public GameObject tail;
    public GameObject Tank;
    private bool _right = false;
    private bool _left = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _right = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            _right = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _left = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _left = false;
        }

        if (_right)
        {
            Tank.transform.Translate(Vector3.right * Speed);
            tail.transform.position += Vector3.right*Speed;
        }

        if (_left)
        {
            Tank.transform.Translate(Vector3.left * Speed);
            tail.transform.position += Vector3.left*Speed;
        }
        Debug.Log("Degree: "+GetComponent<RectTransform>().rotation.z.ToString());
    }
}
