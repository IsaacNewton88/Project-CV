using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawner : MonoBehaviour
{
    [SerializeField] private Transform pfTexturePopup;

    // Start is called before the first frame update
    void Start()
    {
        TextPopup.Create(Vector3.zero, "program");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
