using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float JumpSpeed = 2f;
    public float hitPoints = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetAxisRaw("Horizontal") != 0 ){
            var horizontalMovement = Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime;

            var direction = new Vector3(horizontalMovement, 0, 0);
            gameObject.transform.Translate(direction);
        //} 
        if(Input.GetKey(KeyCode.Space)){
            var verticalMovement = Input.GetAxisRaw("Vertical") * JumpSpeed * Time.deltaTime;
            var jumpDirection = new Vector3(verticalMovement, 0, 0);
            gameObject.transform.Translate(jumpDirection);
        }
    }
}
