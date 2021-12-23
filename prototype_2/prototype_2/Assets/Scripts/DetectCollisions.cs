using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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

  }

  void OnTriggerEnter(Collider other)
  {
    if (gameObject.CompareTag("Projectile") && other.gameObject.CompareTag("Animal"))
    {
      Destroy(gameObject);
      Destroy(other.gameObject);
      ++engineScript.score;
      engineScript.LogStatus();
    }
    else if (gameObject.CompareTag("Player") && other.gameObject.CompareTag("Aggressive"))
    {
      if (engineScript.playerLives > 1)
      {
        Destroy(other.gameObject);
        --engineScript.playerLives;
        engineScript.LogStatus();
      }
      else
      {
        Destroy(gameObject);
        Debug.Log("Game Over!");
      }
    }
  }
}
