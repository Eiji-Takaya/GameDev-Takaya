using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int m_score;
    [SerializeField] Text m_scoreText = null;

    // Start is called before the first frame update
    void Start()
    {
        AddScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int score)
    {
        m_score += score;
        if (m_scoreText)
        {
            m_scoreText.text = "投入金額：" + m_score.ToString("d15") + "円"; // 10桁でゼロ埋め (zero padding) する
        }
    }
}
