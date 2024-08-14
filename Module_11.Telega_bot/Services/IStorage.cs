using Module_11.Telega_bot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11.Telega_bot.Services
{
    public interface IStorage
    {
        Session GetSession(long chatId);
    }
}
