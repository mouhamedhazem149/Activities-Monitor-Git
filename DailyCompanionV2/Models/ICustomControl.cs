namespace DailyCompanionV2.Models
{
    public interface ICustomControl
    {
        void InitializeByResolution();
        void Set_Tags();
        void Sync();
    }
}
