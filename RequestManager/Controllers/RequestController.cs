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
        private List<Request> _requests = new List<Request>();
        /// <summary>
        /// Crée une Request et l'ajoute à la liste
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="updatedOn"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        public void Create(string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {
            int id = _requests.Any() ? _requests.Last().Id + 1 : 1;
            Request requestToAdd = new Request(id, title, description, createdOn, updatedOn, status, priority);
            _requests.Add(requestToAdd);
        }
        
        /// <summary>
        /// Recupere une Request qui a un Id spécifique
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Request GetById(int id)
        {
            Request returnRequest = new Request();
            if (_requests.Any(req=>req.Id == id))
            {

            }
            else
            {
                returnRequest = null;
            }
            
            return returnRequest;
        }
        /// <summary>
        /// Permete de recuperer les Request qui ont un Status bien preci et trie la liste suivant la priorité
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public Request GetByStatusOrderByPriority(Status status)
        {
            Request returnRequest = new Request();

            return returnRequest;
        }
        /// <summary>
        /// Update une Request spécifique dans la liste de requests
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="updatedOn"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        public void Update(int id, string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {
            if (_requests.Any(req => req.Id == id))
            {
                Request requestUpdated = new Request(id, title, description, createdOn, updatedOn, status, priority);
                Request requestToUpdate = _requests.Find(request => request.Id == id);
                
                //pour le test c'est juste necessaire de changer la proprieté Title
                requestToUpdate.Title = requestUpdated.Title;
                requestToUpdate.Description = requestUpdated.Description;
                requestToUpdate.CreatedOn = requestUpdated.CreatedOn;
                requestToUpdate.UpdatedOn= requestUpdated.UpdatedOn;
                requestToUpdate.Status = requestUpdated.Status;
                requestToUpdate.Priority = requestUpdated.Priority;
                //_requests.RemoveAll(req => req.Id == id);
            }
            else
            {
                throw new Exception("The Request doesn't exist");
            }
        }
        /// <summary>
        /// Efface de la liste requests une liste specifiée par l'Id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            if(_requests.Any(req => req.Id == id))
            {
                _requests.RemoveAll(req => req.Id == id);
            }
            else
            {
                throw new Exception("The Request doesn't exist");
            }
        }
    }
}
