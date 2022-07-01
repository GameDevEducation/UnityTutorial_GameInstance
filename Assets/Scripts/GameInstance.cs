using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{
    public enum EGamePhase
    {
        Unknown,

        MainMenu,
        MainLevel
    }

    public EGamePhase Phase { get; private set; } = EGamePhase.Unknown;

    public EGameMode Mode { get; private set; } = EGameMode.Default;

    #region Instance Management
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void LoadPersistentLevel()
    {
        const string LevelName = "PersistentLevel";

        for (int sceneIndex = 0; sceneIndex < SceneManager.sceneCount; sceneIndex++)
        {
            if (SceneManager.GetSceneAt(sceneIndex).name == LevelName)
                return;
        }

        SceneManager.LoadScene(LevelName, LoadSceneMode.Additive);
    }

    public static GameInstance Instance { get; private set; } = null;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError($"Found duplicate GameInstance on {gameObject.name}");
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(Instance);
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameMode(EGameMode mode)
    {
        Mode = mode;
    }

    public void OnEnterMainMenu()
    {
        Phase = EGamePhase.MainMenu;

        Debug.Log(Phase);
    }

    public void OnEnterLevel()
    {
        Phase = EGamePhase.MainLevel;

        Debug.Log(Phase);
    }
}
