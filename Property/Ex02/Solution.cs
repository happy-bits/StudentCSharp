using ConsoleUtilities;

namespace CSharpCourse.Property.Ex02;

public class Solution
{
    public static void Run()
    {
        void SetWithProperty()
        {
            ConsoleCompanion cc = new ConsoleCompanion();

            Address address = new Address
            {
                Street = "Långa gatan",
                StreetNumber = "13B",
                City = "Sundsvall",
            };

            cc.WriteLineDark("Try to set zipcode to 111 22");
            address.ZipCode = "111 22";
            cc.Columns("ZipCode", address.ZipCode);
            Console.WriteLine();

            cc.WriteLineDark("Try to set zipcode to 222 33");
            address.ZipCode = "222 33";
            cc.Columns("ZipCode", address.ZipCode);
            Console.WriteLine();

            cc.WriteLineDark("Try to set zipcode to HELLO");
            address.ZipCode = "HELLO";
            cc.Columns("ZipCode", address.ZipCode);

            // 
        }

        void SetWithMethods()
        {
            ConsoleCompanion cc = new ConsoleCompanion();

            Address address = new Address
            {
                Street = "Långa gatan",
                StreetNumber = "13B",
                City = "Sundsvall",
            };


            cc.WriteLineDark("Try to set zippycode to 111 22");
            address.SetZipCode("111 22");
            cc.Columns("ZippyCode", address.GetZipCode());
            Console.WriteLine();

            cc.WriteLineDark("Try to set zippycode to 222 33");
            address.SetZipCode("222 33");
            cc.Columns("ZippyCode", address.GetZipCode());
            Console.WriteLine();

            cc.WriteLineDark("Try to set zippycode to HELLO");
            address.SetZipCode("HELLO");
            cc.Columns("ZippyCode", address.GetZipCode());
        }


        SetWithProperty();

    }
}
