using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    public GameObject obj;
    public Vector3 spawnPos = new Vector3(25, 0, 0);


    public float Pos = 2;

    private float Out = 2;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(Check),Pos, Out );
    }

    // Update is called once per frame
    private void Update()
    {
       
    }

    private void Check()
    {
        Instantiate(obj, spawnPos, obj.transform.rotation);
    }
}