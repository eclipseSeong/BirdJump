using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReTry : MonoBehaviour
{
    public void ReTryGame(){
        SceneManager.LoadScene("PlayScene");
    }
}
