using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, rot = 80f, curSpeed, rotationX, rotationY;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            curSpeed = speed * 2;
        }
        else curSpeed = speed;

        transform.Translate(Vector3.right * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));

        rotationX -= rot * Time.fixedDeltaTime * Input.GetAxis("Mouse Y");
        rotationY += rot * Time.fixedDeltaTime * Input.GetAxis("Mouse X");

        rotationX = Mathf.Clamp(rotationX, -90, 90);

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Mouse X"));
        transform.GetChild(1).GetComponentInChildren<Transform>().transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        
    }
}

