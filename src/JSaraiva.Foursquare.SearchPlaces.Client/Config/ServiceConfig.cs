using System.Configuration;

namespace JSaraiva.Foursquare.SearchPlaces.Client.Config
{
    public class ServiceConfig : ConfigurationElement
    {
        /// <summary>
        /// HTTP URL of service
        /// </summary>
        [ConfigurationProperty("url", IsRequired = true)]
        public string URL
        {
            get
            {
                return (string)base["url"];
            }
            set
            {
                base["url"] = value;
            }
        }
    }
}
