using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public DraggableObject draggableObject;
    public int AccessDistance = 20;
    public string FlagName;

    Vector3 startPos;
    GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        draggableObject.StartDragAction += FlagStartDrag;
        draggableObject.EndDragAction += FlagEndDrag;

        var go = GameObject.Find("GameManager");
        if (go != null)
        {
            gameManager = go.GetComponent<GameManager>();
        }
    }

    private void FlagStartDrag()
    {
        startPos = draggableObject.transform.position;
    }

    private void FlagEndDrag()
    {
        Vector3 position = transform.localPosition;
        if (Mathf.Abs(position.x) < AccessDistance && Mathf.Abs(position.y) < AccessDistance)
        {
            if (!gameManager.MatchName(FlagName))
            {
                draggableObject.transform.position = startPos;
            }
        }
        else
        {
            draggableObject.transform.position = startPos;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        draggableObject.StartDragAction -= FlagStartDrag;
    }
}
