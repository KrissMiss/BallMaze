using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    int sceneNum = 0;
    public Text timerText;
    public GameObject losePanel;
    public GameObject winPanel;
    float timer = 0;
    public int finishTime = 60;
    bool isPlaying = true;
    bool playerWin = false;
    [SerializeField] GameObject startPanel;

    // Start is called before the first frame update
    void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
    }

    int roundTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (startPanel.activeInHierarchy == true)
        {
            isPlaying = false;
        }
        else
        {
            isPlaying = true;
        }
            if (isPlaying == true )
            {
                timer += Time.deltaTime;
                roundTime = Mathf.RoundToInt(timer);
                timerText.text = roundTime.ToString();
            }


            if ((roundTime >= finishTime || transform.position.y <= -3) && playerWin == false)
            {
                losePanel.SetActive(true);
                Time.timeScale = 0;
                isPlaying = false;
            }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish") && roundTime < finishTime)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
            isPlaying = false;
            playerWin = true;
        }
    }
}
