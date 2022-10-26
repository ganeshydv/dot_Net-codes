using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product3_0_dll;
using Product3_0_dll.ExceptionLayer;

namespace Product3_0_dll.ApplicationLaye
{
    public class AppLayer:IDisposable
    {
        private static AppLayer appLayerRefVar;
        private AppLayer()
        {
            
        }
        public static AppLayer GetInstance()
        {
            if (appLayerRefVar == null)
            {
                appLayerRefVar = new AppLayer();
            }
            
            return appLayerRefVar;
        }
        public void ApplicationL(Prod_lst refProd)
        {
            //using (Prod_lst refProd = new Prod_lst())
            //{
                FactoryMethod(refProd);
                Console.ReadLine();
            //}
        }
        public void Dispose()
        {
            appLayerRefVar=null;
        }

        public void FactoryMethod(Prod_lst productLSt)
        {

            bool b = true;
            int count = 0;
            Console.WriteLine("want to add items (y/n) ? :");
            string addOrNot = Console.ReadLine();
            if (addOrNot.Equals("n"))
            {
                return;
            }

            bool b_2 = true;
            while (true)
            {
                int noOfItems = 0;

                if (b)
                {
                Step_3:
                    Console.WriteLine("enter Total number of items to purchase:");

                    try
                    {
                        noOfItems = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Write("Enter valid input:\n");
                        goto Step_3;

                    }

                    //len = noOfItems;
                    if (noOfItems == 0)
                    {
                        Console.WriteLine("Thank you by...");
                        return;
                    }
                    b = false;
                }

            Step_2:
                Console.Write("\n");
                Console.Write("select :\n1)Add item 2) Display items 3) Find 4) Exit 5) Remove\n");

                int option = 0;
                try
                {
                    option = System.Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Write("Enter valid input:\n");
                    goto Step_2;

                }

                if (option == 1)
                {

                    while (true && b_2)
                    {
                        if (count >= noOfItems)
                        {
                            Console.WriteLine("CART is full");
                            b_2 = false;
                            break;
                        }

                    Step_1:
                        Console.Write("add :\n1) MOBILE 2) TV  3) Exit\n");
                        int option1 = 0;

                        try
                        {
                            option1 = System.Convert.ToInt32(Console.ReadLine());

                        }
                        catch (Exception e1)
                        {
                            Console.Write("Enter valid input:\n" + e1.Message);
                            goto Step_1;
                        }

                        if (option1 == 1)
                        {

                            Mobile mob = new Mobile();
                        Step_3:
                            try
                            {
                                Console.Write("Enter id:");
                                mob.Id = Convert.ToInt32(Console.ReadLine());
                                int digits = 0;
                                int op = mob.Id;
                                while (op > 0)
                                {
                                    digits++;
                                    op =op/10;
                                }
                                if (digits < 3)
                                {
                                 try
                                    {
                                        throw new Product3_0_dll.ExceptionLayer.DigitException("id digit must me greater than 2");
                                    }
                                    catch (DigitException e)
                                    {
                                        Console.WriteLine(e.Message);
                                        goto Step_3;
                                    }
                                    

                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("enter valid id (int value)..." + ex.Message);
                                goto Step_3;
                            }

                            ExtraData(mob);
                            Console.Write("IS 5G y/n :");
                            string s = Console.ReadLine();
                            if (s == "y")
                            {
                                mob.Is5G = true;
                            }
                            else mob.Is5G = false;
                            //refForProduct = (Product)mob;
                            productLSt.Add(mob);
                            count++;
                            //count = count+refForProduct.Quantity-1;

                        }
                        else if (option1 == 2)
                        {
                            Tv tv__ = new Tv();

                        Step1:
                            try
                            {
                                Console.Write("Enter id:");
                                tv__.Id = Convert.ToInt32(Console.ReadLine());
                                ExtraData(tv__);
                            }
                            catch (Exception e)
                            {
                                goto Step1;
                            }


                            Console.Write("IS Smart TV y/n :");
                            string s = Console.ReadLine();
                            if (s == "y")
                            {
                                tv__.IsSmart = true;
                            }
                            else tv__.IsSmart = false;

                            Console.Write("number of HDMI ports :");
                            tv__.HDMI = Convert.ToInt32(Console.ReadLine());
                            //----------------------------------------


                            //refForProduct = (Product)tv__;
                            productLSt.Add(tv__);
                            //count = count + refForProduct.Quantity-1;
                            count++;

                        }
                        else if (option1 == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("please select valid input.");
                        }
                    }


                }
                else if (option == 2)
                {

                    foreach (Product refForProduct_2 in productLSt.getAll())
                    {
                        if (refForProduct_2 != null)
                        {
                            Console.Write("--------------------------------------------------------------------------\n\n" + refForProduct_2.Display() + "\n\n--------------------------------------------------------------------------");
                        }

                    }

                }
                else if (option == 3)
                {
                    Console.Write("Enter id of item you want to find: ");
                    int findById_ = System.Convert.ToInt32(Console.ReadLine());

                    //foreach (Product refForProduct_2 in productLSt)
                    //{
                    if (productLSt.Find(findById_) != null)
                    {
                        Console.Write("Iteam with id: " + findById_ + " \n");

                        Console.Write("--------------------------------------------------------------------------\n\n" + productLSt.Find(findById_).Display() + "\n\n--------------------------------------------------------------------------");


                    }
                    else
                    {
                        Console.Write("Iteam with id: " + findById_ + " not found !! \n");
                    }
                    //}

                }
                else if (option == 4)
                {
                    break;
                }
                else if (option == 5)
                {
                    Console.WriteLine("enter id of item to remove: ");
                    int id_ = Convert.ToInt32(Console.ReadLine());

                    productLSt.Remove_(id_);
                    count--;
                }
                else
                {
                    Console.WriteLine("please enetr valid input");
                }


            }
        }
        public  void ExtraData(Product refForProduct)
        {
        step1:
            try
            {
                Console.Write("Enter Name:");
                refForProduct.name = Console.ReadLine();
            }
            catch (Exception e)
            {
                goto step1;
            }

        step2:
            try
            {
                Console.Write("Enter purchase DATE:");
                refForProduct.PurchaseDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception e)
            {
                goto step2;
            }


        //----------------------------------------------------------------------
        step3:
            try
            {
                Console.Write("Enter price:");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter GST:");
                double gst = Convert.ToDouble(Console.ReadLine());
                refForProduct.Tax = new Price(p, gst);
            }
            catch (Exception e)
            {
                goto step3;
            }

        step4:
            try
            {
                Console.Write("Enter Quantity:");
                refForProduct.Quantity = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                goto step4;
            }

        step5:
            try
            {
                Console.Write("Enter Discount %:");
                refForProduct.Discount = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                goto step5;
            }

            //--------------------------------------------------------------------------


        }
    }
}
