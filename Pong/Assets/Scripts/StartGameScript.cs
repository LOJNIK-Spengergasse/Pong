using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("PongScene");
    }

    public void NormalGame()
    {
        GlobalData.isAI = false;
        StartGame();
    }
    public void ComGame()
    {
        GlobalData.isAI = true;
        GlobalData.AIerrorRange = 0.2f;
        StartGame();
    }

    public void ComGameH()
    {
        GlobalData.isAI = true;
        GlobalData.AIerrorRange = 0.1f;
        StartGame();
    }
}
