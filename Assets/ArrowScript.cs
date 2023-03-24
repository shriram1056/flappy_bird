using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject explosion;

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
        GameObject ExplosionEffect = Instantiate(explosion,transform.position,Quaternion.identity);
        Destroy(gameObject);
        Destroy(ExplosionEffect,1);
    }
}
