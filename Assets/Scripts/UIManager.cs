using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public UI[] text;
    public Text _texts;
    public float _waitTime;
    public float _fadeTime;

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
        //foreach(UI t in text)
        //{
        //    t._texts.canvasRenderer.SetAlpha(0.0f);
        //}
        _texts.canvasRenderer.SetAlpha(0.0f);
    }

    private void Update()
    {
        //for (int i = 0; i < text.Length; ++i)
        //{
        //    StartCoroutine(FadeTextToFullAlpha(text[i]._fadeTime, text[i]._texts));
        //    StartCoroutine(WaitTime(text[i]._waitTime));
        //    StartCoroutine(FadeTextToZeroAlpha(text[i]._fadeTime, text[i]._texts));
        //}
        //StartCoroutine(FadeTextToFullAlpha(_fadeTime, _texts));
        //StartCoroutine(WaitTime(_waitTime));
        //StartCoroutine(FadeTextToZeroAlpha(_fadeTime, _texts));
        _texts.CrossFadeAlpha(1, 1, false);
        StartCoroutine(WaitTime(_waitTime));
        _texts.CrossFadeAlpha(0, 1, false);
    }

    private IEnumerator WaitTime(float time)
    {
        yield return new WaitForSeconds(time);
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
