Console.Write("Enter five-digit number: ");
string number_str = Console.ReadLine();
int number_int = int.Parse(number_str);

string CheckNumber_Str( string number ){
    while (true){
        if (Convert.ToInt32(number) > 9999 & Convert.ToInt32(number) < 100000){
                int IdxPlus = 0, IdxTemp = 0;
                int IdxMinus = number.Length - 1;
                while (IdxTemp<2){
                    IdxTemp++;
                    if (number[IdxPlus]==number[IdxMinus]){
                        IdxPlus++;
                        IdxMinus--;
                    }
                    else {
                        return $"{number} --> No";
                        break;
                    }
                } 
                  
                return $"{number} --> Yes";
                break;
        }
        else {
            Console.WriteLine("You entered incorrect number");
            Console.Write("Enter five-digit number: ");
            number = Console.ReadLine();
        }
    }
}


string CheckNumber_Int(int number){
    while (true){
         if (number > 9999 & number < 100000){
            int numberA = number/1000;
            int numberB = number%100;
            if ((numberA/10) == (numberB%10) & (numberA%10) == (numberB/10)){
                return "Yes";
                break;
            }
            else {
                return "No";
                break;
            }
         }
         else{
            Console.WriteLine("You entered incorrect number");
            Console.Write("Enter five-digit number: ");
            number = int.Parse(Console.ReadLine());
         }
    }
}


// Console.WriteLine( $"Using string method: {number_str} -->" + CheckNumber_Str(number_str));
Console.WriteLine( $"Using math method: {number_int} -->" + CheckNumber_Int(number_int));




