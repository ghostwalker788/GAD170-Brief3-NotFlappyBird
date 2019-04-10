using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Creater : MonoBehaviour
{
    public Transform Pillerspot;
    public GameObject pillerSpawn;


    // Start is called before the first frame update
    void Start()
    {
        //8.5-2.0
        //istachiating a prefab
        //countdown timer
        //time.delttime
        //time.time
        /*
        3.5 - -3.0
            1   -3.0
            2   -2.5
            3   -2.0
            4   -1.5
            5   -1.0
            6   -0.5
            7   0
            8   0.5
            9   1.0 
            10  1.5
            11  2.0
            12  2.5
            13  3.0
            14  3.5
            */
        InvokeRepeating("Spawnpiller", 2.0f, 2.0f);
    }



    public void Spawnpiller()
    {
        float ypos = (Pillerspot.position.y + (-3.0f + (0.5f * Random.Range(0, 14))));
        Vector3 newPos = new Vector3(Pillerspot.position.x, ypos, 0);
        Instantiate(pillerSpawn, newPos, pillerSpawn.transform.rotation);
        
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(myTrans.position.x);
        //Vector3 CAMPOS = new Vector3(myTrans.position.x, 5, 0);
        //transform.position = CAMPOS;
    }
}
