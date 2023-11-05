using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class LoginBehaviours : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Button confirmButton;

    public string serverURL = "localhost/0001";

    WWWForm data;

    // Start is called before the first frame update
    void Start()
    {
        
        usernameInput.onEndEdit.AddListener(submitName);
        passwordInput.onEndEdit.AddListener(submitPassword);
        confirmButton.onClick.AddListener(moveToLevel);
        StartCoroutine(Upload());
    }

    private void submitName(string usernameInput)
    {
        Debug.Log(usernameInput);
    }

    private void submitPassword(string passwordInput)
    {
        Debug.Log(passwordInput);
    }

    public void moveToLevel()
    {
        new WaitForSeconds(3);
        SceneManager.LoadScene("Level 1");
    }

    public void onButtonClick()
    {
        confirmButton.onClick.AddListener(moveToLevel);
    }

    IEnumerator Upload()
    {
        data = new WWWForm();
        data.AddField("usernameInput", usernameInput.text);
        data.AddField("passwordInput", passwordInput.text);

        using (UnityWebRequest www = UnityWebRequest.Post(serverURL, data))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Data upload complete");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
