using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per 
    void Update()
    {
        Rotation();
    }

    public virtual void Picked()
    {
        Debug.Log("Podnios�em");
        Destroy(this.gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(new Vector3(0, 5f, 0));
    }
}
