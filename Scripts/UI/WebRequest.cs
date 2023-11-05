using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class WebRequest : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;

    // Start is called before the first frame update
    void Start()
    {
        usernameInput.onEndEdit.AddListener(getUsername);
        passwordInput.onEndEdit.AddListener(getPassword);
        StartCoroutine(Upload());
    }

    private void getUsername(string username)
    {
        Debug.Log(username);
    }

    private void getPassword(string password)
    {
        Debug.Log(password);
    }

    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("myField", "myData");

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/0001", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
