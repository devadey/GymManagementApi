using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public interface ISubscriptionsWriteService
    {
        Guid CreateSubscription(string subscriptionType, Guid adminId);
    }
}