using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameInstance.Instance.OnEnterMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPlayGame(EGameMode mode)
    {
        GameInstance.Instance.SetGameMode(mode);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Level");
    }

    public void OnPlayGame_Default()
    {
        OnPlayGame(EGameMode.Default);
    }

    public void OnPlayGame_Slow()
    {
        OnPlayGame(EGameMode.Slow);
    }

    public void OnPlayGame_Fast()
    {
        OnPlayGame(EGameMode.Fast);
    }
}
