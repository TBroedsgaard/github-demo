using DataAccess.Controller.Impl;

namespace DataAccess.Facade.Impl
{
    public class DataAccessProjectFacade : IDataAccessProjectFacade
    {
        private ProjectController controller;

        public DataAccessProjectFacade()
        {
            this.controller = new ProjectController();
        }


    }
}