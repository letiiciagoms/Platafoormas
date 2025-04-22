using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
