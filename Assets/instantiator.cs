using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{

    public GameObject originalobject;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void InstantiateObject()
    {
        i = 1;
        while (i <= 3)
        {
            Instantiate(originalobject);
            i++;
        }
    }

}
