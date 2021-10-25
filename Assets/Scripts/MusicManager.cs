using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AK.Wwise.Event MyEvent;
    // Use this for initialization.
    void Awake()
    {
        //  var go = GameObject.Find("WwiseGlobal");
       // MyEvent.Post(gameObject);
        //    MyEvent = go.GetComponent<AK.Wwise.Event>();
    }

    public void StopSound()
    {
        MyEvent.Post(gameObject);
    }
}
