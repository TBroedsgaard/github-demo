using DataAccess.Controller.Impl;

namespace DataAccess.Facade.Impl
{
    public class DataAccessUserFacade : IDataAccessUserFacade
    {
        private UserController controller;

        public DataAccessUserFacade()
        {
            this.controller = new UserController();
        }

    }
}