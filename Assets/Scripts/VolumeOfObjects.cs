using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeOfObjects : MonoBehaviour
{
    public float volume = 500f;
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
        sun.transform.localScale = new Vector3(volume, volume, volume);

        //cube0.transform.localScale(volume, volume, volume);
    }
    public void AdjustVolume(float newVolume)
    {
        volume = newVolume;
    }
}
