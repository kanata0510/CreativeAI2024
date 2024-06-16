using UnityEngine;
using UnityEngine.EventSystems;

public class SetFirstFocus : MonoBehaviour
{
    [SerializeField] private GameObject headButton;
    [SerializeField] private GameObject cursor;
    void OnEnable()
    {
        Debug.Log("OnEnable");
        SetButtonFocus();
        SetCursorPosition();
    }
    void Start()
    {
        SetButtonFocus();
        SetCursorPosition();
    }
    private void SetButtonFocus()
    {
        EventSystem.current.SetSelectedGameObject(headButton);
    }

    private void SetCursorPosition()
    {
        if (EventSystem.current!=null)
        cursor.transform.position = EventSystem.current.currentSelectedGameObject.transform.position;
    }
}
