using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class H : MonoBehaviour
{
    //Constructor to apply values to each variable.
    public H(string name, int publicNumber, int valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Hydrogen";
        this.publicNumber = 1;
        this.valance = 1;
        this.protons = 1;
        this.neutrons = 0;
        this.electrons = 1;
        this.mass = 1.008;
        this.trivia = "This is hydrogen.";
    }
   
    public string name { get; set; }        // The name of the element
    public int publicNumber { get; set; }   // The number of the element
    public double mass { get; set; }        // The atomic mass
    public int valance { get; set; }        // The number of valance electrons
    public Vector3 valancePOS { get; set; } // The positions of the valance electrons
    public GameObject Hydrogen = GameObject.CreatePrimitive(PrimitiveType.Sphere);  //Which type of prefab is to be created.
    public int RayD = 1;                    // ???
    public LayerMask Test;                  // ??
    public int protons { get; set; }        // Number of Protons 
    public int neutrons { get; set; }       // Number of Neutrons
    public int electrons { get; set; }      // Number of Electrons
    public string trivia { get; set; }      // Trivia or interesting fact.
}