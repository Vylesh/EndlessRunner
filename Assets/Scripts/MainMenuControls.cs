using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
