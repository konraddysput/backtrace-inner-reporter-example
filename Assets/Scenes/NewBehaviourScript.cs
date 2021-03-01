using Backtrace.Unity;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private BacktraceClient _backtraceClient;
    // Start is called before the first frame update
    void Awake()
    {
        string universeName = $"your-universe-name.sp.backtrace.io";
        string token = "token";
        _backtraceClient = IntegrationFactory.CreateErrorReporter(universeName, token);
    }

    public void ThrowException()
    {
        // throw an exception
        GameObject prefabButton = null;
        GameObject goButton = (GameObject)Instantiate(prefabButton);
        goButton.transform.localScale = new Vector3(1, 1, 1);

    }
}
