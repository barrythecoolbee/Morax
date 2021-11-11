using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float minHeight;
    public float maxHeight;

    public int health = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        float speedValue = speed * Time.deltaTime;
 
        Vector2 newYPos = new Vector2(0, cursorPos.y);   // Disregard the player's x and z position.

        if(transform.position.y >= minHeight && transform.position.y <= maxHeight){
            transform.position = Vector2.MoveTowards (transform.position, newYPos, speedValue);
        }
        else if(transform.position.y < minHeight){
            transform.position = new Vector2(transform.position.x, minHeight);
        }
        else if(transform.position.y > maxHeight){
            transform.position = new Vector2(transform.position.x, maxHeight);
        }       
        
    }
}
