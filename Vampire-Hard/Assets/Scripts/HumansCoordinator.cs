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
    private List<Personality> crowd_object;
    private Color[] cols = new Color[] {Color.green,Color.yellow,Color.magenta,Color.red,Color.cyan,Color.blue,Color.white};
    public GameObject[] tables;
    void Awake()
    {
        hats = Resources.LoadAll("Sprites/hats", typeof(Sprite)).Cast<Sprite>().ToArray();
        crowd_object = new List<Personality>();
    }


    void set_Hair(GameObject a)
    {
        SpriteRenderer b = a.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>();
        b.sprite = hats[Random.Range(0, 4)];
        b.color = cols[Random.Range(0, cols.Length)];
    }
    
    void Start()
    {
        
        for (int i = 0; i < 4; i++)
        {
            int a = (int)Random.Range(0, 1);
            if (a == 0)
                {
                    crowd.Add(Instantiate(pref_human_brown));
                }
            else if (a == 1) 
                {
                    crowd.Add(Instantiate(pref_human_soldier));
            }
            else if (a == 2)
                {
                    crowd.Add(Instantiate(pref_human_nicy));
                }
            set_Hair(crowd[i]);
            crowd_object.Add(crowd[i].GetComponent<Personality>());
            crowd_object[i].setTarget(new Vector2(Random.Range(-6,6), Random.Range(-4, 4)));
            
            
        }
    }

    public void AddPerson()
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
        else if ( a==2 )
        {
            crowd.Add(Instantiate(pref_human_nicy));
        }
        set_Hair(crowd[crowd.Count()-1]);
        crowd_object.Add( crowd[crowd.Count()-1].GetComponent<Personality>());
        crowd_object[crowd_object.Count()-1].setTarget(new Vector2(Random.Range(-6, 6), Random.Range(-4, 4)));
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100000) > 99000)
        {
            AddPerson();
        }
        foreach (Personality a in crowd_object)
        {
            if (a.reached_goal)
            {
                if (Random.Range(0, 3) >= 1)
                {
                    a.setTarget(new Vector2(Random.Range(-6, 6), Random.Range(-4, 4)));
                }
                else
                {
                    a.setTarget(tables[(int)Random.Range(0, tables.Length)].transform.position);
                }
            }
        }
       
       
    }
}
