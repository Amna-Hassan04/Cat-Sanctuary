using UnityEngine;
using System.Collections;
 
public class ToggleLight : MonoBehaviour {
    private Light myLight;
     
     
    void Start ()
    {
        myLight = GetComponent<Light>();
    }
     
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.F))
        {
            
            myLight.enabled = !myLight.enabled;
        }
    }
}