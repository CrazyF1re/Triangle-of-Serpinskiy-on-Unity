using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject point;
	void Start ()
    {
        point.transform.position = new Vector3(5, 7, 0);
    }

    // Update is called once per frame
    void Update()
    { for (int i = 300; i > 0; i--) {
            int rand = Random.Range(1, 4);
            if (rand == 1)
            {
                Instantiate(point, new Vector3(point.transform.position.x + (p1.transform.position.x - point.transform.position.x) / 2, point.transform.position.y + (p1.transform.position.y - point.transform.position.y) / 2, 0), Quaternion.identity);
                point.transform.position = new Vector3(point.transform.position.x + (p1.transform.position.x - point.transform.position.x) / 2, point.transform.position.y + (p1.transform.position.y - point.transform.position.y) / 2, 0);
            }
            if (rand == 2)
            {
                Instantiate(point, new Vector3(point.transform.position.x + (p2.transform.position.x - point.transform.position.x) / 2, point.transform.position.y + (p2.transform.position.y - point.transform.position.y) / 2, 0), Quaternion.identity);
                point.transform.position = new Vector3(point.transform.position.x + (p2.transform.position.x - point.transform.position.x) / 2, point.transform.position.y + (p2.transform.position.y - point.transform.position.y) / 2, 0);
            }
            if (rand == 3)
            {
                Instantiate(point, new Vector3(point.transform.position.x + (p3.transform.position.x - point.transform.position.x) / 2, point.transform.position.y + (p3.transform.position.y - point.transform.position.y) / 2, 0), Quaternion.identity);
                point.transform.position = new Vector3(point.transform.position.x + (p3.transform.position.x - point.transform.position.x) / 2, point.transform.position.y + (p3.transform.position.y - point.transform.position.y) / 2, 0);
            }
        } 
    }
}
