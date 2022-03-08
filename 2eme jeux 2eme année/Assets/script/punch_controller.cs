using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch_controller : MonoBehaviour
{
    public GameObject enemy;
    public camerashake camerashake;
    public ParticleSystem particule;
    // Start is called before the first frame update
    void Start()
    {
        particule.Stop();
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (other.transform.tag == "enemy")
            {
                StartCoroutine(camerashake.Shake(.15f, .7f));
                particule.Play();
            }
;       }
    }
}
