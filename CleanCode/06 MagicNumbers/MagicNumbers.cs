
namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        const string approved = "1";
        const string rejected = "2";

        enum Status { approved = 1, rejected = 2 };

        public void ApproveDocument(int status)
        {
            if (status == int(Status.approved))
            {
                // ...
            }
            else if (status == int(Status.rejected))
            {
                // ...
            }
        }

        public void RejectDoument(string status)
        {
            switch (status)
            {
                case approved:
                    // ...
                    break;
                case rejected:
                    // ...
                    break;
            }
        }

        

        }
    }
}
