using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
   

    public int totalItemCount;
    public int stage;

    // �÷��̾ �������� �� �԰� �� ����Ʈ�� ���� Win ������ �Ѿ
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }

        if (other.gameObject.tag == "Player")
        { 
        
            SceneManager.LoadScene(stage);
        }
    }
}
