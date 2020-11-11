using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void using UnityEngine.SceneManagement;
        public void StartGame() => SceneManager.LoadScene("RocketMouse");
public Animator startButton;
public Animator settingsButton;
public void OpenSettings()
{
startButton.SetBool("isHidden", true);
settingsButton.SetBool("isHidden", true);
}
{public Animator dialog;
public void OpenSettings()
{
    //..skipped..

    dialog.SetBool("isHidden", false);
}
        
    }

    // Update is called once per frame
    void 
    {
        
    }
}public void CloseSettings()
{
    startButton.SetBool("isHidden", false);
    settingsButton.SetBool("isHidden", false);
    dialog.SetBool("isHidden", true);
}
