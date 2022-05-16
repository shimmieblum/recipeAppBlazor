namespace MyRecipeApp.Data;

public class FXResponse
{
    public object Motd { get; set;}
    public bool Success { get; set;}
    public object Query { get; set;}
    public object Info { get; set;}
    public bool Historical { get; set;}
    public DateTime Date { get; set;}
    public double Result { get; set;}
}