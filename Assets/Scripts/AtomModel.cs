using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomModel : MonoBehaviour
{
    //private HeScript He;

    public AtomModel(string name, int publicNumber, int valance, int protons, int neutrons, int electrons, double mass, string trivia)
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

    public int publicNumber;
    public int group;
    public int block;
    public int valance;
    public string Name;
    public int protons;
    public int neutrons;
    public int electrons;


    public double mass;
    public string trivia;

    public void setPubNumber(int num)
    {
        publicNumber = num;
    }

}
