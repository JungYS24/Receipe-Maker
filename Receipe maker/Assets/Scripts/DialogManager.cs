using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogManager : MonoBehaviour
{
    public GameObject[] panels;
    private int currentPanelIndex = 0;

    private void Start()
    {
        ShowPanel(0); // 초기에 첫 번째 패널을 표시
    }

    private void Update()
    {
        // 아무곳이나 클릭하면 다음 패널 표시
        if (Input.GetMouseButtonDown(0))
        {
            ShowNextPanel();
        }
    }

    private void ShowPanel(int index)
    {
        // 모든 패널을 숨기고 지정된 패널만 표시
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }

    private void ShowNextPanel()
    {
        // 현재 패널 인덱스 증가
        currentPanelIndex++;

        // 마지막 패널에 도달하면 해당 패널을 비활성화
        if (currentPanelIndex < panels.Length)
        {
            ShowPanel(currentPanelIndex);
        }
        else
        {
            // 여기에 마지막 패널을 비활성화하는 로직을 추가
            panels[panels.Length - 1].SetActive(false);
            // 또는 다른 동작을 추가할 수 있습니다.
            Debug.Log("마지막 패널이 비활성화되었습니다.");
        }
    }
}
