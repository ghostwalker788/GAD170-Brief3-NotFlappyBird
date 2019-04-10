using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public UnityEvent OnHitSomething;
    public UnityEvent OnHitCylinder;
    public UnityEvent OnHitGoal;
    public float RFVV = 1;
    public float PXP;

    private GameManager m_currentGameManager;
    // Start is called before the first frame update
    void Start()
    {
        //getign the first instance of the game manager script
        m_currentGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        /// move the player horazontaly across the scree
        transform.position = transform.position + (Vector3.right * RFVV * Time.deltaTime);
        /// control the speeed of the player
        /// 
        PXP = transform.position.x; 





        // check if the space bar was pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // retrieve the player's rigid body
            Rigidbody rb = GetComponent<Rigidbody>();

            // if it was shove the player up
            rb.AddForce(Vector3.up * 200);
            // rb.velocity
        }
    }



    private void OnTriggerEnter(Collider piller)
    {
        //when we enter the triger to play dead sound
        Debug.Log("We made it!");
        m_currentGameManager.onPickUp?.Invoke();
        Destroy(piller.gameObject);
    }
    
    //private void OnTriggerEnter(Collider Goal)
    //{
        //when we enter the triger to play dead sound
    //    Debug.Log("you Got a Point");
//OnHitGoal?.Invoke();
    //}

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "wall")
        {
            Debug.Log("Can't go up somthing stops you");
        }
        if (collision.gameObject.tag == "Piller")
        {
            Debug.Log("We hit a piller");
            OnHitSomething?.Invoke();
        }
        if (collision.gameObject.tag == "Goal")
        {

        }
    }

}
