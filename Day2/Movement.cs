using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Um dieses Skript zu verwenden musst du einen Square in deinem Projekt erstellen und dieses Skript dem Square zuweisen
Der Square wird sich dann automatisch hin und her bewegen.
 
 */
public class Movement : MonoBehaviour
{
    public float movementSpeed =15f;
    public float boundary = 8f;
    public bool isRight;
    SpriteRenderer sprite;
    
   


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
            if (transform.position.x >= boundary)
            {
                isRight = false;
                sprite.flipX = true;
             
            }

        }

        else
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            if (transform.position.x <= -boundary)
            {
                isRight = true;
                sprite.flipX = false;

            }
            
        }

    }
}