using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // 플레이어가 버튼을 누르면 SampleScene으로(본 게임으로) 넘어감
    public void OnclickButton()
    {
        SceneManager.LoadScene(1);
    }
}
