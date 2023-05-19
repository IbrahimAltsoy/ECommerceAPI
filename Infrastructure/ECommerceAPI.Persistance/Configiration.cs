using Microsoft.Extensions.Configuration;

namespace ECommerceAPI.Persistance
{
    static class Configiration
    {
        static public string ConnectingString
        {
            get
            {

                ConfigurationManager configirationManger = new();
                configirationManger.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceAPI.Api"));
                configirationManger.AddJsonFile("appsettings.json");
                return configirationManger.GetConnectionString("myConnectingString");
            }
        }

    }
}
