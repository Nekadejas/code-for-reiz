using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Reiz_Tech_Assignment_2
{
    internal class Branch
    {
        protected List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
        public void PushBranch(Branch branch)
        {
            branches.Add(branch);
        }

        public int GetTreeDepth(Branch branch, int depth)
        {
            int result = depth + 1;

            foreach (Branch item in branch.branches)
            {
                result = Math.Max(result, GetTreeDepth(item, depth + 1));
            }

            return result;

        }

    }
}
