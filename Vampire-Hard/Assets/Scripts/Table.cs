using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public bool alc;
    public bool garl;
    public bool silv;
    public bool cross; 


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "body_brown(Clone)" || collision.gameObject.name == "body_nicy(Clone)" || collision.gameObject.name == "body_soldier(Clone)")
        {
            if (alc)
            {
                collision.gameObject.GetComponent<Personality>().set_animation_alc();
            }
            if (garl)
            {
                collision.gameObject.GetComponent<Personality>().set_animation_garlic();
            }
            if (silv)
            {
                collision.gameObject.GetComponent<Personality>().set_animation_silver();
            }
            if (cross)
            {
                collision.gameObject.GetComponent<Personality>().set_animation_cross();
            }
        }
        
    }
    
}
