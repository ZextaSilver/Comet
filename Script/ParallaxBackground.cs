using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public float parallax_effect_multiplier;
    private Transform camera_transform;
    private Vector3 last_camera_position;

    private void Start()
    {

        camera_transform = Camera.main.transform;
        last_camera_position = camera_transform.position;

    }

    // Update is called once per frame
    private void LateUpdate()
    {

        Vector3 delta_movement = camera_transform.position - last_camera_position;
        //float parallax_effect_multiplier = 0.5f;
        transform.position += delta_movement * parallax_effect_multiplier;
        last_camera_position = camera_transform.position;

    }
}
