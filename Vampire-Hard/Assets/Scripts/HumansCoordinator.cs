using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class HumansCoordinator : MonoBehaviour
{

    public GameObject pref_human_nicy;
    public GameObject pref_human_brown;
    public GameObject pref_human_soldier;
    private Sprite[] hats;
    private List<GameObject> crowd = new List<GameObject>();
    private Color[] cols = new Color[] {Color.green,Color.yellow,Color.magenta,Color.red,Color.cyan,Color.blue,Color.white};

    void Awake()
    {
        hats = Resources.LoadAll("Sprites/hats", typeof(Sprite)).Cast<Sprite>().ToArray();
    }


    void set_Hair(GameObject a)
    {
        SpriteRenderer b = a.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>();
        b.sprite = hats[Random.Range(0, 4)];
        b.color = cols[Random.Range(0, cols.Length)];
    }
    
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            int a = (int)Random.Range(0, 3);
            if (a == 0)
                {
                    crowd.Add(Instantiate(pref_human_brown));
                }
            else if (a == 1) 
                {
                    crowd.Add(Instantiate(pref_human_soldier));
            }
            else
                {
                    crowd.Add(Instantiate(pref_human_nicy));
                }
            set_Hair(crowd[i]);
            crowd[i].GetComponent<Personality>().setTarget(new Vector2(-10, -10));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
