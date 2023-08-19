using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideScript : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotateChange;
    public int cycle;
    public int multiplier;
    public bool ballDropped;
    public int ballDropTrack;

    // Start is called before the first frame update
    void Start()
    {
        cycle = 0;
        multiplier = 1;
        ballDropped = false;
        ballDropTrack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ballDropTrack += 1;

        transform.localScale += scaleChange;

        if (ballDropTrack > 1000) {
            ballDropped = true;
        }

        if (ballDropped) {

            cycle += 1;

            if (cycle > 100)
            {
                cycle = 0;
                multiplier *= -1;
            }

            transform.position += (multiplier * positionChange);
            transform.Rotate(rotateChange);
        }
    }
}
