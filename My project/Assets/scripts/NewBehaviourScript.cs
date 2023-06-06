using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    
    [SerializeField] private float speed = 4.5f;
    
    //[SerializeFiled] - встроеная функция юнити , позволяющая изменить значение переменной из инспектора , а не из кода 
    //private - 
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.right * speed);
    }
}
