using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class StartAndExitButtonHandler : MonoBehaviour
{
    public GameObject menuObject;

    public Button exitButton;

    void Start()
    {
        Button startButton = GetComponent<Button>();
        if (startButton != null)
        {
            startButton.onClick.AddListener(HideMenu);
        }

        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
    }

    void HideMenu()
    {
        if (menuObject != null)
        {
            menuObject.SetActive(false);
        }
    }

    
    void ExitGame()
    {
#if UNITY_EDITOR
        
        EditorApplication.isPlaying = false;
#else
    
        Application.Quit();
#endif
        Debug.Log("Oyun kapatılmaya çalışıldı.");
    }
}
