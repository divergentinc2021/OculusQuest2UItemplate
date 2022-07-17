using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject fallen;
    // Start is called before the first frame update
    public void Instantiatethis()
    {
        for (var i = -5; i < 10; i++)
        {
            Instantiate(fallen, new Vector3(i * 2.0f, 10, 12), Quaternion.identity);
        }
    }


}
