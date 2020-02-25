using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    private Animator anime;
    private SpriteRenderer sprite;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>(); // hay que meterle un rigidbody y poner gravity scale a 0 
    }

    // Update is called once per frame
    /*
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        
        Vector2 movimiento = new Vector2 (moveHorizontal,moveVertical);
        rb2d.AddForce(movimiento * velocidad);
    }
    */
    
    
    
    void Update()
    {
        GetInput();
        Movimiento();
    }
    
    
    public void Movimiento()
    {
        transform.Translate(direccion * velocidad *Time.deltaTime);
    }
    
    public void GetInput()
    {
        direccion = Vector2.zero;
        
         if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
         {
            direccion += Vector2.up;
         }
         if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
         {
            direccion += Vector2.left;
         }
         if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
         {
            direccion += Vector2.down;
         }
         if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
         {
            direccion += Vector2.right;
         }
    }
    
    
    
    
    
    
    
}
