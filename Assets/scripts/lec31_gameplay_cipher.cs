using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lec31_gameplay_cipher : MonoBehaviour
{
    public static lec31_gameplay_cipher instance;
    //reference of prefab
    [SerializeField] GameObject targetPrefab;
    [SerializeField] GameObject winPanel;
    int score = 0;
    bool hasWon = false;
    [SerializeField] Text scoretext;

    private void Awake()
    {
        if (!instance) instance = this; 
    }
    private void Start()

    {
        winPanel.SetActive(false);
        //
        //to instiate ships again and again
    }
    public void StartSpawningTarget() {
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }
    private void Update()
    {
        if (hasWon)
        {
            CancelInvoke("SpawnTarget");
        }
    }

    void SpawnTarget() 
    {
        float xPos = Random.Range(-7.5f, 7.5f);
        float yPos = Random.Range(-4f,4f);
        Vector3 randomTargetPos = new Vector3(xPos, yPos,0);
        //quaternion.identity for no rotation
        Instantiate(targetPrefab,randomTargetPos,Quaternion.identity);   
    }
    public void IncrementScore() {
        score++;
        scoretext.text = score.ToString();

        if(score >= 20)
        {
            winPanel.SetActive(true);
            hasWon = true;
        }
    }
}
