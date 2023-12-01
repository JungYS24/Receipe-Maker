using UnityEngine;

public class Cooking : MonoBehaviour
{
    public CookButton cookButton;
    public CookMaterialType materialType;

    private bool isSelected;

    public void OnIngredientButtonClicked()
    {
        // 버튼이 클릭되면 CookButton 스크립트의 SetMaterialSelected 메서드 호출
        cookButton.SetMaterialSelected(materialType, !isSelected);
        isSelected = !isSelected;
    }
}
