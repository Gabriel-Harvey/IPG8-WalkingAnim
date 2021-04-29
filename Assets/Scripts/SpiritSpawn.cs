using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritSpawn : MonoBehaviour
{
    public Player Spawnloc;
    public SpiritMovement Spirit;


    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S is pressed...");
            spawnSpirit();
            GetComponent<Player>().enabled = false;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<SpiritSpawn>().enabled = false;    
            GetComponent<Collider2D>().enabled = false;
          
        }

    }

    public void spawnSpirit()
    {
        SpiritMovement SpiritClone = Instantiate(Spirit);

        SpiritClone.transform.position = Spawnloc.transform.position;

        SpiritClone.gameObject.SetActive(true);
    }

}
