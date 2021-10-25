using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCursor : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D mainCursor;

    public Texture2D[] greyCursors;
    public Texture2D[] activeCursors;

    public int index;

    [HideInInspector]
    public bool mouseOver;
    public bool inRange;
    public bool uiOpen = false;

    Vector2 cursorOffset;

    private void Start()
    {
        cursorOffset = new Vector2(mainCursor.width / 2, mainCursor.height / 2);

    //    DontDestroyOnLoad(this.gameObject);
    }
        private void FixedUpdate()
    {
        if (mouseOver)
        {
            if (inRange)
            {
                Cursor.SetCursor(activeCursors[index], cursorOffset, CursorMode.Auto);
            } else
            {
                Cursor.SetCursor(greyCursors[index], cursorOffset, CursorMode.Auto);
            }
        }

        else if (uiOpen)
        {
            Cursor.SetCursor(mainCursor, cursorOffset, CursorMode.Auto);
        }

        else
        {
            //   Vector2 cursorOffset = new Vector2(mainCursor.width / 2, mainCursor.height / 2);
            Cursor.SetCursor(mainCursor, cursorOffset, CursorMode.Auto);
        }
    }

    public void UIClose()
    {
        uiOpen = false;
    }

    public void UIOpen()
    {
        uiOpen = true;
    }
}
