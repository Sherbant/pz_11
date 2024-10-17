using UnityEngine;

public class Torii : IEnvironmentObject
{
    private GameObject instance;

    public Torii(GameObject obj)
    {
        instance = obj;
    }

    public GameObject Spawn(Vector3 position)
    {
        instance.transform.position = position; // Устанавливаем позицию
        return instance; // Возвращаем созданный объект
    }
}
