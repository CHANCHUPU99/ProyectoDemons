using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DemonsManager : MonoBehaviour
{
    private List <InterfaceDemon> demons;
    public TextMeshProUGUI demonName;
    public TextMeshProUGUI description;
    public TextMeshProUGUI legions;
    public TextMeshProUGUI direction;
    public TextMeshProUGUI planet;
    public TextMeshProUGUI metal;
    public TextMeshProUGUI element;
    public TextMeshProUGUI zodiaco;
    private int index;
    void Start()
    {
        demons = new List<InterfaceDemon>();
        InterfaceDemon demon0 = new InterfaceDemon("bael", "El primer Rey del Infierno","Sesenta y seis","sur","Sol","oro","Fuego","Aries");
        InterfaceDemon demon1 = new InterfaceDemon("Agares", "puede  ayudar a  los  fugitivos  a  escapar  y  enseña expresiones inmorales, además de acabar con la dignidad de alguien", "Treinta y uno" ,"sur","Venus","Cobre","tierra","Aries" );
        InterfaceDemon demon2 = new InterfaceDemon("Vassago", "Puede conocer el pasado y el futuro y además posee la capacidad de encontrar objetos escondidos o perdidos", "Veintiséis" , "Oeste", "Jupiter","Estaño","agua", "Aries");
        InterfaceDemon demon3 = new InterfaceDemon("Samigina", "Enseña ciencias liberales y da cuenta de las almas que murieron en pecado y de los que se ahogaron en el mar", "Treinta" ,"Oeste","Luna","Plata","agua","Aries");
        InterfaceDemon demon4 = new InterfaceDemon("Marbas", " Posee conocimientos sobre lo oculto y enseña artes mecanicas", "Treinta y seis", "Este","Mercurio","Mercurio","Aire","Aries");
        InterfaceDemon demon5 = new InterfaceDemon("Valefor", "una de sus misiones principales es la de tentar a robar a las personas", "Diez" ,"Norte", "Venus","cobre","Tierra","Aries");
        InterfaceDemon demon6 = new InterfaceDemon("AAmon", "Conoce hechos pasados y futuros y puede ayudar a recon-ciliar a enemigos aunque también todo lo contrario", "Cuarenta" ,"Oeste","luna","Plata","Agua","Tauro");
        InterfaceDemon demon7 = new InterfaceDemon("Barbatos", "Conoce pasado y futuro, reconcilia a amigos en conflicto y da la capacidad de entender las lenguas de los animales", "Treinta" , "Sur", "Venus", "cobre" ,"Fuego", "Tauro");
        InterfaceDemon demon8 = new InterfaceDemon("Paimon", "Paimon enseña todas las artes, las filosofías, las ciencias y las cosas secretas; puede revelar todos los misterios de la tierra , el viento y el agua, lo que es la mente y todo lo que el conjurador quiera saber" , "Doscientos" , "Oeste","Sol","Oro","Agua","Tauro");
        InterfaceDemon demon9 = new InterfaceDemon("Buer", "Aparece cuando el Sol está en Sagitario. Al igual que Quirón, el centauro principal de la mitología griega, enseña filosofía natural y moral, lógica y las virtudes de todas las hierbas y plantas, y también es capaz de curar todas las enfermedades" , "Cincuenta" , "Sur" , "Mercurio" , "Mercurio","Fuego","Tauro");
        demons.Add(demon0);
        demons.Add(demon1);
        demons.Add(demon2);
        demons.Add(demon3);
        demons.Add(demon4);
        demons.Add(demon5);
        demons.Add(demon6);
        demons.Add(demon7);
        demons.Add(demon8);
        demons.Add(demon9);
        //Demonios demon10 = new Demonios("Guison", "Conoce todo lo referente al pasado, presente y futuro, responde todas las preguntas que se le hagan, reconcilia a los amigos y otorga honor y dignidad.", "Cuarenta" ,"Oeste","Venus","Cobre","Agua","Tauro");

        showDemons();

        //print(demon0.demonElements());
        //print(demon1.demonElements());
        //print(demon2.demonElements());
        //print(demon3.demonElements());
        //print(demon4.demonElements());
        //print(demon5.demonElements());
        //print(demon6.demonElements());            
        //print(demon7.demonElements());
        //print(demon8.demonElements());
        //print(demon9.demonElements());

        //print(demon10.demonElements());
    }

    private void showDemons() {
        demonName.text = demons[index].getName();
        description.text = demons[index].getDescription();
        legions.text = demons[index].getLegions();
        direction.text = demons[index].getDirection();
        planet.text = demons[index].getPlanet();
        metal.text = demons[index].getMetal();
        element.text = demons[index].getElement();
        zodiaco.text = demons[index].getZodiaco();

        index++;
      

    }
    public void nextDemons() {
        demonName.text = demons[index].getName();
        description.text = demons[index].getDescription();
        legions.text = demons[index].getLegions();
        direction.text = demons[index].getDirection();
        planet.text = demons[index].getPlanet();
        metal.text = demons[index].getMetal();
        element.text = demons[index].getElement();
        zodiaco.text = demons[index].getZodiaco();

        index++;
        if (index >= demons.Count) {
            index = 0;
        }

    }
}
