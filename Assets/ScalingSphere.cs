using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingSphere : MonoBehaviour
{
    private float _scalingFactor = 0.05f;
    public float limitSize = 1.5f;
    private bool _sphereIncrease = false;   // if false -> decrease else increase
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale= transform.localScale;
        Debug.Log($"scale = {scale}");

        if (!_sphereIncrease)
        {
            transform.localScale -= new Vector3(_scalingFactor, _scalingFactor, _scalingFactor) * Time.deltaTime;
            if (scale.x < 0)
            {
                _sphereIncrease = true;
            }
        } else
        {
            transform.localScale += new Vector3(_scalingFactor, _scalingFactor, _scalingFactor) * Time.deltaTime;
            if (scale.x > limitSize)
            {
                _sphereIncrease = false;
            }
        }


    }
}
