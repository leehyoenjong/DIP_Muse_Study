// 2024-11-24 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using System;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster")
        {
            Destroy(other.gameObject);
        }

        // 총알은 충돌 후 파괴됩니다.
        Destroy(gameObject);


    }
}