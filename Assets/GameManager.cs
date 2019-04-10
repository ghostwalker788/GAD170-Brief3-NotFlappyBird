using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //public int set up
    public int score = 0;

    //is call when we fly in a goal
    public UnityEvent onPickUp;
    private UIManager m_CurrentUIManager;

    // Start is called before the first frame update
    void Start()
    {
        m_CurrentUIManager = FindObjectOfType<UIManager>();
    }

    // when called changes score by {amount}
    public void IncrementScore(int amount)
    {
        score += amount;
        Debug.Log("new score is: "+score);
        m_CurrentUIManager.updateScoreText?.Invoke(score);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
