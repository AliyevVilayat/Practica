using Practica9.Entitiy;
using Practica9.Exceptions;
using Practica9.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practica9.Service
{
    public  class UserService 
    {

        public void ShareStatus(User user,Status status)
        {
            user.Statuses.Add(status);
        }

        public Status GetStatusById(User user,int? id)
        {

            Status status = user.Statuses.Find(status => status.Id == id);
            return status;
        }

        public List<Status> GetAllStatuses(User user)
        {
            if (user.Statuses.Count != 0)
            {
                return user.Statuses;
            }
            return null;
        }

        public List<Status> FilterStatusByDate(User user,DateTime date)
        {
            List<Status> CheckStatuses = new();
            CheckStatuses = user.Statuses.FindAll(status => (status.SharedDate.Ticks - date.Ticks) / 10000000 >= 0);

            if (CheckStatuses.Count == 0)
            {
                throw new NotFoundException("User hec bir status");
            }

            return CheckStatuses;

        }
    }
}
