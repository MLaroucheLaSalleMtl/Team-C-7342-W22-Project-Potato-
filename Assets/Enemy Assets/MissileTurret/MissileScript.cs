using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Elizabeth

public class MissileScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float missileSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * missileSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ow");
        }
        else if (collision.gameObject.CompareTag("Shield"))
        {
            //rb.AddForce(transform.right * missileSpeed);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}