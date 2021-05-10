using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;
    private AudioSource audioSrc;
    public AudioClip sound;
    // Update is called once per frame

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
            shoot();
        }
    }

    void shoot()
    {
        //shot logic
        Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        audioSrc.PlayOneShot(sound);
    }
}
