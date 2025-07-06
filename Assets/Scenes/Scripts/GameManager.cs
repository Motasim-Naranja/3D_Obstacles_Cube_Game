using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;

    bool StateEndGame = false;
    public void EndGame()
        {
        if (StateEndGame == false) 
            { 
            Invoke("Restart",2f);
            StateEndGame = true;
            }
        }

    void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    public void LevelTrigger()
        {
            levelCompleteUI.SetActive(true);
        }

}
