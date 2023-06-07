using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    
    [SerializeField] private float TemplateSpeed = 5f;  //Начальная скорость, которая меняется внутри проекта при желании
    
    //[SerializeFiled] - встроеная функция юнити , позволяющая изменить значение переменной из инспектора , а не из кода 
    //private - объявление приватности переменной
    // float - тип переменной с плавующей точкой (В конце цифры обязателно необходимо писать 'f', этого требует объявление типа float)
    //speed - название переменной для скорости нашего объекта

    //Встроенный метот юнити , который вызывается каждый кадр во время игры
    private void Update()
    {
        transform.position -= new Vector3 (TemplateSpeed * Time.deltaTime, 0, 0);
        //В данной строчке мы вычитаем из позиции объекта Vector3, который принимает в себя 3 перемменные вектора x ,y, z
        Debug.Log(transform.position);
    }
}
