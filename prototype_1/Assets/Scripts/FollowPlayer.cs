using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public GameObject player;
  private Vector3 behindOffset = new Vector3(0, 7, -20);
  private Vector3 frontOffset = new Vector3(0, 1.7f, 1.2f);
  private bool isFrontView = false;
  // Start is called before the first frame update
  void Start()
  {

  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Keypad0))
    {
      isFrontView = !isFrontView;
    }
  }

  // Update is called once per frame
  void LateUpdate()
  {
    transform.position = player.transform.position + (isFrontView ? frontOffset : behindOffset);
  }
}
