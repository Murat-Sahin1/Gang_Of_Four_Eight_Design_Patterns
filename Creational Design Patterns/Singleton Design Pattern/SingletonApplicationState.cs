namespace Gang_Of_Four_Eight_Design_Patterns.Creational_Design_Patterns.Singleton_Design_Pattern
{
    public class SingletonApplicationState
    {
        static SingletonApplicationState Instance { get; set; }
        public bool TestVariable = false;
        public static SingletonApplicationState getAppState()
        {
            if(Instance == null)
            {
                Instance = new SingletonApplicationState();
            }
            return Instance;
        }
    }
}
