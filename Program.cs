
//Start Main
string userChoice = "";
userChoice = DisplayMenu();
while(userChoice!= "1" && userChoice !="2" && userChoice!= "3" && userChoice!= "4"){
    System.Console.WriteLine("Invalid Choice");
    userChoice = DisplayMenu();
    }

Plain(userChoice);
Cheese(userChoice);
//End Main



static string DisplayMenu(){
    
    System.Console.WriteLine("1. Topping-less pizza");
    System.Console.WriteLine("2. Cheese Pizza");
    System.Console.WriteLine("3. Pepperroni Pizza");
    System.Console.WriteLine("4. Exit");
    return Console.ReadLine();
}

static int Plain(string userchoice){
    Random random= new Random();
    int randomRows = random.Next(8,13);
    for(int i = randomRows; i >=1 ; i--){
        Console.Write(" " + "*");
        for(int j=0; j<i ; j++){
            Console.Write(" " + "*");
        }
       System.Console.WriteLine(); 
    }
    return randomRows;
}

static int Cheese(string userchoice){
    Random random = new Random();
    int randomRows=random.Next(8,13);
    for (int i = randomRows;i >=1 ; i--){
        Console.Write(" " + "*");
        for(int j=0;j<i ; j++){
            Console.Write(" " + "#");
            }
    
    System.Console.WriteLine();
    } 
return randomRows;

} 
    











