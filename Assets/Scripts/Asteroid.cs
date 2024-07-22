using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    public float rotationSpeed, minSpeed, maxSpeed, minSize, maxSize;
    public GameObject explosionShip, explosionAsteroid;

    Rigidbody _rigidbodyAsteroid;
    float _size;

    void Awake()
    {
        _size = Random.Range(minSize, maxSize);
        _rigidbodyAsteroid = GetComponent<Rigidbody>();
        _rigidbodyAsteroid.angularVelocity = Random.insideUnitSphere * rotationSpeed;
        var speed = Random.Range(minSpeed, maxSpeed);
        _rigidbodyAsteroid.velocity = new Vector3(0, 0, -speed);
        transform.localScale *= _size;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameBoundary"))
        {
            return;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);

        var explosion = Instantiate(explosionAsteroid, transform.position, Quaternion.identity);
        explosion.transform.localScale *= _size;

        if (other.CompareTag("Ship"))
        {
            Instantiate(explosionShip, other.transform.position, Quaternion.identity);
            
        }
        else if (other.CompareTag("Laser"))
        {
            GameManager.instance.IncreaseScore(1);
        }
    }
}