using UnityEngine;

public class fgh : MonoBehaviour
{
   
    [SerializeField] private float BackgrundSpeed = 3f;

    void Update()
    {
        transform.position -= new Vector3 (BackgrundSpeed * Time.deltaTime, 0, 0);
        Debug.Log(transform.position);
    }
}
