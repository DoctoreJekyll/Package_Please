using UnityEngine;

namespace Test
{
    public class ConsumerDebugger : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            DebuggerClass t = new DebuggerClass();
            Debug.Log(t.TextToShow("Test objetc create"));
        }
    
    }
}
