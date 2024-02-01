using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour


{
    public GameObject Player;
    public float speed;
    private float distence;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distence = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.forward - transform.position;
      

        
      transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
          
        
    }
}
