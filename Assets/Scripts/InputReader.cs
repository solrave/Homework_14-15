using UnityEngine;

public class InputReader
{
  // private readonly KeyCode _jumpKey = KeyCode.Space;
  // private readonly KeyCode _turboKey = KeyCode.LeftShift;
  private readonly KeyCode _useKey = KeyCode.E;
  private readonly KeyCode _throwKeyCode = KeyCode.Space;
  private float _mouseX;
  private float _mouseY;
  public float XAxis => Input.GetAxis("Horizontal");
  public float YAxis => Input.GetAxis("Vertical");

  public bool UseActionInvoked => Input.GetKeyDown(_useKey);
  public bool ThrowActionInvoked => Input.GetKeyDown(_throwKeyCode);
  
  // public bool JumpInvoked => Input.GetKeyDown(_jumpKey);
  //
  // public bool TurboInvoked => Input.GetKey(_turboKey);
  //
  // private Vector3 MouseLook { get; set; }
  //
  // public Vector3 GetMouseLook(float mouseSense)
  // {
  //   _mouseX += Input.GetAxis("Mouse X") * mouseSense;
  //   _mouseY += Input.GetAxis("Mouse Y") * mouseSense;
  //   _mouseY = Mathf.Clamp(_mouseY, -45, 1);
  //   MouseLook = new Vector3(-_mouseY, _mouseX, 0);
  //   return MouseLook;
  // }
}