namespace Game
{    class Lives
    {
        int numberOfLives = 5;

        public void RemoveLife() 
        {
            numberOfLives --;

        }

        public void ShowLives() 
        {
            Console.WriteLine($"Current Lives: {numberOfLives}");
        }
    }
    
}
