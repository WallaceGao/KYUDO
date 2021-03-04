using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public UI[] _textsStar;
    public UI[] _textsInLoop;
    public UI[] _TextsEnd;
    private int _gameLoop;

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
        _gameLoop = 2;
        foreach(UI t in _texts)
        {
            t._isShow = false;
        }
        foreach (UI t in _textsInLoop)
        {
            t._isShow = false;
        }
    }

    private void Update()
    {
        
        for (int i = 0; i < _gameLoop; ++i)
        {
            if (i == 0)
            {
        
            }
            else if (i == 1)
            {
        
            }
            else if (i == 2)
            {
        
            }
        }
    }


    IEnumerable waitTime(float t)
    {
        yield return new WaitForSeconds(t);
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
