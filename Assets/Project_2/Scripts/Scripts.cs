using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject obj;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    public float Speed = 10;

    private float pos = 2;
    private float Out = 2;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating(nameof(Check),pos, Out );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Check()
    {
        Instantiate(obj, spawnPos, obj.transform.rotation);
    }
}
