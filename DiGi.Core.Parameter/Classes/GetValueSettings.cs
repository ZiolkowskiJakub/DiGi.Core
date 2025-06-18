namespace DiGi.Core.Parameter.Classes
{
    public class GetValueSettings
    {
        public bool TryConvert { get; set; } = false;
        public bool CheckAccessType { get; set; } = true;

        public GetValueSettings() 
        {
            
        }

        public GetValueSettings(bool tryConvert, bool checkAccessType)
        {
            TryConvert = tryConvert;
            CheckAccessType = checkAccessType;
        }
    }
}
