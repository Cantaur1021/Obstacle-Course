using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    private Rigidbody rb;
    private MeshRenderer mr;
    [SerializeField] private float timeTillDrop = 3;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        if (timer >= timeTillDrop)
        {
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
