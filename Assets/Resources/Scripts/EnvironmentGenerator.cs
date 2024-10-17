using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class EnvironmentGenerator : MonoBehaviour
{
    public Button generateButton;  // переменная для кнопки
    public int numberOfObjects = 10;  // общее количество объектов, которые нужно создать
    private List<GameObject> createdObjects = new List<GameObject>();  // список для хранения созданных объектов

    private void Start()
    {
        // подписка на событие нажатия кнопки
        generateButton.onClick.AddListener(GenerateEnvironment);
    }

    public void GenerateEnvironment()
    {
        // очистка предыдущих объектов
        ClearEnvironment();

        // распределяем общее количество объектов между тремя типами
        int numberOfRocks = numberOfObjects / 3; // количество камней
        int numberOfTrees = numberOfObjects / 3; // количество деревьев
        int numberOfToriis = numberOfObjects - (numberOfRocks + numberOfTrees); // остальные объекты будут Torii

        // генерация объектов
        for (int i = 0; i < numberOfRocks; i++)
        {
            CreateObject("Rock");
        }

        for (int i = 0; i < numberOfTrees; i++)
        {
            CreateObject("Tree");
        }

        for (int i = 0; i < numberOfToriis; i++)
        {
            CreateObject("Torii");
        }
    }

    // метод для создания объектов
    private void CreateObject(string objectType)
    {
        EnvironmentFactory factory;
        GameObject newObject = null;

        switch (objectType)
        {
            case "Rock":
                factory = new RockFactory();
                newObject = factory.CreateObject().Spawn(GetRandomPosition());
                break;
            case "Tree":
                factory = new TreeFactory();
                newObject = factory.CreateObject().Spawn(GetRandomPosition());
                break;
            case "Torii":
                factory = new ToriiFactory();
                newObject = factory.CreateObject().Spawn(GetRandomPosition());
                break;
            default:
                throw new System.Exception("Unknown object type");
        }

        if (newObject != null)
        {
            createdObjects.Add(newObject);  // сохранение ссылки на созданный объект
        }
    }

    // метод для получения случайной позиции
    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
    }

    // метод для очистки объектов
    private void ClearEnvironment()
    {
        // удаление всех созданных объектов из списка
        foreach (GameObject obj in createdObjects)
        {
            Destroy(obj); 
        }
        createdObjects.Clear();  // очищение списка
    }
}
