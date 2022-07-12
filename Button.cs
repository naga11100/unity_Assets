using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button : MonoBehaviour, 
    IPointerClickHandler, 
    IPointerDownHandler, 
    IPointerUpHandler
{
        [SerializeField]
    Image           ImgFrame    = null;
        [SerializeField]
    UnityEvent      OnClick     = null;
    
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        // ボタンが押される
        Debug.Log("aa");
        ImgFrame.color = new Color(0, 0, 0, 1);
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        // ボタンが離される
        Debug.Log("bb");
        ImgFrame.color = new Color(0, 0, 0, 1);
    }
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        // ボタンが押され、その後ドラッグ操作が入ることなくボタンが離される
        OnClick?.Invoke();
        Debug.Log("cc");
        ImgFrame.color = new Color(0, 0, 0, 1);
    }
}