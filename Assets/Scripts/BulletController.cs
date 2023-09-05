using UnityEngine;
using DG.Tweening;
public class BulletController : MonoBehaviour
{
    public static int Force;
    public int Speed;
    public int Degree;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.DOMove(new Vector3(Speed,Degree,0),Speed/10f);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
