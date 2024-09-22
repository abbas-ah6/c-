Random random = new();
int daysUntilExpiration = random.Next(0, 12);
int discountPercentage = 0;

Console.WriteLine("Days Until Expiration: " + daysUntilExpiration + "\n");

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%");
        }
        else
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%");

        }
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");

    }
}
else
{

    Console.WriteLine("Your subscription has expired.");
}