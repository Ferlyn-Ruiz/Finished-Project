using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRevervationSystem
{
    class Program
    {

        private static void Password()
        {
            string password;
            Console.Clear();
            Console.SetCursorPosition(50, 15);
            Console.Write("Password: ");
            password = Console.ReadLine();
            while (password != "101")
            {
                Console.Clear();
                Console.SetCursorPosition(50, 15);
                Console.Write("Password: ");
                password = Console.ReadLine();
            }
            return;
        }
       
        static void Main(string[] args)
        {
            Console.Clear();
            string[,] occupants_profile = new string[60,4];
            int[,] cidate = new int[60, 3];
            int[,] codate = new int[60, 3];
            int[] rooms = new int[60];
            int prog = 0, num = 0, pos = 30;
             int[]numday = new int[60];
            int[]occupants = new int[60];
            string name, number, age, address;
            int roomnum;
            string choice, choices;

            double[] tpayment = new double[60];
            double[] cash = new double[60];
            double[] balance = new double[60];
            double[] change = new double[60];
            int numdays, occupant;
            double tpayments,cashs, balances, changes, epayment, excess;
           
           int month1, day1, year1, month2, day2, year2;

            Password();

            Console.Clear();
            Console.WriteLine("HotelReservation System");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"
                                __    __   ________   ________   ________    __           
                               |  |  |  | |   __   | |__    __| |   _____|  |  |      
                               |  |__|  | |  |  |  |    |  |    |  |__      |  |         
                               |   __   | |  |  |  |    |  |    |   __|     |  |     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                               |  |  |  | |  |__|  |    |  |    |  |_____   |  |_____    
                               |__|  |__| |________|    |__|    |________|  |________|  
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                                                101  101010101   101
                                              10101  101   101 10101
                                                101  101   101   101
                                                101  101   101   101
                                                101  101   101   101
                                                101  101010101   101
");

            do
            {

                Console.SetCursorPosition(pos, 15);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Magenta;
                System.Threading.Thread.Sleep(70);
                Console.WriteLine("1");

                do
                {
                    //jamer pogi
                    Console.SetCursorPosition(30, 15);
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.Write("\n\n\t\t\t\t\t\t  Loading{0}%", num * 2);
                    num++;




                } while (num == prog);

                pos++;
                prog++;

            } while (prog <= 50);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            


            do
            {
            Mainmenu:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"          
                                                __________________________
                                               | HOTEL RESERVATION SYSTEM |
                                               ---------------------------- ");


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"   
                                                    ==================
                                                    == M A I N MENU ==
                                                    ================== ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t  <><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("\t\t\t\t\t  <><>   [A]ROOM RESERVATION          <><>");
                Console.WriteLine("\t\t\t\t\t  <><>   [B]VIEW OCCUPANT'S RECORD    <><>");
                Console.WriteLine("\t\t\t\t\t  <><>   [C]VIEW RESERVED ROOMS       <><>");
                Console.WriteLine("\t\t\t\t\t  <><><><><><><><><><><><><><><><><><><><>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n\t\t\t\t\t         ENTER YOUR CHOICE [A/B/C]: ");
                choices = Console.ReadLine();
                while ((choices != "a") && (choices != "A") && (choices != "b") && (choices != "B") && (choices != "c") && (choices != "C"))
                {
                    Console.Clear();
                    goto Mainmenu;
                }       

                Console.Clear();
                if ((choices == "a") || (choices == "A"))
                {   

                    int a = 0;
                    string ans;
                   
                    do
                    {


                        Console.WriteLine("\t\t\t\t\t\t\t\t\tHotel Reservation System");
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 1 AMENITIES                             |
                        |                                                                         |
                        |    2500 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Refrigerator                      |
                        |    Luxury Bedding                     Complimentary Toiletries & Towels |
                        |    Free Wireless Internet             Good Showers                      |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                        Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 2 AMENITIES                             |
                        |                                                                         |
                        |    2500 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Refrigerator                      |
                        |    Luxury Bedding                     Complimentary Toiletries & Towels |
                        |    Free Wireless Internet             Good Showers                      |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");

                        Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 3 AMENITIES                             |
                        |                                                                         |
                        |    2500 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Refrigerator                      |
                        |    Luxury Bedding                     Complimentary Toiletries & Towels |
                        |    Free Wireless Internet             Good Showers                      |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                        Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 4 AMENITIES                             |
                        |                                                                         |
                        |    2500 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Refrigerator                      |
                        |    Luxury Bedding                     Complimentary Toiletries & Towels |
                        |    Free Wireless Internet             Good Showers                      |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                        Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 5 AMENITIES                             |
                        |                                                                         |
                        |    2500 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Refrigerator                      |
                        |    Luxury Bedding                     Complimentary Toiletries & Towels |
                        |    Free Wireless Internet             Good Showers                      |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\n\t\t\t\t\t PRESS ANY KEY TO FILL UP FOR RESERVATION ");
                        Console.ReadKey();
                        Console.Write("\n\n");

                    enterroomnum:
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.Write("\t\t\tEnter Your Room Number:  ");

                            roomnum = int.Parse(Console.ReadLine());
                    
                        AskingForDate:
                            if ((roomnum == 1) || (roomnum == 2) || (roomnum == 3) || (roomnum == 4) || (roomnum == 5))
                        {
                       
                            Console.WriteLine("\n\n");
                            Console.WriteLine("\t\t\tCheck in Date ");
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t       MONTH:  ");
                            month1 = int.Parse(Console.ReadLine());
                           
                            
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t         DAY:  ");
                            day1 = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t        YEAR:  ");
                            year1 = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("\n\n");
                            Console.WriteLine("\t\t\tCheck out Date ");
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t       MONTH:  ");
                            month2 = int.Parse(Console.ReadLine());
                           
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t         DAY:  ");
                            day2 = int.Parse(Console.ReadLine());
                           
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t        YEAR:  ");
                            year2 = int.Parse(Console.ReadLine());
                            
                        }
                        else
                        {
                            goto enterroomnum;
                        }
                        for (int x = 0; x <= 59; x++)
                        {
                            if ((roomnum == rooms[x]) && (month1 == cidate[x, 0]) && (year1 == cidate[x, 2]) && (month2 == codate[x, 0]) && (year2 == codate[x, 2]))
                            {
                                if (((day1 >= cidate[x, 1]) && (day1 <= codate[x, 1])) || ((day2 >= cidate[x, 1]) && (day2 <= codate[x, 1])))
                                {   
                                  
                                    Console.WriteLine("\n\n\n\n");
                                    Console.WriteLine(@"
                                                  *************************************
                                                  **  THIS ROOM IS ALREADY RESERVED  **
                                                  *************************************");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto AskingForDate;


                                }
                            }
                        }
                       
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.Write("\t\t\t           Name: ");
                            occupants_profile[a, 0] = name = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t        Address: ");
                            occupants_profile[a, 1] = address = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t            Age: ");
                            occupants_profile[a, 2] = age = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.Write("\t\t\t Contact Number: ");
                            occupants_profile[a, 3] = number = Console.ReadLine();

                            try
                            {
                                Console.Clear();
                                Console.Write("\n\n\n\n\t\t\t\t\t Number of Occupants: ");
                                occupants[a]=occupant=int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.Write("\n\n\t\t\t\t\t PLEASE INPUT NUMERIC DATA ONLY ");
                                Console.Write("\n\n\t\t\t\t\t Number of Occupants: ");
                                occupants[a] = occupant = int.Parse(Console.ReadLine());
                            }
                            try
                            {
                               
                                Console.Write("\n\n\n\n\t\t\t\t\t Number of Day: ");
                                numday[a] = numdays = int.Parse(Console.ReadLine());

                            }
                            catch
                            {
                                Console.Clear();
                                Console.Write("\n\n\t\t\t\t\t PLEASE INPUT NUMERIC DATA ONLY ");
                                Console.Write("\n\n\n\n\t\t\t\t\t Number of Day: ");
                                numday[a] = numdays = int.Parse(Console.ReadLine());

                            }

                           

                            Console.Clear();
                             Console.WriteLine("\n\n\tTHIS ROOM IS LIMITED FOR FIVE PERSONS ONLY, EXCESS OCCUPANTS WILL BE CHARGED  Php 500.00 EACH");


                             if (occupant <= 5)
                            {


                                tpayments = numdays * 2500;                              
                                double totalpayment = 2500;                               
                                Console.WriteLine("\t\t\t\t\t     Room Rate: {0}", totalpayment);
                                Console.WriteLine("\t\t\t\t\t Total Payment: {0}", tpayment[a]=tpayments);

                                try
                                {
                                   
                                    Console.Write("\n\n\t\t\t\t      Enter Cash Amount: ");
                                    cashs = double.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    Console.Clear();
                                    Console.Write("\n\n\t\t\t\t\t PLEASE INPUT NUMERIC DATA ONLY ");
                                    Console.Write("\n\n\t\t\t\t      Enter Cash Amount: ");
                                    cashs = double.Parse(Console.ReadLine());

                                }



                                if (cashs < tpayments)
                                {
                                    balances = tpayments - cashs;
                                    Console.WriteLine("\n\n\t\t\t\t\t\tBalance: {0}", balances);
                                    Console.Clear();


                                }


                                changes = cashs - tpayments;
                                Console.WriteLine("\t\t\t\t\t Your Change is: {0}", changes);
                               
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("\n\n\n\n\t\t\t        D A T A   S A V I N G ...... ");
                                do
                                {

                                    Console.SetCursorPosition(pos, 15);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    System.Threading.Thread.Sleep(70);
                                    Console.WriteLine("1");

                                    do
                                    {
                                        Console.SetCursorPosition(30, 15);
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.Write("\n\n\t\t\t\t\t\t  Loading{0}%", num * 2);
                                        num++;




                                    } while (num == prog);

                                    pos++;
                                    prog++;

                                } while (prog <= 30);
                                System.Threading.Thread.Sleep(100);
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t                       HOTEL 101                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t                     R E C I E P T                              ");
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                    ROOM NUMBER: {0}                         ", rooms[a] = roomnum);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                    CHECK IN DATE                            ");
                                Console.WriteLine("\t\t\t                     Month: {0}                                      ", cidate[a, 0] = month1);
                                Console.WriteLine("\t\t\t                       Day: {0}                                     ", cidate[a, 1] = day1);
                                Console.WriteLine("\t\t\t                      Year: {0}                                     ", cidate[a, 2] = year1);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                    CHECK IN DATE                            ");
                                Console.WriteLine("\t\t\t                     Month: {0}                                      ", codate[a, 0] = month2);
                                Console.WriteLine("\t\t\t                       Day: {0}                                     ", codate[a, 1] = day2);
                                Console.WriteLine("\t\t\t                      Year: {0}                                    ", codate[a, 2] = year2);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                     Name: {0}                                     ", occupants_profile[a, 0] = name);
                                Console.WriteLine("\t\t\t                  Address: {0}                                     ", occupants_profile[a, 1] = address);
                                Console.WriteLine("\t\t\t                      Age: {0}                                     ", occupants_profile[a, 2] = age);
                                Console.WriteLine("\t\t\t           Contact Number: {0}                                     ", occupants_profile[a, 3] = number);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t                      P A Y M E N T                          ");
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t              Number of Days: {0}                            ", numday[a] = numdays);
                                Console.WriteLine("\t\t\t         Number of Occupants: {0}                            ", occupants[a] = occupant);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                  Amount Due: {0}                            ", tpayment[a]=tpayments);
                                Console.WriteLine("\t\t\t                        Cash: {0}                            ", cash[a]=cashs);
                                if (cashs > tpayments)
                                {
                                    balances = tpayments - cashs;
                                    
                                    Console.WriteLine("\t\t\t                      Change: {0}                            ", change[a] = changes);
                                  
                                }
                                if (cashs < tpayments)
                                {
                                    balances = tpayments - cashs;
                                    Console.WriteLine("\t\t\t                     Balance: {0}                            ", balance[a] = balances);
                                    Console.WriteLine("\t\t\t                      Change: 0                            ");

                                }                          
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t               THANK YOU COME AGAIN!                         ");
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t*********************************************************");

                            
                        }
                             
                            if (occupant > 5)
                            {
                                double payment1;
                                excess = occupant - 5;
                                epayment = excess * 500;
                                payment1 =  epayment+2500;
                                tpayments = payment1 * numdays;
                
                                Console.WriteLine("\t\t\t\t\t Excess Payment for {0} occupants: {1}", excess, epayment);
                                Console.WriteLine("\t\t\t\t\t Daily Payment for {0} days: {1}", numday[a] , payment1);
                                Console.WriteLine("\t\t\t\t\t Total Payment: {0}", tpayments);
                                try
                                {
                                    
                                    Console.Write("\n\n\t\t\t\t      Enter Cash Amount: ");
                                    cashs = double.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    Console.Clear();
                                    Console.Write("\n\n\t\t\t\t\t PLEASE INPUT NUMERIC DATA ONLY ");
                                    Console.Write("\n\n\t\t\t\t      Enter Cash Amount: ");
                                    cashs = double.Parse(Console.ReadLine());

                                }


                                if (cashs < tpayments)
                                {
                                    balances = tpayments - cashs;
                                    Console.WriteLine("\n\n\t\t\t\t\t\tBalance: {0}", balances);
                                    Console.Clear();


                                }


                                changes = cashs - tpayments;
                                Console.WriteLine("\t\t\t\t\t Your Change is: {0}", changes);
                               

                                
                              

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("\n\n\n\n\t\t\t        D A T A   S A V I N G ...... ");
                                do
                                {

                                    Console.SetCursorPosition(pos, 15);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    System.Threading.Thread.Sleep(70);
                                    Console.WriteLine("1");

                                    do
                                    {
                                        Console.SetCursorPosition(30, 15);
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.Write("\n\n\t\t\t\t\t\t  Loading{0}%", num * 2);
                                        num++;




                                    } while (num == prog);

                                    pos++;
                                    prog++;

                                } while (prog <= 30);
                                System.Threading.Thread.Sleep(100);
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t                       HOTEL 101                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t                     R E C I E P T                              ");
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                    ROOM NUMBER: {0}                         ", rooms[a] = roomnum);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                    CHECK IN DATE                            ");
                                Console.WriteLine("\t\t\t                     Month: {0}                                      ", cidate[a, 0] = month1);
                                Console.WriteLine("\t\t\t                       Day: {0}                                     ", cidate[a, 1] = day1);
                                Console.WriteLine("\t\t\t                      Year: {0}                                     ", cidate[a, 2] = year1);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                    CHECK IN DATE                            ");
                                Console.WriteLine("\t\t\t                     Month: {0}                                      ", codate[a, 0] = month2);
                                Console.WriteLine("\t\t\t                       Day: {0}                                     ", codate[a, 1] = day2);
                                Console.WriteLine("\t\t\t                      Year: {0}                                    ", codate[a, 2] = year2);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                     Name: {0}                                     ", occupants_profile[a, 0] = name);
                                Console.WriteLine("\t\t\t                  Address: {0}                                     ", occupants_profile[a, 1] = address);
                                Console.WriteLine("\t\t\t                      Age: {0}                                     ", occupants_profile[a, 2] = age);
                                Console.WriteLine("\t\t\t           Contact Number: {0}                                     ", occupants_profile[a, 3] = number);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t                      P A Y M E N T                          ");
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t              Number of Days: {0}                            ", numday[a]=numdays);
                                Console.WriteLine("\t\t\t         Number of Occupants: {0}                            ", occupants[a]=occupant);
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t                  Amount Due: {0}                            ", tpayment[a] = tpayments);

                                Console.WriteLine("\t\t\t                        Cash: {0}                            ", cash[a] = cashs);
                                if (cashs > tpayments)
                                {
                                    balances = tpayments - cashs;                                   
                                    Console.WriteLine("\t\t\t                      Change: {0}                            ", change[a]=changes);
                                  
                                }                 
                                if (cashs < tpayments)
                                {
                                    balances = tpayments - cashs;
                                   Console.WriteLine("\t\t\t                     Balance: {0}                            ", balance[a]=balances);
                                   Console.WriteLine("\t\t\t                      Change: 0                            ");
                                   
                                }                              
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                                Console.WriteLine("\t\t\t               THANK YOU COME AGAIN!                         ");
                                Console.WriteLine("\t\t\t                                                             ");
                                Console.WriteLine("\t\t\t*********************************************************");
                               
                            }


                            
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\n\t\t\t           Fill Up Again?[Y/N]: ");
                        ans = Console.ReadLine();
                        while ((ans != "Y") && (ans != "y") && (ans != "N") && (ans != "n")) 
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\n\t\t\t           Fill Up Again?[Y/N]: ");
                            ans = Console.ReadLine();
                            
                        }
                        a++;
                    }
                    while (ans == "y" || ans == "Y");

                }
                if (choices == "b" || choices == "B")
                {
                    string ask;
                   int cimonth, ciday, ciyear;                   
                    int b = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n");
                        Console.Write("\t\t\t\t   Enter Room Number:  ");
                        roomnum = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n\t\t\t\t\t >>ENTER DATE<< ");
                        Console.Write("\n\t\t\t\t       MONTH:  ");
                        cimonth =  int.Parse(Console.ReadLine());
                        Console.Write("\n\t\t\t\t         DAY:  ");
                        ciday =  int.Parse(Console.ReadLine());
                        Console.Write("\n\t\t\t\t        YEAR:  ");
                        ciyear = int.Parse(Console.ReadLine());
                        
                        Console.Clear();
                        for (b = 0; b <= 59; b++)
                        {
                            if ((roomnum== rooms[b])&&(cimonth == cidate[b, 0]) && (ciyear == cidate[b, 2]))
                            {
                                if ((ciday >= cidate[b, 1]) && (ciday <= codate[b, 1]))
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@"   
                                        =======================
                                        == OCCUPANTS PROFILE ==
                                        =======================");
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                      ROOM NUMBER: {0}                         ", rooms[b]);
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                   Check in Date : {0}, {1},{2}                        ", cidate[b, 0],
                                                                                                                                cidate[b, 1],
                                                                                                                                 cidate[b, 2]);
                                    Console.WriteLine("\t\t\t                  Check out Date : {0}, {1},{2}                          ", codate[b, 0],
                                                                                                                                codate[b, 1],
                                                                                                                                 codate[b, 2]);                                  
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                             Name: {0}                                     ", occupants_profile[b, 0]);
                                    Console.WriteLine("\t\t\t                          Address: {0}                                     ", occupants_profile[b, 1]);
                                    Console.WriteLine("\t\t\t                              Age: {0}                                     ", occupants_profile[b, 2]);
                                    Console.WriteLine("\t\t\t                   Contact Number: {0}                                     ", occupants_profile[b, 3]);
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                      P A Y M E N T                          ");
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                  Amount Due: {0}                            ", tpayment[b]);
                                    Console.WriteLine("\t\t\t                        Cash: {0}                            ", cash[b]);
                                    if (cash[b] > tpayment[b])
                                    {
                                        balance[b] = tpayment[b] - cash[b];
                                      
                                        Console.WriteLine("\t\t\t                      Change: {0}                            ", change[b] );
                                  
                                        
                                    }
                                    if (cash[b] < tpayment[b])
                                    {
                                        balance[b] = tpayment[b] - cash[b];
                                        Console.WriteLine("\t\t\t                     Balance: {0}                            ", balance[b]);
                                        Console.WriteLine("\t\t\t                      Change: 0                            ");

                                    }                          
                                    b=61;
                                }
                            }
                        }

                        if (b == 60)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\n\n");
                            Console.WriteLine(@"
                                                  ***************************
                                                  **  COSTUMERS NOT FOUND  **
                                                  *************************** ");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\n\t\t\t Search Again[Y/N]:   ");
                        ask = Console.ReadLine();
                        while ((ask != "Y") && (ask != "y") && (ask != "N") && (ask != "n"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\n\t\t\t Search Again[Y/N]:   ");
                            ask = Console.ReadLine();

                        }

                    }
                    while (ask == "y" || ask == "Y");
                }
                if (choices == "C" || choices == "c")
                {
                    string ask3;
                    int smonth, sday, syear;
                    int c, counter=0;
                    
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t >>ENTER DATE<< ");
                        Console.Write("\n\t\t\t\t\tMONTH: ");
                        smonth = int.Parse(Console.ReadLine());
                        Console.Write("\n\t\t\t\t\t  DAY: ");
                        sday = int.Parse(Console.ReadLine());
                        Console.Write("\n\t\t\t\t\t YEAR: ");
                        syear = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@"   
                                            =======================
                                            ==  RESERVED ROOMS   ==
                                            =======================");
                        Console.WriteLine("\n\n");
                        for (c = 0; c <= 59; c++)
                        {
                            if ((smonth == cidate[c, 0]) && (syear == cidate[c, 2]))
                            {
                                if ((sday >= cidate[c, 1]) && (sday <= codate[c, 1])) 
                                {
                                   
                                    Console.WriteLine("\t\t\t                      ROOM NUMBER: {0}                         ", rooms[c]);
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                        OCCUPANTS PROFILE                                                   ");
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                             Name: {0}                                     ", occupants_profile[c, 0]);
                                    Console.WriteLine("\t\t\t                          Address: {0}                                     ", occupants_profile[c, 1]);
                                    Console.WriteLine("\t\t\t                              Age: {0}                                     ", occupants_profile[c, 2]);
                                    Console.WriteLine("\t\t\t                   Contact Number: {0}                                     ", occupants_profile[c, 3]);
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                   Check in Date : {0}, {1},{2}                        ", cidate[c, 0],
                                                                                                                                cidate[c, 1],
                                                                                                                                 cidate[c, 2]);
                                    Console.WriteLine("\t\t\t                  Check out Date : {0}, {1},{2}                          ", codate[c, 0],
                                                                                                                                codate[c, 1],
                                                                                                                                 codate[c, 2]);                                           
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                   Number of Days: {0}                            ", numday[c]);
                                    Console.WriteLine("\t\t\t              Number of Occupants: {0}                            ", occupants[c]);
                                    Console.WriteLine("\t\t\t                                                             ");
                                    Console.WriteLine("\t\t\t                                                             ");
                                    counter++;
                                }
                            }
                        }
                        if (counter == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\n\n");
                            Console.WriteLine(@"
                                                  *******************************
                                                  **  NO RESERVED ROOMS FOUND  **
                                                  *******************************");

                        }
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\n\t\t\t View Again?[Y/N]: ");
                        ask3 = Console.ReadLine();
                        while ((ask3 != "Y") && (ask3 != "y") && (ask3 != "N") && (ask3 != "n"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\n\t\t\t View Again?[Y/N]: ");
                            ask3 = Console.ReadLine();

                        }
                    }
                    while (ask3 == "y" || ask3 == "Y");

                }

                Console.Write("\n\t\t\t\t Main Menu?[Y/N]: ");
                choice = Console.ReadLine();
                while ((choice != "Y") && (choice != "y") && (choice != "N") && (choice != "n"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t Main Menu?[Y/N]: ");
                    choice = Console.ReadLine();

                }
            }
            while (choice == "Y" || choice == "y");
       
        }
    }
}
