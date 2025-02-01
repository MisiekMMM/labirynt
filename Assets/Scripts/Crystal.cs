using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : PickUpScript
{
    public int pointsToAdd = 5;
    // Start is called before the first frame update
    public override void Picked()
    {
        GameManager.gameManager.AddPoints(pointsToAdd);
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
