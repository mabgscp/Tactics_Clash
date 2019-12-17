using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Unit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            bool hitSuccess = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, Mathf.Infinity);

            if (hitSuccess)
            {
                Unit = Instantiate
                (
                    Unit.gameObject,
                    hitInfo.point + Vector3.up * Unit.transform.lossyScale.y,
                    Quaternion.identity
                );
                
            }
        }
    }
}
