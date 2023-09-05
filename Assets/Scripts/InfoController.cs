using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoController : MonoBehaviour
{
    public GameObject Tail;
    public PowerController powerController;
    private float _power;
    private float _degree;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Power: "+powerController.GetPower().ToString()+"\nDegree: "+ Tail.transform.rotation.z.ToString();
        
    }
}
