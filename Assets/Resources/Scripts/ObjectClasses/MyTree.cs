using UnityEngine;

public class MyTree : IEnvironmentObject
{
    private GameObject instance;

    public MyTree(GameObject obj)
    {
        instance = obj;
    }

    public GameObject Spawn(Vector3 position)
    {
        instance.transform.position = position; // Устанавливаем позицию
        return instance; // Возвращаем созданный объект
    }
}
