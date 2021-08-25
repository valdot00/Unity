using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{

    public string playerName = "jon snow";
    public int levelCharecter = 1;
   
    void Start()
    {
       Debug.Log("vamos a llamar a GENERATE CHARACTER");
       GenerateCharacter(playerName,levelCharecter);
       Debug.Log("hemos llamado a generate character");
    }
   
    void Update()
    {
        
    }

    public void GenerateCharacter(string name,int level){

        Debug.LogFormat("personaje: {0} de nivel {1}",name,level );
    }
}
