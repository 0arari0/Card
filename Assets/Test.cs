using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField]
    Text text;

    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            for (float i = 0f; i <= 1f; i += 0.02f)
            {
                text.color = new Color(text.color.r, text.color.g, text.color.b, i);
                yield return null;
            }
            for (float i = 1f; i >= 0f; i -= 0.02f)
            {
                text.color = new Color(text.color.r, text.color.g, text.color.b, i);
                yield return null;
            }
        }
    }
}
