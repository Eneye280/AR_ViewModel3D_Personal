using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public bool isActive;
    public float speed;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            isActive = true;
        if (Input.GetMouseButtonUp(0))
            isActive = false;

        if(isActive)
            transform.Rotate(0, -Input.GetAxis("Mouse X") * speed * Time.deltaTime, 0);
    }
}
