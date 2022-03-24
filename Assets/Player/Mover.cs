using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0;
    [SerializeField] float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started Mover");
    }

    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Horizontal")/10;
        zValue = Input.GetAxis("Vertical")/10;
        transform.Translate(xValue, yValue, zValue);
    }
}
