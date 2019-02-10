using System;

namespace Programa02
{
    //Programa que sirve para poder pedir una Pizza
    //Ricardo Villagrana
    //07/02/18
    class Program
    {
        static void Main(string[] args)
        {
            int num,num2,num3,num4,num5;
            string pizza = "";
            string para = "";
            string ingredientes = "";
            string de = "";

           do
           {
                   Console.WriteLine("1.Pequeña");
                   Console.WriteLine("2.Mediana");
                   Console.WriteLine("3.Grande");
                   Console.WriteLine("4.Salir");
                   num=int.Parse(Console.ReadLine());
               switch (num)
               {
                   case 1:{
                       pizza = "Pizza pequeña";
                       Console.WriteLine("1.Extra Queso");
                       Console.WriteLine("2.Champiñones");
                       Console.WriteLine("3.Clavos");
                       Console.WriteLine("4.Cebolla");
                       Console.WriteLine("5.Cominos");
                       Console.WriteLine("6.Tomates");
                       Console.WriteLine("");
                       num2=int.Parse(Console.ReadLine());

                       switch (num2)
                       {
                           case 1:{
                              ingredientes="Extra Queso";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;//<---

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;

                           //----->

                           case 3:{
                              ingredientes="Clavo";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;

                           case 6:{
                              ingredientes="Tomates";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;


//--->
                           case 5:{
                              ingredientes="Cominos";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;


                           //----->

                           case 4:{
                              ingredientes="Cebollas";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;



                           
                           
                        //    default:
                        //     Console.WriteLine("");
                        //-------------------------------------

                        case 2:{

                            ingredientes="Champiñones";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;//aqui

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                //   case 3:{
                                //       Console.WriteLine("snxnasnskj");
                                //   }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                                //-------------------------------------
                                

                                
                              }

                            

                             

                              


                            

                            

                            


                        }break;

                           

                       }//switch
                       

                   }break;//Se acaba el caso 1 de Pizza Pequeña

                //----------------------------------------------------------
                   case 2:{
                       pizza = "Pizza mediana";
                       Console.WriteLine("1.Extra Queso");
                       Console.WriteLine("2.Champiñones");
                       Console.WriteLine("3.Clavos");
                       Console.WriteLine("4.Cebolla");
                       Console.WriteLine("5.Cominos");
                       Console.WriteLine("6.Tomates");
                       Console.WriteLine("");
                       num2=int.Parse(Console.ReadLine());

                       switch (num2)
                       {
                           case 1:{
                              ingredientes="Extra Queso";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;//<---

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;

                           //----->

                           case 3:{
                              ingredientes="Clavo";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;

                           case 6:{
                              ingredientes="Tomates";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;


//--->
                           case 5:{
                              ingredientes="Cominos";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;


                           //----->

                           case 4:{
                              ingredientes="Cebollas";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;



                           
                           
                        //    default:
                        //     Console.WriteLine("");
                        //-------------------------------------

                        case 2:{

                            ingredientes="Champiñones";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;//aqui

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                //   case 3:{
                                //       Console.WriteLine("snxnasnskj");
                                //   }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                                //-------------------------------------
                                

                                
                              }

                            

                             

                              


                            

                            

                            


                        }break;

                           

                       }//switch
                       

                   }break;//Se acaba el caso 2 de Pizza Mediana 

                   //-----------------------------------------------


                   case 3:{
                       pizza = "Pizza grande";
                       Console.WriteLine("1.Extra Queso");
                       Console.WriteLine("2.Champiñones");
                       Console.WriteLine("3.Clavos");
                       Console.WriteLine("4.Cebolla");
                       Console.WriteLine("5.Cominos");
                       Console.WriteLine("6.Tomates");
                       Console.WriteLine("");
                       num2=int.Parse(Console.ReadLine());

                       switch (num2)
                       {
                           case 1:{
                              ingredientes="Extra Queso";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;//<---

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;

                           //----->

                           case 3:{
                              ingredientes="Clavo";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;

                           case 6:{
                              ingredientes="Tomates";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;


//--->
                           case 5:{
                              ingredientes="Cominos";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;


                           //----->

                           case 4:{
                              ingredientes="Cebollas";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                              }


                           }break;



                           
                           
                        //    default:
                        //     Console.WriteLine("");
                        //-------------------------------------

                        case 2:{

                            ingredientes="Champiñones";

                              Console.WriteLine("1.Comer Aqui");
                              Console.WriteLine("2.Para Llevar");
                              num3=int.Parse(Console.ReadLine());

                              switch (num3)
                              {
                                  case 1:{
                                      para="comer aqui";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingreddientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;//aqui

                                  case 2:{
                                      para="para llevar";

                                      Console.WriteLine("1.Delgada");
                                      Console.WriteLine("2.Gruesa");
                                      num4=int.Parse(Console.ReadLine());

                                      switch (num4)
                                      {
                                          case 1:{
                                             de="delgada";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;

                                          case 2:{
                                             de="gruesa";
                                             Console.WriteLine("1.Armar pizza");
                                         
                                             num5=int.Parse(Console.ReadLine());

                                             switch (num5)
                                             {
                                                 case 1:{
                                                    Console.WriteLine($"Es una {pizza} con  ingredientes como: {ingredientes} y {de}, ademas es {para}");
                                                    //Console.ReadKey();
                                                 }break;
                                                 
                                                //  default:
                                                //  Console.WriteLine("");
                                             }


                                          }break;
                                          
                                        //   default:
                                        //    Console.WriteLine("");
                                      }


                                  }break;

                                //   case 3:{
                                //       Console.WriteLine("snxnasnskj");
                                //   }break;
                                  
                                //   default:
                                //    Console.WriteLine("");
                                //-------------------------------------
                                

                                
                              }

                            

                             

                              


                            

                            

                            


                        }break;

                           

                       }//switch
                       

                   }break;//Se acaba el caso 1 de Pizza Grande









//------------------------------------------------
                //    case 2:{
                //             Console.WriteLine("snxnasnskj");
                //    }break;


                   

                  

                   
                //    default:
                //     Console.WriteLine("");
               }
               
               


              
              
           } while (num!=4);

        //no se mueven   
        }
    }
}
