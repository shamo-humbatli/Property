/**
 * <summary>author: Shamo Humbatli</summary>
 */

using System.Collections.Generic;

namespace Property
{
    public class PropertiesBox
    {
        private Dictionary<string, string> properties;

        public PropertiesBox()
        {

        }

        public void AddProperty(string propertyKey, string propertyValue)
        {
            if(properties == null)
            {
                properties = new Dictionary<string, string>();
            }

            properties.Add(propertyKey, propertyValue);
        }


        public Dictionary<string, string> Properties { get => properties; set => properties = value; }
    }
}
