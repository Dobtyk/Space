using UnityEngine;

public class Ship : MonoBehaviour
{
    public Transform LaserGun;
    public float xMin, xMax, zMin, zMax, tilt, speed;

    Rigidbody _rigidbodyShip;

    void Awake()
    {
        _rigidbodyShip = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var moveVertical = Input.GetAxis("Vertical");
        var moveHorizontal = Input.GetAxis("Horizontal");
        _rigidbodyShip.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed;

        var restrictedX = Mathf.Clamp(_rigidbodyShip.position.x, xMin, xMax);
        var restrictedZ = Mathf.Clamp(_rigidbodyShip.position.z, zMin, zMax);
        _rigidbodyShip.position = new Vector3(restrictedX, 30, restrictedZ);

        _rigidbodyShip.rotation = Quaternion.Euler(_rigidbodyShip.velocity.z * tilt, 0, -_rigidbodyShip.velocity.x * tilt);
    }
}