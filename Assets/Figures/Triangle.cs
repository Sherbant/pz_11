using UnityEngine;

public class Triangle : IShape
{
    public void Draw()
    {
        GameObject triangle = new GameObject("Triangle");
        MeshFilter meshFilter = triangle.AddComponent<MeshFilter>();
        MeshRenderer renderer = triangle.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        mesh.vertices = new Vector3[]
        {
            new Vector3(0, 1, 0),
            new Vector3(-1, -1, 0),
            new Vector3(1, -1, 0)
        };
        mesh.triangles = new int[] { 0, 1, 2 };
        mesh.RecalculateNormals();

        // установка материала и цвета
        renderer.material = new Material(Shader.Find("Standard"));

        meshFilter.mesh = mesh;

        triangle.transform.position = new Vector3(-2, 3, 0);
    }
}