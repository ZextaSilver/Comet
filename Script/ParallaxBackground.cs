using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Vector2 parallax_effect_multiplier;
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
        transform.position += new Vector3(delta_movement.x * parallax_effect_multiplier.x, 
                                            delta_movement.y * parallax_effect_multiplier.y);
        last_camera_position = camera_transform.position;

    }
}
