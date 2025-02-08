using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Red,
    Green,
    Gold,
}

public class Key : PickUpScript
{
    public KeyColor color;

    // Start is called before the first frame update


    void Update()
    {
        Rotation();
    }

    public override void Picked()
    {
        GameManager.gameManager.AddKey(color);
        Destroy(this.gameObject);
    }
}


// Update is called once per frame
