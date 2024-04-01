using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        Vector3 mInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 move = mInput * speed * Time.deltaTime;
        transform.position += move; // Aktualisiere die Position, indem du die Bewegung hinzufügst
    }
}
