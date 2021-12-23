using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyOutOfBounds : MonoBehaviour
{
  private float topBound = 30;
  private float bottomBound = -10;
  private float horizontalBound = 23;
  private GameObject engineObject;
  private GameEngine engineScript;
  // Start is called before the first frame update
  void Start()
  {
    engineObject = GameObject.Find("GameEngine");
    engineScript = engineObject.GetComponent<GameEngine>();
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.z > topBound || Mathf.Abs(transform.position.x) > horizontalBound)
    {
      Destroy(gameObject);
    }
    else if (transform.position.z < bottomBound)
    {
      if (engineScript.playerLives > 1)
      {
        --engineScript.playerLives;
        engineScript.LogStatus();
      }
      else
      {
        Debug.Log("Game Over!");
        Destroy(GameObject.FindGameObjectWithTag("Player"));
      }
      Destroy(gameObject);
    }
  }
}
