namespace GoF_Patterns.Memento.Example
{
    class HeroMemento
    {
        public int Cartidges { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int cartidges, int lives)
        {
            Cartidges = cartidges;
            Lives = lives;
        }
    }
}