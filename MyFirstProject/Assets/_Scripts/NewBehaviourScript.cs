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
        
    }

}
