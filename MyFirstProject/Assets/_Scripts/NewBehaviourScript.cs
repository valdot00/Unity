using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //public int carDooors = 4;

    public int x = 2;
    public int y = 3;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(3+5);

        //Debug.Log(carDooors-3);

        Sumalosdosnumeros();
    }
    // Update is called once per frame
    void Update()
    {
        //Sumalosdosnumeros();
    }
    void Sumalosdosnumeros(){

        Debug.Log(x+y);

    }
}
