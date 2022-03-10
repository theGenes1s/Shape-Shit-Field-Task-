using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody PlayerRB; //Rigid body Instance.
    public float gravitymodifier; // Gravity Hold
    public bool isonground = true; //Boolean Check to identify the player is on ground surface.
    public bool GameOver = false;
    private Animator playerAnim;


    // Start is called before the first frame update
    
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier; 
        
    }

    
    void Update()
    {
    
    ShapeShift();

    }

/// <summary>
    /// Shape shifting mechanism done using transform scale
    /// </summary>
void ShapeShift()
{
if (Input.GetMouseButton(0) && isonground)
    {
        
        transform.localScale = new Vector3(1f, 3f, 0.5f) ;
        
    }
        
    else if (Input.GetMouseButton(1) && isonground)
    {
        transform.localScale = new Vector3(0.3f, 0.2f, 1.8f) ;
        
    }
   
    else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            
        }
}
    

    //Collision detection on ground 
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isonground = true;
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver = true;
            Debug.Log("Game Over");
        }
        
    }
}
