using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    [Header("Movement")]
    [Range(0.1f, 2.0f)]
    public float rotationSpeed;

    [Header("Audio")] 
    public AudioSource pickupSound;

    // Start is called before the first frame update
    void Start()
    {
        pickupSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        SpinGem();
    }

    private void SpinGem()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
    }

    private IEnumerator PlayPickupSound()
    {
        pickupSound.Play();
        yield return new WaitForSeconds(0.2f);
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlayPickupSound());
        }
    }
}
