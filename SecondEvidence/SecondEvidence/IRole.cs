using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEvidence
{
    public interface IRole
    {
        void AddRole(string Role);

        string RolePlay();
    }
}
