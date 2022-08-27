Console.Write("Enter a number: ");
int Number = int.Parse(Console.ReadLine());

void GetCubeOf ( int number){
    if (number < 1){
        for (int i=1; i >= number; i--){
            if(i==number){
                Console.Write(Math.Pow(i,3));
            }
            else {
                Console.Write(Math.Pow(i,3) + ", ");
            }

        }
    }
    else{
        for (int i=1; i <=number; i++){
            if(i==number){
                Console.Write(Math.Pow(i,3));
            }
            else {
                Console.Write(Math.Pow(i,3) + ", ");
            }
        }
    }
    
}
GetCubeOf(Number);