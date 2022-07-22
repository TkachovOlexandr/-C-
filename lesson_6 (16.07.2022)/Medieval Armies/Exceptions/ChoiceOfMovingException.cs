namespace Medieval_Armies.Exceptions
{
    internal class ChoiceOfMovingException : Exception
    {
        public ChoiceOfMovingException() : base("This way of movement doesn't comply to a warrior!") { }
    }
}
