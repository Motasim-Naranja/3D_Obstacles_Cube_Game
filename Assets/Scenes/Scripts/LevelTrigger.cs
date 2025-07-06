
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.LevelTrigger();
    }
}
