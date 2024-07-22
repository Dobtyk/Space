using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float speed;

    Vector3 startPosition;

    void Awake()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        var offset = Mathf.Repeat(speed * Time.time, 200);
        startPosition.z = -offset;
        transform.position = startPosition;
    }
}
