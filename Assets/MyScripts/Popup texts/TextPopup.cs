using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPopup : MonoBehaviour
{
    public static TextPopup Create(Vector3 position, string text)
    {
        Transform textPopupTransform = Instantiate(GameAssets.i.pfTextPopup, position, Quaternion.identity);

        TextPopup textPopup = textPopupTransform.GetComponent<TextPopup>();
        textPopup.Setup("text");

        return textPopup;
    }
    private TextMeshPro textMesh;
    private float disappearTimer;
    private const float DISAPPEAR_TIMER_MAX = 1f;
    private Color textColor;
    private Vector3 moveVector;
    // private static int sortingOrder;
        //in case new text should always come top

    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    public void Setup(string text)
    {
        textMesh.SetText(text);
        textColor = textMesh.color;
        disappearTimer = DISAPPEAR_TIMER_MAX;

        moveVector = new Vector3(1, 1) * 10f;
    }

    private void Update()
    {        
        transform.position += moveVector * Time.deltaTime;
        moveVector -= moveVector * 1f * Time.deltaTime;

        if (disappearTimer > DISAPPEAR_TIMER_MAX * .5f)
        {
            float increaseScaleAmount = 1f;
            transform.localScale += Vector3.one * increaseScaleAmount * Time.deltaTime;
        }
        else
        {
            float decreaseScaleAmount = 1f;
            transform.localScale += Vector3.one * decreaseScaleAmount * Time.deltaTime;
        }

        disappearTimer -= Time.deltaTime;
        if (disappearTimer < 0)
        {
            //start dissappearing
            float disappearSpeed = 3f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            textMesh.color = textColor;
            if (textColor.a < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
