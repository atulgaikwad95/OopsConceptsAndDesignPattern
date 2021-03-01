namespace DependencyInversionUsingAutofac
{
    class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            System.Console.WriteLine("Data is Loading");
        }

        public void SaveData(string data)
        {
            System.Console.WriteLine($"Saving {data}");
        }
    }
}
