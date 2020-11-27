using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGanerator : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab = null;
    [SerializeField] int m_score = 4000;
    [SerializeField, Range(0.1f, 1f)] float m_interval = 0.25f;
    float m_timer;

    void Update()
    {
        m_timer += Time.deltaTime;

        if (Input.GetButton("Fire1") && m_timer > m_interval)
        {
            m_timer = 0;
            GameObject go = Instantiate(ballPrefab) as GameObject;
            go.transform.position = new Vector3(0, 10, 24);

            GameManager gm = GameManager.FindObjectOfType<GameManager>();
            if (gm)
            {
                gm.AddScore(m_score);
            }
        }
    }
}
