namespace DiGi.Core.Parameters
{
    public class SetValueSettings
    {
        public bool TryConvert { get; set; } = false;
        public bool CheckAccessType { get; set; } = true;

        public SetValueSettings() 
        {
            
        }

        public SetValueSettings(bool tryConvert, bool checkAccessType)
        {
            TryConvert = tryConvert;
            CheckAccessType = checkAccessType;
        }
    }
}
