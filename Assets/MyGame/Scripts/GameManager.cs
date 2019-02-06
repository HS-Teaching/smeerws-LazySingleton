using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {

    private InputField objName;
    private TextMeshProUGUI tmpName;
    
    public SceneLoader sceneLoader;

    private void Start()
    {
        objName = FindObjectOfType<InputField>();
    }

    public void SaveName()
    {
        LazySingleton.Instance.Name = objName.text;
        sceneLoader.LoadNextScene();
    }

    public void LoadName()
    {
        if(tmpName == null)
        {
            tmpName = GameObject.Find("TMPName").GetComponent<TextMeshProUGUI>();
        }

        tmpName.text = LazySingleton.Instance.Name;
    }
}
