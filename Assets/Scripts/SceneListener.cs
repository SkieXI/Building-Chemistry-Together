using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneListener : MonoBehaviour
{
    public Button He;


    // Use this for initialization
    void Start ()
    {
        He.onClick.AddListener(SpawnTest);
	}

    public void SpawnTest()
    {
        Debug.Log("Button HYDROGEN is pressed.");

    }
	
	// Update is called once per frame
	void Update ()
    {

        //Code that allows the prefab to follow around the mouse cursos as its being dragged across the screen.
        Vector3 Mousecursor1 = Input.mousePosition;

        Mousecursor1.z = -Camera.main.transform.position.z;

        Vector3 Mousecursor2 = Camera.main.ScreenToWorldPoint(Mousecursor1);

        Vector3 POS = this.transform.position;
        POS.x = Mousecursor2.x;
        POS.y = Mousecursor2.y;

        this.transform.position = POS;

        //If the mouse button is let go, and its not within the trey, it will be destoryed.

        //if () //This is for detecting the position of the cylinder of the trey.
            //The radius of the cylinder is 
        {
            Destroy(this.gameObject);
        }

	}

    void setPubNumber(int num)
    {

    }
}
