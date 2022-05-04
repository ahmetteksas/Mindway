using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader instance;

    public PlayerSettings settings;

    public Vector3Variable position1;
    public Vector3Variable position2;

    [SerializeField] Text sceneName;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Start()
    {
        settings.sceneName = (SceneManager.GetActiveScene().name);
        sceneName.text = settings.sceneName;

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameObject firstObject = ObjectPool.instance.SpawnFromPool("Cube1", position1.Value, Quaternion.identity);
            GameObject secondObject = ObjectPool.instance.SpawnFromPool("Cube2", position2.Value, Quaternion.identity);
        }

    }


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
