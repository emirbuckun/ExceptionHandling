namespace ExceptionHandling
{
  internal class Program
  {
    private static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string? input = Console.ReadLine();
      int number = input is not null ? int.Parse(input) : 0;
      try
      {
        ValidateNumberRange(number);
        Test();
      }
      catch (Exception)
      {
      }
    }

    private static void ValidateNumberRange(int number)
    {
      if (number < 0) throw new NumberOutOfRangeException();
    }

    private static void Test()
    {
      try
      {
        ChildMethod();
      }
      catch (NullReferenceException ex)
      {
        Console.WriteLine($"NullReferenceException Catched: {ex}");
      }
      catch (NumberOutOfRangeException ex)
      {
        Console.WriteLine($"NumberOutOfRangeException Catched: {ex}");
      }
      catch (NotImplementedException ex)
      {
        Console.WriteLine($"NotImplementedException Catched: {ex}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Exception Catched: {ex}");
      }
      finally
      {
        // Runs in every case
      }
    }

    private static void ChildMethod()
    {
      throw new NumberOutOfRangeException();
    }
  }
}