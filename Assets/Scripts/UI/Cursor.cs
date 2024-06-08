using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cursor : MonoBehaviour
{
    void Update()
    {
        setPosition();
    }
    private void setPosition()
    {
        if (!IsCurrentEventSystemNull())
        {
            transform.position = EventSystem.current.currentSelectedGameObject.transform.position;

        }
    }
    private bool IsCurrentEventSystemNull()
    {
        return EventSystem.current == null || EventSystem.current.currentSelectedGameObject == null;
    }
}
