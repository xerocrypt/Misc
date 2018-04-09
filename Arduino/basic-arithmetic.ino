void setup() {
  // Code here executes once
  Serial.begin(9600);
  
  int firstNum = 124;
  int secondNum = 1334;
  int summed = firstNum + secondNum;
  int multiplied = firstNum * secondNum;
  int divided = secondNum / firstNum;
  int subtracted = secondNum - firstNum;

  Serial.println("Summed: ");
  Serial.println(summed);
  Serial.println("Multiplied: ");
  Serial.println(multiplied);
  Serial.println("Divided: ");
  Serial.println(divided);
  Serial.println("Subtracted: ");
  Serial.println(subtracted);
}

void loop() 
{
  // Move code to this function to loop execution
}
