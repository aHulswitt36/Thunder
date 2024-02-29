using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
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
        if(Input.GetButtonDown("Jump") && (body.velocity.y < 2 && body.position.y < 1.5)){
            body.AddForce(Vector2.up * JumpSpeed, ForceMode2D.Impulse);
        }
    }
}
