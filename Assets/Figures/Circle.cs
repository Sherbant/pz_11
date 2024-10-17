using UnityEngine;

public class Circle : IShape
{
    public void Draw()
    {
        GameObject circle = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        MeshRenderer renderer = circle.GetComponent<MeshRenderer>();
        renderer.material = new Material(Shader.Find("Standard"));

        // Установите позицию круга
        circle.transform.position = new Vector3(0, 3, 0);
    }
}