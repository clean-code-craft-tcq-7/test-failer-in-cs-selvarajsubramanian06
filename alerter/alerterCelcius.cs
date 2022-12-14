using System;

namespace alerter
{
    public class alerterCelcius
    {
        static int alertFailureCount = 0;
        public static int alertInCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkStub.networkAlertStub(celcius);
            if (returnCode != 200)
            {
                alertFailureCount += 1;
            }
            else
            {
                alertFailureCount = 0;
            }

            return alertFailureCount;
        }
    }
}
