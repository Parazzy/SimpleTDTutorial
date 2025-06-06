using UnityEngine;
using UnityEngine.EventSystems; // IPointerHandlers

public class UpgradeUIHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public bool mouseOver = false;

    public void OnPointerEnter(PointerEventData eventData) {
        mouseOver = true;
        UIManager.main.SetHoveringState(true);
    }

    public void OnPointerExit(PointerEventData eventData) {
        mouseOver = false;
        UIManager.main.SetHoveringState(false);
        gameObject.SetActive(false);
    }
}
