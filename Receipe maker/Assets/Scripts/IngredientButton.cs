using UnityEngine;
using UnityEngine.UI;

public class IngredientButton : MonoBehaviour
{
    public CookMaterialType materialType;  // 재료 버튼의 타입

    private bool isSelected;  // 재료 버튼이 선택되었는지 여부

    // CookButton 스크립트 참조
    private CookButton cookButton;

    private void Start()
    {
        // CookButton 스크립트를 찾아서 참조
        cookButton = FindObjectOfType<CookButton>();
    }

    // 버튼 클릭 시 호출되는 메서드
    public void OnIngredientButtonClicked()
    {
        isSelected = !isSelected;  // 선택 상태를 토글

        // 선택 상태에 따라 버튼의 색상 변경
        UpdateButtonVisual();

        // 선택 상태에 따라 CookButton 스크립트에 현재 재료 버튼을 전달
        cookButton.SetMaterialSelected(materialType, isSelected);
    }

    // 버튼의 시각적 상태를 업데이트하는 메서드
    public void UpdateButtonVisual()
    {
        // 선택되었을 때 버튼의 색상을 어둡게, 선택되지 않았을 때 기본 색상으로 설정
        Color newColor = isSelected ? Color.gray : Color.white;
        GetComponent<Image>().color = newColor;
    }
}
