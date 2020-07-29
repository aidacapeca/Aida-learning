 Sino defino este namespace todo existira en el globalSpace y ahi puede entrar en conflicto las clases de librerias, etc. 
 Tambien puedo agregar subnamespaces como Gradebook.Math
               Sintaxis para declarar e inicializar variables 













            
            -   Dado que C# es fuertemente tipado el tipo de la variable se mantiene. 
            -   var x = 35.8; double x = 35.8 es tmb posible 
            -   Al declarar una variable que aun no usare no puedo dejarla como var/tipo result; y ya en este caso tendria que 
                    inicializar el valor de result = algo.
            -   La sintaxis para arrays es tipo/var[] nombre = new tipo[length]; 
            -   Si quiero inicialiazr un array en el mismo punto de la instancia luego del length agrego entre {} el valor
                    de cada posicion separados por , . Tomando esta sintaxis incluso podria omitir incluir el length 
                    ya que el compiler figures out el length correspondiente segun la cantidad de elementos en {}. 
                    De esta forma incluso podria omitir tmb el tipo 
            -   IMPLICIT TYPING
            













            
            -   a = a + b -> a += b;
            -   STRING INTERPOLATION: gracias a la sintaxis de C# puedo hacer Console.WriteLine($"Hello, {args[0]} !");
                        double[] numbers = new[] {44.5, 25.4}; 
            System.Collections.Generic.List grades;
            List<double> grades = new List<double>(); () invoco un metodo para crear mi lista
            var grades = new List<double>() {valores, valores} IMPLICIT  
            para acceder lo trato tmb por [index];
            









    throw; // Me ayuda a 1. terminar el programa 2. obligar a alguien mas a atrapar la excepcion y hacer algo
                }
                /*
                *   Puedo catchear una ex de tipo ArgumentException de esta forma podria seguir en mi loop. 
                *   Puedo catchear una ex FormatException (caso de que no puedo parsear el input)
                *   puedo usar un finally block como el codigo que siempre quiero ejecutar sin importar si fue exitoso o dio error
                */



      Cuando estoy definiendo una clase, y esta es hija de otra la sintaxis para marcar esta herencia es de la forma
    *   public class Hija : Madre { } 
    *   Cuando estoy definiendo el constructor de la clase hija tengo 2 formas principales de agregar el constructor del padre
    *   this.Atribute  forma explicita
    *   public Constructor() : base(arguments required)
    *   C# no permite multiples herencias ej: Book : X : Y lo correcto seria X:Y y Book: X
    *   
    *   Una clase abstracta es de la forma: public / private abstract class ClassName {
    *    ...... }
    *   La idea es que todas las clases que hereden una clase abstracta implementen de una manera distinta sus metodos
    *   por ej: public abstract void AddGrade(double); -> at this level I cant prensent an implementation, only the heads
    *   En la clase hija, cuando defino el metodo AddGrade() debo agregar la key override
    *   public override void AddGrade(double ..)
    *   
    *   Una interface solo describe los metodos e implementation details. Por convention todas las interfaces son IName
    *   public interface Name{
    *   void AddGrade (double ..) -> no defino si es public/private, depende de la implementacion
    *   Statistics GetStatistics();  }  
    *   Para implementar en una clase la coloco similar a la herencia, puedo implementar tantas interfaces como quiera y 
    *   separarlas por ,
    *   var writer = File.AppendText() -> abre un archivo dado el nombre que le pase 
    *   writer = WriteLine(grade) 
    *   writer.Close();
    *   
    













       El acceso predeterminado en C# para una clase es internal: solo puede ser utilizado 
        *   dentro del proyecto (similar a private). Como necesito acceder a la clase desde 
        *   los tests defino la clase como public
        













         si a List<double> grades le agrego public desde program.cs voy a poder hacer book.grades y 
        acceder a ella pero romperia el pilar de encapsulamiento    
        
        Al no crear un constructor tengo un constructor implicito
         los constructores no tienen tipo de retorno y puedo crear tantos quiera los diferenciara e 
        identificara los parametros que le pase
         Loops Sntaxis
        En los loops puedo hacer
        *   break; y romper el ciclo
        *   continue: rompe solo esa iteracion pero continua el ciclo
        *   goto tag: y defino dentro de las instrucciones ese tag: 

        do{  Se ejecuta al menos una vez y luego evalua la instruccion
             instructions
        }while(condition);

        while(condition){ puede no ejecutarse
             instructions
        }

        for (initialization (var i = 0); condition; increment/decrement ){
            instructions
        }

        switch(variable){
            case X: 
                 instructions
                break;
            ......

            case var d when (d condition): Matching pattern syntaxis
                instructions
                break;
            
            default: if none of the previous cases apply
        }
        













        

         
            Un test se divide en 3 partes principales: 
            *   arrange section: test data setting , instancia y declaracion de todas las 
                variables. 
            *   act section: invoke the necesary methods to compute something and produce a result
            *   assert section: does the compare to execute the test. 
            
















                          En este caso se genera un error porque no reconoce la clase Book, para corregir esto 
            *   debemos importar como un package la clase mediante el .NET cli (terminal) haciendo 
            *   dotnet add 1. add reference to package (como xunit) 2. add project reference
            *   dot net add reference path (src/Project/Project.csproj)  
            *   
            












