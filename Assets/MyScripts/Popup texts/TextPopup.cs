using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPopup : MonoBehaviour
{
    public static TextPopup Create(Vector3 position, string text)
    {
        Transform textPopupTransform = Instantiate(GameAssets.i.pfTexturePopup, position, Quaternion.identity);

        TextPopup textPopup = textPopupTransform.GetComponent<TextPopup>();
        textPopup.Setup("text");

        return textPopup;
    }
    private TextMeshPro textMesh;

    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    public void Setup(string text)
    {
        textMesh.SetText(text);
    }    
}
