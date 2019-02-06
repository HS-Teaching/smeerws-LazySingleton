/* lazy singleton 
 * this fixes the persistency problem (across scenes) and in addition the singleton object must not be present in the hierarchy (lazy instantiation).  
 */
using UnityEngine;

public class LazySingleton : MonoBehaviour {

    private readonly string Tag = "lazySingleton";
    private static LazySingleton instance = null;
    private string yourName = "";

    public static LazySingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<LazySingleton>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "LazySingleton";
                    instance = go.AddComponent<LazySingleton>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    public string Name
    {
        get
        {
            Debug.Log(Tag + " get name " + yourName);
            return yourName;
        }

        set
        {
            Debug.Log(Tag + " name set to " + yourName);
            yourName = value;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Destroy " + Tag + " " + gameObject.name);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Assign this " + Tag + " instance  with name " + gameObject.name);
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
