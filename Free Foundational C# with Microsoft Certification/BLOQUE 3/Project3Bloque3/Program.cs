string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad",
"I like all three of the menu choices" };

int periodLocation = 0;

for(int i=0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    bool parar = false;

    do
    {
        string ?substring;
        if(periodLocation != -1)
        {
            substring = myString.Substring(0, periodLocation);
            Console.WriteLine(substring.TrimStart());
            myString = myString.Remove(0,periodLocation + 2);
            periodLocation = myString.IndexOf(".");
        }
        else
        {
            parar = true;
            if(myString.Length > 0)
            {
                substring = myString.Substring(0);
                Console.WriteLine(substring.TrimStart());
            }          
        }

    }while(parar == false);

    
}