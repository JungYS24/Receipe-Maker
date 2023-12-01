using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnStartButtonClicked()
    {

        Debug.Log("Start button clicked!");
        // 시작 버튼이 클릭되었을 때 실행될 동작 추가
        SceneManager.LoadScene("Main"); 
    }
}

