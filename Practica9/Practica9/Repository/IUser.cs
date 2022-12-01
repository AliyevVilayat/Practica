using Practica9.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9.Repository
{
    public interface IUser
    {
        public void ShareStatus(Status status);
        public Status GetStatusById(int? id);
        public List<Status> GetAllStatuses();
        public List<Status> FilterStatusByDate(DateTime date);
    }
}
