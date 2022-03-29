using System;

namespace Task2_29March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Student student = new Student("Baxseli Nezerov", "AP204", 90);
            Student student1 = new Student("Tural Hemidzade", "AP204", 80);

            Group group = new Group(1,student,15);
            Group group2 = new Group(2,student,16);
            
            
            

            

            Console.WriteLine("Menu");
            do
            {
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Butun telebelere bax");
                Console.WriteLine("3.Telebeler uzre axtaris et");
                Console.WriteLine("0.Proqrami bitir");

                

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Telebenin ad ve soyadini qeyd edin");
                       string fulname = Console.ReadLine();
                        Console.WriteLine("Group nomresini daxil edin");
                        Console.WriteLine("\n-----\n");
                        Console.WriteLine("Zehmet olmasa qrupun adini 2 boyuk herf ve 3 reqem olmaqla sira ile qeyd edin");

                        string groupno = Console.ReadLine();

                        while (!(groupno.Length == 5 && char.IsUpper(groupno[0]) && char.IsUpper(groupno[1])
                        && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]) && char.IsDigit(groupno[4])))
                        {
                            Console.WriteLine("Zehmet olmasa qrupun adini 2 boyuk herf ve 3 reqem olmaqla sira ile qeyd edin");
                            groupno = Console.ReadLine();
                        }
                        Console.WriteLine("Telebenin ortalamasini qeyd edin");

                        int avarage = Convert.ToInt32(Console.ReadLine());

                        while (avarage > 100)
                        {
                            Console.WriteLine("0-100 arasi ortalama qeyd edin");

                            avarage = Convert.ToInt32(Console.ReadLine());

                            
                        }
                         break;

                        case 2:

                       
                        group.Info();
                        group2.Info();


                        

                        break;

                        case 3:
                        Console.WriteLine("Qrupun max telebe limiti qeyd edin 0-20 arasi");
                       
                        int grouplimit = Convert.ToInt32(Console.ReadLine());


                        while ((group.No==1))
                        {
                            group.Info();
                            break;

                        }
                        while (group.No == 2)
                        {
                            group.Info();
                            break;

                        }
                                              
                        break;
                    case 0:
                        
                        break;
                    default:
                        break;
                }

            } while (true);





            //Console.WriteLine("Zehmet olmasa qrupun adini 2 boyuk herf ve 3 reqem olmaqla sira ile qeyd edin");

            //string groupno = Console.ReadLine();

            //while (!(groupno.Length == 5 && char.IsUpper(groupno[0]) && char.IsUpper(groupno[1])
            //&& char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]) && char.IsDigit(groupno[4])))
            //{
            //    Console.WriteLine("Zehmet olmasa qrupun adini 2 boyuk herf ve 3 reqem olmaqla sira ile qeyd edin");
            //    groupno = Console.ReadLine();
            //}

            //Console.WriteLine("Qrupun max telebe limiti qeyd edin 0-20 arasi");

            //int grouplimit = Convert.ToInt32(Console.ReadLine());

            //while (!(grouplimit > 0 && grouplimit < 20))
            //{
            //    Console.WriteLine("Qrupun max telebe limiti qeyd edin 0-20 arasi");
            //    grouplimit = Convert.ToInt32(Console.ReadLine());
            //}



        }

     

       
    }
}
