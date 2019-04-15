using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FirstTray : MonoBehaviour
{
    static public Vector3 POS = Vector3.zero;
    public static UnityEvent ballance;
    
    public Transform Gravity;

	void FixedUpdate ()
    {
        Vector3 POS = transform.position;
        // POS.x = 
		
	}

    private void electronBallance(int V, int V2)
    {
        // How to subscribe to an event Class.Onclicked += Function
        // How to unsbuscribe to an event. Class.onclicked -= Function

        //Good rule of thumb: When you have an event subsribed, you must also have an unsubscribed button.

    }
}
