using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlDelArma : MonoBehaviour
{
    private Control Mando;
    public PlayerInput _playerInput;
    public Transform shootSpawn;
    public bool shooting;
    public GameObject bulletPrefab;

    private void Start()
    {
        Mando = new Control(); 

    }

    void Update()
    {
        if (Mando.Gameplay.Disparar.triggered) shooting = true;
        shooting = Input.GetKeyDown(KeyCode.JoystickButton5);
        shooting = Input.GetKeyDown(KeyCode.Mouse0);
        
        if (shooting) 
        {
            InstantiateBullet();
        }
    }



    private void InstantiateBullet()
    {
        Instantiate(bulletPrefab, shootSpawn.position, shootSpawn.rotation);

    }

}
