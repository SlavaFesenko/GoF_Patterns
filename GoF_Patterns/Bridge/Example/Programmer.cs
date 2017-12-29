namespace GoF_Patterns.Bridge.Example
{
    abstract class Programmer
    {
        protected ILanguage _language;

        public ILanguage Language
        {
            set => _language = value;
        }

        protected Programmer(ILanguage language)
        {
            _language = language;
        }

        public virtual void DoWork()
        {
            _language.Build();
            _language.Execute();
        }

        public abstract void EarnMoney();
    }
}