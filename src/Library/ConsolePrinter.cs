public class ConsolePrinter : IPrinter
{
    public void PrintRecipe(IRecipePrintData printData)
    {
        Console.WriteLine(printData.GetTextToPrint());
    }
}
