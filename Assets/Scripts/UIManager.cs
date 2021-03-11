using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public UI[] _textsInLoop;
    private int _LoopIndex;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        _LoopIndex = 0;
        StartCoroutine(waitTime(_textsInLoop, _LoopIndex));
    }

    IEnumerator waitTime(UI[] t, int index )
    {
        for (int i = 0; i < t.Length; ++i)
        {
            yield return new WaitForSeconds(t[i]._waitTime);
            t[i]._text.SetActive(true);
            yield return new WaitForSeconds(t[i]._showTime);
            t[i]._text.SetActive(false);
            _LoopIndex++;
        }
    }
}
