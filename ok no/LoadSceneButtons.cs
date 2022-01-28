using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadSceneButtons : MonoBehaviour
    {
        public string SceneName = "";


        public void LoadTargetScene()
        {
            SceneManager.LoadScene(SceneName);
        }
    }

