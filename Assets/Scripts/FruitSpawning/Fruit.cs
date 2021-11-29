using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{

    public GameObject fruitSliced;
    Rigidbody2D rb;
    public float startForce = 15f;
    public GameObject slicedFruits;
    public float speedLoss = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blade")
        {
            Vector3 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            slicedFruits = Instantiate(fruitSliced, transform.position, rotation);


            Rigidbody[] slicedFruit = slicedFruits.GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody srb in slicedFruit)
            {
                srb.velocity = rb.velocity;
            }


            Destroy(slicedFruits, 3f);
            Destroy(gameObject);
        }
    }

    public void Death()
    {

    }
}