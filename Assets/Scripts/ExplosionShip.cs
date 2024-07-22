using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionShip : MonoBehaviour
{
    private void Awake()
    {
        Invoke("LoadScene", 2.0f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
