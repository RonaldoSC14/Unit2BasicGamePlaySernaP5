using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float lastKeyPressTime = 0;
    float cooldown = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time - lastKeyPressTime > cooldown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastKeyPressTime = Time.time;
            }
        }
    }
}
