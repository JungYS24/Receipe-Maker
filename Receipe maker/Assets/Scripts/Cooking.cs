using UnityEngine;

public class Cooking : MonoBehaviour
{
    public CookButton cookButton;
    public CookMaterialType materialType;

    private bool isSelected;

    public void OnIngredientButtonClicked()
    {
        // ��ư�� Ŭ���Ǹ� CookButton ��ũ��Ʈ�� SetMaterialSelected �޼��� ȣ��
        cookButton.SetMaterialSelected(materialType, !isSelected);
        isSelected = !isSelected;
    }
}
