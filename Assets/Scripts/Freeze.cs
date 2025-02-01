using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : PickUpScript
{

    public int freezeTime = 10;
    // Start is called before the first frame update
    public override void Picked()
    {
        GameManager.gameManager.FreezeTime(freezeTime);
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
