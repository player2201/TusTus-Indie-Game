using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalMovement = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(horizontalMovement, 0, 0);
        transform.Translate(0, verticalMovement, 0);
    }
}
