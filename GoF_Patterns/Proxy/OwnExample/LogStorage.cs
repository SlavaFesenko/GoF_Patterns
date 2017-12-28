namespace GoF_Patterns.Proxy.OwnExample
{
    class LogStorage : ASubject
    {
        public override string GetPage(int number)
        {
            // get data from DB
            switch (number)
            {
                case 0: return $"Page #{number}";
                case 1: return $"Page #{number}";
                case 2: return $"Page #{number}";
                default: return "Page not found";
            }
            
            
        }
    }
}