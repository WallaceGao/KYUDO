using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sakuraPaticle : MonoBehaviour
{
    public ParticleSystem _sakura;
    public float _maxSpeed = 0.0f;
    public float _foucsSpeed = 0.0f;
    public bool _isFoucs = false;

    private void Awake()
    {
        var main = _sakura.main;
        main.simulationSpeed = _maxSpeed;
    }

    private void Update()
    {
        if (_isFoucs)
        {
            var main = _sakura.main;
            main.simulationSpeed = _maxSpeed;
        }
        else
        {
            var main = _sakura.main;
            main.simulationSpeed = _foucsSpeed;
        }
    }
}
