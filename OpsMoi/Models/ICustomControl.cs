namespace OpsMoi.Models
{
    public interface ICustomControl
    {
        void InitializeByResolution();
        void SetButton_Tags();
        void Sync();
    }
}
