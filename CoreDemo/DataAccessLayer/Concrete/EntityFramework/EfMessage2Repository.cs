using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetInboxtWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.message2s.Include(x => x.SenderUser).Where(y => y.ReceiverID == id).ToList(); 
            }
        }
        
        public List<Message2> GetSendBoxWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.message2s.Include(x => x.ReceiverUser).Where(x => x.SenderID == id).ToList();
            }
        }
    }
}
