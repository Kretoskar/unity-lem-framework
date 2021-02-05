using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Pooler
{
    private static Dictionary<string, Pool> _pools = new Dictionary<string, Pool>();

    public static void Spawn(GameObject objectToSpawn, Vector3 position, Quaternion rotation)
    {
        GameObject obj;
        
        string key = GenerateKey(objectToSpawn);

        if (_pools.ContainsKey(key))
        {
            if (_pools[key].Inactive.Count == 0)
            {
                Object.Instantiate(objectToSpawn, position, rotation, _pools[key].Parent.transform);
            }
            else
            {
                obj = _pools[key].Inactive.Pop();
                obj.transform.position = position;
                obj.transform.rotation = rotation;
                obj.SetActive(true);
            }
        }
        else
        {
            //Create pool for the object
            GameObject newParent = new GameObject($"POOL_{key}");
            Object.Instantiate(objectToSpawn, position, rotation, newParent.transform);
            
            Pool newPool = new Pool(newParent);
            _pools.Add(key, newPool);
        }
    }

    public static void Despawn(GameObject objectToDespawn)
    {
        string key = GenerateKey(objectToDespawn);

        if (_pools.ContainsKey(key))
        {
            _pools[key].Inactive.Push(objectToDespawn);
            objectToDespawn.transform.position = _pools[key].Parent.transform.position;
            objectToDespawn.SetActive(false);
        }
        else
        {
            GameObject newParent = new GameObject($"POOL_{key}");
            Pool newPool = new Pool(newParent);
            
            objectToDespawn.transform.SetParent(newParent.transform);
            
            _pools.Add(key, newPool);
            _pools[key].Inactive.Push(objectToDespawn);
            objectToDespawn.SetActive(false);
        }
    }

    private static string GenerateKey(GameObject keyObject) => keyObject.name.Replace("(Clone)", "");
}
