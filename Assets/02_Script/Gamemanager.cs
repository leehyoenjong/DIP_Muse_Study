using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    private void Awake()
    {
        instance = this;
    }

    public void DestoryObject(GameObject obj)
    {
        Destroy(obj);
    }
}
