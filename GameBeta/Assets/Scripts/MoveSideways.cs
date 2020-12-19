using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideways : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move object to the right, or left if minus value added
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
