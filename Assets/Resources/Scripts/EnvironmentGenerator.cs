using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class EnvironmentGenerator : MonoBehaviour
{
    public Button generateButton;  // ���������� ��� ������
    public int numberOfObjects = 10;  // ����� ���������� ��������, ������� ����� �������
    private List<GameObject> createdObjects = new List<GameObject>();  // ������ ��� �������� ��������� ��������

    private void Start()
    {
        // �������� �� ������� ������� ������
        generateButton.onClick.AddListener(GenerateEnvironment);
    }

    public void GenerateEnvironment()
    {
        // ������� ���������� ��������
        ClearEnvironment();

        // ������������ ����� ���������� �������� ����� ����� ������
        int numberOfRocks = numberOfObjects / 3; // ���������� ������
        int numberOfTrees = numberOfObjects / 3; // ���������� ��������
        int numberOfToriis = numberOfObjects - (numberOfRocks + numberOfTrees); // ��������� ������� ����� Torii

        // ��������� ��������
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

    // ����� ��� �������� ��������
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
            createdObjects.Add(newObject);  // ���������� ������ �� ��������� ������
        }
    }

    // ����� ��� ��������� ��������� �������
    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
    }

    // ����� ��� ������� ��������
    private void ClearEnvironment()
    {
        // �������� ���� ��������� �������� �� ������
        foreach (GameObject obj in createdObjects)
        {
            Destroy(obj); 
        }
        createdObjects.Clear();  // �������� ������
    }
}
