using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    private Vector3 startPos;

    [SerializeField] private Vector3 direction;

    [SerializeField] private Rigidbody rigidBody;

    public int speed;

    private void Start()
    {
        startPos = transform.position;

        rigidBody.velocity = direction * speed;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Respawn")
        {
            transform.position = startPos;
        }
    }

    private void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
