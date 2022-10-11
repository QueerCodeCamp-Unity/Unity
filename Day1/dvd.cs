using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dvd : MonoBehaviour
{
    public float movementSpeed = 10f;
    private Vector2 movementDirection;
    public bool isRight;
    public bool isUp;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 screenDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.nearClipPlane));
        Debug.Log(screenDimensions);


        if (isRight) {
            movementDirection.x=1f;
            if(transform.position.x > screenDimensions.x-transform.lossyScale.x/2f) {
                isRight = false;
            }
        }   else {
            movementDirection.x=-1f;
            if(transform.position.x < -screenDimensions.x+transform.lossyScale.x/2f) {
            isRight = true;
            }
        }
        
        if (isUp) {
            movementDirection.y=1f;
            if(transform.position.y > screenDimensions.y-transform.lossyScale.y/2f) {
            isUp = false;
            }
        }   else {
            movementDirection.y=-1f;
            if(transform.position.y < -screenDimensions.y+transform.lossyScale.y/2f) {
            isUp = true;
            }
        }
        transform.Translate(movementDirection*movementSpeed*Time.deltaTime);

    }
}
