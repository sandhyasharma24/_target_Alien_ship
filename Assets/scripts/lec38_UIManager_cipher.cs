using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec38_UIManager_cipher : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject gamePanel;

    void ShowPanel(GameObject panelToShow) 
    { 
    startPanel.SetActive(false);
    gamePanel.SetActive(false);


    panelToShow.SetActive(true);
    }
    public void OnClickStartButton() { 
    ShowPanel(gamePanel);
        lec31_gameplay_cipher.instance.StartSpawningTarget();
    }
}
