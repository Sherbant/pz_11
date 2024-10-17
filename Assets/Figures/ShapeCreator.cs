using UnityEngine;
using UnityEngine.UI;

public class ShapeCreator : MonoBehaviour
{
    private bool circleCreated = false;
    private bool squareCreated = false;
    private bool triangleCreated = false;

    private GameObject circle;  // ������ �� ��������� ����
    private GameObject square;  // ������ �� ��������� �������
    private GameObject triangle; // ������ �� ��������� �����������

    public Dropdown colorDropdown; // ������ �� Dropdown ��� ������ �����

    void Start()
    {
        // ����������� ����� � ������� ��������� �������� � Dropdown
        colorDropdown.onValueChanged.AddListener(delegate {
            ChangeAllShapesColor(GetSelectedColor());
        });
    }

    private void ChangeAllShapesColor(Color selectedColor)
    {
        if (circle != null)
        {
            SpriteRenderer circleRenderer = circle.GetComponent<SpriteRenderer>();
            if (circleRenderer != null)
            {
                circleRenderer.color = selectedColor;
            }
        }

        if (square != null)
        {
            SpriteRenderer squareRenderer = square.GetComponent<SpriteRenderer>();
            if (squareRenderer != null)
            {
                squareRenderer.color = selectedColor;
            }
        }

        if (triangle != null)
        {
            SpriteRenderer triangleRenderer = triangle.GetComponent<SpriteRenderer>();
            if (triangleRenderer != null)
            {
                triangleRenderer.color = selectedColor;
            }
        }
    }

    // ����� ��� ��������� ���������� �����
    private Color GetSelectedColor()
    {
        switch (colorDropdown.value)
        {
            case 0: return Color.red;   // �������
            case 1: return Color.green; // �������
            case 2: return Color.blue;  // �����
            default: return Color.white; // ����� (�� ���������)
        }
    }

    public void CreateCircle()
    {
        if (!circleCreated)
        {
            circle = new GameObject("Circle");
            SpriteRenderer renderer = circle.AddComponent<SpriteRenderer>();

            renderer.sprite = Resources.Load<Sprite>("Sprites/CircleSprite");  // ���������� ����� ������ ��� ��� ��������
            renderer.color = GetSelectedColor(); // ���������� �����

            circle.transform.position = new Vector3(7, 3, -8);
            circleCreated = true;
        }
        else
        {
            Debug.Log("���� ��� ������!");
        }
    }

    public void CreateSquare()
    {
        if (!squareCreated)
        {
            square = new GameObject("Square");
            SpriteRenderer renderer = square.AddComponent<SpriteRenderer>();
            renderer.sprite = Resources.Load<Sprite>("Sprites/SquareSprite"); 
            renderer.color = GetSelectedColor(); 

            square.transform.position = new Vector3(-12, 3, -8);
            squareCreated = true;
        }
        else
        {
            Debug.Log("������� ��� ������!");
        }
    }

    public void CreateTriangle()
    {
        if (!triangleCreated)
        {
            triangle = new GameObject("Triangle");
            SpriteRenderer renderer = triangle.AddComponent<SpriteRenderer>();
            renderer.sprite = Resources.Load<Sprite>("Sprites/TriangleSprite"); 
            renderer.color = GetSelectedColor(); 

            triangle.transform.position = new Vector3(-2, 3, -8);
            triangleCreated = true;
        }
        else
        {
            Debug.Log("����������� ��� ������!");
        }
    }

    public void RemoveShapes()
    {
        if (circleCreated)
        {
            Destroy(circle);
            circleCreated = false;
            circle = null;
        }

        if (squareCreated)
        {
            Destroy(square);
            squareCreated = false;
            square = null;
        }

        if (triangleCreated)
        {
            Destroy(triangle);
            triangleCreated = false;
            triangle = null;
        }
    }
}