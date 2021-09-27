using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {

        public bool hasTheKeyToDungeon = true;
       
    }
    
    void Update()
    {
        if(hasTheKeyToDungeon){
            Debug.Log("tienes la llave, en horabuena");
        }else{
            Debug.Log("No puedes pasaaaaaar");
        }

        string weaponType = "Cuchillo";

        if(weaponType == "espada"){
            Debug.Log("puedes pasar");
        }

        int currentGold;

        if(currentGold > 50){
            if(weaponType == "espada"){
                Debug.Log("god save the queen")
            }
        }else{
            Debug.Log("tengo mas de 50 monedas y mi arma no es la espada")
        }
        
    }

}
