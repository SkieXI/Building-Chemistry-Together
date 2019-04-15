using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {

    private void OnCollisionEnter(Collision tray)
    {
        //As soon as the mouse click is lifted, this should kick in.
        if (!Input.GetMouseButtonDown(0))
        {
            //If the prefab is located outside of the mesh, it will be destoryed. 
            if (tray.gameObject.name != "tray1")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
