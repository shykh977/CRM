using Newtonsoft.Json.Serialization;

namespace BTG_CRM.Helper
{
    public class LowercaseContractResolver : DefaultContractResolver
    {

        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName;//.ToLower();
        }

    }
}
