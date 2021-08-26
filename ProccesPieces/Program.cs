/*Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego ingrese la
longitud de cada perfil; sabiendo que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30
son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote. */

using System;

namespace ProccesPieces
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            int goodPieces = 0;
            float pieceLength = 0;

            Console.Write("Please, enter the quantity of pieces to process: ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++){
                Console.Write($"Please, enter the length of piece #{i+1}: ");
                pieceLength = float.Parse(Console.ReadLine());
                validatePiece(pieceLength);

            }

            void validatePiece (float pieceLength) {
                if(pieceLength >= 1.20 && pieceLength <= 1.30){
                    goodPieces = goodPieces + 1;
                }
            }

            Console.Write($"\nNumber of Good Pieces: {goodPieces}");
        }
    }
}
