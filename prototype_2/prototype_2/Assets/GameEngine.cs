using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
  public int playerLives = 3;
  public int score = 0;
  // Start is called before the first frame update
  void Start()
  {
    LogStatus();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void LogStatus()
  {
    Debug.Log("Lives = " + playerLives + " Score = " + score);
  }
}
