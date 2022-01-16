using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickRestart()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void OnClickRestart2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void OnClickNextStage()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
