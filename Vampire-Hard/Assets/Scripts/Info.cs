using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public GameObject player;
    private Player pl;
    private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        pl = player.GetComponent<Player>();
    }
    
    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + pl.score + " " + "Health: " + pl.health;
        
    }
}
