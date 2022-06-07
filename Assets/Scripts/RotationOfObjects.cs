using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfObjects : MonoBehaviour
{
    public float speed = 20f;
    GameObject sun, earth, jupiter;

    private void Start()
    {
        sun = GameObject.Find("Sun");
        earth = GameObject.Find("Earth");
        jupiter = GameObject.Find("Jupiter");
    }

    // Update is called once per frame
    void Update()
    {
        //cube0.transform.rotation = Quaternion.Euler(cube0.transform.rotation.x, speed * Time.deltaTime, cube0.transform.rotation.z, Space.World);
        sun.transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
        earth.transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
        jupiter.transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
