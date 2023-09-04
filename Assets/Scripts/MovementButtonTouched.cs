using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MovementButtonTouched : MonoBehaviour
{
    public int Speed;
    public int XPos;
    public GameObject Tank;
    public void ButtonTouched()
    {
        Tank.transform.Translate(Vector3.left*Speed*XPos);
    }
}
