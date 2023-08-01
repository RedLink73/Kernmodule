using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSideways : MonoBehaviour
{

    public float amp;
    public float freq;

    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time * freq) * amp + initPos.x , initPos.y , 0);
    }
}
