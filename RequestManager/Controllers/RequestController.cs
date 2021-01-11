using RequestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager.Controllers
{
    class RequestController
    {
        public void Create(string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {

        }
        public Request GetById(int id)
        {
            Request _returnRequest = new Request();
            
            return _returnRequest;
        }

        public Request GetByStatusOrderByPriority(Status status)
        {
            Request _returnRequest = new Request();

            return _returnRequest;
        }
    }
}
