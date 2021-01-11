using System;

namespace RequestManager.Models
{
    class Request
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }

        /// <summary>
        /// Contructeur vide
        /// </summary>
        public Request() { }
        /// <summary>
        /// Constructeur avec paramétres
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="updatedOn"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        public Request(int id, string title, string description, DateTime createdOn, DateTime updatedOn, Status status, Priority priority)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Status = status;
            Priority = priority;
        }
    }
}
