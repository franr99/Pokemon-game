using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad;
    //public Vector2 direccion;
    private Animator anime;
    private SpriteRendered sprite;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        sprite = GetComponent<SpriteRendered>();
        rb2d = GetComponent<Rigidbody2D>(); // hay que meterle un rigidbody y poner gravity scale a 0 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        
        Vector2 movimiento = new Vector2 (moveHorizontal,moveVertical);
        rb2d.AddForce(movimiento * velocidad);
    }
    
    
  /*  Si no funciona lo de arriba prueba esto
    void Update()
    {
        GetInput();
        Movimiento();
    {
    
    
    public void Movimiento()
    {
        transform.Translate(Vector2.direccion * velocidad *Time.deltaTime);
    }
    
    public void GetInput()
    {
        direccion = Vector2.zero;
        
         if(input.GetKey(KeyCode.W) || input.GetKey(KeyCode.Down))
         {
            direccion += Vector2.up;
         }
         if(input.GetKey(KeyCode.A) || input.GetKey(KeyCode.Down))
         {
            direccion += Vector2.left;
         }
         if(input.GetKey(KeyCode.S) || input.GetKey(KeyCode.Down))
         {
            direccion += Vector2.down;
         }
         if(input.GetKey(KeyCode.D) || input.GetKey(KeyCode.Down))
         {
            direccion += Vector2.right;
         }
    }
    */
    
    
    
    
    
    
}
