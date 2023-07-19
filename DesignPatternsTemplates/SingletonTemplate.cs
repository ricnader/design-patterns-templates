namespace DesignPatternsTemplates
{
    public class SingletonTemplate
    {
        public static SingletonTemplate instance { get; private set; }
        public string Value1 { get; set; }         

        private SingletonTemplate()
        {}

        public void setValue1(string value) => this.Value1 = value;

        public SingletonTemplate getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonTemplate();
            }
            return instance;
        }
    }
}