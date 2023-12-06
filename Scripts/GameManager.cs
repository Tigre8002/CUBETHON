using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static bool gameHasEnded = false;
    public static GameObject panelUI;

    public static async void CompleteLevel()
    {
        panelUI.SetActive(true);
        await Task.Delay(1000);
        LoadNextLevel.loadNextLevel();
    }

    public static async void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            await Task.Delay(1000);
            
            Restart();
        }
    }

    private static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameHasEnded = false;
    }
}