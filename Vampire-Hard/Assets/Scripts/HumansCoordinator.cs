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
    private GameObject[] crowd;

    void Awake()
    {
        hats = Resources.LoadAll("Sprites/hats", typeof(Sprite)).Cast<Sprite>().ToArray();
    }


    void set_Hair(GameObject a)
    {
        /// GameObject b = a.transform.FindChild("Hair");
    }
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int a = (int)Random.Range(0, 2);
            if (a == 0)
                {
                    crowd[i] = Instantiate(pref_human_brown);
                    set_Hair(crowd[i]);
                }
            else if (a == 1) 
                {
                    crowd[i] = Instantiate(pref_human_soldier);
                }
            else
                {
                    crowd[i] = Instantiate(pref_human_nicy);
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
