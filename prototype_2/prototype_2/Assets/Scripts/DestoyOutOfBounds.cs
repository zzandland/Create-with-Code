using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyOutOfBounds : MonoBehaviour
{
  private float topBound = 30;
  private float bottomBound = -10;
  private float horizontalBound = 23;
  // Start is called before the first frame update
  void Start()
  {

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
      Debug.Log("Game Over!");
      Destroy(gameObject);
      Destroy(GameObject.FindGameObjectWithTag("Player"));
    }
  }
}
