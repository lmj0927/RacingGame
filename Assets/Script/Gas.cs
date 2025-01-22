using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gas : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        collider.TryGetComponent<Car>(out Car car);
        if (car != null)
        {
            car.GetGas();
        }
        Destroy(gameObject);
    }
}
