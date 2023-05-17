using UnityEngine.Assertions;

namespace Global
{
    public static class AssertDebug 
    {
        //Funcion que podemos utilizar para comprobar si tenemos el componente que necesitamos
        public static void CheckComponent<T>(T component) where T : class
        {
            Assert.IsNotNull(component);
        }
    }
}
