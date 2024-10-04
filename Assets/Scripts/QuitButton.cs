using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Application.Quit(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
