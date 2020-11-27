using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
