using UnityEngine;

public class RotatingCubeBehaviour : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
    }
}
