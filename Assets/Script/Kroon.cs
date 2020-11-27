using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kroon : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab = null;
    [SerializeField] Transform muzzle = null;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<BallController>())
        {
            Destroy(collision.gameObject);
            Shoot();
        }
    }
    void Shoot()
    {
        if (BallPrefab && muzzle) // m_bulletPrefab にプレハブが設定されている時 かつ m_muzzle に弾の発射位置が設定されている時
        {
            GameObject go = Instantiate(BallPrefab, muzzle.position, BallPrefab.transform.rotation);  // インスペクターから設定した m_bulletPrefab をインスタンス化する
            go.transform.SetParent(this.transform);
        }
    }
}
