using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    public GameObject topPipe;
    public GameObject bottomPipe;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6){
            topPipe.transform.position += new Vector3(0,5,0);
            bottomPipe.transform.position += new Vector3(0,-6.6f,0);
        }
    }
}
