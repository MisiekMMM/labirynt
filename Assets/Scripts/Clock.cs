using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : PickUpScript
{
    public bool addTime; 
    public int timeToAdd = 8;
    // Start is called before the first frame update
    public override void Picked()
    {
        if(addTime)
        {
            GameManager.gameManager.AddTime(timeToAdd);
        }
        else
        {
            GameManager.gameManager.AddTime(-timeToAdd);
        }
        
        Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}

