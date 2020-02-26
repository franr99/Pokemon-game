using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad;
   
    private Animator anime;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        
    }

  

    
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, velocidad * Time.deltaTime);

        anime.SetFloat("MovX", mov.x);
        anime.SetFloat("MovY", mov.y);

    }
    
    
    
    
    
    
    
    
    
    
}
