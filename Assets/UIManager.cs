using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


[System.Serializable]
public class MyIntEvent : UnityEvent<int>
{


}

public class UIManager : MonoBehaviour
{

    public Text ScoreText;

    public MyIntEvent updateScoreText;

    // Start is called before the first frame update
    void Start()
    {
        updateScoreText.AddListener(UpdateScoreText);
    }

    public void UpdateScoreText(int amount)
    {
        ScoreText.text = "Score: " + amount;
    }

    // gets the current active sceen and ads one to it to load the next scene.
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
