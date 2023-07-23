using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Demons : MonoBehaviour
{
    public abstract string getName();
    public abstract string getDescription();
    public abstract string getLegions();
    public abstract string getDirection();
    public abstract string getPlanet();
    public abstract string getMetal();
    public abstract string getElement();
    public abstract string getZodiaco();
    public abstract void setName(string name);
    public abstract void setDescription(string description);
    public abstract void setDirection(string direction);
    public abstract void setLegions(string legions);
    public abstract void setPlanet(string planet);
    public abstract void setMetal(string metal);
    public abstract void setElement(string element);
    public abstract void setZodiaco(string zodiaco);
}

public class InterfaceDemon : Demons
{
    public override string getName()
    {
        return name;
    }
    public override string getDescription() {
        return description;
    }
    public override string getLegions()
    {
        return legions;
    }
    public override string getDirection()
    {
        return direction;
    }
    public override string getPlanet()
    {
        return planet;
    }
    public override string getMetal()
    {
        return metal;
    }
    public override string getElement()
    {
        return element;
    }
    public override string getZodiaco()
    {
        return zodiaco;
    }
    public override void setName(string name)
    {
        this.name = name;
    }
    public override void setDescription(string description) {
        this.description = description;
    }
    public override void setDirection(string direction)
    {
        this.direction = direction;
    }
    public override void setLegions(string legions)
    {
        this.legions = legions;
    }
    public override void setPlanet(string planet)
    {
        this.planet = planet;
    }
    public override void setMetal(string metal)
    {
        this.metal = metal;
    }
    public override void setElement(string element)
    {
        this.element = element;
    }
    public override void setZodiaco(string zodiaco)
    {
        this.zodiaco = zodiaco;
    }

    private string name;
    private string description;
    private string legions;
    private string direction;
    private string planet;
    private string metal;
    private string element;
    private string zodiaco;

    public InterfaceDemon(string name, string description, string legions, string direction, string planet, string metal, string element, string zodiaco)
    {
        this.name = name;
        this.description = description;
        this.legions = legions;
        this.direction = direction;
        this.planet = planet;
        this.metal = metal;
        this.element = element;
        this.zodiaco = zodiaco;
    }

    //public string Name { get { return name; } set { name = value; } }
    //public string Description { get { return description; } set { description = value; } }
    //public string Legions { get { return legions; } set { legions = value; } }
    //public string Direction { get { return direction; } set { direction = value; } }
    //public string Planet { get { return planet; } set { planet = value; } }
    //public string Metal { get { return metal; } set { metal = value; } }
    //public string Element { get { return element; } set { element = value; } }
    //public string Zodiaco { get { return zodiaco; } set { zodiaco = value; } }

    public string demonElements()
    {
        return getName() + getLegions() + getDescription() + getDirection() + getPlanet() + getMetal() + getElement() + getZodiaco();
        //return name + description + legions + Direction + planet + metal + element + zodiaco;
    }
}
