namespace ConsoleApp2
{
    class Modifiers
    {
        public string name; //all
        private string name2; // only class
        protected string name3; // privarte only nested
        internal string name4; // public only project
        protected internal string name5; // public and public any project nested
        string name6; // private
        private protected string name7;
    }
}
