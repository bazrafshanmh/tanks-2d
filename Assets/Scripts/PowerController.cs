using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    private float _power;
    public int powerSum;
    private int _multiplyer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _multiplyer = 1;
        }else if (Input.GetKeyUp(KeyCode.A))
        {
            _multiplyer = 0;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _multiplyer = -1;
        }else if (Input.GetKeyUp(KeyCode.D))
        {
            _multiplyer = 0;
        }
        _power += powerSum*_multiplyer;
        Debug.Log("Power: "+ _power.ToString());
    }

    public float GetPower()
    {
        return _power;
    }
}
