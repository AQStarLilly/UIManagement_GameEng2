using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button button;
    private Color originalColor;
    public Color highlightColor = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        originalColor = button.image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        button.image.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.image.color = originalColor;
    }
}
