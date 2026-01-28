namespace DiGi.Core.Parameter.Classes
{
    public class SetValueSettings
    {
        public SetValueSettings()
        {
        }

        public SetValueSettings(bool tryConvert, bool checkAccessType)
        {
            TryConvert = tryConvert;
            CheckAccessType = checkAccessType;
        }

        public bool CheckAccessType { get; set; } = true;

        public bool TryConvert { get; set; } = false;
    }
}