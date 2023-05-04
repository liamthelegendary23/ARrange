using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsToggle : MonoBehaviour
{

    public GameObject redX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EnableX()
    {
        redX.SetActive(true);
    }


    public void DisableX()
    {
        redX.SetActive(false);
    }
}
