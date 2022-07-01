using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameInstance.Instance.OnEnterLevel();

        Debug.Log($"Starting game with mode {GameInstance.Instance.Mode}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnReturnToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
