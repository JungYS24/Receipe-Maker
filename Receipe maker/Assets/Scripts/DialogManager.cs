using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogManager : MonoBehaviour
{
    public GameObject[] panels;
    private int currentPanelIndex = 0;

    private void Start()
    {
        ShowPanel(0); // �ʱ⿡ ù ��° �г��� ǥ��
    }

    private void Update()
    {
        // �ƹ����̳� Ŭ���ϸ� ���� �г� ǥ��
        if (Input.GetMouseButtonDown(0))
        {
            ShowNextPanel();
        }
    }

    private void ShowPanel(int index)
    {
        // ��� �г��� ����� ������ �гθ� ǥ��
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }

    private void ShowNextPanel()
    {
        // ���� �г� �ε��� ����
        currentPanelIndex++;

        // ������ �гο� �����ϸ� �ش� �г��� ��Ȱ��ȭ
        if (currentPanelIndex < panels.Length)
        {
            ShowPanel(currentPanelIndex);
        }
        else
        {
            // ���⿡ ������ �г��� ��Ȱ��ȭ�ϴ� ������ �߰�
            panels[panels.Length - 1].SetActive(false);
            // �Ǵ� �ٸ� ������ �߰��� �� �ֽ��ϴ�.
            Debug.Log("������ �г��� ��Ȱ��ȭ�Ǿ����ϴ�.");
        }
    }
}
