using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cl : MonoBehaviour {

    public Cl(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Chlorine";
        this.publicNumber = 17;
        this.valance = 7;
        this.protons = 17;
        this.neutrons = 18;
        this.electrons = 17;
        this.mass = 35.453;
        this.trivia = "This is chlorine.";


    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public double mass { get; set; }
    public int valance { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}