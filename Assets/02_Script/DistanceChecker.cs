// 2024-11-23 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using System;
using UnityEditor;
using UnityEngine;

public class DistanceChecker
{
    const float checkDistance = 3.0f; // 임계 거리 값

    // 거리 체크 함수
    public static bool IsTargetClose(GameObject me, GameObject target)
    {
        if (target == null)
        {
            Debug.LogWarning("타겟이 설정되지 않았습니다.");
            return false;
        }

        float distance = Vector3.Distance(me.transform.position, target.transform.position);
        return distance <= checkDistance;
    }
}
