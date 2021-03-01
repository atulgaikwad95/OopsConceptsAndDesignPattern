namespace DependencyInversionUsingAutofac
{
    interface IDataAccess
    {
        void LoadData();
        void SaveData(string data);
    }
}