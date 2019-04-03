using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class HumansCoordinator : MonoBehaviour
{

    public GameObject pref_human;
    public Object[] hats;
    private Sprite head;
    public Sprite[] body;

    void Awake()
    {
        hats = Resources.LoadAll("Sprites/hats", typeof(Sprite)).Cast<Sprite>().ToArray();
        head = Resources.Load("Sprites/hats", typeof(Sprite))as Sprite;
        body = Resources.LoadAll("Sprites/bodys", typeof(Sprite)).Cast<Sprite>().ToArray();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
