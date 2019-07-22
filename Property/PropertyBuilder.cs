/**
 * <summary>author: Shamo Humbatli</summary>
 */

using System.IO;

namespace Property
{
    public class PropertyBuilder
    {
        public PropertyBuilder()
        {

        }

        public PropertiesBox LoadPropertiesFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            string[] props = File.ReadAllLines(filePath);
            PropertiesBox pb = new PropertiesBox();

            foreach (string prop in props)
            {
                string key = prop.Split('=')[0].Trim();
                string value = prop.Split('=')[1].Trim();

                pb.AddProperty(key, value);
            }
            return pb;
        }
    }
}
