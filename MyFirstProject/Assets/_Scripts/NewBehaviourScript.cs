using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int[] ranking = new int[]{4,7,9};
    //LIST
     List<string> partyMembers = new List<string>(){
           "ARAGON","SNAKE","SOLID SNAKE","VENOM SNAKE","LIQUIT SNAKE"
       };


    void Start()
    {
        //array

        //int[] ranking = new int[3]; //[0,0,0];

       int firstScore = ranking[0];

       ranking[2]=125;

       //int someNumber = ranking[8];

       int arrayLength = ranking.Length; //3

       int pos = 8;

       if(pos >=0 && pos < ranking.Length){
           int someNumber = ranking[pos];
       }

       string firstMember = partyMembers[0];
       Debug.LogFormat("nuestra comunidad tiene {0} miembros",partyMembers.Count);

       partyMembers.Add("dontomas");
       partyMembers.Add("don chui");

       partyMembers.Insert(2,"sam");

        Debug.LogFormat("nuestra comunidad tiene {0} miembros",partyMembers.Count);

        partyMembers.Remove("don chui");
        partyMembers.RemoveAt(3);

    }
    
    void Update()
    {
       
        
    }

}
