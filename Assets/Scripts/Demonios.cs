using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Demonios {
    private string name;
    private string description;
    private int knowLedge;
    private string legions;
    private string direction;
    private string planet;
    private string metal;
    private string element;
    private string zodiaco;

   public Demonios(string name, string description, string legions, string direction, string planet, string metal, string element, string zodiaco) {
        this.name = name;
        this.description = description;
        this.legions = legions;
        this.direction = direction;
        this.planet = planet;
        this.metal = metal;
        this.element = element;
        this.zodiaco = zodiaco;
    }

    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }
    public string Legions { get { return legions; } set { legions = value; } }
    public string Direction { get { return direction; } set { direction = value; } }
    public string Planet { get { return planet; } set { planet = value; } }
    public string Metal { get { return metal; } set { metal = value; } }
    public string Element { get { return element; } set { element = value; } }
    public string Zodiaco { get { return zodiaco; } set { zodiaco = value; } }

    public string demonElements() {
        return name + description + legions + Direction + planet + metal + element + zodiaco;
    }
}
