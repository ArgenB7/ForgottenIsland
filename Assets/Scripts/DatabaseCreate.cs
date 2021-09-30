using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DatabaseCreate : MonoBehaviour
{
    // Start is called before the first frame update

    public Image image;
    public GameObject databasePrefab;

    public Canvas canvas;
    public GameObject notificationPrefab;
    public Vector3 notifPosition;
    public Vector3 notifScale;
    public Quaternion notifRotation;

    //public Array databaseObjects;
    public string databaseText;
    public string notificationText;

    private TMP_Text databaseChildText;
    private TMP_Text notifChildText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NotificationLerp(float wait, GameObject notification)
    {
        yield return new WaitForSeconds(wait);
        Destroy(notification);
    }

    public void CreateDatabaseButton()
    {
        var myDatabasePrefab = Instantiate(databasePrefab, transform);
        myDatabasePrefab.GetComponentInChildren<TMP_Text>().SetText(databaseText);
        myDatabasePrefab.transform.parent = image.transform;

        //notification here
        var myNotif = Instantiate(notificationPrefab, transform);
        myNotif.GetComponentInChildren<TMP_Text>().SetText(notificationText);
        
      //  canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        myNotif.transform.parent = canvas.transform;

        myNotif.GetComponent<RectTransform>().anchoredPosition = notifPosition;
        myNotif.GetComponent<RectTransform>().rotation = notifRotation;
        myNotif.GetComponent<RectTransform>().localScale = notifScale;

        StartCoroutine(NotificationLerp(3, myNotif));
    }
}
