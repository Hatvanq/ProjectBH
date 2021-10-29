using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static List<GameObject> bullets;
    void Start()
    {
        bullets = new List<GameObject>();
    }
    public static GameObject GetBulletFromPool()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (bullets[i].active == false)
            {
                bullets[i].GetComponent<Bullet>().ResetTimer();
                bullets[i].SetActive(true);
                return bullets[i];
            }
        } 
        return null;
    }

}
