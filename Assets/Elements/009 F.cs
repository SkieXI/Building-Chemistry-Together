using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{

    public F(string name, int publicNumber, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Florine";
        this.publicNumber = 9;
        this.protons = 9;
        this.neutrons = 10;
        this.electrons = 9;
        this.mass = 18.998;
        this.trivia = "This is boron";


    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public double mass { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}