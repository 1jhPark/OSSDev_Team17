using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//다시 시작 버튼 코드
public class Replay : MonoBehaviour
{
    public void ReplayFunc()
    {
        SceneManager.LoadScene("GameScene");
        GetComponent<AudioSource>().Play();
    }
}
