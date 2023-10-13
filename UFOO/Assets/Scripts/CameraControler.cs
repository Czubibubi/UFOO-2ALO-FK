using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject player; // zmienna w ktorej przechowujemy informacje 
    Vector3 offset; // zmienna przechowuje informacje o koordach X Y Z
    void Start()
    {
        offset= transform.position - player.transform.position; 
        
    }

    
    void Update()
    {
        transform.position = offset + player.transform.position;
        // oblicza pozyzje kamery za pomoca lokalizacuji aktualnej gracza 
        
    }
}
