using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

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
    }
    else if (gameObject.CompareTag("Player") && other.gameObject.CompareTag("Aggressive"))
    {
      Destroy(gameObject);
      Debug.Log("Game Over!");
    }
  }
}
