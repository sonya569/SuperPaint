

namespace Painting
{
    class SOFactory
    {
        public static IFileSO GetInstance(string type)
        {
            IFileSO fs = null;
            string[] str = type.Split('.');
            switch (str[str.Length - 1])
            {
                case "json":
                    fs = new FileSO_JSON(type);
                    break;
                case "csv":
                    fs = new FileSO_CSV(type);
                    break;
                case "xml":
                    fs = new FileSO_XML(type);
                    break;
                case "yaml":
                    fs = new FileSO_YAML(type);
                    break;
            }
            return fs;
        }
    }
}