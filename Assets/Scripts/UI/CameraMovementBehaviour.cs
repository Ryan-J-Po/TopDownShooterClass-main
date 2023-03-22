using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = _target.transform.position;
        
        transform.localPosition = _offset + location;
    }
}
