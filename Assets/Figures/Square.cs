using UnityEngine;

public class Square : IShape
{
    public void Draw()
    {
        GameObject square = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer renderer = square.GetComponent<MeshRenderer>();
        renderer.material = new Material(Shader.Find("Standard"));

        square.transform.position = new Vector3(2, 3, 0);
    }
}