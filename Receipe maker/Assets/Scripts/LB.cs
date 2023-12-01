using UnityEngine;

public class LB : MonoBehaviour
{
    public void OnLeaveButtonClicked()
    {
        // 게임 종료 코드
        Debug.Log("Leave button clicked!"); // 확인을 위한 로그

        // 에디터에서는 종료 확인 불가
        // 실제 빌드된 게임에서 동작
        Application.Quit();
    }
}

