using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndLoader : MonoBehaviour
{
    public TMP_InputField field;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if(field.text == "CaMoEr")
        {
            SceneManager.LoadScene("end");
        }
    }
}
