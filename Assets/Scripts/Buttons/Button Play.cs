using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
