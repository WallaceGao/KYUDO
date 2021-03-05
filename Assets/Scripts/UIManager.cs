using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public UI[] _textsInLoop;
    private int _gameLoop;
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
        _gameLoop = 3;
        _LoopIndex = 0;
        StartCoroutine(waitTime(_textsInLoop, _LoopIndex));
    }

    private void Update()
    {

        //}
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

    //IEnumerator FadeIn()
    //{
    //    while (_texts.color.a < 1)
    //    {
    //        _texts.color = Color.Lerp(_texts.color, new Color(_texts.color.r, _texts.color.g, _texts.color.b,1.0f), _fadeTime * Time.deltaTime);
    //        yield return null;
    //    }
    //}
    //
    //IEnumerator FadeOut()
    //{
    //    while (_texts.color.a > 0)
    //    {
    //        _texts.color = Color.Lerp(_texts.color, new Color(_texts.color.r, _texts.color.g, _texts.color.b, 0.0f), _fadeTime * Time.deltaTime);
    //        yield return null;
    //    }
    //}

}
