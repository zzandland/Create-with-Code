using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;

  // Update is called once per frame
  void Update()
  {
    // On spacebar press, send dog
    if (Input.GetKeyDown(KeyCode.Space))
    {
      // Delete existing dog and send a new one
      Destroy(GameObject.FindGameObjectWithTag("Dog"));
      Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
  }
}
