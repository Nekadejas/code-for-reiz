namespace Reiz_Tech_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new Branch();
            var branch1 = new Branch();
            var branch11 = new Branch();
            var branch2 = new Branch();
            var branch21 = new Branch();
            var branch211 = new Branch();
            var branch22 = new Branch();
            var branch221 = new Branch();
            var branch2211 = new Branch();
            var branch222 = new Branch();
            var branch23 = new Branch();
            var branch22111 = new Branch();

            root.PushBranch(branch1);
            root.PushBranch(branch2);
            branch1.PushBranch(branch11);
            branch2.PushBranch(branch21);
            branch2.PushBranch(branch22);
            branch2.PushBranch(branch23);
            branch21.PushBranch(branch211);
            branch22.PushBranch(branch221);
            branch22.PushBranch(branch222);
            branch211.PushBranch(branch2211);
            branch2211.PushBranch(branch22111);






            Console.WriteLine(root.GetTreeDepth(root, 0));

            

        }
    }
}