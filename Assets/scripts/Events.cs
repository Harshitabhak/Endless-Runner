using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
   public void ReplayGame()
    {
        SceneManager.LoadScene("game");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");

    }
}
