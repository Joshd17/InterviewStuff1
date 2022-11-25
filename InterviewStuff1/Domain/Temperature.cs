
namespace InterviewStuff1.Domain;
public class Temperature
{
    public decimal Celcius { get; init; }
    public decimal Farenheit => (1.8m * Celcius) + 32;

    private Temperature(decimal celcius)
    {
        Celcius = celcius;
    }

    public static Temperature FromCelcius(decimal celcius)
    {
        return new Temperature(celcius);
    }

    public static Temperature FromF(decimal f)
    {
        return new Temperature((f-32)*5/9);
    }
}