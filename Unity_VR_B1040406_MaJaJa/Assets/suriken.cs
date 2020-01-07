using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suriken : MonoBehaviour
{
    public GameObject Cam1, Cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addF()
    {
        if (Cam1.activeInHierarchy == true)
        {
            this.GetComponent<Rigidbody>().AddForce(Cam1.gameObject.transform.forward * 200);
        }
        else
        {
            this.GetComponent<Rigidbody>().AddForce(Cam2.gameObject.transform.forward * 200);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "GGG")
        {
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
