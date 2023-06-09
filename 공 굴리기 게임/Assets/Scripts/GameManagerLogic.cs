using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
   

    public int totalItemCount;
    public int stage;

    // 플레이어가 아이템을 다 먹고 골 포인트에 들어가면 Win 씬으로 넘어감
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
