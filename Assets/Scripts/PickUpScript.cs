using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Rotation(); 
    }
    public void Rotation()
    {
        transform.Rotate(new Vector3(0 ,5f, 0));
    }
    public virtual void Picked()
    {
        Debug.Log("Picked 👍😀😁😁📣😱😱😱");
        Destroy(this.gameObject);
    }
    
}
