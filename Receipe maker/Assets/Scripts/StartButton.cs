using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnStartButtonClicked()
    {

        Debug.Log("Start button clicked!");
        // ���� ��ư�� Ŭ���Ǿ��� �� ����� ���� �߰�
        SceneManager.LoadScene("Main"); 
    }
}

