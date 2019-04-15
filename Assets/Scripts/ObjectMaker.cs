using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour
{
    //TODO: Ask about what void Awake() does as oppose to how void Start() works.
    // What this script is going to do is take the variables from a script of atmoms, and apply them to the prefab.
    public GameObject Atom_Core;
    public GameObject Electron;
    public int stuff;
    public Transform target;

    float timer = 0;
    float speed;
    float width;
    float height;
    int vElectron;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //startpos is the X and Y position of the mouse curser when the left click is held down.
            Debug.Log("Mouse Position =" + Input.mousePosition);
            Vector3 startpos = Input.mousePosition;

            GameObject newGameObject =  Instantiate(Atom_Core, startpos, Quaternion.identity) as GameObject;

            newGameObject.AddComponent<Rigidbody>();
            newGameObject.GetComponent<H>().valance = vElectron;
        }

        //Each electron will take two laps per second.

        //transform.RotateAround(Atom_Core.transform.position, Atom_Core.transform.up, 720 * Time.deltaTime);


    }
}
