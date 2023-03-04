namespace Domain.Utilities;

public static class Utility
{
    public static int CalculateNights(DateTime checkInDate, DateTime checkOutDate)
    {
        var nights = checkOutDate - checkInDate;

        return nights.Days;
    }

    public static decimal CalculateNightPrices(decimal pricePerNight, int totalNights)
    {
        var result = pricePerNight * totalNights;

        return result;
    }

    public static decimal CalculateTotalWithTax(decimal nightPrice, decimal tax)
    {
        var taxPercentage = tax / 100;
        var result = nightPrice + (nightPrice * taxPercentage);

        return result;
    }

    public static bool DateValidation(DateTime checkInDate, DateTime checkOutDate)
    {
        if (checkInDate > checkOutDate)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
