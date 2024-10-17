using UnityEngine;

public class Rock : IEnvironmentObject
{
    private GameObject instance;

    public Rock(GameObject obj)
    {
        instance = obj;
    }

    public GameObject Spawn(Vector3 position)
    {
        instance.transform.position = position; // Устанавливаем позицию
        return instance; // Возвращаем созданный объект
    }
}
