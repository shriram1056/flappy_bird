using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public GameObject arrowPrefab;
    public float flapStrength;
    public bool birdIsAlive = true;
 
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive){
            // vector2.up -> (0,1)
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

         if(Input.GetKeyDown(KeyCode.Return) == true && birdIsAlive){
            GameObject arrow = (GameObject) Instantiate(arrowPrefab, transform.position, Quaternion.identity);
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f);
            Physics2D.IgnoreCollision(GetComponent<CircleCollider2D>(), arrow.GetComponent<PolygonCollider2D>());
            
        }

        if(transform.position.y> 11.5|| transform.position.y < -12){
            logic.gameOver();
            birdIsAlive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.name != "arrow(Clone)"){
            logic.gameOver();
            birdIsAlive = false;
        }
        
    }
}
