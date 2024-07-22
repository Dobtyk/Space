using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;

    void Awake()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
    }
}
