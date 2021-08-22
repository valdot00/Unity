using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //public int carDooors = 4;

    public int x = 2;
    public int y = 3;
    public string name = "jorge oswaldo pelayo arellano" ;
    private int age = 29;

    int level;
    string haircolor = "red";
    int money = 7;

    float temperature = 25;
    int piNumber = (int)3.14159265;


    //double p = 20.11111;
    //float p2 = 20.13164;

    private int health = 100;

     public bool bossDefeated = false;
     public bool hasTheKey = true;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(3+5);

        //Debug.Log(carDooors-3);

        //Sumalosdosnumeros();

        //Debug.Log("hoy es vierne "+name);

        //Debug.LogFormat("el valor de {0} mas el valor de {1} resula {2}",x,y,x+y);

        //Debug.LogFormat("el valor de "+x+" mas el valor de "+y+" resula ",x+y);

        string sentence = $"el valor de x es {x}";
        Debug.Log(sentence);

        var currentage = false;
       // float suma = (float)currentage+price;



    }
    // Update is called once per frame
    void Update()
    {
        //Sumalosdosnumeros();
    }
    void Sumalosdosnumeros(){

        Debug.Log(x+y);

    }

    public void Mimetodo(){

    }
    public void Mimetoido2(){

    }

    public void MakeDamage(){
        health-=10;
    }
}
