using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : ScriptableObject
{
    public Sprite image;
    public Vector2 spawPoints;
    public bool alcohol = false;
    public bool garlik = false;
    public bool silver = false;
    public bool cross = false;
    public BoxCollider2D top = new BoxCollider2D();
    public BoxCollider2D bottom = new BoxCollider2D();
    
}
