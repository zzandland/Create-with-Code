using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void LateUpdate()
  {
    transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
  }
}
