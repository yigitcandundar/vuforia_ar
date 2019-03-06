using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

    private Vector3 scaleDown = new Vector3(.25f, .25f, .25f);
    private Vector3 scaleUp = new Vector3(.5f, .5f, .5f);
    public AudioSource aSource;

	void Start () {
        
        StartCoroutine(Animate());
	}

    private IEnumerator Animate()
    {
        transform.localScale = scaleUp;

        float timer = Time.time;
        float switchTime = 1;

        bool shrink = true;

        while (true)
        {
            if (shrink)
            {
                if (Time.time - timer < switchTime)
                {
                    transform.localScale = Vector3.Lerp(transform.localScale, scaleDown, (Time.time - timer) / switchTime);
                }
                else
                {
                    timer = Time.time;
                    transform.localScale = scaleDown;
                    shrink = false;
                }
            }
            else
            {
                if (Time.time - timer < switchTime)
                {
                    transform.localScale = Vector3.Lerp(transform.localScale, scaleUp, (Time.time - timer) / switchTime);
                }
                else
                {
                    timer = Time.time;
                    transform.localScale = scaleUp;
                    shrink = true;
                }
            }
            yield return null;
        }
    }
}
