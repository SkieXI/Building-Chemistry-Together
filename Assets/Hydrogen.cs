using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hydrogen : MonoBehaviour {

    public bool isDragging;

	// Update is called once per frame
	void Update ()
    {
        if (!isDragging)
        {
            return;
        }
		
	}

    public void OnBeingDrag(PointerEventData data)
    {
        isDragging = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        isDragging = false;
    }
}
