using UnityEngine;

public class LB : MonoBehaviour
{
    public void OnLeaveButtonClicked()
    {
        // ���� ���� �ڵ�
        Debug.Log("Leave button clicked!"); // Ȯ���� ���� �α�

        // �����Ϳ����� ���� Ȯ�� �Ұ�
        // ���� ����� ���ӿ��� ����
        Application.Quit();
    }
}

