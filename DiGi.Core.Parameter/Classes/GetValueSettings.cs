namespace DiGi.Core.Parameter.Classes
{
    public class GetValueSettings
    {
        public GetValueSettings()
        {

        }

        public GetValueSettings(bool tryConvert, bool checkAccessType)
        {
            TryConvert = tryConvert;
            CheckAccessType = checkAccessType;
        }

        public bool CheckAccessType { get; set; } = true;

        public bool TryConvert { get; set; } = false;
    }
}
