using UnityEngine;

public class MyUntitySingleton : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
