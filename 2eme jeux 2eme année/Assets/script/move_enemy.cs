using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move_enemy : MonoBehaviour
{
    Transform player;
    public float speed;
    private Rigidbody rb;
    public GameObject trail;

    public AudioSource AudioSourceoui;
    private void Start()
    {
        //Son
        AudioSourceoui = GetComponent<AudioSource>();
        AudioSourceoui.Stop();

        player = GameObject.FindWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.LookAt(player);
        Vector3 direction = player.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0); 
        rb.AddForce(direction* speed * Time.deltaTime);
    }
    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                rb.AddForce(rb.velocity * -2, ForceMode.Impulse);
                rb.AddForce(rb.velocity + Vector3.up *  3, ForceMode.Impulse);
                AudioSourceoui.Play();
                Destroy(this.gameObject, 2);
                this.rb.useGravity = true;
                this.rb.mass = 1;
                FindObjectOfType<audiomanager>().Play("Punch");
                trail.SetActive (true);
                Debug.Log("Ta taper");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject, 2f);
    }
}
