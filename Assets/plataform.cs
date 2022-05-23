using System.Collections;
using System.Collections.Generic;
using UnityEngine;

            
public class plataform : MonoBehaviour {
    public float speed,Rlimit,Llimit;
    public bool toRight;
    public GameObject Prefab1, Prefab2, BaseR, BaseL;
    // Use this for initialization
    void Start () {
       toRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (toRight)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x >= Rlimit)
        {
            toRight = false;
            GameObject clone; 
            clone = Instantiate(Prefab1);
            clone.transform.position = BaseR.transform.position + new Vector3(0, 1, 0);    
        }
        else if (transform.position.x <= Llimit)
        {
            toRight = true;
            GameObject clone;
            clone = Instantiate(Prefab2);
            clone.transform.position = BaseL.transform.position + new Vector3(0, 1, 0);
        }
        
	}
}
