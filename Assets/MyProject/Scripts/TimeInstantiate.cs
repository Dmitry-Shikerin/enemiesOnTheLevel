using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInstantiate : MonoBehaviour
{
    public GameObject Template;

    private void Start()
    {
        GameObject newObject = Instantiate(Template, new Vector3(0, 0, 0), Quaternion.identity);
        //newObject.GetComponent</* что сюда передать?*/>
    }
}
