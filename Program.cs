using System;

namespace espiral_gtesistemas
{
    class Program
    {
        static void Main(string[] args)
        {
            int col;
            int fil=0; 
            int filAux;
            int colAux=0;

            Console.WriteLine("Introduce el numero pocisiones de la primera cara de la espiral:");
            int nmatriz = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            char[,] matrizEspiral = new char [nmatriz,nmatriz];
            int contador = nmatriz;

            while(contador>1){  

            //Hacia la derecha
            for(col=colAux; col < contador; col++){
            matrizEspiral[fil,col] = 'X';  
            }
            col--;
            if (contador==0)
                break;
            contador--;

            //Hacia abajo 
            for(fil++; fil <= contador; fil++){ 
                matrizEspiral[fil,col] = 'X';
            }
            fil--; 
            colAux=col;
            if (contador==0)
                break;
            contador--;

            //Hacia la izquierda 
            for(col--; col >= (nmatriz-contador-1); col--){ 
                matrizEspiral[fil,col] = 'X';
            } 
            col++;
            filAux=fil;
            if (contador==0)
                break;
            contador--;
    
     
            //Hacia arriba
            for(fil--; fil >= (nmatriz-contador-1) ; fil--){ 
                matrizEspiral[fil,col] = 'X'; 
            }         
            colAux=col +1;
            contador++;
            fil++;

            }
            // Imprimir
            for (int m=0;m<nmatriz;m++)
                {
                    for (int n=0;n<nmatriz;n++)
                    {
                        Console.Write(matrizEspiral [m,n]);
                    }
                Console.WriteLine();
                }
        }
    }
}
