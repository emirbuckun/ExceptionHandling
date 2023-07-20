namespace ExceptionHandling
{
  internal class NumberOutOfRangeException : Exception
  {
    public NumberOutOfRangeException()
    {
      Console.WriteLine("Number Out Of Range Exception occurred!");
    }
  }
}