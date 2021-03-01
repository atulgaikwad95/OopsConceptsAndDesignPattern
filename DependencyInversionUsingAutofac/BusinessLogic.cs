namespace DependencyInversionUsingAutofac
{
    class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("Starting the Processing the Data");
            System.Console.WriteLine("Data is Processing now");
            _dataAccess.LoadData();
            _dataAccess.SaveData("PreocessInfo");
            _logger.Log("Finished With the Processing");
        }
    }
}
