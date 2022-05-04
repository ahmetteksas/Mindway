using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu]
public class PlayerSettings : ScriptableObject
{
    public string sceneName;

    public Vector3Variable firstPos;
    public Vector3Variable secondPos;

    //public Transform firstPosition;
    //public Transform secondPosition;
    public GameObject levelPrefab;
    public GameObject levelPrefab2;


    //[SerializeField] FloatReference healthReference; // Read from Resource

    //public float health;

    //[Button]
    //void Reset()
    //{
    //    healthReference.Value = health;
    //}
}
