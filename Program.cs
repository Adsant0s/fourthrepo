using System;
//*************************************
//Ariane Dos Santos
//Program Leap Year
//04/02/2021
//**************************************
namespace Q3
{
    class Program
    {

        const double Fee1 = 0.025, Fee2 = 0.03, Fee3 = 0.05;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            RetailerCharge();



        }

        static void RetailerCharge()
        {
            //declaring variables

            double BookWeight, DeliveryCharge = 2.50, TotalCharge;


            string DoAgain;

            do
            {
                Console.Write("Enter book weight: ");
                BookWeight = double.Parse(Console.ReadLine());

                string DeliveryType;

                Console.WriteLine("Enter delivery type: ");
                DeliveryType = Console.ReadLine();


                TotalCharge = BookWeight + DeliveryCharge;

                Console.WriteLine("Your total charge is: {0:c} ", TotalCharge);


                Console.Write("Do you wish to calculate another parcel (y/n) ? ");
                DoAgain = Console.ReadLine();

            }
            while (DoAgain == "y");
        }

        static double GetWeightCharge(double BookWeight)
        {
            double WeightCharge = 0;

            if (BookWeight <= 2000)
            {
                WeightCharge = BookWeight * Fee1;
            }
            else if (BookWeight > 2001 || BookWeight < 5001)
            {
                WeightCharge = BookWeight * Fee2;
            }

            else if(BookWeight >= 5001)
            {
                WeightCharge = BookWeight * Fee3;
            }

            return WeightCharge;
        }

        static double GetDeliveryCharge(string DeliveryType)
        {

            double DeliveryCharge;

            switch (DeliveryType)
            {
                case "R":
                DeliveryCharge = 2.50;
                break;

                case "E":
                    DeliveryCharge = 4.00;
                    break;

                case "SE":
                    DeliveryCharge = 5.00 ;
                    break;

                case "SSE":
                    DeliveryCharge = 6.00;
                    break;

                default:
                    DeliveryCharge = 0;
                    break;
            }

            return DeliveryCharge;
        }

    }


}

    



