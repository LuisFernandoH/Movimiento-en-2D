using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); //Obtiene el valor de Entrada horizontal
        float verticalInput = Input.GetAxis("Vertical"); //

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * speed * Time.deltaTime;
        //NOTA: Marcabva error por cuestiones de definir la variable movement con (Vertical3)
        transform.position += (Vector3)movement;
    }
}
