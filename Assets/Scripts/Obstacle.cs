using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public int damage = 1;
    public float speed;
    public int obstacleHealth;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        CheckHealth();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }

        if (other.CompareTag("Fireball"))
        {
            Destroy(other.gameObject);
            obstacleHealth-=5;
        }

        if (other.CompareTag("Crystal"))
        {
            Destroy(other.gameObject);
        }
    }

    private void CheckHealth()
    {
        if(obstacleHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
