using UnityEngine;

namespace Global
{
    public static class TestMethod 
    {

        //Funcion que nos permite rápidamente comprobar métodos(sin parametros) sin necesidad de estar generando inputs
        public static void CheckMethod(System.Action action, KeyCode keyCode)
        {
            if (Input.GetKeyDown(keyCode))
            {
                action.Invoke();
            }
        }
        
    }
}
