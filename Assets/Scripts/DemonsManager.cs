using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class DemonsManager : MonoBehaviour
{

    Demonios m_demonnios;
    void Start()
    {
       
        Demonios demon0 = new Demonios("bael", "El primer Rey del Infierno","Sesenta y seis","sur","Sol","oro","Fuego","Aries");
        Demonios demon1 = new Demonios("Agares", "puede  ayudar a  los  fugitivos  a  escapar  y  ense�a expresiones inmorales, adem�s de acabar con la dignidad de alguien", "Treinta y uno" ,"sur","Venus","Cobre","tierra","Aries" );
        Demonios demon2 = new Demonios("Vassago", "Puede conocer el pasado y el futuro y adem�s posee la capacidad de encontrar objetos escondidos o perdidos", "Veintis�is" , "Oeste", "Jupiter","Esta�o","agua", "Aries");
        Demonios demon3 = new Demonios("Samigina", "Ense�a ciencias liberales y da cuenta de las almas que murieron en pecado y de los que se ahogaron en el mar", "Treinta" ,"Oeste","Luna","Plata","agua","Aries");
        Demonios demon4 = new Demonios("Marbas", " Posee conocimientos sobre lo oculto y ense�a artes mecanicas", "Treinta y seis", "Este","Mercurio","Mercurio","Aire","Aries");
        Demonios demon5 = new Demonios("Valefor", "una de sus misiones principales es la de tentar a robar a las personas", "Diez" ,"Norte", "Venus","cobre","Tierra","Aries");
        Demonios demon6 = new Demonios("AAmon", "Conoce hechos pasados y futuros y puede ayudar a recon-ciliar a enemigos aunque tambi�n todo lo contrario", "Cuarenta" ,"Oeste","luna","Plata","Agua","Tauro");
        Demonios demon7 = new Demonios("Barbatos", "Conoce pasado y futuro, reconcilia a amigos en conflicto y da la capacidad de entender las lenguas de los animales", "Treinta" , "Sur", "Venus", "cobre" ,"Fuego", "Tauro");
        Demonios demon8 = new Demonios("Paimon", "Paimon ense�a todas las artes, las filosof�as, las ciencias y las cosas secretas; puede revelar todos los misterios de la tierra , el viento y el agua, lo que es la mente y todo lo que el conjurador quiera saber" , "Doscientos" , "Oeste","Sol","Oro","Agua","Tauro");
        Demonios demon9 = new Demonios("Buer", "Aparece cuando el Sol est� en Sagitario. Al igual que Quir�n, el centauro principal de la mitolog�a griega, ense�a filosof�a natural y moral, l�gica y las virtudes de todas las hierbas y plantas, y tambi�n es capaz de curar todas las enfermedades" , "Cincuenta" , "Sur" , "Mercurio" , "Mercurio","Fuego","Tauro");
        Demonios demon10 = new Demonios("Guison", "Conoce todo lo referente al pasado, presente y futuro, responde todas las preguntas que se le hagan, reconcilia a los amigos y otorga honor y dignidad.", "Cuarenta" ,"Oeste","Venus","Cobre","Agua","Tauro");

        print(demon0.demonElements());
        print(demon1.demonElements());
        print(demon2.demonElements());
        print(demon3.demonElements());
        print(demon4.demonElements());
        print(demon5.demonElements());
        print(demon6.demonElements());            
        print(demon7.demonElements());
        print(demon8.demonElements());
        print(demon9.demonElements());
        print(demon10.demonElements());
    }

}
