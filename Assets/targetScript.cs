using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    public GameObject topPipe;
    public GameObject bottomPipe;
    public float pipeOffset;
    private RectTransform rectTransform;
    private Camera mainCamera;

    private void Start()
    {
        // Get the RectTransform component of gameObject1
        rectTransform = this.GetComponent<RectTransform>();
        pipeOffset = this.transform.parent.gameObject.transform.position.y;

        // Get the main camera
        mainCamera = Camera.main;
        // Check if we have a RectTransform and a main camera
        if (rectTransform != null && mainCamera != null)
        {
           float minY = mainCamera.ViewportToWorldPoint(Vector3.zero).y + rectTransform.rect.height / 2f;
            float maxY = mainCamera.ViewportToWorldPoint(Vector3.up).y - rectTransform.rect.height / 2f;
            float randomY = Random.Range(minY, maxY);
            // Set the position of gameObject1
            rectTransform.position = new Vector3(rectTransform.position.x, randomY, 0f);

            
        }
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
            
            if(this.transform.localPosition.y > 0){
                this.transform.position += new Vector3(0,5,0);
            }else{
            this.transform.position += new Vector3(0,-6.6f,0);
            }

        }
    }
}
