using UnityEngine;

namespace AJierroCode.Core
{
    public class StatesGameManager : MonoBehaviour
    {
        #region -----SINGLETON-------
        private static StatesGameManager instance;
        //Instanciamos el objeto/singleton
        public static StatesGameManager Instance
        {
            get
            {
                if (instance == null)//Si no tenemos instancia
                {
                    instance = FindObjectOfType<StatesGameManager>();//La buscamos
                    if (instance == null)
                    {
                        instance = new GameObject().AddComponent<StatesGameManager>();//Si no, la instanciamos
                    }
                }

                return instance;
            }
        }
        #endregion
        
        public enum GameStates
        {
            Gameplay,
            Event,
            None
        }

        public GameStates actualGameState;
        
        private void Awake()
        {
            SingletonController();
            //TODO Esto puede dar algun problema pero de momento incializamos asi
            actualGameState = GameStates.None;
        }

        private void SingletonController()
        {
            if (instance != null)
            {
                Destroy(this);
            }
            
            DontDestroyOnLoad(this);
        }

        //Funcion para setear nuestro juego al modo que necesitemos
        public void SetGameState(GameStates newState)
        {
            actualGameState = newState;
        }

        //Comprobamos si el estado que tenemos es el que necesitamos
        public bool CheckActualState(GameStates actualState)
        {
            if (actualState != actualGameState)
            {
                return false;
            }

            return true;
        }
    }
}
