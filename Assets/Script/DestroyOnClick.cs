using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    GameObject destroythis;
    // Start is called before the first frame update
    public void click()
    {
        destroythis = GameObject.FindGameObjectWithTag ("Finish");
        Destroy(destroythis);
    }
}
