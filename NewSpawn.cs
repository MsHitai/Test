using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSpawn : MonoBehaviour
{
    public InputField newSpeed;
    public InputField timeSet;
    public Rigidbody newCubePrefab;
    public int speed;
    public float interval;
    private float timer;
    //public float force = 0.1f;

    private Vector3 startPos;

    public void Spawn()
    {
        
        Rigidbody c = Instantiate(newCubePrefab, startPos, Quaternion.identity);
        
        //c.transform.Translate(transform.forward * speed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        
        //GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        speed = int.Parse(newSpeed.text);
        interval = int.Parse(timeSet.text);
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            Spawn();
            timer -= interval;
        }
        
    }
}
