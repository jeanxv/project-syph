using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour


{
    public GameObject player;
    public float speed;
    private float distence;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distence = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.forward - transform.position;
      

        
      transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
          
        
    }
}
