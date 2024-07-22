using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public List<GameObject> asteroids;
    public float minDelay, maxDelay, nextLaunchTime;

    void Awake()
    {

    }

    void Update()
    {
        if (Time.time > nextLaunchTime)
        {
            var positionX = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
            Instantiate(asteroids[Random.Range(0, 5)], new Vector3(positionX, 30, transform.position.z), Quaternion.identity);
            nextLaunchTime = Time.time + Random.Range(minDelay, maxDelay);
        }
    }
}
