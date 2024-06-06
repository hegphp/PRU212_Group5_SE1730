using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public float changeTime = 9.5f;
    public string SceneName;
   private void Update()
    {
         changeTime -= Time.deltaTime;
        if (changeTime < 0)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
