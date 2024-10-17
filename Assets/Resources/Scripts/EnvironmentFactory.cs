using UnityEngine;

public abstract class EnvironmentFactory
{
    public abstract IEnvironmentObject CreateObject();
}

public class RockFactory : EnvironmentFactory
{
    public override IEnvironmentObject CreateObject()
    {
        GameObject rockPrefab = Resources.Load<GameObject>("Prefabs/RockPrefab"); // загрузка префаба
        GameObject rockInstance = GameObject.Instantiate(rockPrefab); // создание экземпляра
        return new Rock(rockInstance); // возвращаем Rock
    }
}

public class TreeFactory : EnvironmentFactory
{
    public override IEnvironmentObject CreateObject()
    {
        GameObject treePrefab = Resources.Load<GameObject>("Prefabs/MyTreePrefab"); 
        GameObject treeInstance = GameObject.Instantiate(treePrefab); 
        return new MyTree(treeInstance); 
    }
}

public class ToriiFactory : EnvironmentFactory
{
    public override IEnvironmentObject CreateObject()
    {
        GameObject toriiPrefab = Resources.Load<GameObject>("Prefabs/ToriiPrefab"); 
        GameObject toriiInstance = GameObject.Instantiate(toriiPrefab); 
        return new Torii(toriiInstance); 
    }
}
