using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 10f;
    [SerializeField] float moveSpeed = 20f;

    void Update()
    {
        float move = 0f;
        float steer = 0f;

        if (Keyboard.current.wKey.isPressed) move = 1f;
        else if (Keyboard.current.sKey.isPressed) move = -1f;

        if (Keyboard.current.aKey.isPressed) steer = 1f;
        else if (Keyboard.current.dKey.isPressed) steer = -1f;

        // Vector3.up = (0, 1, 0) — moves along Y axis (forward in top-down 2D)
        transform.Translate(Vector3.up * move * moveSpeed * Time.deltaTime);

        // Vector3.forward = (0, 0, 1) — rotates around Z axis (turning in 2D)
        transform.Rotate(Vector3.forward * steer * steerSpeed * Time.deltaTime);
    }
}