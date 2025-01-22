using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float moveSpeed = 5f; 
    
    public TMP_Text gasText;
    public GameObject endUI;
    private float gasValue = 100f;
    
    
    void Awake()
    {
        gasText.text = "GAS: " + 100;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * (moveSpeed * Time.deltaTime);    
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }
        gasValue -= Time.deltaTime * 10f;
        gasText.text = "GAS: " + gasValue.ToString("n2");
        if (gasValue <= 0)
        {
            endUI.gameObject.SetActive(true);
            gasText.gameObject.SetActive(false);
            
            gasValue = 100;
            
            transform.parent.gameObject.SetActive(false);
        }
    }

    public void GetGas()
    {
        gasValue = Mathf.Clamp(gasValue += 30f, 0, 100);
    }
}
