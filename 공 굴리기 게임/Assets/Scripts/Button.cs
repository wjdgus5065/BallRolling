using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // �÷��̾ ��ư�� ������ SampleScene����(�� ��������) �Ѿ
    public void OnclickButton()
    {
        SceneManager.LoadScene(1);
    }
}
