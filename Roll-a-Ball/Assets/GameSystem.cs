﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameSystem : MonoBehaviour {

    public void GameStart(){
        SceneManager.LoadScene("Stage01");
    }
}
