using UnityEngine;
using UnityEngine.SceneManagement;

public enum CookMaterialType
{
    Cheeze,
    Chicken,
    Fork,
    Shrimp,
    Chili
}

public class CookButton : MonoBehaviour
{
    private bool material1Selected;
    private bool material2Selected;

    public CookMaterialType materialType1;
    public CookMaterialType materialType2;

    public void OnCookButtonClicked()
    {
        Debug.Log("요리재료를 선택하라!");

        // materialType1과 materialType2에 따라 적절한 음식 조합 씬으로 이동
        if (material1Selected && material2Selected)
        {
            CheckCombination();
        }
        else
        {
            Debug.Log("요리재료를 두 가지 선택하십시오!");
        }
    }

    public void SetMaterialSelected(CookMaterialType materialType, bool isSelected)
    {
        if (!material1Selected)
        {
            material1Selected = isSelected;
            materialType1 = materialType;
        }
        else if (!material2Selected)
        {
            material2Selected = isSelected;
            materialType2 = materialType;
        }
    }


    private void CheckCombination()
    {
        if ((materialType1 == CookMaterialType.Cheeze && materialType2 == CookMaterialType.Fork) ||
            (materialType1 == CookMaterialType.Fork && materialType2 == CookMaterialType.Cheeze))
        {
            SceneManager.LoadScene("CheeseTonkatsuScene");
        }
        else if ((materialType1 == CookMaterialType.Chicken && materialType2 == CookMaterialType.Chili) ||
                 (materialType1 == CookMaterialType.Chili && materialType2 == CookMaterialType.Chicken))
        {
            SceneManager.LoadScene("SpicyChickenScene");
        }
        else if ((materialType1 == CookMaterialType.Fork && materialType2 == CookMaterialType.Chili) ||
                 (materialType1 == CookMaterialType.Chili && materialType2 == CookMaterialType.Fork))
        {
            SceneManager.LoadScene("BulgogiScene");
        }
        else if ((materialType1 == CookMaterialType.Shrimp && materialType2 == CookMaterialType.Chili) ||
                 (materialType1 == CookMaterialType.Chili && materialType2 == CookMaterialType.Shrimp))
        {
            SceneManager.LoadScene("ChiliShrimpScene");
        }
        else
        {
            // 조합에 맞지 않는 경우 Trash 씬으로 이동
            SceneManager.LoadScene("Trash");
        }
    }

}
