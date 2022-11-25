
namespace InterviewStuff1.Domain;
public class Temperature
{
    public decimal Celsius { get; init; }
    public decimal Fahrenheit => (1.8m * Celsius) + 32;

    private Temperature(decimal celsius)
    {
        Celsius = celsius;
    }

    public static Temperature FromCelsius(decimal celsius)
    {
        return new Temperature(celsius);
    }

    public static Temperature FromF(decimal f)
    {
        return new Temperature((f-32)*5/9);
    }
}