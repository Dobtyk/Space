using UnityEngine;

public class LaserGun : MonoBehaviour
{
    public GameObject LaserShot;
    public float shotDelay;
    float nextShotTime;

    void Update()
    {
        if (Time.time > nextShotTime && Input.GetButton("Fire1"))
        {
            Vector3 a = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(LaserShot, a, Quaternion.identity);
            nextShotTime = Time.time + shotDelay;
        }
    }
}