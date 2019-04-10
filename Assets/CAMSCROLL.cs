using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CAMSCROLL : MonoBehaviour
{

    public Transform myTrans;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(myTrans.position.x);
        Vector3 CAMPOS = new Vector3(myTrans.position.x,5,0);
        transform.position = CAMPOS;
    }
}
