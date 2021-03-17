using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMaterial : MonoBehaviour
{
    [SerializeField] private Terrain Obj1;
    [SerializeField] private Renderer Obj2;
    // Start is called before the first frame update
    void Start()
    {
        Obj2.material = Obj1.materialTemplate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
