using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public int bulletsAmount;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    public void OnFire(InputValue value)
    {
        if (value.isPressed && bulletsAmount > 0)
        {
            bulletsAmount--;
            
            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            muzzleEffect.Play();
            shootSound.Play();
        }

        

    }
}
